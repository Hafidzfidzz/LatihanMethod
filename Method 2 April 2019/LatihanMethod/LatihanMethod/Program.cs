using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            int hasil;

            // membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            // panggil method Penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil Penjumlahan: " + hasil);

            // panggil method Penjumlah dengan 2 parameter (overload method)
            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("Hasil Penjumlahan overload: " + hasil);

            //panggil method pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan: " + hasil);

            // panggil static method langsung dari nama classnya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian: " + hasil);

            Console.ReadKey();
        }
            static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
