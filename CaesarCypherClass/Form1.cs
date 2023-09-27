using System.Reflection.Metadata;

namespace CaesarCypherClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Encrypt(object sender, EventArgs e)
        {
            //pobieramy do stringa zawarto�� okienka na tekst �r�d�owy
            string inputText = inputTextBox.Text;
            //zmieniamy wszystkie litery na wielkie
            inputText = inputText.ToUpper();
            //usuwamy wszystkie space z �r�d�owego tekstu
            inputText = inputText.Replace(" ", "");

            //zmienna przechowuj�ca docelowy (zaszyfrowany) tekst
            string outputText = "";
            //przechodzimy p�tl� poprzez ca�y tekst �r�d�owy znak po znaku
            foreach (char c in inputText)
            {
                //dodaj warto�c klucza do znaku
                char encodedChar = (char)((int)c + 3);
                //sprawdzamy czy nie wyszli�my poza alfabet �aci�ski
                if ((int)encodedChar > 90)
                {
                    //cofamy si� o d�ugo�� alfabetu
                    encodedChar = (char)((int)encodedChar - 26);
                }
                //zapisujemy do nowego tekstu zaszyfrowany znak
                outputText += encodedChar;

            }
            //wy�wietlamy zaszyfrowany tekst
            outputTextBox.Text = outputText;
        }
        private void EncryptV2(object sender, EventArgs e)
        {
            char[] chars = { 'A', '�', 'B', 'C', '�', 'D', 'E', '�', 'F', 'G', 'H', 'I', 'J', 'K', 'L', '�', 'M', 'N', '�', 'O', '�', 'P', 'Q', 'R', 'S', '�', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '�', '�' };

            string inputText = inputTextBox.Text.ToUpper();

            string outputText = String.Empty;

            foreach (char c in inputText)
            {
                //c oznacza bie��c� liter� z tekstu do zaszyfrowania

                //i jako indeks w tablicy z literami -- znajdujemy odpowiadaj�c� liter�
                int i = Array.IndexOf(chars, c);
                if (i >= 0)
                {
                    //tablica posiada odpowiedni znak - przesuwamy
                    i += 3;
                    //sprawdzamy czy nie przekroczyli�my tablicy
                    if (i > chars.Length - 1)
                    {
                        //je�li wyszli�my poza tablic� to odejmij jej d�ugo��
                        i -= chars.Length;
                    }
                    //zapisz wynikowy tekst do zmiennej
                    outputText += chars[i];
                }
            }
            outputTextBox.Text = outputText;
        }
    }
}