using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BloodDonateManagement
{
    public partial class LoginForm : MetroForm
    {
        bool check = false;
        DataAccess Da;
        DataSet Ds;
        public LoginForm()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        //admin part

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            AdminPanal.Visible = true ;
            NameTxt.Text = "";
            PasswordTxt.Text = "";
            check = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
                //string sql =(@"SELECT * FROM Admin_Table WHERE Name='" + NameTxt.Text + "' and Password='" + PasswordTxt.Text + "';");
            string sql = (@"SELECT * FROM Admin WHERE Name='" + NameTxt.Text + "' and Password='" + PasswordTxt.Text + "';");
                //string sql1= (@"SELECT * FROM User_Table WHERE Name='" +NameTxt.Text + "' and Password='" + PasswordTxt.Text + "';");
            string sql1 = (@"SELECT * FROM SignUp_Table WHERE Name='" + NameTxt.Text + "' and Password='" + PasswordTxt.Text + "';");

            if (check == true)
            {
                //if login user
                Ds = Da.ExecuteQuery(sql1);

                if (Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Welcome " + NameTxt.Text);
                    new user_Profile(NameTxt.Text).Visible = true;
                }
                else
                {
                    MessageBox.Show("Something is not right please try again");
                }
            }
            else
            {
                //if admin login
                Ds = Da.ExecuteQuery(sql);
                if (Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Welcome "+NameTxt.Text);
                    new HomePage().Visible = true;
                }
                else
                {
                    MessageBox.Show("Something is not right please try again");
                }
            }
        }
        
        private void clear_btn_Click(object sender, EventArgs e)
        {
            NameTxt.Text = "";
            PasswordTxt.Text = "";
        }

        //User part

        private void user_btn_Click(object sender, EventArgs e)
        {
            AdminPanal.Visible = true;
            check = true;
            NameTxt.Text = "";
            PasswordTxt.Text = "";


        }

        private void Sign_btn_Click(object sender, EventArgs e)
        {

            if (check == false)
                MessageBox.Show("Sign up not permitted for admin");
            else
                new Sign_Up_Form().Visible=true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
