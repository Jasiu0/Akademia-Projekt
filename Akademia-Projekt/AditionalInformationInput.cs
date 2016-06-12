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
    public partial class MainWindow : Window
    {

        private void AddDescription_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book = (Book)LibraryListView.SelectedItems[0];
                InputBox.Visibility = System.Windows.Visibility.Visible;
            }
            catch
            {
                MessageBox.Show("Wybierz książkę przed dodaniem dodatkowych informacji!",
                    "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Book book = (Book)LibraryListView.SelectedItems[0];
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
            AdvancedBook advancedBook = new AdvancedBook(book.Title, book.Name, book.Surname,
                book.PublishingHouse, book.PublicationDate,
                book.Genre, DescriptionTextBox.Text, HttpPathTextBox.Text);
            AdvancedBooks.Add(advancedBook);
            DescriptionTextBox.Text = String.Empty;
            HttpPathTextBox.Text = String.Empty;
        }
        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
            DescriptionTextBox.Text = String.Empty;
            HttpPathTextBox.Text = String.Empty;
        }
    }


}