using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace BTH5
{
    class QLSV
    {
        public static QLSV Instance { get; private set; }

        String connString = @"Data Source=localhost;Initial Catalog=master;Integrated Security=True";

        SqlConnection myConnection;
        private void Dtb()
        {
            myConnection = new SqlConnection(connString);
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        public void AddInfo(Student std)
        {
            try {
                SqlCommand myCmd = myConnection.CreateCommand();
                myCmd.CommandText = "insert into QLSV.dbo.SV (sv_name, sv_id, sv_class, sv_dob, sv_gender, areacode, sv_phone, sv_mail) values (@sv_name, @sv_id, @sv_class, @sv_dob, @sv_gender, @areacode, @sv_phone, @sv_mail)";
                myCmd.Parameters.AddWithValue("@sv_name", std.Sv_name);
                myCmd.Parameters.AddWithValue("@sv_id", std.Id);
                myCmd.Parameters.AddWithValue("@sv_class", std.Sv_class);
                myCmd.Parameters.AddWithValue("@sv_dob", std.Dob);
                myCmd.Parameters.AddWithValue("@sv_gender", (int) std.Gender);
                myCmd.Parameters.AddWithValue("@areacode", std.Areacode);
                myCmd.Parameters.AddWithValue("@sv_phone", std.Phone);
                myCmd.Parameters.AddWithValue("@sv_mail", std.Mail);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public List<Student> GetAllRecords()
        {
            List<Student> result = new List<Student>();
            SqlDataReader reader = null;

            try
            {
                SqlCommand myCmd = myConnection.CreateCommand();
                myCmd.CommandText = "select * from QLSV.dbo.SV";
                
                reader = myCmd.ExecuteReader();
                while (reader.Read())
                {
                    Student std = new Student()
                    {
                        Id = reader["sv_id"] as string,
                        Sv_name = reader["sv_name"] as string,
                        Sv_class = reader["sv_class"] as string,
                        Mail = reader["sv_mail"] as string,
                        Phone = (int)reader["sv_phone"],
                        Gender = (Gender)(int)reader["sv_gender"],
                        Dob = (DateTime)reader["sv_dob"],
                        Areacode = reader["areacode"] as string
                    };

                    result.Add(std);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            } finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return result;
        }

        public void DeleteInfo(string id)
        {
            try {
                SqlCommand myCmd = myConnection.CreateCommand();
                myCmd.CommandText = "delete from QLSV.dbo.SV where sv_id = @id";
                myCmd.Parameters.AddWithValue("@id", id);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        public void UpdateInfo(Student std)
        {
            try
            {
                SqlCommand myCmd = myConnection.CreateCommand();
                myCmd.CommandText = "update QLSV.dbo.SV set sv_name = @sv_name, sv_class = @sv_class, sv_dob = @sv_dob, sv_gender = @sv_gender, areacode = @areacode, sv_phone = @sv_phone, sv_mail = @sv_mail where sv_id = @sv_id";
                myCmd.Parameters.AddWithValue("@sv_name", std.Sv_name);
                myCmd.Parameters.AddWithValue("@sv_id", std.Id);
                myCmd.Parameters.AddWithValue("@sv_class", std.Sv_class);
                myCmd.Parameters.AddWithValue("@sv_dob", std.Dob);
                myCmd.Parameters.AddWithValue("@sv_gender", (int)std.Gender);
                myCmd.Parameters.AddWithValue("@areacode", std.Areacode);
                myCmd.Parameters.AddWithValue("@sv_phone", std.Phone);
                myCmd.Parameters.AddWithValue("@sv_mail", std.Mail);
                myCmd.ExecuteNonQuery();
            }
            catch { }
        }

        private QLSV()
        {
            Dtb();
        }

        public static void StartService(bool forceRestart = false)
        {
            if (Instance == null || forceRestart)
            {
                Instance = new QLSV();
            }

        }
    }
}
