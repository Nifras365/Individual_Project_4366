using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Student_management_system_4366
{
    public class AddStudent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public BitmapImage Image { get; set; }

        public string DateOfBirth { get; set; }

        public double GPA { get; set; }

        public String ImageUrl
        {
            get { return $"C:/Users/Nifras MJM/Desktop/GUI Individual/Student_management_system_4366/{Image}"; }

        }

        public AddStudent(string firstName, string lastName, int age, BitmapImage image, string dateOfBirth, double gPa)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Image = image;
            DateOfBirth = dateOfBirth;
            GPA = gPa;
        }

        public AddStudent() { }
    }
}

