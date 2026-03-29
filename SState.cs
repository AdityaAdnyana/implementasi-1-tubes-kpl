using System;
using System.Collections.Generic;
using System.Text;

namespace ImplemantasiGenericQuiz
{
    enum State { ChouseBab, Evaluasi, GameOver };
    internal class SState
    {
        public SState()
        {
            State state = State.ChouseBab;


            // pilih bab soal
            Console.WriteLine("Pilih Bab Soal : ");
            Console.WriteLine("1. leason 1");


            while (state != State.GameOver)
            {
                string[] StateStringt = { "Daftar Bab", " Pengerjaan ", " Evaluasi ", " GameOver " };
                Console.WriteLine($"===== {StateStringt[(int)state]} =====");
                
                switch (state)
                {
                    case State.ChouseBab:
                        string cmnd = Console.ReadLine();
                        if (cmnd == "1")
                        {
                            TempLessonInit dummyLesson = new();
                            state = State.Evaluasi;
                        }
                        else if (cmnd == "exit")
                        {
                            Console.WriteLine("Keluar dari permainan");
                            state = State.GameOver;
                        }
                        else
                        {
                            Console.WriteLine("Input Salah");
                            state = State.ChouseBab;
                        }
                        break;
                    case State.Evaluasi:
                        //Console.WriteLine("Evaluasi Jawaban");
                        ////evaluasi soal yg salah
                        //EvaluasiSoal(new int[] { });
                        Console.WriteLine("PlayAgain / Exit ");

                        cmnd = Console.ReadLine();
                        if (cmnd == "PlayAgain")
                        {
                            Console.Clear();
                            Console.WriteLine("Pilih Bab Soal : ");
                            Console.WriteLine("1. leason 1");
                            state = State.ChouseBab;
                        }
                        else if (cmnd == "Exit")
                        {
                            Console.WriteLine("Keluar dari permainan");
                            state = State.GameOver;
                        }
                        else
                        {
                            Console.WriteLine("Input Salah");
                            Console.Clear();
                            state = State.Evaluasi;
                        }


                        break;
                    case State.GameOver:
                        Console.WriteLine("Game Over");
                        break;
                }
            }
        }

        //public void GetBabSoal(int cmd)
        //{
        //    PengerjaanSoal();
        //}


        //public void PengerjaanSoal()
        //{

        //}

        //public void EvaluasiSoal(int[] soalSalah)
        //{

        //}
    }
}
