using System;

namespace _19._11._2842_Tugas12
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arrNim = { 6478, 3902, 1054 };
			string[] arrNama = { "Jamal", "Habib", "Nadya" };
			int[] arrNilai = { 75, 80, 95 };

			Console.WriteLine("No.      Nim      Nama      Nilai");
			Console.WriteLine("=================================");

			for (int i = 0; i < arrNama.Length; i++)
			{
				Console.WriteLine("{0}.      {1}      {2}       {3}", i + 1, arrNim[i], arrNama[i], arrNilai[i]);
			}

			Console.ReadKey();
		}
    }
}
