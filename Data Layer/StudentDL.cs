using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using StudentIntelisenceApi.Models;

namespace StudentIntelisenceApi.Data_Layer
{
    public class StudentDL
    {
        string _connectionString = "";
        public StudentDL()
        {
            _connectionString = WebConfigurationManager.ConnectionStrings["DemoCN"].ConnectionString;
        }
        public DataTable GetAllStudents()
        {
            try
            {
                List<Student> listStudents = new List<Student>();
                DataTable dataTable = new DataTable();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("FetchAllStudents", con);
                    command.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetListOfStudents due to "
                   + exception.Message, exception.InnerException);
            }
        }
        public DataTable GetbyName(string str)
        {
            try
            {
                List<Student> listStudents = new List<Student>();
                DataTable dataTable = new DataTable();
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand("FetchbyName", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", str);
                    con.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                }
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetListOfStudents due to "
                   + exception.Message, exception.InnerException);
            }
        }

    }
}