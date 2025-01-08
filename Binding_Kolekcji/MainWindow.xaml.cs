using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
using System.Windows.Data;


namespace Binding_Kolekcji
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>
    {
        new Produkt("01-11", "ołówek", 8, "Katowice 1"),
        new Produkt("PW-20", "pióro wieczne", 75, "Katowice 2"),
        new Produkt("DZ-10", "długopis żelowy", 1121, "Katowice 1"),
        new Produkt("DZ-12", "długopis kulkowy", 280, "Katowice 2")
    };

            1stProdukty.ItemsSource = ListaProduktow;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(1stProdukty.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Magazyn", ListSortDirection.Ascending));

            view.SortDescriptions.Add(new SortDescription("Nazwa", ListSortDirection.Ascending));
        }

    }
}
