class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("============================");
        Console.WriteLine("mulai melakukan pekerjaan");
        Console.WriteLine("============================");

        Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1));
        Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2));

        tid1.Start();   
        tid2.Start();  

        Console.ReadLine(); 
    }
}