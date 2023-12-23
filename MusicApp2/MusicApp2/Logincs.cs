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
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ORI3K49\SQLEXPRESS;Initial Catalog=MusicApp;Integrated Security=True");

        private void Logincs_Load(object sender, EventArgs e)
        {
            
        }

        private void lgn_clear_btn_Click(object sender, EventArgs e)
        {
            lgn_mail_txb.Clear();
            lgn_password_txb.Clear();

            lgn_mail_txb.Focus();
        }

        private void lgn_login_btn_Click(object sender, EventArgs e)
        {
            String email, password;

            email = lgn_mail_txb.Text;
            password = lgn_password_txb.Text;

            if (email == "" || password == "")
            {
                errorProvider1.SetError(lgn_login_btn, "There are values that you did not enter!");
            }
            else
            {
                try
                {
                    String querry = "SELECT * FROM Users WHERE Email =  '" + email + "' AND Password = '" + password + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        email = lgn_mail_txb.Text;
                        password = lgn_password_txb.Text;

                        // Kullanıcı girişini kontrol et ve kullanıcı bilgilerini veritabanından al
                      

                        // SQL sorgusuyla kullanıcıyı doğrula ve kullanıcı ID'sini al
                        string query = "SELECT Id FROM Users WHERE Email = @email AND Password = @password";
                        int userId;
                        using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ORI3K49\\SQLEXPRESS;Initial Catalog=MusicApp;Integrated Security=True"))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@email", email);
                                command.Parameters.AddWithValue("@password", password);

                                connection.Open();
                                var result = command.ExecuteScalar(); // Kullanıcı ID'sini al

                                if (result != null) // Kullanıcı doğrulandıysa
                                {
                                    userId = Convert.ToInt32(result); // Kullanıcı ID'sini al
                                                                      // Oturum boyunca kullanıcı ID'sini sakla (örneğin, Session ile)
                                    User.Id = userId; // Örnek: Session ile kullanıcı ID'sini saklama
                                    
                                 
                                }
                            }
                        }


                        Player player = new Player();
                        player.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lgn_mail_txb.Clear();
                        lgn_password_txb.Clear();

                        lgn_mail_txb.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void lgn_exit_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
