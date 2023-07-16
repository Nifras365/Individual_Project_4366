using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;

namespace Student_management_system_4366
{
    public partial class ListviewWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<AddStudent> student;
        [ObservableProperty]
        public AddStudent studentNew = null;


        [RelayCommand]
        public void Adduser()
        {
            var newStudent = new AddStudent();
            var vm = new AddStudentVM(newStudent);
            vm.title = "Add User";
            Window1 window = new Window1(vm);
            window.ShowDialog();

            if (vm.NewStudent.FirstName != null)
            {
                student.Add(vm.NewStudent);
            }
        }

        [RelayCommand]

        public void Removeuser()
        {
            if (studentNew != null)
            {
                string name = studentNew.FirstName;
                student.Remove(studentNew);
                MessageBox.Show($"{name}'s profile deleted successfully");
            }

            else
            {
                MessageBox.Show("Please select a user before press the delete button!!!");
            }
        }

        [RelayCommand]

        public void Edituser()
        {
            if (studentNew != null)
            {
                var vm = new AddStudentVM(studentNew);
                vm.title = "EDIT DETAILS";
                var window = new Window1(vm);
                window.ShowDialog();

                int index = student.IndexOf(studentNew);
                student.RemoveAt(index);
                student.Insert(index, vm.NewStudent);

            }

            else
            {
                MessageBox.Show("No user selected !!!");
            }
        }

        [RelayCommand]

        public void Quitmainwindow()
        {
            Application.Current.Shutdown();
        }
        public ListviewWindowVM()
        {
            student = new ObservableCollection<AddStudent>();
            BitmapImage image1 = new BitmapImage(new Uri("C:/Users/Nifras MJM/Desktop/GUI Individual/Student_management_system_4366/A.png", UriKind.Relative));
            student.Add(new AddStudent("Kevin", "KM", 23, image1, "2000/01/01",3.1));
            BitmapImage image2 = new BitmapImage(new Uri("C:/Users/Nifras MJM/Desktop/GUI Individual/Student_management_system_4366/B.png", UriKind.Relative));
            student.Add(new AddStudent("Peter", "Parker", 21, image2, "2001/12/01",3.6));
            BitmapImage image3 = new BitmapImage(new Uri("C:/Users/Nifras MJM/Desktop/GUI Individual/Student_management_system_4366/C.png", UriKind.Relative));
            student.Add(new AddStudent("Lisa", "WR", 24, image3, "1998/08/12",2.4));
            BitmapImage image4 = new BitmapImage(new Uri("C:/Users/Nifras MJM/Desktop/GUI Individual/Student_management_system_4366/D.png", UriKind.Relative));
            student.Add(new AddStudent("Ben", "TN", 25, image4, "1998/03/21",1.8));
        }

    }
}
