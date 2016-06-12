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
        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            int count = Books.Count;
            if ( count<(int)LibrarySize.max  && count >= (int)LibrarySize.min)
            try
            {
                if (this.TitleTextBox.Text != null)
                {
                    Book book = new Book();
                    book.Title = this.TitleTextBox.Text;
                    book.Name = this.NameTextBox.Text;
                    book.Surname = this.SurnameTextBox.Text;
                    book.PublishingHouse = this.PublishingHouseTextBox.Text;
                    book.PublicationDate = int.Parse(this.PublicationDateTextBox.Text);
                    book.Genre = this.GenreComboBox.Text;
                    Books.Add(book);
                }
            }
            catch
            {
                MessageBox.Show("Dodaj tytuł lub wpisz poprawnie datę!",
                   "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book = (Book)LibraryListView.SelectedItems[0];
                Books.Remove(book);
             }
            catch
            {
                MessageBox.Show("Wybierz książkę, którą chcesz usunąć!",
                 "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.LibraryListView.ItemsSource = Books;
            this.Checked.Content = "Filtruj: ";
        }
    }
}
