using System;
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
            PopulateStudentListBox();
        }

        public void PopulateStudentListBox()
        {
            StudentListBox.ItemsSource = _crudManager.RetrieveAllStudents();
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
                if (StudentIDTB.Text != null)
                {

                }
            }
        }
    }
}
