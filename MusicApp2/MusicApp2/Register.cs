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

namespace MusicApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ORI3K49\SQLEXPRESS;Initial Catalog=MusicApp;Integrated Security=True");

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void rgs_clear_btn_Click(object sender, EventArgs e)
        {
            rgs_name_btn.Clear();
            rgs_email_btn.Clear();
            rgs_password_btn.Clear();
            rgs_confirm_btn.Clear();

            rgs_name_btn.Focus();
        }

        private void rgs_register_btn_Click(object sender, EventArgs e)
        {
            String name, email, password, confirm;

            name = rgs_name_btn.Text;
            email = rgs_email_btn.Text;
            password = rgs_password_btn.Text;
            confirm = rgs_confirm_btn.Text;
            conn.Open();

            if (name != "" || email != "" || password != "" || confirm != "")
            {
                if(password == confirm)
                {
                    try
                    {
                        string insertQuery = "INSERT INTO Users (Name, Email, Password) VALUES (@name, @email, @password)";

                        using (conn)
                        {
                            
                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@password", password);

                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Register is successful", "Alert");
                        Logincs logincs = new Logincs();
                        logincs.Show();

                        this.Close();
                    }
                    catch(SqlException ex) 
                    {
                        if(ex.Number == 2627)
                        {
                            errorProvider2.SetError(rgs_email_btn, "This email address is already in use!");
                            MessageBox.Show("Register is unsuccessful","Error");

                            Logincs logincs = new Logincs();
                            logincs.Show();

                            this.Close();

                            
                        }
                    }
                    


                }
                else
                {
                    errorProvider1.SetError(rgs_register_btn, "Password and Confirm are not same!");
                }
            }
            else
            {
                errorProvider1.SetError(rgs_register_btn, "There are values that you did not enter!");
            }

        }

        private void rgs_login_btn_Click(object sender, EventArgs e)
        {
            Logincs logincs = new Logincs();
            logincs.Show();
            this.Hide();
        }
    }
}
