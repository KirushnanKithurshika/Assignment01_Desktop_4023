using Assignment_Destop;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Assignment_Destop
{
    public partial class NewWindowVM : ObservableObject
    {


        [ObservableProperty]
        public string? firstname;
        [ObservableProperty]
        public string? lastname;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public string? dateofbirth;
        [ObservableProperty]
        public double gpa;
        [ObservableProperty]
        public string? selectedImage;
        [ObservableProperty]
        public string title;
        [ObservableProperty]
        public BitmapImage insertPhoto;

        public Student addStudent { get; private set; }
        public NewWindowVM(Student x)
        {
            addStudent = x;

            firstname = addStudent.FirstName;
            lastname = addStudent.LastName;
            age = addStudent.Age;
            gpa = addStudent.GPA;
            dateofbirth = addStudent.DateOfBirth;
            selectedImage = addStudent.Image;
        }
        public NewWindowVM()
        {

        }

        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void SaveStudent()
        {

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.");
                return;
            }
            if (addStudent == null)
            {

                addStudent = new Student()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Age = age,
                    DateOfBirth = dateofbirth,
                    GPA = gpa,
                    Image = selectedImage
                };


            }
            else
            {

                addStudent.FirstName = firstname;
                addStudent.LastName = lastname;
                addStudent.Age = age;
                addStudent.GPA = gpa;
                addStudent.Image = selectedImage;
                addStudent.DateOfBirth = dateofbirth;



            }
            if (addStudent.FirstName != null)
            {

                CloseAction();
            }
            Application.Current.MainWindow.Show();
            return;


        }

        [RelayCommand]
        public void InsertImage()
        {
            OpenFileDialog insertImg = new OpenFileDialog();
            insertImg.Filter = "Image files | *.bmp; *.png; *.jpg";
            insertImg.FilterIndex = 1;
            if (insertImg.ShowDialog() == true)
            {
                insertPhoto = new BitmapImage(new Uri(insertImg.FileName));

                MessageBox.Show("Imgae successfuly uploded!");
            }
        }



    }
}

