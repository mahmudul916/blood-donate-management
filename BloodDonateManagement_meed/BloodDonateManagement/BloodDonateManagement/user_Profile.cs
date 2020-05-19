using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonateManagement
{
    public partial class user_Profile : MetroFramework.Forms.MetroForm
    {
        //public user_Profile()
        //{
        //    InitializeComponent();
        //}

        //private void user_Profile_Load(object sender, EventArgs e)
        //{

        //}
        string name;
        string selectedUserName;
        string email;

        DataAccess da;
        DataSet Ds;

        public user_Profile(string name)
        {
            InitializeComponent();
            this.name = name;
            da = new DataAccess();
            this.showInfo();


        }

        private void showInfo()
        {

            //MessageBox.Show("show info");
            string sql = "SELECT * FROM SignUp_Table WHERE Name ='" + this.name + "';";
            Ds = da.ExecuteQuery(sql);
            this.mtxtName.Text = Ds.Tables[0].Rows[0][0].ToString();
            this.mtxtAge.Text = Ds.Tables[0].Rows[0][1].ToString();
            this.mtxtArea.Text = Ds.Tables[0].Rows[0][2].ToString();
            this.mtxtBG.Text = Ds.Tables[0].Rows[0][3].ToString();
            //MessageBox.Show("show info done");

        }

        private void user_Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sql="select * from UserRegistration where BloodGroup ='"+this.mcmbSearch.Text+"' and DonorStatus='yes';";
            //string sql = "select * from UserRegistration where BloodGroup ='" + this.mcmbSearch.Text + "';";
            //MessageBox.Show("metro combo box 1 selected index change");
            string sql = "select * from SignUp_Table where BloodGroup ='" + this.mcmbSearch.Text + "';";
            this.Ds = da.ExecuteQuery(sql);
            this.UsrGrid.AutoGenerateColumns = false;
            this.UsrGrid.DataSource = this.Ds.Tables[0];
            //MessageBox.Show("metro combo box 1 selected index change DONE");
        }

        private void user_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void user_Profile_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("user profile load");
            // TODO: This line of code loads data into the 'bloodDonorDataSet.SignUp_Table' table. You can move, or remove it, as needed.
            this.signUp_TableTableAdapter.Fill(this.bloodDonorDataSet.SignUp_Table);
            // TODO: This line of code loads data into the 'adminDataSet.User_Table' table. You can move, or remove it, as needed.
            //this.user_TableTableAdapter.Fill(this.adminDataSet.User_Table);
            this.signUp_TableTableAdapter.Fill(this.bloodDonorDataSet.SignUp_Table);
            // TODO: This line of code loads data into the 'bloodDonorDataSet.UserRegistration' table. You can move, or remove it, as needed.
            this.signUp_TableTableAdapter.Fill(this.bloodDonorDataSet.SignUp_Table);
            //MessageBox.Show("user profile load DONE");

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //string sql = "select * from UserRegistration where Area ='" + this.mcmbAreaSearch.Text + "';";
            //MessageBox.Show("last");
            string sql = "select * from SignUp_Table where Area ='" + this.mcmbAreaSearch.Text + "';";
            this.Ds = da.ExecuteQuery(sql);
            this.UsrGrid.AutoGenerateColumns = false;
            this.UsrGrid.DataSource = this.Ds.Tables[0];
            //MessageBox.Show("last done");
        }

        private void mcmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //blood group
            string sql = "select * from SignUp_Table where bloodgroup ='" + this.mcmbSearch.Text + "';";
            this.Ds = da.ExecuteQuery(sql);
            this.UsrGrid.AutoGenerateColumns = false;
            this.UsrGrid.DataSource = this.Ds.Tables[0];
        }

        private void mcmbAreaSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //area
            string sql = "select * from SignUp_Table where Area ='" + this.mcmbAreaSearch.Text + "';";
            this.Ds = da.ExecuteQuery(sql);
            this.UsrGrid.AutoGenerateColumns = false;
            this.UsrGrid.DataSource = this.Ds.Tables[0];
        }

        private void UsrGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = UsrGrid.Rows[e.RowIndex];

            //email = row.Cells[0].Value.ToString();

            //MessageBox.Show(email);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new SendMail(email).Visible = true;
        }

        private void UsrGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = UsrGrid.Rows[e.RowIndex];

            selectedNameTxt.Text = row.Cells[1].Value.ToString();
            email = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();

            //MessageBox.Show(email);
        }
    }
}
