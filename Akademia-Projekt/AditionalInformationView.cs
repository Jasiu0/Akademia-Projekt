using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace Akademia_Projekt
{
    public partial class MainWindow: Window
    {
        private Boolean first = true;
        private void AdditionInformation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book2 = (Book)LibraryListView.SelectedItems[0];
            }
            catch
            {
                MessageBox.Show("Wybierz książkę przed wyświetleniem dodatkowych informacji!",
                    "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Book book = (Book)LibraryListView.SelectedItems[0];
            Boolean found = false;
            foreach (AdvancedBook advancedbook in AdvancedBooks)
            {
                if (book.Title == advancedbook.Title && book.Name == advancedbook.Name &&
                      book.Surname == advancedbook.Surname && book.PublishingHouse == advancedbook.PublishingHouse &&
                      book.PublicationDate == advancedbook.PublicationDate && book.Genre == advancedbook.Genre)
                {
                    found = true;
                    if (first == true)
                    {
                        first = false;
                        MessageBox.Show("Pierwsze uruchomienie dodatkowych informacji może zająć chwile! Prosze o cierpliwość.",
                                        "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    AdditionalInformation.Visibility = System.Windows.Visibility.Visible;
                    string fullFilePath = advancedbook.HttpPath;
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    try
                    {
                        bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
                    }
                    catch
                    {
                        MessageBox.Show("Żle podanny adres obrazka!",
                                        "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                        fullFilePath = "http://pruebakr-1.webcindario.com//nope.jpg";
                        bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
                    }
                    bitmap.EndInit();
                    BookImage.Source = bitmap;
                    TitleInfo.Text = "Tytuł: " + advancedbook.Title + "\n " +
                                   "Imię: " + advancedbook.Name + "\n " +
                                   "Nazwisko : " + advancedbook.Surname + "\n " +
                                   "Wydawnictwo: " + advancedbook.PublishingHouse + "\n " +
                                   "Data wydania: " + advancedbook.PublicationDate + "\n " +
                                   "Gatunek: " + advancedbook.Genre + "\n " +
                                   "Opis: " + advancedbook.Description + "\n ";
                }
            }
            if (found == false)
            {
                MessageBox.Show("Nie znaleziono dodatkowych informacji o tej książce!",
                     "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AdditionalInformation.Visibility = System.Windows.Visibility.Collapsed;
        }

    }
}
