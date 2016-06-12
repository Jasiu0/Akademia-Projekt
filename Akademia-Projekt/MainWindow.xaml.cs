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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Book> Books;
        public ObservableCollection<AdvancedBook> AdvancedBooks;
        public ObservableCollection<Book> Temp;
        public enum LibrarySize : int 
        {
           max = 1000,
           min = 0
        }
        public MainWindow()
        {
            InitializeComponent();
            Books = new ObservableCollection<Book>();
            this.LibraryListView.ItemsSource = Books;
            AdvancedBooks = new ObservableCollection<AdvancedBook>();
            Book book = new Book("Najwyższa jakość", "Cacao", "DecoMorreno", "ExtraCiemne", 2016, "Dramat");
            Books.Add(book);
            AdvancedBook advancedbook = new AdvancedBook("Najwyższa jakość", "Cacao", "DecoMorreno", "ExtraCiemne",
                2016, "Dramat", "Główny bohater, którego imienia nie poznamy, jest typowym pracownikiem w supermarkecie. Niestety na osiedlu ma wielu wrogów. Doprowadzają go do szału, więc postanawia się wyprowadzić. Jednak wyprowadzka nie jest taka łatwa… ", "http://img.joemonster.org//i//2016//06//13412861_1155083667847042_9187056239490614781_n-20160608230421.jpg");
            AdvancedBooks.Add(advancedbook);
            book = new Book("Czekoladowa Pokusa", "Cacao", "DecoMorreno", "ExtraFantazja", 2015, "Romans");
            Books.Add(book);
            advancedbook = new AdvancedBook("Czekoladowa Pokusa", "Cacao", "DecoMorreno", "ExtraFantazja", 2015, "Romans", "Czekoladowa pokusa porusza trudne tematy zbliżeń międzyrasowych. Autor porusza się w temacie z wyraźną swobodą i dużym smakiem. Czy prawdziwa miłość wygra ze stereotypami? Czy może czekoladowa pokusa okaże się...", "http://s.lubimyczytac.pl/upload/books/309000/309212/488365-352x500.jpg?_ga=1.215693271.1193945144.1465468976");
            AdvancedBooks.Add(advancedbook);
            book.Show();

        }
    }
}
