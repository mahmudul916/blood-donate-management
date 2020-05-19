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
    public partial class HomePage : MetroForm
    {
        DataAccess Da = new DataAccess();
        DataSet Ds = new DataSet();
        AdminTable_Repo adminrepo;

        public HomePage()
        {
            InitializeComponent();
            adminrepo = new AdminTable_Repo();
            Da = new DataAccess();
            DataView();
        }

        public void DataView(string sql = "select * from SignUp_Table;")
        {            
            this.Ds = this.Da.ExecuteQuery(sql);
            this.UserDataTable.AutoGenerateColumns = false;
            this.UserDataTable.DataSource = this.Ds.Tables[0];
                       
        }

        private void Admin_HomePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminDataSet.User_Table' table. You can move, or remove it, as needed.
            //this.user_TableTableAdapter.Fill(this.adminDataSet.User_Table);
            //this.user_TableTableAdapter.Fill(this.adminDataSet.User_Table);

        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
           {
                //string sql = (@"insert into User_Table
                //values('" + this.SignNameTxt.Text + "', '" + this.AgeTxt.Text + "', '" + this.BloodgroupTxt.Text + "',' " + this.AreaTxt.Text + "', '" + this.PhoneTxt.Text + "', '" + this.EmailTxt.@Text + "','" + this.PassTxt.Text + "');");

                //string sql = (@"INSERT INTO SignUp_Table (id , name, age, area, bloodgroup, password, email, sex, DonorStatus) 
                //                VALUES ('ID','"+SignNameTxt.Text+"','"+AgeTxt.Text+"','"+AreaTxt.Text+"','"+bloodGroupCombo.Text+"','"+PassTxt.Text+"','"+EmailTxt.Text+"','"+ genderComboBox.SelectedItem.ToString() +"','"+ donorStatusComboBox.SelectedItem.ToString()+"') ; ");

                /*string sql = (@"INSERT INTO SignUp_Table (id , name, age, area, bloodgroup, password, email, sex, DonorStatus) 
                                VALUES ('ID','"+SignNameTxt.Text+"','"+AgeTxt.Text+"','"+AreaTxt.Text+"','"+bloodGroupCombo.Text+"','"+PassTxt.Text+"','"+EmailTxt.Text+"','"+ genderComboBox.SelectedItem.ToString() +"','"+ donorStatusComboBox.SelectedItem.ToString()+"') ; ");
                                */

                try
                {
                    //Ds = Da.ExecuteQuery(sql);
                    Ds = Da.ExecuteQuery(adminrepo.InsertValue(SignNameTxt.Text,AgeTxt.Text,AreaTxt.Text,bloodGroupCombo.Text,PassTxt.Text,EmailTxt.Text, genderComboBox.Text, donorStatusComboBox.Text));
                    DataView();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }           
            //DataView();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            //string sql = "select * from Signup_Table where Name ='" + this.SignNameTxt.Text + "';";
            this.Ds = this.Da.ExecuteQuery(adminrepo.UpdateValue(this.SignNameTxt.Text));

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
            string sql = @"Update Signup_Table set
            Age='" + this.AgeTxt.Text + @"',
            BloodGroup='" + this.bloodGroupCombo.Text + @"',
            Area=' " + this.AreaTxt.Text + @"',
            Email='" + this.EmailTxt.@Text + @"' 
            where  Name='" + this.SignNameTxt.Text + "';";

                Ds = Da.ExecuteQuery(sql);
                DataView();
            }
        }

        private void UserDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SignNameTxt.Text = this.UserDataTable.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString();
            this.AgeTxt.Text = this.UserDataTable.CurrentRow.Cells["ageDataGridViewTextBoxColumn"].Value.ToString();
            this.bloodGroupCombo.Text = this.UserDataTable.CurrentRow.Cells["bloodGroupDataGridViewTextBoxColumn"].Value.ToString();
            this.AreaTxt.Text = this.UserDataTable.CurrentRow.Cells["areaDataGridViewTextBoxColumn"].Value.ToString();
            //this.PhoneTxt.Text = this.UserDataTable.CurrentRow.Cells["phoneDataGridViewTextBoxColumn"].Value.ToString();
            this.EmailTxt.Text = this.UserDataTable.CurrentRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            
        }

        private void UserDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = UserDataTable.Rows[e.RowIndex];

            SignNameTxt.Text = row.Cells[0].Value.ToString();
            AgeTxt.Text = row.Cells[1].Value.ToString();
            bloodGroupCombo.Text = row.Cells[2].Value.ToString();
            AreaTxt.Text = row.Cells[3].Value.ToString();
            EmailTxt.Text = row.Cells[4].Value.ToString();
            genderComboBox.Text = row.Cells[5].Value.ToString();
            donorStatusComboBox.Text = row.Cells[6].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string sql = @"DELETE FROM SignUp_Table WHERE name='"+SignNameTxt.Text+"';";

            //Da.ExecuteQuery(sql);
            //DataView();

            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Da.ExecuteQuery(adminrepo.DeleteValue(SignNameTxt.Text));
                MessageBox.Show("Delete Success");
                DataView();
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Canceled");
            }
            DataView();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from SignUp_Table where name like '%"+txtSearchBox.Text+"%'";
            this.Ds = Da.ExecuteQuery(sql);
            this.UserDataTable.AutoGenerateColumns = false;
            this.UserDataTable.DataSource = this.Ds.Tables[0];
        }
    }
}
