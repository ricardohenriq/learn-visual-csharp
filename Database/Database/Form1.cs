using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database
{
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            try
            {
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect.connection;

                cmd.CommandText = "INSERT INTO dotnet_user (name, age) VALUES(@name, @age)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", "Bill Gates");
                cmd.Parameters.AddWithValue("@age", 20);
                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "cmd.CommandText = \"INSERT INTO dotnet_user VALUES(@name, @age)\";" + "\n" +
                    "cmd.Prepare();" + "\n" +
                    "cmd.Parameters.AddWithValue(\"@name\", \"Bill Gates\");" + "\n" +
                    "cmd.Parameters.AddWithValue(\"@age\", 20);" + "\n" +
                    "cmd.ExecuteNonQuery();"
                    );

            }
            catch (Exception ex)
            {
                //Application.Exit();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            try
            {
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect.connection;

                cmd.CommandText = "SELECT name, age, id FROM dotnet_user";
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Create a list to store the result
                List<List<string>> records = new List<List<string>>();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    records.Add(new List<string>(){
                        dataReader["id"].ToString(),
                        dataReader["name"].ToString(),
                        dataReader["age"].ToString()
                    });
                }

                //Create a line with records content
                string listRecords = "";
                foreach (List<string> record in records)
                {
                    listRecords += record.ElementAt(0) + " - ";
                    listRecords += record.ElementAt(1) + " - ";
                    listRecords += record.ElementAt(2) + "\n\n";
                }

                MessageBox.Show(
                    "cmd.CommandText = \"SELECT name, age, id FROM dotnet_user\";" + "\n" +
                    "MySqlDataReader dataReader = cmd.ExecuteReader();" + "\n\n\n" +
                    listRecords
                    );

            }
            catch (Exception ex)
            {
                //Application.Exit();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }

        private void updateBbutton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            try
            {
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect.connection;

                cmd.CommandText = "UPDATE dotnet_user SET age=@age WHERE name=@name";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", "Bill Gates");
                cmd.Parameters.AddWithValue("@age", 100);
                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "cmd.CommandText = \"UPDATE dotnet_user SET age=@age WHERE name=@name\";" + "\n" +
                    "cmd.Prepare();" + "\n" +
                    "cmd.Parameters.AddWithValue(\"@name\", \"Bill Gates\");" + "\n" +
                    "cmd.Parameters.AddWithValue(\"@age\", 100);" + "\n" +
                    "cmd.ExecuteNonQuery();"
                    );

            }
            catch (Exception ex)
            {
                //Application.Exit();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            try
            {
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect.connection;

                cmd.CommandText = "DELETE FROM dotnet_user WHERE name=@name";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@name", "Bill Gates");
                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "cmd.CommandText = \"DELETE FROM dotnet_user WHERE name=@name\";" + "\n" +
                    "cmd.Prepare();" + "\n" +
                    "cmd.Parameters.AddWithValue(\"@name\", \"Bill Gates\");" + "\n" +
                    "cmd.ExecuteNonQuery();"
                    );

            }
            catch (Exception ex)
            {
                //Application.Exit();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();
            try
            {
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = dbConnect.connection;

                cmd.CommandText = "SELECT Count(*) FROM dotnet_user";

                int Count = Int32.Parse(cmd.ExecuteScalar().ToString());

                MessageBox.Show(
                    "cmd.CommandText = \"SELECT Count(*) FROM dotnet_user\";" + "\n" +
                    "int Count = Int32.Parse(cmd.ExecuteScalar().ToString());" + "\n" +
                    Count
                    );

            }
            catch (Exception ex)
            {
                //Application.Exit();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnect.CloseConnection();
            }
        }
    }
}
