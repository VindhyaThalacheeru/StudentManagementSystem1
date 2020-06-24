using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegistration
{
    public class DisconnectedSample
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["atmsms"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            return con;
        }


        public void GetData()
        {
            //SqlConnection con = ConnectionEstablish();
            string cs = "Data Source = 10.0.1.7; Initial Catalog = StudentCourseRegistration; Integrated Security = True;";
            //  string cs1 = "Server=10.0.1.7;Database=Sales;Trusted_Connection=true";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT courseId, courseName, courseDetail, duration, fees FROM Course1", cs);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row[0].ToString() + "   " + row[1].ToString() + "" + row[2].ToString() + " " + row[3].ToString() + " " + row[4].ToString() + " ");
            }

            Console.WriteLine("data has filled");

        }

    }
}
