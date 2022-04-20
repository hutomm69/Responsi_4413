using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_4413
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Tomo = new Karyawan("4413", "Tomo", 2000000);
            Karyawan Yoga = new Karyawan("4413", "Yoga", 3000000);
            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. {0}/{1}   {2}",Tomo.NIK, Tomo.Nama, Tomo.GajiBulanan);
            Console.WriteLine("2. {0}/{1}   {2}",Yoga.NIK, Yoga.Nama, Yoga.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Naikkan Gaji sebesar 10%");
            Console.WriteLine();

            Tomo.NaikkanGaji(10);
            Yoga.NaikkanGaji(10);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. {0}/{1}   {2}", Tomo.NIK, Tomo.Nama, Tomo.GajiBulanan);
            Console.WriteLine("2. {0}/{1}   {2}", Yoga.NIK, Yoga.Nama, Yoga.GajiBulanan);
        }
    }
}
