using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Assignment_Destop
{
    public class Student
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public double GPA { get; set; }

        public string Image { get; set; }

        public string ImageURL
        {
            get
            { return $"/Images/icons/{Image}"; }
        }




        public Student(int age,
                       string firstName,
                       string lastName,
                       string dateOfBirth,
                       double GPA,
                       string image)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            this.GPA = GPA;
            Image = image;
        }

        public Student()
        {

        }
    }
}
