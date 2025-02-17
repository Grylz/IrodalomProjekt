using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.Generic;
using IrodalomProjekt.Models;
using Microsoft.Win32;

namespace IrodalomProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Kerdes> kerdesek = new List<Kerdes>();
        private static int aktualisIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void KerdesBetoltes(string fileName)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT fájlok (*.txt)|*.txt";
            if(openFileDialog.ShowDialog() == true)
            {
                try
                {
                    KerdesBetoltes(openFileDialog.FileName);
                    MessageBox.Show("Sikeres betöltés!", "Információ", MessageBoxButton.OK, MessageBox.Information);
                    if(kerdesek.Count > 0)
                    {
                        aktualisIndex = 0;
                        MutatKerdes(aktualisIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a fájl betöltése közben: {ex.Message}");
                }
            }
            
        }

        private void MutatKerdes(int aktualisIndex)
        {
            throw new NotImplementedException();
        }

        private void Betoltes_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Elozo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kovetkezo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}