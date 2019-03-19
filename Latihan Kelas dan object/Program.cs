using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Kelas_dan_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();


            //mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.0000";
            saya.Nama = "Tejo";
            saya.Ipk = 3.69f;

            kamu.Nim = "18.11.0001";
            kamu.Nama = "Udin";
            kamu.Ipk = 3.49f;

            //memanggil method registrasi dan isi KRS
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
