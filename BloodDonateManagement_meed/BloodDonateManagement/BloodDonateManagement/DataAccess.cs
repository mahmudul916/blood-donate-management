using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace BloodDonateManagement
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private System.Data.DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }
                
        public DataAccess()
        {
            //this.Sqlcon = new SqlConnection(@"Data Source = TASNIM\SQLEXPRESS; Initial Catalog = Admin; User ID = sa; Password = 12345678");
            this.Sqlcon = new SqlConnection(@"Data Source=.;Initial Catalog=BloodDonor;Integrated Security=True");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);

            return Ds;


        }
            
    }
}
