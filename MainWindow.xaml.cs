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
using static System.Net.Mime.MediaTypeNames;

namespace SzyfrCezara
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
            string textszyfr = szyfrtext.Text;
            int move = int.Parse(szyfrint.Text);
            string result = "";

            // Przechodzimy przez każdy znak w tekście
            foreach (char ch in textszyfr)
            {
                // Sprawdzamy, czy znak jest literą
                if (char.IsLetter(ch))
                {
                    // Wyznaczamy przesunięcie dla każdej litery
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    // Szyfrujemy literę zgodnie z przesunięciem
                    result += (char)((((ch + move) - offset) % 26) + offset);
                }
                else
                {
                    // Jeśli znak nie jest literą, to dodajemy go bez zmian
                    result += ch;
                }
            }

            szyfrresult.Text = result;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string textdeszyfr = deszyfrtext.Text;
            int move2 = int.Parse(deszyfrint.Text);
            string result2 = "";

            // Przechodzimy przez każdy znak w tekście
            foreach (char ch in textdeszyfr)
            {
                // Sprawdzamy, czy znak jest literą
                if (char.IsLetter(ch))
                {
                    // Wyznaczamy przesunięcie dla każdej litery
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    // Deszyfrujemy literę zgodnie z przesunięciem
                    result2 += (char)((((ch - move2) - offset + 26) % 26) + offset);
                }
                else
                {
                    // Jeśli znak nie jest literą, to dodajemy go bez zmian
                    result2 += ch;
                }
            }
            
            deszyfrresult.Text = result2;
        }
    }
}