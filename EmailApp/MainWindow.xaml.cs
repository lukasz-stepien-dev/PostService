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

namespace EmailApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RadioPostcard.IsChecked == true) 
            { 
                Price.Content = "Cena: 1zł";
                Img.Source = new BitmapImage(new Uri("./img/pocztowka.png", UriKind.Relative));
            }
            if (RadioLetter.IsChecked == true) 
            { 
                Price.Content = "Cena: 1,5zł";
                Img.Source = new BitmapImage(new Uri("./img/list.png", UriKind.Relative));
            }
            if (RadioPackage.IsChecked == true) 
            { 
                Price.Content = "Cena: 10zł";
                Img.Source = new BitmapImage(new Uri("./img/paczka.png", UriKind.Relative));
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(ZipCodeInput.Text, out var zipCode))
            {
                if (zipCode < 10000 || zipCode > 99999)
                {
                    Errors.Content = "Nieprawidłowa liczba cyfr w kodzie pocztowym";
                }
                else
                {
                    Errors.Content = "Dane przesyłki zostane wysłane";
                }
            }
            else
            {
                Errors.Content = "Kod pocztowy powinien się składać z samych cyfr";
            }
        }
    }
}
