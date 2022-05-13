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
using System.IO;

namespace ChatRoom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(Microsoft.VisualStudio.Web.CodeGeneration.DotNet.ApplicationInfo app)
        {
            InitializeComponent();
            AddHandler(Keyboard.KeyDownEvent, (KeyEventHandler)HandlerKeyDownEvent);
        }
        private void SendMessage()
        {
            if (userRoom.Text != "")
            {
                var text = userRoom.Text.Trim();
                chatRoom.Text += "\r\n" + text;
                userRoom.Clear();
            }
            else
            {
                MessageBox.Show("НЕ ВВЕЛИ СООБЩЕНИЕ!");
            }
        }

        private void HandlerKeyDownEvent(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    SendMessage();
                    break;
                case Key.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }//Клавиатура

        public void buttonRead_Click(object sender, RoutedEventArgs e)
        {
            //var text = chatRoom.Text;
            if (userRoom.Text != "")
            {
                var text = userRoom.Text.Trim();
                chatRoom.Text += "\r\n" + text;
                userRoom.Clear();
            }

            else
            {
                MessageBox.Show("НЕ ВВЕЛИ СООБЩЕНИЕ!");
            }
        }

        private void buttonCheck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void escape_click(object sender, RoutedEventArgs e)
        {

        }


        //private void scrollToEnd(object sender, EventArgs e)
        //{
        //    chatRoom.SelectionStart = chatRoom.Text.Length;
        //    chatRoom.ScrollToCaret();
        //}
    }       
}
