using System.Collections.ObjectModel;
using System.Windows;

namespace Binding_Kolekcji
{
    public partial class MainWindow : Window
    {
        // Deklarujemy ObservableCollection dla produktów
        private ObservableCollection<Produkt> ListaProduktow;

        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            // Inicjalizacja ObservableCollection z danymi
            ListaProduktow = new ObservableCollection<Produkt>
            {
                new Produkt("01-11", "ołówek", 8, "Katowice 1"),
                new Produkt("PW-20", "pióro wieczne", 75, "Katowice 2"),
                new Produkt("DZ-10", "długopis żelowy", 1121, "Katowice 1"),
                new Produkt("DZ-12", "długopis kulkowy", 280, "Katowice 2")
            };

            // Ustawienie wiązania z ListView
            1stProdukty.ItemsSource = ListaProduktow;
        }
    }
}
