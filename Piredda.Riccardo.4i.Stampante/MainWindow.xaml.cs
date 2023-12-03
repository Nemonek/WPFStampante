using System.Windows;
using Piredda.Riccardo._4i.Stampante.Models;

namespace Piredda.Riccardo._4i.Stampante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Piredda.Riccardo._4i.Stampante.Models.Stampante s;
        public MainWindow()
        {
            InitializeComponent();
            s = new();
            ComboBoxColori.ItemsSource =  new string[] { "Ciano", "Magenta", "Giallo", "Nero" };
            ComboBoxColori.SelectedIndex = 0;
            ComboBoxColoriStato.ItemsSource = new string[] { "Ciano", "Magenta", "Giallo", "Nero" };
            ComboBoxColoriStato.SelectedIndex = 0;
        }

        private void PrintRandomPage(object sender, RoutedEventArgs e)
        {
            Pagina p = new();
            if (s.Stampa(p))
                Esito.Text = "Riuscito";
            else
                Esito.Text = "Fallito";
        }
        private void InserisciCarta(object sender, RoutedEventArgs e)
        {

            if ((!int.TryParse(InputCarta.Text, out int res)) || res <= 0)
                InputCarta.Text = "Failed";
            else
            {
                s.AggiungiCarta(res);
                InputCarta.Text = "Riuscito";
            }
        }
        private void RiempiColore(object sender, RoutedEventArgs e)
        {
            switch(ComboBoxColori.SelectedIndex)
            {
                case 0:
                    s.SostituisciColore(Colori.Ciano);
                    break;
                case 1:
                    s.SostituisciColore(Colori.Magenta);
                    break;
                case 2:
                    s.SostituisciColore(Colori.Giallo);
                    break;
                case 3:
                    s.SostituisciColore(Colori.Nero);
                    break;
            }
        }
        private void StatoColore(object sender, RoutedEventArgs e)
        {
            switch (ComboBoxColoriStato.SelectedIndex)
            {
                case 0:
                    TextStatoColore.Text = s.StatoInchiostro(Colori.Ciano).ToString();
                    break;
                case 1:
                    TextStatoColore.Text = s.StatoInchiostro(Colori.Magenta).ToString();
                    break;
                case 2:
                    TextStatoColore.Text = s.StatoInchiostro(Colori.Giallo).ToString();
                    break;
                case 3:
                    TextStatoColore.Text = s.StatoInchiostro(Colori.Nero).ToString();
                    break;
            }
        }
        private void StatoCartaEvent(object sender, RoutedEventArgs e)
        {
            StatoCarta.Text = s.StatoCarta().ToString();
        }

        private void StampaNonRandom(object sender, RoutedEventArgs e)
        {

        }

    }
}
