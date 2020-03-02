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

namespace Prestiti_wpf
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
            string nome = txt_nome.Text;
            string cognome = txt_cognome.Text;

            int percentuale = int.Parse(txt_perc.Text);
            int rata = int.Parse(txt_nrate.Text);
            int importo = int.Parse(txt_importo.Text);
            int perc = importo / 100 * percentuale;
            int import = importo + perc;
            int soldirata = import / rata;
            txt_rest.Text = import.ToString();
            txt_importoRata.Text = soldirata.ToString();
        }
    }
}
