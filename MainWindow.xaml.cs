using Microsoft.Win32;
using System.Windows;
using WpfApp2;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.IO;

namespace pr2
{
    public partial class MainWindow : Window
    {
        private NumberManager numberManager;
        private FileManager fileManager;

        public MainWindow()
        {
            InitializeComponent();
            numberManager = new NumberManager();
            fileManager = new FileManager();
        }

        private void FillButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ArrayCountTextBox.Text, out int n) && n > 0)
                {
                    numberManager.Fill(int.Parse(ArrayCountTextBox.Text));
            }
            else
            {
                MessageBox.Show("введите корректное число");
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int difference = numberManager.CalculateDifference();
            MessageBox.Show($"разница между макс и мин значениями: {difference}");
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            numberManager.Clear();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" б\n2 практ\nввести n целых чисел, найти разницу чисел.");
        }
    }

}