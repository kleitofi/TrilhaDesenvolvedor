using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrilhaDesenvolvedor
{
    public class Sql
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\micro\source\repos\TrilhaDesenvolvedor\dbTrilha.mdf;Integrated Security=True");
        public Sql()
        {
            Console.WriteLine("Caminho EXE | " + Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString()));
            Console.WriteLine(@"Caminho banco | Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\micro\source\repos\TrilhaDesenvolvedor\dbTrilha.mdf; Integrated Security = True");
        }
        public void Conexao(SqlCommand sqlCommand)
        {
            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na function: Conexao | " + e.Message);
            }
            finally
            {
                conn.Close();                
            }
        }
        public bool VerificaLogin(Pessoa p)
        {
            bool result = false;
            //string StringDeConexao = @”Data Source = localhost; Initial Catalog = tempdb; User Id = sa; Password = minhasenha;”;
            using (conn)
            {                
                try
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT [Login],[Senha] FROM [dbo].[CadastroPessoas]  where [Login] = '{p.Login}' and [Senha] = '{p.Senha}'",conn);
                    conn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                }
                catch (SqlException e)
                {
                    throw new Exception("Erro na function: VerificaLogin | " + e.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public void AddPessoa(Pessoa p,List<Filho> f)
        {
            try
            {
                string scriptPessoa = $"INSERT INTO [CadastroPessoas]([Nome],[Sobrenome]," +
                $"[Sexo],[CPF],[DataNascimento],[Email],[Cep],[Endereco],[NumeroEnd]," +
                $"[Bairro],[UF],[Cidade],[Categoria],[SalarioBase],[Imagem],[Login],[Senha])" +
                    $"VALUES('{p.Nome}'," +
                    $"'{p.Sobrenome}'," +
                    $"'{p.Sexo}'," +
                    $"'{String.Join("", System.Text.RegularExpressions.Regex.Split(p.CPF.ToString(), @"[^\d]"))}'," +
                    $"'{p.DataNascimento.ToString("dd/MM/yyyy")}'," +
                    $"'{p.Email}'," +
                    $"'{String.Join("", System.Text.RegularExpressions.Regex.Split(p.Cep.ToString(), @"[^\d]"))}'," +
                    $"'{p.Endereco}'," +
                    $"'{p.EndNumero}'," +
                    $"'{p.Bairro}'," +
                    $"'{p.UF}'," +
                    $"'{p.Cidade}'," +
                    $"'{p.Categoria}'," +
                    $"'{p.SalarioBase}'," +
                    $"{p.Imagem.Length}," +
                    $"'{p.Login}'," +
                    $"'{p.Senha}')";

                Console.WriteLine("scriptPessoa: " + scriptPessoa);
                conn.Open();
                new SqlCommand(scriptPessoa, conn).ExecuteNonQuery();
                // GET NOME NUMERO ID PAI -----------------------------------------------------------------
                string script = $"SELECT top 1 MAX([Id]) as maxID FROM [dbo].[CadastroPessoas] where [Email] like '{p.Email}'";
                SqlCommand cmd = new SqlCommand(script, conn);
                SqlDataReader dr = cmd.ExecuteReader();   
                
                if (dr.Read() && dr.HasRows)
                {
                    try
                    {
                        p.Id = (int)dr["maxID"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na function: AddPessoa (GET NOME NUMERO ID PAI) | " + ex.Message);
                        p.Id = 0;
                    }
                }
                conn.Close();
                //-----------------------------------------------------------------
                
                if (p.Filhos)
                {
                    conn.Open();
                    foreach (var item in f)   
                    {
                        string scriptFilho = $"INSERT INTO [CadastroFilhos] ([IdPai],[Nome],[DataNascimento],[Sexo]) " +
                        $"VALUES('{p.Id}'," +
                        $"'{item.Nome}'," +
                        $"'{item.DataNascimento.ToString("dd/MM/yyyy")}'," +
                        $"'{item.Sexo}')";

                        Console.WriteLine("scriptFilho: " + scriptFilho);
                        new SqlCommand(scriptFilho, conn).ExecuteNonQuery();
                    } 
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na function: AddPessoa | " + e.Message);
                throw;
            }            
            finally
            {
                MessageBox.Show("Cadastrado !");
                conn.Close();
            }
        }

        public void ListPessoas(ComboBox comboBox, string categoria = "%")
        {
            try
            {
                string _script = $"SELECT * FROM [CadastroPessoas] where [categoria] like '{categoria}' order by [Nome] asc";

                Console.WriteLine("ListPessoas:" + _script);
                conn.Open();
                SqlCommand cmd = new SqlCommand(_script, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                SqlDataAdapter data = sqlDataAdapter;
                DataTable tb = new DataTable();

                data.Fill(tb);

                comboBox.DataSource = tb;
                comboBox.DisplayMember = "Nome";
                comboBox.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                conn.Close();
            }
        }
        public Pessoa ChekedLancamento(string nome)
        {
            Pessoa pessoa = new Pessoa();
            try
            {
                string _script = $"SELECT top 1 MAX([Nome]) as maxNome  SELECT * FROM [CadastroPessoas] where [Nome] like '{nome}'";
                Console.WriteLine("_script:" + _script);
                conn.Open();
                SqlCommand cmd = new SqlCommand(_script, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() && dr.HasRows)
                {
                    try
                    {
                        pessoa = new Pessoa()
                        {
                            Nome = dr["maxNome"].ToString(),
                            SalarioBase = (double)dr["SalarioBase"],
                            Categoria = dr["Categoria"].ToString()
                        };

                        return pessoa;
                    }
                    catch (Exception)
                    {
                        return pessoa;
                    }
                }
                return pessoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return pessoa;
            }
            finally
            {                
                conn.Close();                
            }
        }

    }
    
}