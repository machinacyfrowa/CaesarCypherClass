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
            //pobieramy do stringa zawartoœæ okienka na tekst Ÿród³owy
            string inputText = inputTextBox.Text;
            //zmieniamy wszystkie litery na wielkie
            inputText = inputText.ToUpper();
            //usuwamy wszystkie space z Ÿród³owego tekstu
            inputText = inputText.Replace(" ", "");

            //zmienna przechowuj¹ca docelowy (zaszyfrowany) tekst
            string outputText = "";
            //przechodzimy pêtl¹ poprzez ca³y tekst Ÿród³owy znak po znaku
            foreach (char c in inputText)
            {
                //dodaj wartoœc klucza do znaku
                char encodedChar = (char)((int)c + 3);
                //sprawdzamy czy nie wyszliœmy poza alfabet ³aciñski
                if ((int)encodedChar > 90)
                {
                    //cofamy siê o d³ugoœæ alfabetu
                    encodedChar = (char)((int)encodedChar - 26);
                }
                //zapisujemy do nowego tekstu zaszyfrowany znak
                outputText += encodedChar;

            }
            //wyœwietlamy zaszyfrowany tekst
            outputTextBox.Text = outputText;
        }
        private void EncryptV2(object sender, EventArgs e)
        {
            char[] chars = { 'A', '¥', 'B', 'C', 'Æ', 'D', 'E', 'Ê', 'F', 'G', 'H', 'I', 'J', 'K', 'L', '£', 'M', 'N', 'Ñ', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Œ', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '¯', '' };

            string inputText = inputTextBox.Text.ToUpper();

            string outputText = String.Empty;

            foreach (char c in inputText)
            {
                //c oznacza bie¿¹c¹ literê z tekstu do zaszyfrowania

                //i jako indeks w tablicy z literami -- znajdujemy odpowiadaj¹c¹ literê
                int i = Array.IndexOf(chars, c);
                if (i >= 0)
                {
                    //tablica posiada odpowiedni znak - przesuwamy
                    i += 3;
                    //sprawdzamy czy nie przekroczyliœmy tablicy
                    if (i > chars.Length - 1)
                    {
                        //jeœli wyszliœmy poza tablicê to odejmij jej d³ugoœæ
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