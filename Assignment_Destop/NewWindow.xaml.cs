
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

namespace Assignment_Destop
{
    /// <summary>
    /// Interaction logic for NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow(NewWindowVM newWindow)
        {
            InitializeComponent();
            DataContext = newWindow;
            newWindow.CloseAction = () => Close();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //var mWindow = new MainWindow();
            //mWindow.Show();

        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShutDown_Click(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}