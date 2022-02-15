//crud using a database and a c# for do its
using System;
using System.Data;
using System.Data.SqlClient;

namespace myApp
{
    class Program
    {
        
        static void DeleteDepartamento(Int32 id)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "DELETE  [tb-departamento] WHERE id = @id";
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
 
        //SELECT
        static void SelectDepartamento(string nome)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "SELECT id, nome, descricao FROM [tb-departamento] WHERE nome = @nome";
                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    Int32 idDepartamento = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("id"));
                    String nomeDepartamento = sqlDataReader.GetString(sqlDataReader.GetOrdinal("nome"));
                    String descricaoDepartamento = sqlDataReader.GetString(sqlDataReader.GetOrdinal("descricao"));
                    Console.WriteLine(
                        $"Departamento \"{nome}\": {idDepartamento} - {nomeDepartamento} - {descricaoDepartamento}");
                }
                else
                {
                    Console.WriteLine($"Departamento \"{nome}\" não encontrado");
                    Console.WriteLine($"Departamento \"{nome}\" não encontrado");
                }

                connection.Close();
            }
        }
        //UPDATE
        static void UpdateDepartamento(Int32 id, String descricao)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "UPDATE [tb-departamento] SET descricao = @descricao WHERE id = @id";
                sqlCommand.Parameters.Add(new SqlParameter("descricao", descricao));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        //INSERT
        static void insertDepartamento(String nome, String descricao)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO [tb-departamento] (nome, descricao) values (@nome, @descricao)";

                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                sqlCommand.Parameters.Add(new SqlParameter("descricao", descricao));

                sqlCommand.ExecuteNonQuery();

                connection.Close();
            }

        }

        
        
        //CARGOS
        static void DeleteCargos(Int32 id)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "DELETE  [tb-cargo] WHERE id = @id";
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        //SELECT
        static void SelectCargos(string nome)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "SELECT nome, tipo, [id-departamento] FROM [tb-cargo] WHERE nome = @nome";
                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    String Cargonome = sqlDataReader.GetString(sqlDataReader.GetOrdinal("nome"));
                    String tipoCargo = sqlDataReader.GetString(sqlDataReader.GetOrdinal("tipo"));
                    Int32 departamentoCargo = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("id-departamento"));
                    Console.WriteLine(
                        $"Departamento \"{nome}\": {Cargonome} - {tipoCargo} - {departamentoCargo}");
                }
                else
                {
                    Console.WriteLine($"Cargo \"{nome}\" não encontrado");
                    Console.WriteLine($"Cargo \"{nome}\" não encontrado");
                }

                connection.Close();
            }
        }
        //UPDATE
        static void UpdateCargos(Int32 id, String nome)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "UPDATE [tb-cargo] SET nome = @nome WHERE id = @id";
                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        //INSERT
        static void insertCargos(String nome, String tipo, Int32 idcargo)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO [tb-cargo] (nome, tipo, [id-departamento]) values (@nome, @tipo, @idcargo)";

                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                sqlCommand.Parameters.Add(new SqlParameter("descricao", tipo));
                sqlCommand.Parameters.Add(new SqlParameter("descricao", idcargo));

                sqlCommand.ExecuteNonQuery();

                connection.Close();
            }
        }




        //FUNCIONARIO
        static void DeleteFuncionario(Int32 id)
        {
            using (SqlConnection connection = new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "DELETE  [tb-funcionario] WHERE id = @id";
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        //SELECT
        static void SelectFuncionario(string cpf)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "SELECT cpf, nome, [id-cargo], sexo FROM [tb-funcionario] WHERE cpf = @cpf";
                sqlCommand.Parameters.Add(new SqlParameter("cpf", cpf));
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    String cpffuncionario = sqlDataReader.GetString(sqlDataReader.GetOrdinal("cpf"));
                    String nome = sqlDataReader.GetString(sqlDataReader.GetOrdinal("nome"));
                    String sexo = sqlDataReader.GetString(sqlDataReader.GetOrdinal("sexo"));
                    Int32 idcargo = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("id-cargo"));
                    Console.WriteLine(
                        $"Departamento \"{cpffuncionario}\": {nome} - {sexo} - {idcargo}");
                }
                else
                {
                    Console.WriteLine($"Funcionario \"{cpf}\" não encontrado");
                    Console.WriteLine($"Funcionario \"{cpf}\" não encontrado");
                }

                connection.Close();
            }
        }
        //UPDATE
        static void UpdateFuncionario(Int32 id, String nome)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "UPDATE [tb-funcionario] SET nome = @nome WHERE id = @id";
                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        //INSERT
        static void insertFuncionario(String cpf, String nome, String sexo, Int32 idcargo)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO [tb-funcionario] (cpf, nome, sexo,[id-cargo]) values (@cpf, @nome, @sexo, @idcargo)";

                sqlCommand.Parameters.Add(new SqlParameter("nome", nome));
                sqlCommand.Parameters.Add(new SqlParameter("cpf", cpf));
                sqlCommand.Parameters.Add(new SqlParameter("idcargo", idcargo));
                sqlCommand.Parameters.Add(new SqlParameter("sexo", sexo));

                sqlCommand.ExecuteNonQuery();

                connection.Close();
            }

        }

        static void Main(string[] args)
        {
            using (SqlConnection connection =
                new SqlConnection(@"Server=.\SQLSERVERCRUD;Database=crud1;User Id=sa;Password=P@ssw0rdcrud;"))
            {
                //TABELA DE PARTAMENTO

                //insert                
                //insertDepartamento("PUTA", "AAAAAAAA");

                //Update
                //UpdateDepartamento(4, "fodaseKJJJKK");

                //select 
                //SelectDepartamento("RH");
                //SelectDepartamento("Rafaelgay");
                //SelectDepartamento("HUMM MACACO");
                
                //DELETE
                //DeleteDepartamento(3);
                
                
                
                
                //TABELA CARGO
                
                //INSERT 
                //insertCargos("Proficional do sexo", "T", 1);
                
                //SELECT 
                //SelectCargos("Proficional do sexo");

                //UPDATE
                //UpdateCargos(2, "Puta do t.i");

                //DELETE
                //DeleteCargos(1);

                
                

                //TABELA FUNCIONARIO
                                
                //INSERT 
                //insertFuncionario("23652374558", "MACACO DE CANLCINHA DE RENDA", "F", 2);
                
                //SELECT 
                SelectFuncionario("23652374558");

                //UPDATE
                //UpdateFuncionario(1, "BOLSONARO PELADINHO NA PRAIA");

                //DELETE
                //DeleteFuncionario(1);




            }
        }
    }
}

    
    