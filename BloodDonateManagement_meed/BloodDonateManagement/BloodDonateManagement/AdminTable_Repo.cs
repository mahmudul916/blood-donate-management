using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BloodDonateManagement
{
    class AdminTable_Repo
    {
        DataSet Ds;
        DataAccess Da;
        int userID;

        public AdminTable_Repo()
        {
            Ds = new DataSet();
            Da = new DataAccess();
        }

        private int GenerateId()
        {
            string sql = @"select max(id) from SignUp_Table";
            Ds = Da.ExecuteQuery(sql);

            //string s = Ds.Tables[0].Rows[0][0].ToString();
            userID = Convert.ToInt32(Ds.Tables[0].Rows[0][0]);

            return ++userID;

        }

        public string InsertValue(string name, string age, string area, string bloodgroup, string password, string email, string gender, string status)
        {
            return (@"INSERT INTO SignUp_Table (id , name, age, area, bloodgroup, password, email, sex, DonorStatus) 
                                VALUES ('"+GenerateId().ToString("d4")+"','" + name + "','" + age + "','" + area + "','" + bloodgroup + "','" + password + "','" + email + "','" + gender + "','" + status + "') ; " ) ; 
        }

        public string UpdateValue(string name)
        {
            return (@"select * from Signup_Table where Name ='" + name + "';");
        }

        public string DeleteValue(string name)
        {
            return (@"DELETE FROM SignUp_Table WHERE name='" + name + "';");
        }
    }
}
