
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Assignment_Destop
{
    public partial class CollectionWindow : ObservableObject
    {


        [ObservableProperty]
        public ObservableCollection<Student> students;
        [ObservableProperty]
        public Student? edit_student = null;




        [RelayCommand]
        public void RemoveStudent()
        {
            if (edit_student != null)
            {
                string name = edit_student.FirstName;
                students.Remove(edit_student);
                MessageBox.Show($"{name} is Deleted successfuly");

            }
            else
            {
                MessageBox.Show("Please Select Student");


            }
        }

        [RelayCommand]
        public void AddStudent()
        {
            /*
            var student = new Student(21, "wall", "King", "2001/08/04", 3.9, "4.png");
            Person.Add(student);
            */
            var newWindow = new NewWindowVM();

            newWindow.title = "ADD STUDENT";
            NewWindow window = new NewWindow(newWindow);
            window.ShowDialog();

            if (newWindow.addStudent.FirstName != null)
            {
                students.Add(newWindow.addStudent);
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if (edit_student != null)
            {
                var newWindow = new NewWindowVM(edit_student);
                newWindow.title = "EDIT STUDENT";
                var window = new NewWindow(newWindow);

                window.ShowDialog();


                int index = students.IndexOf(edit_student);
                students.RemoveAt(index);
                students.Insert(index, newWindow.addStudent);



            }
            else
            {
                MessageBox.Show("Please Select the student");
            }
        }

        public CollectionWindow()
        {
            students = new ObservableCollection<Student>();
            students.Add(new Student(22, "Harry","Potter", "2000/12/01", 3.5, "1.png"));
            students.Add(new Student(23, "Henry", "Petter", "1999/02/11", 3.2, "10.png"));
            students.Add(new Student(22, "Charry", "Jhon", "2000/11/21", 3.7, "3.png"));
            students.Add(new Student(21, "Paul",  "Lewi", "2001/03/03", 3.4, "7.png"));
            students.Add(new Student(23, "Lewis",  "Sam", "1999/10/08", 3.5, "8.png"));
            students.Add(new Student(22, "Rahul",  "Doll", "2000/04/01", 3.5, "2.png"));
        }



    }
}
