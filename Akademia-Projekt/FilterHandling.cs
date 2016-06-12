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
        private void Filter_Checked(object sender, RoutedEventArgs e)
        {
            string filter = (string)(sender as RadioButton).Content;
            Temp = new ObservableCollection<Book>();
            this.LibraryListView.ItemsSource = Temp;
            foreach (Book book in Books)
            {
                #region Filtr
                switch (filter)
                {
                    case "Tytuł":
                        if (this.TitleTextBox.Text == book.Title)
                        {
                            Temp.Add(book);
                        }
                        break;
                    case "Imię":
                        if (this.NameTextBox.Text == book.Name)
                        {
                            Temp.Add(book);
                        }
                        break;
                    case "Nazwisko":
                        if (this.SurnameTextBox.Text == book.Surname)
                        {
                            Temp.Add(book);
                        }
                        break;
                    case "Wydawnictwo":
                        if (this.PublishingHouseTextBox.Text == book.PublishingHouse)
                        {
                            Temp.Add(book);
                        }
                        break;
                    case "Rok wydania":
                        try
                        {
                            if (int.Parse(this.PublicationDateTextBox.Text) == book.PublicationDate)
                            {
                                Temp.Add(book);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Zły format daty w filtrze!",
                      "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                        break;
                    case "Gatunek":
                        if (this.GenreComboBox.Text == book.Genre)
                        {
                            Temp.Add(book);
                        }
                        break;

                }
                #endregion
            }

            this.Checked.Content = "Filtruj: " + filter;

        }

    }
}
