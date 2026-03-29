using System;

public class Program
{
    public static void Main()
    { 
        Soal DaftarSoal = new Soal();
        List<DataSoal> daftarSoal = DaftarSoal.dataSoal;
        foreach (var item in daftarSoal)
        {
            Console.WriteLine($"Pertanyaan: {item.Soal}");

            for (int i = 0; i < item.Jawaban.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {item.Jawaban[i]}");
            }

            Console.Write("Masukan jawaban : ");
            Console.ReadLine();

            Console.WriteLine($"Jawaban yang benar: {item.Jawaban[item.JawabanSoal]}");
            Console.WriteLine("------------------------------");
        }
    }
}