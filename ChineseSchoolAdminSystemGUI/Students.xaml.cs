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
    }
}
