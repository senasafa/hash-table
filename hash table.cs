using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Hash Table kullanarak Dictionary oluşturma
        Dictionary<int, string> hashTable = new Dictionary<int, string>();

        // Anahtar-Değer çiftlerini ekleme
        hashTable.Add(1, "Sena");
        hashTable.Add(2, "Yavuz");
        hashTable.Add(3, "Burçin");

        // Aranacak anahtar
        int arananAnahtar = 2;

        // Anahtarın olup olmadığını kontrol etme
        if (hashTable.TryGetValue(arananAnahtar, out string bulunanDeger))
        {
            Console.WriteLine($"Anahtar {arananAnahtar} bulundu! Değer: {bulunanDeger}");
        }
        else
        {
            Console.WriteLine($"Anahtar {arananAnahtar} bulunamadı!");
        }
    }
}
