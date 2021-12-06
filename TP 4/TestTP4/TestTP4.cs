using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinal.ClassLibrary;


namespace TestTP4
{
    [TestClass]
    public class TestTP4
    {
        static SqlConnection connection;
        static SqlCommand command;
        static SqlDataReader reader;


        [TestMethod]
        public void lecturaDatos()
        {
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;
            connection = connection.connection();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            string query = "Select * from dbo.Lol_Matches";

            try
            {
                List<Lol> list = new List<Lol>();
                List<Lol> lista = SqlHandler.GetLolGames();
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

                    list.Add(new Lol(id, champion, role, elo, region, win));
                }

                Assert.AreEqual(list.Count(),lista.Count());
                Assert.IsNotNull(list);
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

        [TestMethod]
        public void escrituraDatos()
        {
            SqlCommand command = new SqlCommand();
            connection = connection.connection();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            Random numberGen = new Random();
            List<Lol> lista = SqlHandler.GetLolGames();

            int affected = 0;


            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            string champion = ((Lol.EChamp)(numberGen.Next(1, 10))).ToString();
            string role = ((Lol.ERole)(numberGen.Next(1, 6))).ToString();
            string region = ((Lol.ERegion)(numberGen.Next(1, 9))).ToString();
            string elo = ((Lol.ERank)(numberGen.Next(1, 6))).ToString();
            int win = numberGen.Next(0, 2);

            StringBuilder sb = new StringBuilder();

            sb.Append("INSERT INTO dbo.Lol_Matches ([Champion],[Role],[Region],[Elo],[Win]) VALUES (");
            sb.Append("'" + champion + "'" + ",");
            sb.Append("'" + role + "'" + ",");
            sb.Append("'" + region + "'" + ",");
            sb.Append("'" + elo + "'" + ",");
            sb.Append("'" + win + "'" + ")");

            string query = sb.ToString();

            command.CommandText = query;
            affected = command.ExecuteNonQuery();

            List<Lol> list = SqlHandler.GetLolGames();

            connection.Close();

            Assert.AreNotEqual(list.Count(), lista.Count());
            Assert.IsTrue(list.Count() > lista.Count());
        }

    }
}
