using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Student_management_system_4366
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofBirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage selectedImage;

        public AddStudentVM(AddStudent a)
        {

            NewStudent = a;

            firstname = NewStudent.FirstName;
            lastname = NewStudent.LastName;
            age = NewStudent.Age;
            dateofBirth = NewStudent.DateOfBirth;
            gpa = NewStudent.GPA;
            selectedImage = NewStudent.Image;
        }
        //new
        public AddStudentVM() { }

        public AddStudent NewStudent { get; private set; }

        public Action CloseAction { get; internal set; }
        public BitmapImage Image { get; private set; }

        [RelayCommand]
        public void Insertanimage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;

                // Display the selected image in an Image control
                selectedImage = new BitmapImage(new Uri(imagePath));
                // Example: ImageControl.Source = selectedImage.Source;
            }
        }

        [RelayCommand]
        public void saveall()
        {
            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA Value must be between 0 and 4");
            }

            if (NewStudent == null)
            {
                NewStudent = new AddStudent();
                {
                    Firstname = firstname;
                    Lastname = lastname;
                    Age = age;
                    DateofBirth = dateofBirth;
                    Image = selectedImage;
                    Gpa = gpa;

                }
            }

            else
            {
                NewStudent.FirstName = firstname;
                NewStudent.LastName = lastname;
                NewStudent.Age = age;
                NewStudent.DateOfBirth = dateofBirth;
                NewStudent.Image = selectedImage;
                NewStudent.GPA = gpa;
            }
            if (NewStudent.FirstName != null)
            {

                CloseAction();
            }

            // Get the current window and close it
            Window currentWindow = Window.GetWindow(Application.Current.MainWindow);
            currentWindow.Close();
        }

        [RelayCommand]
        public void closeall()
        {

            ListviewWindow listviewWindow = new ListviewWindow();
            listviewWindow.Show();

            CloseAction();
        }

    }
}
