using System;
using System.Collections.Generic;
using System.Text;

public class Soal
{
    public List<DataSoal> dataSoal;

    public Soal()
    {
        dataSoal = new List<DataSoal>();
        dataSoal.Add(new DataSoal { Soal = "Test 1", Jawaban = new[] { "coba 1", "coba 2", "coba 3", "coba 4" }, JawabanSoal = 0 });
        dataSoal.Add(new DataSoal { Soal = "Test 2", Jawaban = new[] { "coba 1", "coba 2", "coba 3", "coba 4" }, JawabanSoal = 1 });
        dataSoal.Add(new DataSoal { Soal = "Test 3", Jawaban = new[] { "coba 1", "coba 2", "coba 3", "coba 4" }, JawabanSoal = 2 });
        dataSoal.Add(new DataSoal { Soal = "Test 4", Jawaban = new[] { "coba 1", "coba 2", "coba 3", "coba 4" }, JawabanSoal = 3 });
    }


}
