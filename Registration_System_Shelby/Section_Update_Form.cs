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
    public partial class Section_Update_Form : Form
    {
        public Section_Update_Form()
        {
            InitializeComponent();
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                conn.Open();

                string query = "SELECT lname, fname, teacher_id FROM teacher_table Order by lname, fname ASC;";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Teacher ID: " + table.Rows[i]["teacher_id"]);
                    teacherCombo.Items.Add(table.Rows[i]["teacher_id"] + "," + table.Rows[i]["lname"] + "," + table.Rows[i]["fname"]);
                }
                /*while(reader.Read())
                {
                    Console.WriteLine(reader["name"] + " - " + reader["city"]);
                }*/

                string query2 = "SELECT `section_id`, `teacher_id`, `course_name`, `section`, `days`, `start_time`, `end_time` FROM section_table Order by course_name, section ASC;";
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

                reader.Close();
                reader2.Close();
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

                string query = $"UPDATE `section_table` SET  `course_id`='{course_id}', `section`='{section}', `days`='{days}', `start_time`='{start_time}' WHERE `teacher_id`={teacher_id};";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int numRowsAffected = cmd.ExecuteNonQuery();
                long lastInserted = cmd.LastInsertedId;

                if (numRowsAffected >= 1)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {

                string sectionselectionid = sectionCombo.Text;
                string[] words = sectionselectionid.Split(',');
                string section_id_num = words[0]; //get the id from the split string. 


                conn.Open();

                string query = $"SELECT * FROM section_table WHERE section_id = '{section_id_num}';";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                string teacher_id_db = "";

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++)
                {


                    MessageBox.Show("Adding Section ID: " + table.Rows[i]["section_id"]);

                    teacherCombo.Text = getTeacherIds(table.Rows[i]["teacher_id"].ToString());
                    courseTxt.Text = table.Rows[i]["course_name"].ToString();
                    sectionTxt.Text = table.Rows[i]["section"].ToString();
                    daysTxt.Text = table.Rows[i]["days"].ToString();
                    startTxt.Text = table.Rows[i]["start_time"].ToString();
                    endTxt.Text = table.Rows[i]["end_time"].ToString();

                }

                string query2 = "SELECT lname, fname, teacher_id FROM teacher_table Order by lname, fname ASC;";
                MessageBox.Show(query2);
                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                DataTable table2 = new DataTable();

                //table2.Load(reader2);

                //for (int i = 0; i < table2.Rows.Count; i++)
                //{
                //    teacher_id_db = table2.Rows[i]["teacher_id"].ToString() + "," + table2.Rows[i]["lname"].ToString() + "," + table2.Rows[i]["fname"].ToString();
                //    teacherCombo.Text = teacher_id_db;
                //}


                reader.Close();
                //reader2.Close();
                conn.Close();
            }
        }

        private string getTeacherIds(string current_id)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT lname, fname, teacher_id FROM teacher_table ORDER BY lname, fname ASC;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                if (teacherCombo.Items.Count == 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        teacherCombo.Items.Add(table.Rows[i]["teacher_id"] + ", " + table.Rows[i]["fname"] + " " + table.Rows[i]["lname"]);
                    }
                }
                reader.Close();

                MySqlCommand current = new MySqlCommand($"SELECT t.teacher_id, t.fname, t.lname, s.teacher_id FROM teacher_table as t, section_table as s WHERE t.teacher_id = s.teacher_id AND t.teacher_id = '{current_id}';", conn);
                MySqlDataReader reader_current = current.ExecuteReader();

                DataTable table_current = new DataTable();

                table_current.Load(reader_current);

                string teacher_id_db = table_current.Rows[0]["teacher_id"] + ", " + table_current.Rows[0]["fname"] + " " + table_current.Rows[0]["lname"];

                reader_current.Close();
                conn.Close();

                return teacher_id_db;
            }

        }
    }
}
