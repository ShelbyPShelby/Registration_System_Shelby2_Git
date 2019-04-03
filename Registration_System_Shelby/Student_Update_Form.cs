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
    public partial class Student_Update_Form : Form
    {
        public Student_Update_Form()
        {
            InitializeComponent();

            //Zach Approach 
            //Shout out to Zach on 3-21-2019 for showing dr_T's Tired brain where to put this code
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
                    studentidcombo.Items.Add(table.Rows[i]["student_id"] + "," + table.Rows[i]["lname"] + "," + table.Rows[i]["fname"]);
                }

                reader.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                
                string studentselectionid = studentidcombo.Text;
                string[] words = studentselectionid.Split(',');
                string student_id_num = words[0]; //get the id from the split string.        

                conn.Open();

                string fname = fnametxt.Text;
                string lname = lnametxt.Text;
                string major = majortxt.Text;
                string degree = degreetxt.Text;

                string query = $"UPDATE `student_table` SET `fname`='{fname}', `lname`='{lname}', `major`='{major}', `degree`='{degree}' WHERE `student_id`={student_id_num};";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); //close the form
        }

        private void Student_Update_Form_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void studentidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {

                string studentselectionid = studentidcombo.Text;
                string[] words = studentselectionid.Split(',');
                string student_id_num = words[0]; //get the id from the split string. 


                conn.Open();

                string query = $"SELECT * FROM student_table WHERE student_id = '{student_id_num}';";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable table = new DataTable();

                table.Load(reader);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //  Console.WriteLine(table.Rows[i]["name"]);
                    MessageBox.Show("Adding Student ID: " + table.Rows[i]["student_id"]);
                    fnametxt.Text = table.Rows[i]["fname"].ToString();
                    lnametxt.Text = table.Rows[i]["lname"].ToString();
                    majortxt.Text = table.Rows[i]["major"].ToString();
                    degreetxt.Text = table.Rows[i]["degree"].ToString();
                }

           
                conn.Close();
            }

        }
    }
}
