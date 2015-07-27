using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportDemo.PrintReport
{
    public class ReportData 
    {
        public List<student> StudentList { get; set; }

        public int TotalStudent { get; set; }
        

        public void loadReportData()
        {
            StudentList = new List<student>();
            StudentList.Add(new student("Sharad Kumar", "Pune School", "12",40));
            StudentList.Add(new student("Sharad Kumar", "Pune School", "12",30));
            StudentList.Add(new student("Sharad Kumar", "ABC School", "12",88));
            StudentList.Add(new student("Sharad Kumar", "ABC School", "12",45));
            StudentList.Add(new student("Sharad Kumar", "Pune School", "12",66));
            StudentList.Add(new student("Sharad Kumar", "XYZ School", "12",95));
            StudentList.Add(new student("Sharad Kumar", "Pune School", "12",50));
            StudentList.Add(new student("Sharad Kumar", "XYZ School", "12",65));
            StudentList.Add(new student("Sharad Kumar", "Pune School", "12",90));
            StudentList.Add(new student("Sharad Kumar", "ABC School", "12",85));
            StudentList.Add(new student("Sharad Kumar", "ABC School", "12",75));
            StudentList.Add(new student("Sharad Kumar", "XYZ School", "12",65));

            TotalStudent = StudentList.Count;
        }

        public List<student> getStudentList()
        {
            return StudentList;
        }
    }

    public class student
    {
        public student(string nm,string snm,string ag,double src)
        {
            Name = nm;
            SchoolName = snm;
            Age = ag;
            Score = src;
        }
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public string Age { get; set; }
        public double Score { get; set; }
    }
}