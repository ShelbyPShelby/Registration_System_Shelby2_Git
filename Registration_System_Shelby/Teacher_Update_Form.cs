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

namespace Registration_System_Shelby
{
    public partial class Teacher_Update_Form : Form
    {
        public Teacher_Update_Form()
        {
            InitializeComponent();
            //Zach Approach 
            //Shout out to Zach on 3-21-2019 for showing dr_T's Tired brain where to put this code
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
                    TeacherCombo.Items.Add(table.Rows[i]["teacher_id"] + "," + table.Rows[i]["lname"] + "," + table.Rows[i]["fname"]);
                }

                reader.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {

                string teacherselectionid = TeacherCombo.Text;
                string[] words = teacherselectionid.Split(',');
                string teacher_id_num = words[0];

                string fname = fnameTxt.Text,
                       lname = lnameTxt.Text,
                       title = titleTxt.Text,
                       rank = rankTxt.Text;

                conn.Open();

                string query = $"UPDATE `teacher_table` SET  `fname`='{fname}', `lname`='{lname}', `title`='{title}', `rank`='{rank}' WHERE `teacher_id`={teacher_id_num};";
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

        private void teacherCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {

                string teacherselectionid = TeacherCombo.Text;
                string[] words = teacherselectionid.Split(',');
                string teacher_id_num = words[0]; //get the id from the split string. 


                conn.Open();

                string query = $"SELECT * FROM teacher_table WHERE teacher_id = '{teacher_id_num}';";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Teacher ID: " + table.Rows[i]["teacher_id"]);
                    fnameTxt.Text = table.Rows[i]["fname"].ToString();
                    lnameTxt.Text = table.Rows[i]["lname"].ToString();
                    titleTxt.Text = table.Rows[i]["title"].ToString();
                    rankTxt.Text = table.Rows[i]["rank"].ToString();
                }


                conn.Close();
            }

        }
    }
}
