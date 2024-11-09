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

namespace WPFTraning
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count = 0;
        public MainWindow()
        {
            
            InitializeComponent();
           
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            count ++;
            
            lw.Items.Add(count);

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            lw.Items.Remove(lw.SelectedItem);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            lw.Items.Clear();
            count = 0;
        }

       
    }
}
