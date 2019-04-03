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
    public partial class Section : Form
    {
        public Section()
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
                    teacherCombo.Items.Add(table.Rows[i]["student_id"] + "," + table.Rows[i]["lname"] + "," + table.Rows[i]["fname"]);
                }
                /*while(reader.Read())
                {
                    Console.WriteLine(reader["name"] + " - " + reader["city"]);
                }*/
                reader.Close();


                query = "SELECT * FROM section_table Order by course, section ASC;";
                MessageBox.Show(query);
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader2 = cmd.ExecuteReader();

                table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Section ID: " + table.Rows[i]["section_id"]);
                    teacherCombo.Items.Add(table.Rows[i]["section_id"] + "," + table.Rows[i]["course"] + "," + table.Rows[i]["section"]);
                }




                conn.Close();

            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                string course_id = courseTxt.Text,
                       section = sectionTxt.Text,
                       days = daysTxt.Text,
                       start_time = startTxt.Text,
                       end_time = endTxt.Text,
                       teacherTextField = teacherCombo.Text;
                string[] words = teacherTextField.Split(',');
                string teacher_id = words[0];
                       

                conn.Open();

                string query = $"INSERT INTO `section_table` (`section_id`, `teacher_id`, `course_name`, `section`, `days`, `start_time`, `end_time`) VALUES (NULL, '{teacher_id}', '{course_id}', '{section}', '{days}', '{start_time}', '{end_time}');";
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
