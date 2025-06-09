using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zad5_SymulatorMikroprocesora
{
    public partial class Form1 : Form
    {
        private Dictionary<string, ushort> rejestry = new Dictionary<string, ushort>  // dziala podobnie jak tablica, ale zamiast indeksow liczbowych uzywamy wlasnych kluczy w tym przypadku nazw rejestrow np AX
        {
            { "AX", 0 }, { "BX", 0 }, { "CX", 0 }, { "DX", 0 }
        };

        private List<string> program = new List<string>();
        private int aktualnaInstrukcja = 0;

        public Form1()
        {
            InitializeComponent();
            AktualizujRejestry();
        }

        private void btnDodajInstrukcje_Click_1(object sender, EventArgs e)   // zapisuje instrukcje do listy
        {
            program.Add(txtKod.Text);
            lstProgram.Items.Add($"{program.Count - 1}: {txtKod.Text}");
            txtKod.Clear();
        }

        private void btnWykonajCaly_Click_1(object sender, EventArgs e)   // wykonuje instrukcje z listy po kolej w petli po czym aktualizuje rejestry
        {
            for (aktualnaInstrukcja = 0; aktualnaInstrukcja < program.Count; aktualnaInstrukcja++)
            {
                WykonajInstrukcje(program[aktualnaInstrukcja]);
            }
            AktualizujRejestry();
        }

        private void btnWykonajKrokowo_Click_1(object sender, EventArgs e)    // wykonuje nastepna instrukcje z listy, jesli takowa wystepuje
        {
            if (aktualnaInstrukcja < program.Count)
            {
                lstProgram.SelectedIndex = aktualnaInstrukcja;
                WykonajInstrukcje(program[aktualnaInstrukcja]);
                aktualnaInstrukcja++;
                AktualizujRejestry();
            }
        }

        private void WykonajInstrukcje(string linia)
        {
            var czesci = linia.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); // dzieli linie instrukcji na czesci i przechowuje w tablicy. Separatorami są przecinek i spacja. RemoveEmptyEntries ignoruje puste pola np przy dwoch spacjach.
            if (czesci.Length < 3) return;

            string rozkaz = czesci[0].ToUpper(); // .ToUpper() akceptuje zarówno małe jak i duże litery 
            string cel = czesci[1].ToUpper();
            string zrodlo = czesci[2].ToUpper();

            ushort wartoscZrodla = 0;  // ushort poniewaz to dokladnie 16-bitowa liczba, w przeciwienstwie do int ktory jest 32-bitowa liczba

            if (rejestry.ContainsKey(zrodlo)) wartoscZrodla = rejestry[zrodlo];  // sprawdzamy czy zrodlo to rejestr czy liczba (czy tryb rejestrowy czy natychmiastowy), jesli tak to pobiera wartosc z rejestru
            else if (ushort.TryParse(zrodlo, out ushort wartosc)) wartoscZrodla = wartosc;   //  jesli to liczba to konwertuje na zmienna ushort (16-bitowa)
            else return;

            switch (rozkaz)
            {
                case "MOV":
                    if (rejestry.ContainsKey(cel)) rejestry[cel] = wartoscZrodla;
                    break;
                case "ADD":
                    if (rejestry.ContainsKey(cel)) rejestry[cel] += wartoscZrodla;
                    break;
                case "SUB":
                    if (rejestry.ContainsKey(cel)) rejestry[cel] -= wartoscZrodla;
                    break;
            }
        }

        private void AktualizujRejestry()      // aktualizacja rejestrow
        {
            lblAX.Text = $"AX = {rejestry["AX"]} ({(rejestry["AX"] >> 8)}H:{(rejestry["AX"] & 0xFF)}L)";
            lblBX.Text = $"BX = {rejestry["BX"]} ({(rejestry["BX"] >> 8)}H:{(rejestry["BX"] & 0xFF)}L)";
            lblCX.Text = $"CX = {rejestry["CX"]} ({(rejestry["CX"] >> 8)}H:{(rejestry["CX"] & 0xFF)}L)";
            lblDX.Text = $"DX = {rejestry["DX"]} ({(rejestry["DX"] >> 8)}H:{(rejestry["DX"] & 0xFF)}L)";
        }

        private void btnZapiszProgram_Click_1(object sender, EventArgs e)     // zapisuje program do pliku txt
        {
            File.WriteAllLines("program.txt", program);
        }

        private void btnWczytajProgram_Click_1(object sender, EventArgs e)   // wczytuje program z pliku txt i zmienia aktualnaInstrukcje na 0
        {
            if (File.Exists("program.txt"))
            {
                program = File.ReadAllLines("program.txt").ToList();
                lstProgram.Items.Clear();
                for (int i = 0; i < program.Count; i++)
                {
                    lstProgram.Items.Add($"{i}: {program[i]}");
                }
                aktualnaInstrukcja = 0;
            }
        }
    }
}
