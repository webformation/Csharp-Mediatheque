using MediathequeAbonne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Saisie
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Abonne a;
        public Abonne abonne
        {
            get { return a; }
            set { a = value;
                OnPropertyChanged("abonne");
            }
        }
        private void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int agesaisi;
            Abonne a = null;
            if (int.TryParse(age.Text, out agesaisi))
            {
                a = new Abonne("Mme", nom.Text, prenom.Text, agesaisi, new Adresse(rue.Text, cp.Text, ville.Text));
            }
            Valid v = new Valid();
            this.Hide();            
            v.Show();

        }
    }
}
