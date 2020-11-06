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

namespace CourseWork
{
    class SQLWorker
    {
        private string connectionString;
        private string query;

        public SQLWorker(string userConnectionString,string userQuery)
        {
            this.connectionString = userConnectionString;
            this.query = userQuery;
        }

        public void Register(string user,string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand("AddUser", sqlCon);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.AddWithValue("@username", user);
                sqlCom.Parameters.AddWithValue("@password", password);
                sqlCom.ExecuteNonQuery();
            }
        }

        public bool IsUserExists()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
