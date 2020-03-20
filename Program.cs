using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang
{
    class Program
    {
        static void Main(string[] args)
        {
        home:
            Console.Clear();
            Console.WriteLine("Selamat Datang di Program Hitung Luas Permukaan dan Volume Bangun Ruang Bareng Syamsu :)\n");

            Console.WriteLine("Silahkan Pilih Menu yang diinginkan:\n" +
                "1. Luas Permukaan dan Volume Kubus\n" +
                "2. Luas Permukaan dan Volume Balok\n" +
                "3. Luas Permukaan dan Volume Tabung\n" +
                "4. Luas Permukaan dan Volume Bola\n" +
                "5. Luas Permukaan dan Volume Kerucut\n" +
                "6. Exit\n" +
                "Jadi menu apa yang kamu inginkan?\n");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    BangunRuangKubus Kubus = new BangunRuangKubus();

                    Console.WriteLine("Masukkan nilai panjang sisi = ");
                    Kubus.p = Convert.ToInt32(Console.ReadLine());

                    Kubus.l = Kubus.p;
                    Kubus.t = Kubus.l;

                    Kubus.LuasPermukaan = Kubus.HitungLuasPermukaan();
                    Kubus.Volume = Kubus.HitungVolume();
                    Console.Clear();

                    Console.WriteLine("\nHasil Luas Permukaan Kubus = {0}", Kubus.LuasPermukaan);
                    Console.WriteLine("\nHasil Volume Kubus = {0}", Kubus.Volume);

                    Console.WriteLine("\nTekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;
                    break;


                case 2:
                    Console.Clear();
                    BangunRuangBalok Balok = new BangunRuangBalok();

                    Console.WriteLine("Masukkan nilai panjang = ");
                    Balok.p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai panjang = " + Balok.p);

                    Console.WriteLine("\nMasukkan nilai lebar = ");
                    Balok.l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai lebar = " + Balok.l);

                    Console.WriteLine("\nMasukkan nilai tinggi = ");
                    Balok.t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai tinggi = " + Balok.t);

                    Balok.LuasPermukaan = Balok.HitungLuasPermukaan();
                    Balok.Volume = Balok.HitungVolume();

                    Console.Clear();
                    Console.WriteLine("\nHasil Luas Permukaan Balok = {0}", Balok.LuasPermukaan);
                    Console.WriteLine("\nHasil Volume Balok = " + Balok.Volume);
                    Console.WriteLine("\nTekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;
                    break;


                case 3:
                    Console.Clear();
                    BangunRuangTabung Tabung = new BangunRuangTabung();

                    Console.WriteLine("Masukkan nilai jari-jari = ");
                    Tabung.r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai jari-jari = " + Tabung.r);

                    Console.WriteLine("\nMasukkan nilai tinggi = ");
                    Tabung.t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai tinggi = " + Tabung.t);


                    Tabung.LuasPermukaan = Tabung.HitungLuasPermukaan();
                    Tabung.Volume = Tabung.HitungVolume();
                    Console.Clear();
                    Console.WriteLine("\nHasil Luas Permukaan Tabung = " + Tabung.LuasPermukaan);
                    Console.WriteLine("\nHasil Volume Tabung = " + Tabung.Volume);
                    Console.WriteLine("\nTekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;

                    break;
                case 4:
                    Console.Clear();
                    BangunRuangBola Bola = new BangunRuangBola();

                    Console.WriteLine("Masukkan nilai jari-jari = ");
                    Bola.r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai jari-jari = " + Bola.r);

                    Bola.LuasPermukaan = Bola.HitungLuasPermukaan();
                    Bola.Volume = Bola.HitungVolume();

                    Console.Clear();
                    Console.WriteLine("\nHasil Luas Permukaan Bola = " + Bola.LuasPermukaan);
                    Console.WriteLine("\nHasil Volume Bola = " + Bola.Volume);

                    Console.WriteLine("\nTekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;
                    break;

                case 5:
                    Console.Clear();
                    BangunRuangKerucut Kerucut = new BangunRuangKerucut();

                    Console.WriteLine("Masukkan nilai jari-jari = ");
                    Kerucut.r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai jari-jari = " + Kerucut.r);

                    Console.WriteLine("\nMasukkan nilai tinggi = ");
                    Kerucut.t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai tinggi = " + Kerucut.t);

                    Console.WriteLine("\nMasukkan nilai s (garis pelukis) = ");
                    Kerucut.s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNilai s = " + Kerucut.s);

                    Kerucut.LuasPermukaan = Kerucut.HitungLuasPermukaan();
                    Kerucut.Volume = Kerucut.HitungVolume();

                    Console.Clear();
                    Console.WriteLine("\nHasil Luas Permukaan Kerucut = " + Kerucut.LuasPermukaan);
                    Console.WriteLine("\nHasil Volume Kerucut = " + Kerucut.Volume);

                    Console.WriteLine("\nTekan tombol apapun untuk mengulang Program");
                    Console.ReadLine();
                    goto home;

                    break;

                case 6:
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Input yang kamu masukkan salah, silahkan coba lagi");
                    Console.ReadLine();
                    goto home;
                    break;
            }
        }
    }
}
