using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask3
{
    public class Student
    {
        string name;
        string id;
        string department;
        float cgpa;


        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Id

        {
            get => id;
            set => id = value;
        }
        public string Department
        {
            get => department;
            set => department = value;

        }
        public string CGPA

        {
            get => cgpa;
            set => cgpa = value;

        }
    }

    public void ShowInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Cgpa: " + cgpa);
    }
