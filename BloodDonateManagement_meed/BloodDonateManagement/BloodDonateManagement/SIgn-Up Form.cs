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

namespace BloodDonateManagement
{
    public partial class Sign_Up_Form : MetroForm
    {
        DataAccess Da = new DataAccess();
        DataSet Ds = new DataSet();
        HomePage HP;
        public string id;
        private string ID        
        {
            get { return this.id; }
            //set { this.id = "User-" + value ; }
            set { this.id = value.ToString(); }
        }
        static int UserID = 0;

        int userID;

        public Sign_Up_Form()
        {
            InitializeComponent();
            HP = new HomePage();
            this.ID = (++UserID).ToString("d4");
        }

        private void Sign_btn_Click(object sender, EventArgs e)
        {
            {
                if(NamePart1Txt.Text=="" || SignEmailTxt.Text=="" || SignPassTxt.Text=="" || SignAreaTxt.Text=="" || bloodGroupCombo.Text=="" || SignAgeTxt.Text=="" || SexCombo.Text=="" || StatusCombo.Text=="")
                {
                    MessageBox.Show("All fields must be filled");
                    return;
                }

                try
                {
                    string sql = @"insert into SignUp_Table (id, name , age , area, bloodgroup , password, email , sex , DonorStatus) 
				        values ('"+"872s"+"','"+NamePart1Txt.Text+"',"+Convert.ToByte(SignAgeTxt.Text)+",'"+SignAreaTxt.Text+"','"+bloodGroupCombo.Text+"','"+SignPassTxt.Text+"','"+SignEmailTxt.Text+"','"+SexCombo.Text+"','"+StatusCombo.Text+"') ;"; 


                    Ds = Da.ExecuteQuery(sql);

                    MessageBox.Show("Your account has been created");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
              //  DataView();
        }

        private int GenerateId()
        {
            string sql = @"select max(id) from SignUp_Table";
            Ds = Da.ExecuteQuery(sql);

            //string s = Ds.Tables[0].Rows[0][0].ToString();
            userID = Convert.ToInt32(Ds.Tables[0].Rows[0][0]);

            return ++userID;

        }

        private void SignStatusTxt_Click(object sender, EventArgs e)
        {
            //
        }

        private void StatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SignSexTxt_Click(object sender, EventArgs e)
        {

        }

        private void SexCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void SignAgeTxt_Click(object sender, EventArgs e)
        {

        }

        private void SignBGTxt_Click(object sender, EventArgs e)
        {

        }

        private void SignAreaTxt_Click(object sender, EventArgs e)
        {

        }

        private void SignPassTxt_Click(object sender, EventArgs e)
        {

        }

        private void SignEmailTxt_Click(object sender, EventArgs e)
        {

        }

        private void NamePart2Txt_Click(object sender, EventArgs e)
        {

        }

        private void NamePart1Txt_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

        
