using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PropertyRecord
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-NDLH171;pwd=Rup40317@;uid=sa;database=ChinAn");
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        

        private void submitButton_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO [ChinAn].[dbo].[property] (year_month, amount) VALUES (@year_month, @amount)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@year_month", dateTimePicker1.Text.Trim());
                cmd.Parameters.AddWithValue("@amount", amounttextBox.Text.Trim());

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Submit successful");
                    }
                    else
                    {
                        MessageBox.Show("Submit failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                
            }
        }
    }
}
