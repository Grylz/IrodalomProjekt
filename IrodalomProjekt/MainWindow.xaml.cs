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
            try
            {
                var lines = File.ReadAllLines("valaszok.txt"); 

                if (lines.Length == 0)
                {
                    MessageBox.Show("A fájl üres!", "Hiba", MessageBoxButton.OK);
                    return;
                }

                kerdesek.Clear(); 

                foreach (var line in lines)
                {
                    var parts = line.Split(';');

                    if (parts.Length == 7)
                    {
                        var kerdes = new Kerdes(
                            parts[1], 
                            parts[2], 
                            parts[3], 
                            parts[4], 
                            parts[5],
                            parts[6], 
                            "" 
                        );
                        kerdesek.Add(kerdes);
                    }
                    else
                    {
                        MessageBox.Show("Hibás formátum a fájlban: " + line, "Hiba", MessageBoxButton.OK);
                    }
                }

                MessageBox.Show("Sikeres betöltés!", "Információ", MessageBoxButton.OK);

                if (kerdesek.Count > 0)
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



        private void MutatKerdes(int aktualisIndex)
        {
            if (aktualisIndex >= 0 && aktualisIndex < kerdesek.Count)
            {
                var kerdes = kerdesek[aktualisIndex];

                tbkKerdesSzovege.Text = kerdes.KerdesSzovege;

                ValaszA.Content = $"A) {kerdes.ValaszA}";
                ValaszB.Content = $"B) {kerdes.ValaszB}";
                ValaszC.Content = $"C) {kerdes.ValaszC}";
                ValaszD.Content = $"D) {kerdes.ValaszD}";
            }
            else
            {
                MessageBox.Show("Nincs több kérdés!", "Információ", MessageBoxButton.OK);
            }
        }

        private void Betoltes_Click(object sender, RoutedEventArgs e)
        {
            KerdesBetoltes("");
        }
        
        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Elozo_Click(object sender, RoutedEventArgs e)
        {
            if (aktualisIndex > 0)
            {
                aktualisIndex--;
                MutatKerdes(aktualisIndex);
            }
            else
            {
                MessageBox.Show("Ez már az első kérdés!", "Figyelmeztetés", MessageBoxButton.OK);
            }
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Kovetkezo_Click(object sender, RoutedEventArgs e)
        {
            if (aktualisIndex < kerdesek.Count - 1)
            {
                aktualisIndex++;
                MutatKerdes(aktualisIndex);
            }
            else
            {
                MessageBox.Show("Ez már az utolsó kérdés!", "Figyelmeztetés", MessageBoxButton.OK);
            }
        }
    }
}

