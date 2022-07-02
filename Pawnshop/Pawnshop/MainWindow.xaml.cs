using Pawnshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pawnshop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static PawnshopEntities db = Class1.GetContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Password;
            var authUser = db.Employee.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
            if (authUser != null)
            {
                MessageBox.Show("Авторизация прошла успешно");
            }
            else MessageBox.Show("Не верно введен логин или пароль");
        }



      

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }
    }
}
    

