using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToObjectConvertor.DataAccessLayer
{

    public class DBConnection
    {
        public string ConnectionString { get; set; }
        public string Query { get; set; }

        public DBConnection()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MyDevelopment\XMLToObjectConvertor\XMLToObjectConvertor\DataAccessLayer\XMLToObjDB.mdf;Integrated Security=True";
        }

        public bool Insert(List<Person> personList)
        {
            try
            {
                string insertStmt = "INSERT INTO Person(ID, Name,LastName, Age) " +
                                    "VALUES(@ID, @Name, @LastName, @Age)";

                // set up connection and command objects in ADO.NET
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(insertStmt, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.Int);
                        cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                        cmd.Parameters.Add("@LastName", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Age", SqlDbType.Int);

                        conn.Open();

                        foreach (Person person in personList)
                        {
                            try
                            {
                                cmd.Parameters["@ID"].Value = person.ID;
                                cmd.Parameters["@Name"].Value = person.Name;
                                cmd.Parameters["@LastName"].Value = person.LastName;
                                cmd.Parameters["@Age"].Value = person.Age;

                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message,"Error");
                            }
                        }

                        conn.Close();
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<Person> Select()
        {
            List<Person> pList = new List<Person>();

            try
            {

                string query = "Select * From Person";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pList.Add(new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message,"Error");
            }

            return pList;
        }

        public bool Delete(string id)
        {
            try
            {

                string query = "delete From Person where id =" + id;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error");
            }

            return true;
        }

    }
}
