using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oynanacak kelimelerin olduğu bir dizi oluşturulur.
            string[] words = { "programlama", "bilgisayar", "yazılım", "donanım", "internet" };

            // Rastgele bir kelime seçmek için bir Random nesnesi oluşturulur.
            Random random = new Random();

            // Seçilen kelimeyi tutmak için bir değişken.
            string selectedWord = words[random.Next(words.Length)];

            // Tahmin edilen harfleri tutmak için bir karakter dizisi oluşturulur. Başlangıçta tüm harfler '_' ile doldurulur.
            char[] guess = new char[selectedWord.Length];
            for (int i = 0; i < guess.Length; i++)
            {
                guess[i] = '_';
            }

            // Kalan deneme hakkı ve yanlış tahminleri tutmak için değişkenler.
            int attempts = 6;
            List<char> incorrectGuesses = new List<char>();

            // Oyun devam ettiği sürece döngü.
            while (attempts > 0)
            {
                // Ekranı temizle.
                Console.Clear();

                // Oyun durumunu ekrana yazdır.
                Console.WriteLine("Adam Asmaca Oyunu");
                Console.WriteLine(new string(guess)); // Tahmin edilen kelime
                Console.WriteLine("Hatalı tahminler: " + string.Join(", ", incorrectGuesses));
                Console.WriteLine("Kalan deneme hakkı: " + attempts);

                // Kullanıcıdan bir harf tahmini al.
                Console.Write("Bir harf tahmin edin: ");
                char playerGuess = Console.ReadLine()[0];

                // Tahmin edilen harf, seçilen kelimede var mı kontrol et.
                if (selectedWord.Contains(playerGuess))
                {
                    // Eğer varsa, tahmin dizisinde ilgili harfleri güncelle.
                    for (int i = 0; i < selectedWord.Length; i++)
                    {
                        if (selectedWord[i] == playerGuess)
                        {
                            guess[i] = playerGuess;
                        }
                    }
                }
                else
                {
                    // Eğer yoksa, yanlış tahminler listesine ekle ve deneme sayısını azalt.
                    if (!incorrectGuesses.Contains(playerGuess))
                    {
                        incorrectGuesses.Add(playerGuess);
                        attempts--;
                    }
                }

                // Tüm harfler doğru tahmin edilmişse oyun bitti.
                if (!new string(guess).Contains('_'))
                {
                    Console.Clear();
                    Console.WriteLine("Tebrikler! Kelimeyi doğru bildiniz: " + new string(guess));
                    break;
                }
            }

            // Tüm deneme hakları tükenmişse oyun bitti.
            if (attempts == 0)
            {
                Console.Clear();
                Console.WriteLine("Üzgünüm, kaybettiniz. Kelime: " + selectedWord);
            }
        }
    }
}
