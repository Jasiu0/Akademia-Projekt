using System;
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

    interface IShow
    {
        void Show();
    }
    public class Book: IShow
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PublishingHouse { get; set; }
        public int PublicationDate { get; set; }
        public string Genre { get; set; }
        public Book(string title, string name, string surname, string publishingHouse, int publicationDate, string genre)
        {
            this.Title = title;
            this.Name = name;
            this.Surname = surname;
            this.PublishingHouse = publishingHouse;
            this.PublicationDate = publicationDate;
            this.Genre = genre;

        }

        public Book()
        {
        }
        
        public void Show()
        {
            MessageBox.Show("Witam w Bibliotece! Zapanuj nad Bazą!",
            "Witaj", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
    }
}
