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
    /// Interaction logic for Teachers.xaml
    /// </summary>
    public partial class Teachers : Page
    {
        CRUDManager _crudManager = new CRUDManager();
        public Teachers()
        {
            InitializeComponent();
            PopulateTeacherListBox();
        }

        public void PopulateTeacherListBox()
        {
            TeacherListBox.ItemsSource = _crudManager.RetrieveAllTeachers();
        }

        private void TeacherListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (TeacherListBox.SelectedItem != null)
            {
                _crudManager.SetSelectedTeacher(TeacherListBox.SelectedItem);
                PopulateTeacherFields();
            }
        }

        public void PopulateTeacherFields()
        {
            if (_crudManager.SelectedTeacher != null)
            {
                TeacherIDTB.Text = _crudManager.SelectedTeacher.TeacherId.ToString();
                TFirstNameTB.Text = _crudManager.SelectedTeacher.FirstName;
                TLastNameTB.Text = _crudManager.SelectedTeacher.LastName;
                TeacherEmailTB.Text = _crudManager.SelectedTeacher.Email;
            }
        }

        private void AddTeacherBT_Click(object sender, RoutedEventArgs e)
        {
            if (TeacherListBox.SelectedItem == null)
            {
                var iD = int.TryParse(TeacherIDTB.Text, out int tID);
                var tFirstName = TFirstNameTB.Text;
                var tLastName = TLastNameTB.Text;
                var tEmail = TeacherEmailTB.Text;

                _crudManager.AddTeacher(tID, tFirstName, tLastName, tEmail);
            }

            PopulateTeacherListBox();
            TeacherIDTB.Clear();
            TFirstNameTB.Clear();
            TLastNameTB.Clear();
            TeacherEmailTB.Clear();
            
        }

        private void EditTeacherBt_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.EditTeacher(int.Parse(TeacherIDTB.Text), TFirstNameTB.Text, TLastNameTB.Text, TeacherEmailTB.Text);
            TeacherListBox.ItemsSource = null;
            PopulateTeacherListBox();
            TeacherListBox.SelectedItem = _crudManager.SelectedTeacher;
            PopulateTeacherFields();
        }

        private void DeleteTeacherBt_Click(object sender, RoutedEventArgs e)
        {
            _crudManager.DeleteTeacher(int.Parse(TeacherIDTB.Text));
            TeacherIDTB.Clear();
            TFirstNameTB.Clear();
            TLastNameTB.Clear();
            TeacherEmailTB.Clear();
            PopulateTeacherListBox();

        }

        private void ResetBt_Click(object sender, RoutedEventArgs e)
        {
            TeacherIDTB.Clear();
            TFirstNameTB.Clear();
            TLastNameTB.Clear();
            TeacherEmailTB.Clear();
        }
    }
}
