using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using StudentIntelisenceApi.Models;
using StudentIntelisenceApi.Data_Layer;

namespace StudentIntelisenceApi.Business_Layer
{
    public class StudentBL
    {
        public StudentDL dataLayer = new StudentDL();
        public List<Student> GetAllStudents()
        {
            try
            {
                DataTable table = new DataTable();
                List<Student> listStudents = new List<Student>();
                table = dataLayer.GetAllStudents();

                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in table.Rows)
                    {
                        Student student = new Student();
                        student.ID = Convert.ToInt32(dataRow["ID"]);
                        student.FirstName = dataRow["FirstName"].ToString();
                        student.LastName = dataRow["LastName"].ToString();
                        student.Course = dataRow["Course"].ToString();
                        student.Age = Convert.ToInt32(dataRow["Age"].ToString());
                        listStudents.Add(student);
                    }
                }
                return listStudents;
            }
            catch (Exception exception)
            {
                throw new Exception("An exception of type " + exception.GetType().ToString()
                   + " is encountered in GetListOfStudents due to "
                   + exception.Message, exception.InnerException);
            }
        }
        public List<Student> GetbyName(string str)
        {
            try
            {
                DataTable table = new DataTable();
                List<Student> listStudents = new List<Student>();
                table = dataLayer.GetbyName(str);

                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow dataRow in table.Rows)
                    {
                        Student student = new Student();
                        student.ID = Convert.ToInt32(dataRow["ID"]);
                        student.FirstName = dataRow["FirstName"].ToString();
                        student.LastName = dataRow["LastName"].ToString();
                        student.Course = dataRow["Course"].ToString();
                        student.Age = Convert.ToInt32(dataRow["Age"].ToString());
                        listStudents.Add(student);
                    }
                }
                return listStudents;
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