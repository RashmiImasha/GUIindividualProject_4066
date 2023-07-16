using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_01.Model;
using Microsoft.Win32;


namespace Desktop_01
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public int idNo;

        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;

        
        //To change the tile

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage selectedImage;

       

        public AddStudentVM(Student u)
        {
            User = u;

            idNo = User.IdNo;
            firstname = User.FirstName;
            lastname = User.LastName;
            age = User.Age;
            gpa = User.GPA;
            dateofbirth = User.DateofBirth;
            selectedImage = User.Image;
        }
        public AddStudentVM()
        {

        }

        //get image
        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                selectedImage = new BitmapImage(new Uri(dialog.FileName));

                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }
        }

        public Student User { get; private set; }
        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void Save()
        {
            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.", "Error");
                return;
            }
            if (User == null)
            {

                User = new Student()
                {
                    IdNo = idNo,
                    Age = age,
                    FirstName = firstname,
                    LastName = lastname,
                    Image =selectedImage,
                    DateofBirth = dateofbirth,                    
                    GPA = Gpa
                };
            }
            else
            {
                User.FirstName = firstname;
                User.LastName = lastname;
                User.Age = age;
                User.GPA = gpa;
                User.Image = selectedImage;
                User.DateofBirth = dateofbirth;
            }

            if (User.FirstName != null)
            {
                CloseAction();
            }
            Application.Current.MainWindow.Show();
        }
    }

}

