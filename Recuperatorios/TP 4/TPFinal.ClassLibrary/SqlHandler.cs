using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal.ClassLibrary
{
    public static class SqlHandler
    {
        static SqlConnection connection;
        static SqlCommand command;
        static SqlDataReader reader;

        static SqlHandler()
        {
            connection = connection.connection();
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }

        public static List<Lol> GetLolGames()
        {
            
            string query = "Select * from dbo.Lol_Matches";
            try
            {
                List<Lol> list = new List<Lol>();

                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string champion = reader.GetString(1);
                    string role = reader.GetString(2);
                    string elo = reader.GetString(3);
                    string region = reader.GetString(4);
                    int win = reader.GetInt32(5);

                    list.Add(new Lol(id, champion, role,elo, region, win));
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

        }
        public static bool insertLolMatch(Lol match)
        {
            int rows;

            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO dbo.Lol_Matches ([Champion],[Role],[Region],[Elo],[Win]) VALUES (");
            sb.Append("'" + match.champion.ToString() + "'" + ",");
            sb.Append("'" + match.role.ToString() + "'" + ",");
            sb.Append("'" + match.region.ToString() + "'" + ",");
            sb.Append("'" + match.rank.ToString() + "'" + ",");
            sb.Append("'" + match.Win.ToString() + "'" + ")");

            string query = sb.ToString();
            try
            {
                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                rows = command.ExecuteNonQuery();
                if (rows!= 0)
                {
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }

        
        public static void editLolMatch(Lol match, int id)
        {

            int rows;
            string query = $"UPDATE dbo.Lol_Matches SET [Champion] = '{match.champion}',[Role] = '{match.role}',[Region] = '{match.region}',[Elo] = '{match.rank}',[Win] = '{match.Win}' WHERE [id] = {id}";

            try
            {
                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                rows = command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

            
        }

        public static void deleteLolMatch(int id)
        {

            int rows;
            string query = $"Delete from dbo.Lol_Matches WHERE [id] = {id}";

            try
            {
                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                rows = command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }


        }

        public static List<Tft> GetTftGames()
        {
            string query = "Select * from dbo.Tft_Matches";
            try
            {
                List<Tft> list = new List<Tft>();

                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string composition = reader.GetString(1);
                    string elo = reader.GetString(2);
                    string position = reader.GetString(3);

                    list.Add(new Tft(id, composition, elo, position));
                }

                return list;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }

        }

        public static bool insertTftMatch(Tft match)
        {
            int rows;

            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO dbo.Tft_Matches ([Composition],[Elo],[Position]) VALUES (");
            sb.Append("'" + match.composition.ToString() + "'" + ",");
            sb.Append("'" + match.rank.ToString() + "'" + ",");
            sb.Append("'" + match.position.ToString() + "'" + ",");

            string query = sb.ToString();
            try
            {
                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                rows = command.ExecuteNonQuery();
                if (rows != 0)
                {
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }

        public static void editTftMatch(Tft match, int id)
        {

            int rows;

            string query = $"UPDATE dbo.Tft_Matches SET [Compositio] = '{match.composition}',[Elo] = '{match.rank}',[Position] = '{match.position}' WHERE [id] = {id}";

            try
            {
                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                rows = command.ExecuteNonQuery();


            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }


        }
        public static void deleteTftMatch(int id)
        {

            int rows;
            string query = $"Delete from dbo.Tft_Matches WHERE [id] = {id}";

            try
            {
                command.CommandText = query;

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                rows = command.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }


        }


    }
}
