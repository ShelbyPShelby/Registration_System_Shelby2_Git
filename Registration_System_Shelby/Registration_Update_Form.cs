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
using System.Text.RegularExpressions;

namespace Registration_System_Shelby
{
    public partial class Registration_Update_Form : Form
    {
        public Registration_Update_Form()
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                conn.Open();

                string query = "SELECT lname, fname, student_id FROM student_table Order by lname, fname ASC;";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    studentCombo.Items.Add(table.Rows[i]["student_id"] + "," + table.Rows[i]["lname"] + "," + table.Rows[i]["fname"]);
                }
                /*while(reader.Read())
                {
                    Console.WriteLine(reader["name"] + " - " + reader["city"]);
                }*/
                reader.Close();

                
                string query2 = "SELECT * FROM section_table Order by course_name ASC;";
                MessageBox.Show(query2);
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable table2 = new DataTable();

                table2.Load(reader2);

                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Section ID: " + table2.Rows[i]["section_id"]);
                    sectionCombo.Items.Add(table2.Rows[i]["section_id"] + "," + table2.Rows[i]["course_name"] + "," + table2.Rows[i]["section"]);
                }

                reader2.Close();

                string query3 = "SELECT * FROM registration_table Order by registration_id ASC;";
                MessageBox.Show(query3);
                MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                MySqlDataReader reader3 = cmd3.ExecuteReader();

                DataTable table3 = new DataTable();

                table3.Load(reader3);

                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding registration ID: " + table2.Rows[i]["registration_id"]);
                    sectionCombo.Items.Add(table2.Rows[i]["registration_id"]);
                }

                reader3.Close();
                conn.Close();

            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                string  teacherTextField = studentCombo.Text;
                string[] words = teacherTextField.Split(',');
                string teacher_id = words[0];
                       

                conn.Open();

                string query = $"";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int numRowsAffected = cmd.ExecuteNonQuery();
                long lastInserted = cmd.LastInsertedId;

                if(numRowsAffected >= 1)
                {
                    MessageBox.Show("Success: Rows" + numRowsAffected + " ID entered: " + lastInserted);
                }
                else
                {
                    MessageBox.Show("\nError in insert query");
                }
                


                conn.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fname_Click(object sender, EventArgs e)
        {

        }
    }
}
