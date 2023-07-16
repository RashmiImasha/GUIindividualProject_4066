using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Desktop_01.Model
{
    public class Student
    {
        public int IdNo { get; set; }
        public int Age { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BitmapImage Image { get; set; }
        public string DateofBirth { get; set; }
        public double GPA { get; set; }
        public string Imagepath
        {
            get { return $"/Model/Images/{Image}"; }
        }

        public Student(int idNo, int age, string firstName, string lastName, BitmapImage image, string dateofBirth, double gPA)
        {
            IdNo = idNo;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Image = image;
            DateofBirth = dateofBirth;
            GPA = gPA;
        }

        public Student()
        { 
        }
    }
}
