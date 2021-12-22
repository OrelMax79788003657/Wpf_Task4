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

namespace Wpf_Task4
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

        private void button_Dollars_Click_1(object sender, RoutedEventArgs e)
        {

            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double rezRuble = rateDollar * sumDollar;
            resSum.Text = rezRuble.ToString();
        }

        private void button_Euro_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double rezRuble = rateEuro * sumEuro;
            resSum1.Text = rezRuble.ToString();
        }

        private void button_Hryvnia_Click(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rate2.Text);
            double sumHryvnia = Convert.ToDouble(sum2.Text);
            double rezRuble = rateHryvnia * sumHryvnia;
            resSum2.Text = rezRuble.ToString();
        }

        private void button_Dram_Click(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double sumDram = Convert.ToDouble(sum3.Text);
            double rezRuble = rateDram * sumDram;
            resSum3.Text = rezRuble.ToString();
        }




        private void buttonInches_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxInches != null && textBoxInchesResult != null)
            {
                double inches = double.Parse(textBoxInches.Text);

                double result = inches * 0.0254;

                textBoxInchesResult.Text = Convert.ToString(Math.Round(result, 2));
            }

        }

        private void buttonFt_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxFt != null && textBoxFtResult != null)
            {
                double ft = double.Parse(textBoxFt.Text);

                double result = ft / 3.2808;
                
                textBoxFtResult.Text = Convert.ToString(Math.Round(result, 2));
            }

        }

        private void buttonMile_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxMile != null && textBoxMileResult != null)
            {
                double mile = double.Parse(textBoxMile.Text);

                double result = mile * 1609.34;

                textBoxMileResult.Text = Convert.ToString(result);
            }
        }

        private void buttonVerst_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxVerst != null && textBoxVerstResult != null)
            {
                double verst = double.Parse(textBoxVerst.Text);

                double result = verst * 1066.8;

                textBoxVerstResult.Text = Convert.ToString(result);
            }
        }
    }
}
