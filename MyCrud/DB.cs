using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyCrud
{
    public class DB
    {
        static string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\байбатыровм\\Documents\\MyDB.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True;";
        public static List<StudentModel> pStudentSearch(string lname)
        {
            using (SqlConnection db = new SqlConnection(con))
            {
                return db.Query<StudentModel>("pStudentSearch", 
                    new { @lname = lname }, 
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
            }            
        }

        public static string pStudentAddOrEdit(StudentAddOrEditModel model)
        {
            using (SqlConnection db = new SqlConnection(con))
            {
                DynamicParameters p = new DynamicParameters(model);
                db.Execute("pStudentAddOrEdit", p, commandType: System.Data.CommandType.StoredProcedure);
                return "ok";
            }
        }

        public static StudentAddOrEditModel pGetStudentById(string id)
        {
            using (SqlConnection db = new SqlConnection(con))
            {
                return db.Query<StudentAddOrEditModel>("pGetStudentById", new { @id = id}, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();                
            }
        }

        public static string pStudentDel(string id)
        {
            using (SqlConnection db = new SqlConnection(con))
            {
                db.Execute("pStudentDel", new { @id = id }, commandType: System.Data.CommandType.StoredProcedure);
                return "ok";
            }
        }
    }    
}

