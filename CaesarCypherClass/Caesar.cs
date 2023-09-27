using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypherClass
{
    static class Caesar
    {
        public static string EncryptV1(string inputText)
        {
            
            //zmieniamy wszystkie litery na wielkie
            inputText = inputText.ToUpper();
            //usuwamy wszystkie space z źródłowego tekstu
            inputText = inputText.Replace(" ", "");

            //zmienna przechowująca docelowy (zaszyfrowany) tekst
            string outputText = "";
            //przechodzimy pętlą poprzez cały tekst źródłowy znak po znaku
            foreach (char c in inputText)
            {
                //dodaj wartośc klucza do znaku
                char encodedChar = (char)((int)c + 3);
                //sprawdzamy czy nie wyszliśmy poza alfabet łaciński
                if ((int)encodedChar > 90)
                {
                    //cofamy się o długość alfabetu
                    encodedChar = (char)((int)encodedChar - 26);
                }
                //zapisujemy do nowego tekstu zaszyfrowany znak
                outputText += encodedChar;

            }
            //wyświetlamy zaszyfrowany tekst
            return outputText;
        }
        public static string EncryptV2(string inputText) 
        {
            char[] chars = { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ż', 'Ź' };


            string outputText = String.Empty;

            foreach (char c in inputText)
            {
                //c oznacza bieżącą literę z tekstu do zaszyfrowania

                //i jako indeks w tablicy z literami -- znajdujemy odpowiadającą literę
                int i = Array.IndexOf(chars, c);
                if (i >= 0)
                {
                    //tablica posiada odpowiedni znak - przesuwamy
                    i += 3;
                    //sprawdzamy czy nie przekroczyliśmy tablicy
                    if (i > chars.Length - 1)
                    {
                        //jeśli wyszliśmy poza tablicę to odejmij jej długość
                        i -= chars.Length;
                    }
                    //zapisz wynikowy tekst do zmiennej
                    outputText += chars[i];
                }
            }
            return outputText;
        }
    }
}
