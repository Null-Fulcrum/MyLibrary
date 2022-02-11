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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyLibrary.ClassHelper;

namespace MyLibrary.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = AppDate.Context.Emplovee.ToList().
               Where(i => i.Login == txtLogin.Text && i.Password == txtPassword.Text).
               FirstOrDefault();
            if (userAuth != null)
            {
                DoubleAnimation visabilityAnim = new DoubleAnimation();
                visabilityAnim.From = 1.0;
                visabilityAnim.To = 0.0;
                visabilityAnim.Duration = TimeSpan.FromSeconds(1);
                MainGrid.BeginAnimation(Grid.OpacityProperty, visabilityAnim);
            }
            else
            {
              

                MessageBox.Show("Пользователь с такими данными не найден!");
            }
        }
    }
}
