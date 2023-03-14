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

namespace lab21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_addition_Click(object sender, RoutedEventArgs e)
        {

            double r;
            if (!double.TryParse(tb_A.Text, out r) || !double.TryParse(tb_B.Text, out r))
            {
                tb_A.Clear();
                tb_B.Clear();
                MessageBox.Show("Invalid Data");
            }

            tb_ans.Text = (Convert.ToDouble(tb_A.Text) + Convert.ToDouble(tb_B.Text)).ToString();
        }

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {

            double r;
            if (!double.TryParse(tb_A.Text, out r) || !double.TryParse(tb_B.Text, out r))
            {
                tb_A.Clear();
                tb_B.Clear();
                MessageBox.Show("Invalid Data");
            }

            tb_ans.Text = (Convert.ToDouble(tb_A.Text) - Convert.ToDouble(tb_B.Text)).ToString();
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {

            double r;
            if (!double.TryParse(tb_A.Text, out r) || !double.TryParse(tb_B.Text, out r))
            {
                tb_A.Clear();
                tb_B.Clear();
                MessageBox.Show("Invalid Data");
            }

            tb_ans.Text = (Convert.ToDouble(tb_A.Text) * Convert.ToDouble(tb_B.Text)).ToString();
        }

        private void btn_divide_Click_1(object sender, RoutedEventArgs e)
        {
            double r;
            if (!double.TryParse(tb_A.Text, out r) || !double.TryParse(tb_B.Text, out r))
            {
                tb_A.Clear();
                tb_B.Clear();
                MessageBox.Show("Invalid Data");
            }

            tb_ans.Text = (Convert.ToDouble(tb_A.Text) / Convert.ToDouble(tb_B.Text)).ToString();
        }
    }
}
