using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MyCrud
{
    public class DB
    {

        // приветствие из конфигурации
        public static readonly string hello = ConfigurationManager.AppSettings["hello"];
        // строка подключения из конфигурации
        private static readonly string con = ConfigurationManager.AppSettings["con"];


        public static List<StudentModel> pStudentSearch(string lname)
        {
            using (IDbConnection db = new SqlConnection(con))
            {
                return db.Query<StudentModel>("pStudentSearch",
                    new { @lname = lname },
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static DataTable pStudentSearchDT(string lname)
        {
            using (SqlConnection db = new SqlConnection(con))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand("pStudentSearch", db))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@lname", lname);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
            }
        }

        public static string pStudentAddOrEdit(StudentAddOrEditModel model)
        {
            using (IDbConnection db = new SqlConnection(con))
            {
                db.Execute("pStudentAddOrEdit", model, commandType: CommandType.StoredProcedure);
                return "ok";
            }
        }

        public static StudentAddOrEditModel pGetStudentById(string id)
        {
            using (IDbConnection db = new SqlConnection(con))
            {
                return db.Query<StudentAddOrEditModel>("pGetStudentById",
                    new { @id = id },
                    commandType: CommandType.StoredProcedure)
                    .FirstOrDefault();
            }
        }

        public static string pStudentDel(string id)
        {
            using (IDbConnection db = new SqlConnection(con))
            {
                db.Execute("pStudentDel",
                    new { @id = id },
                    commandType: CommandType.StoredProcedure);
                return "ok";
            }
        }

    }
}