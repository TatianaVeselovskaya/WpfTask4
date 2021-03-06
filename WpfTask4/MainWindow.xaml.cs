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

namespace WpfTask4
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
        //валюта
        private void ButtonDollar(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateDol.Text);
            double sumDollar = Convert.ToDouble(sumDol.Text);
            double resDouble = rateDollar * sumDollar;
            resSumDol.Text = resDouble.ToString();
        }
        private void ButtonEuro(object sender, RoutedEventArgs e)
        {
            double rateEURO = Convert.ToDouble(rateEuro.Text);
            double sumEURO = Convert.ToDouble(sumEuro.Text);
            double resEURO = rateEURO * sumEURO;
            resSumEuro.Text = resEURO.ToString();
        }
        private void ButtonGrivna(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rateGrivna.Text);
            double sumGrivn = Convert.ToDouble(sumGrivna.Text);
            double resGrivn = rateGrivn * sumGrivn;
            resSumGrivna.Text = resGrivn.ToString();
        }
        private void ButtonDrama(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateDrama.Text);
            double sumDram = Convert.ToDouble(sumDrama.Text);
            double resDram = rateDram * sumDram;
            resSumDrama.Text = resDram.ToString();
        }

        //расстояние 
        private void ButtonDyuymy(object sender, RoutedEventArgs e)
        {
            const double rateDyuymy = 0.0254;
            double rateDyuym = Convert.ToDouble(rateDyuymy);
            double sumDyuym = Convert.ToDouble(sumDyuymy.Text);
            double resDyuym = rateDyuym * sumDyuym;
            resSumDyuymy.Text = resDyuym.ToString();
        }

        private void ButtonFut(object sender, RoutedEventArgs e)
        {
            const double rateFUT = 0.3048;
            double sumFUT = Convert.ToDouble(sumFut.Text);
            double resFUT = rateFUT * sumFUT;
            resSumFut.Text = resFUT.ToString();
        }
        private void ButtonMile(object sender, RoutedEventArgs e)
        {
            const double rateMil = 1609.34;
            double sumMil = Convert.ToDouble(sumMile.Text);
            double resMil = rateMil * sumMil;
            resSumMile.Text = resMil.ToString();
        }
        private void ButtonVersty(object sender, RoutedEventArgs e)
        {
            const double rateVerst = 1066.8;
            double sumVerst = Convert.ToDouble(sumVersty.Text);
            double resVerst = rateVerst * sumVerst;
            resSumVersty.Text = resVerst.ToString();
        }
    }
}
