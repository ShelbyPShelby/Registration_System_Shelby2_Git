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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=registration_db;user=root"))
            {
                string fname = fnameTxt.Text,
                       lname = lnameTxt.Text,
                       major = majorTxt.Text,
                       degree = degreeTxt.Text;

                conn.Open();

                string query = $"INSERT INTO `student_table` (`student_id`, `fname`, `lname`, `major`, `degree`) VALUES (NULL, '{fname}', '{lname}', '{major}', '{degree}');";
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
    }
}
