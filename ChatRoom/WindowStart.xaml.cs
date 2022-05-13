using Microsoft.VisualStudio.Web.CodeGeneration.DotNet;
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
using System.Windows.Shapes;

namespace ChatRoom
{
    /// <summary>
    /// Interaction logic for WindowStart.xaml
    /// </summary>
    public partial class WindowStart : Window
    {
        ApplicationInfo app = null;
        public WindowStart(ApplicationInfo app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            
            if(login.Text != "" && password.Text != "")
            {
                if (!app.IsUserForLogin(login.Text))
                {

                    //app.CreateNewUser(login.Text, password.Text);
                    //MainWindow mainWindow = new MainWindow(ApplicationInfo app);
                    //mainWindow.Show();
                    //this.Close();

                }
                else
                {
                    login.ToolTip = "Пользователь уже существует";
                    login.Background = Brushes.LightCoral;
                }
            }
            else
            {
                MessageBox.Show("Не ввели логин и/или пароль");
            }
        }

        private void registration(object sender, RoutedEventArgs e)
        {
            WindowRegistration windowRegistration = new WindowRegistration();
            windowRegistration.Show();
            this.Close();
        }
    }
}
