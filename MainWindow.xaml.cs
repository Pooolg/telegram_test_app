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
using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System;


namespace testapp
{
    public partial class MainWindow : Window
    {
        private MessageBoxResult result_lang;
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            this.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private async void Sqlexecute(string commandText,bool need_return)
        {
            
        }

        private void help_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private async void Start_btn_Click(object sender, RoutedEventArgs e)
        {
            string bot_token = Bot_token_text_box.Text.Trim();
            string lang = "RU";

            if (bot_token.Length < 32)
            {
                dbSqliteCheck l = new dbSqliteCheck();
                l.print("HI");
                Bot_token_text_box.ToolTip = "bot_token invalid";
                Bot_token_text_box.Background = Brushes.DarkRed;
                await Task.Delay(100);
                Bot_token_text_box.Background = Brushes.IndianRed;
                await Task.Delay(70);
                Bot_token_text_box.Background = Brushes.White;
            }
            else
            {
                result_lang = MessageBox.Show("Ваш язык русский?", "Language", MessageBoxButton.YesNo);
                Console.WriteLine(result_lang);
            }
        }

        private void help_btn_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
