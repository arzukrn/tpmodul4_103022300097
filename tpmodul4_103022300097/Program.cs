using tpmodul4_103022300052;

class Program
{
    static void Main()
    {

        Console.WriteLine("\n===== CEK KODE POS =====");
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        int kodePos = KodePos.GetKodePos(kelurahan);

        if (kodePos != -1)
        {
            Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");
        }
        else
        {
            Console.WriteLine($"Kelurahan {kelurahan} tidak ditemukan dalam database.");
        }

        Console.WriteLine("===== SIMULASI DOOR MACHINE =====\n");

        DoorMachine pintu = new DoorMachine();

        Console.WriteLine(">>> Membuka pintu...");
        pintu.BukaPintu();

        Console.WriteLine(">>> Mengunci pintu...");
        pintu.KunciPintu();

        Console.WriteLine(">>> Membuka pintu lagi...");
        pintu.BukaPintu();

        Console.WriteLine(">>> Mencoba membuka pintu yang sudah terbuka...");
        pintu.BukaPintu();

        Console.WriteLine(">>> Mengunci pintu...");
        pintu.KunciPintu();
        Console.WriteLine(">>> Mencoba mengunci pintu yang sudah terkunci...");
        pintu.KunciPintu();

        Console.WriteLine("\n===== SIMULASI SELESAI =====");
        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}


