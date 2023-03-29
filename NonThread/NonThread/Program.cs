class Program
{

    public class non_Thread
    {
        public void cuci_baju()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(("cuci baju ke {0}"),i);
            }
        }

        public void sertrika()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(("setrika baju ke {0}"), i);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("mulai melakukan pekerjaan");
        Console.WriteLine("===================================");

        non_Thread tid1 = new non_Thread();

        tid1.cuci_baju();
        tid1.sertrika();

        Console.WriteLine("===================================");
        Console.WriteLine("Selesai........... !");
        Console.WriteLine("===================================");

    }
}