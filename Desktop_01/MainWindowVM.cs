using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Desktop_01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Desktop_01
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> students;

        [ObservableProperty]
        public Student selectedStudent = null;

     
        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }

        [RelayCommand]
        public void message()
        {
            MessageBox.Show($"{selectedStudent.FirstName} GPA value must be between 0 and 4.", "Error");
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddStudentVM();
            vm.title = "DETAILS OF STUDENT";
            AddStudentWindow window = new AddStudentWindow(vm);
            window.ShowDialog();

            if (vm.User.FirstName != null)
            {
                students.Add(vm.User);
            }
        }

        [RelayCommand]

        public void Delete()
        {
            if (selectedStudent != null)
            {
                string name = selectedStudent.FirstName;
                students.Remove(selectedStudent);
                MessageBox.Show($"{name} is deleted successfuly!");

            }
            else
            {
                MessageBox.Show("Plese select the student to be deleted!", "Error");
            }
        }

        [RelayCommand]
        public void ExecuteEditStudentCommand()
        {
            if (selectedStudent != null)
            {
                var vm = new AddStudentVM(selectedStudent);
                vm.title = "Edit Student";
                var window = new AddStudentWindow(vm);

                window.ShowDialog();


                int index = students.IndexOf(selectedStudent);
                students.RemoveAt(index);
                students.Insert(index, vm.User);

            }
            else
            {
                MessageBox.Show("Please select the student to edit!", "Error");
            }
        }


        public MainWindowVM()
        {
            students = new ObservableCollection<Student>();
            BitmapImage image1 = new BitmapImage(new Uri("/Model/Images/1.png", UriKind.Relative));
            students.Add(new Student(20231001,20,"Ruvini","Buddhika",image1,"15/02/1999",3.56));
            BitmapImage image2 = new BitmapImage(new Uri("/Model/Images/2.png", UriKind.Relative));
            students.Add(new Student(20231002, 23, "Chapa", "Nishadi", image2, "12/03/1998", 3.56));
            BitmapImage image3 = new BitmapImage(new Uri("/Model/Images/3.png", UriKind.Relative));
            students.Add(new Student(20231003, 24, "Prasadi", "Maneesha", image3, "19/09/1999", 3.56));
            BitmapImage image4 = new BitmapImage(new Uri("/Model/Images/4.png", UriKind.Relative));
            students.Add(new Student(20231004, 22, "Nimmi", "Nadeeshani", image4, "17/03/2000", 3.56));
            BitmapImage image5 = new BitmapImage(new Uri("/Model/Images/6.png", UriKind.Relative));
            students.Add(new Student(20231005, 21, "Yeshvi", "Amelya", image5, "01/01/1999", 3.56));
        }

    }
}
