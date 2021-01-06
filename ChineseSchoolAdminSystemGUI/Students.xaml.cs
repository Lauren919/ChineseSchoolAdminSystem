﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChineseSchoolAdminSystem;
using ChineseSchoolAdminSystemBusiness;

namespace ChineseSchoolAdminSystemGUI
{
    /// <summary>
    /// Interaction logic for Students.xaml
    /// </summary>
    public partial class Students : Page
    {
        CRUDManager _crudManager = new CRUDManager();
        public Students()
        {
            InitializeComponent();
            PopulateClassListBox();
        }

        public void PopulateClassListBox()
        {
            ClassListBox.ItemsSource = _crudManager.RetrieveAllClasses();
        }

        private void ClassListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _crudManager.SelectedClass = _crudManager.GetClass(ClassListBox.SelectedItem.ToString());
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents(_crudManager.SelectedClass.ClassName);
        }

        public void PopulateStudentListBox()
        {
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents("Mandarin-Beginner");
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents("Mandarin-Intermediate");
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents("Mandarin-Advanced");
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents("Cantonese-Beginner");
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents("Cantonese-Intermediate");
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents("Cantonese-Advanced");
        }

        private void StudentListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (StudentListBox.SelectedItem != null)
            {
                _crudManager.SetSelectedStudent(StudentListBox.SelectedItem);
                PopulateStudentFields();
            }
        }

        public void PopulateStudentFields()
        {
            if (_crudManager.SelectedStudent != null)
            {
                StudentIDTB.Text = _crudManager.SelectedStudent.StudentId.ToString();
                FirstNameTB.Text = _crudManager.SelectedStudent.FirstName;
                LastNameTB.Text = _crudManager.SelectedStudent.LastName;
                AgeTB.Text = _crudManager.SelectedStudent.Age.ToString();
                AllergiesTB.Text = _crudManager.SelectedStudent.Allergies;
                ParentNameTB.Text = _crudManager.SelectedStudent.ParentName;
                ParentContactNoTB.Text = _crudManager.SelectedStudent.ParentContactNumber;
                ParentEmailTB.Text = _crudManager.SelectedStudent.ParentEmail;
                ClassIDTB.Text = _crudManager.SelectedStudent.ClassId.ToString();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if(StudentListBox.SelectedItem == null)
            {
                var sID = int.TryParse(StudentIDTB.Text, out int studentID);
                if (sID == false)
                {
                    MessageBox.Show("Invalid Entry. Please enter a valid number");
                }
                var sFirstName = FirstNameTB.Text;
                var sLastName = LastNameTB.Text;
                var age = int.TryParse(AgeTB.Text, out int sAge);
                var allergies = AllergiesTB.Text;
                var parentName = ParentNameTB.Text;
                var parentContact = ParentContactNoTB.Text;
                var parentEmail = ParentEmailTB.Text;
                var classID = int.TryParse(ClassIDTB.Text, out int sClassID);

                _crudManager.AddStudent(studentID, sFirstName, sLastName, sAge, allergies, parentName, parentContact, parentEmail, sClassID);
            }

            PopulateStudentListBox();
            StudentIDTB.Clear();
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AgeTB.Clear();
            AllergiesTB.Clear();
            ParentNameTB.Clear();
            ParentContactNoTB.Clear();
            ParentEmailTB.Clear();
            ClassIDTB.Clear();
        }

        private void EditBt_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.EditStudent(int.Parse(StudentIDTB.Text), FirstNameTB.Text, LastNameTB.Text, int.Parse(AgeTB.Text), AllergiesTB.Text, ParentNameTB.Text, ParentContactNoTB.Text, ParentEmailTB.Text, int.Parse(ClassIDTB.Text));
            StudentListBox.ItemsSource = null;
            PopulateStudentListBox();
            StudentListBox.SelectedItem = _crudManager.SelectedStudent;
            PopulateStudentFields();
        }

        private void DeleteBt_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.DeleteStudent(int.Parse(StudentIDTB.Text));
            StudentIDTB.Clear();
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AgeTB.Clear();
            AllergiesTB.Clear();
            ParentNameTB.Clear();
            ParentContactNoTB.Clear();
            ParentEmailTB.Clear();
            ClassIDTB.Clear();
            StudentListBox.ItemsSource = null;
            PopulateStudentListBox();
        }

        private void ResetBt_Click(object sender, RoutedEventArgs e)
        {
            StudentIDTB.Clear();
            FirstNameTB.Clear();
            LastNameTB.Clear();
            AgeTB.Clear();
            AllergiesTB.Clear();
            ParentNameTB.Clear();
            ParentContactNoTB.Clear();
            ParentEmailTB.Clear();
            ClassIDTB.Clear();
        }
    }
}
