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
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics.Metrics;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Fuvar> fuvarok = File.ReadAllLines("fuvar.csv").Skip(1).Select(x=>new Fuvar(x) ).toList();

        }

        private void harmasFeladat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"3.feladat:{fuvarok.Count()} fuvar");
        }

        private void negyesFeladat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"4. feladat: {fuvarok.where(x => x.taxiAzonosito).Count()} fuvar alatt: {fuvarok.Sum().Where(x => x.viteldij} "); 
        }

        private void otosFeladat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"5. feladat:{fuvarok.groupBy(fizetesModja).}");
        }

        private void hatosFeladat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"6. feladat : {fuvarok.Where(x => x.megtettTavolsag).Sum() * 1.6} km");
        }

        private void nyolcasFeladat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
