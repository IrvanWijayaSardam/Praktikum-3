namespace AplikasiGameThread_20SA11206;

using System.Threading;
using System.Threading.Tasks;


public partial class Form1 : Form
{
    public bool PlayAgain = false;
    static Random r;
    static Thread Player1Thd;
    static Thread Player2Thd;
    static Thread Player3Thd;
    public static int countPlayer1;
    public static int countPlayer2;
    public static int countPlayer3;


    public Form1()
    {
        InitializeComponent();
        countPlayer1= 0;
        countPlayer2= 0;    
        countPlayer3= 0;
        r = new Random();   
    }

    public static void Player1()
    {
        while(true)
        {
            Thread.Sleep(50);
            if(countPlayer1 > 650) { 
            Player1Thd.Abort();
            break;
            }
            countPlayer1 = countPlayer1+ (1 + r.Next(6));
        }
    }
    public static void Player2()
    {
        while (true)
        {
            Thread.Sleep(50);
            if (countPlayer1 > 650)
            {
                Player2Thd.Abort();
                break;
            }
            countPlayer2 = countPlayer2 + (1 + r.Next(6));
        }
    }

    public static void Player3()
    {
        while (true)
        {
            Thread.Sleep(50);
            if (countPlayer1 > 650)
            {
                Player3Thd.Abort();
                break;
            }
            countPlayer3 = countPlayer3 + (1 + r.Next(6));
        }
    }

    private void btn_Play_Click(object sender, EventArgs e)
    {
        countPlayer1 = 0;
        countPlayer2 = 0;
        countPlayer3 = 0;

        Player1Thd = new Thread(new ThreadStart(Player1));
        Player1Thd.IsBackground = true;
        Player1Thd.Start();

        Player2Thd = new Thread(new ThreadStart(Player2));
        Player2Thd.IsBackground = true;
        Player2Thd.Start();

        Player3Thd = new Thread(new ThreadStart(Player3));
        Player3Thd.IsBackground = true;
        Player3Thd.Start();

        timer1.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        bool check = false;

        if(countPlayer1 > 650)
        {
            timer1.Stop();  
            countPlayer1= 0;
            countPlayer2 = 0;   
            countPlayer3 = 0;
            check = true;
            int i = Int32.Parse(lbPlayerOne.Text);
            i++;
            lbPlayerOne.Text = i.ToString();
            MessageBox.Show("Player one win the race");
        }
        if (countPlayer2 > 650)
        {
            timer1.Stop();
            countPlayer1 = 0;
            countPlayer2 = 0;
            countPlayer3 = 0;
            check = true;
            int i = Int32.Parse(lbPlayerTwo.Text);
            i++;
            lbPlayerTwo.Text = i.ToString();
            MessageBox.Show("Player Two win the race");
        }
        if (countPlayer2 > 650)
        {
            timer1.Stop();
            countPlayer1 = 0;
            countPlayer2 = 0;
            countPlayer3 = 0;
            check = true;
            int i = Int32.Parse(lbPlayerThree.Text);
            i++;
            lbPlayerThree.Text = i.ToString();
            MessageBox.Show("Player Three win the race");
        }

        if(check == false)
        {
            button1.Left = countPlayer1;
            button2.Left = countPlayer2;
            button3.Left = countPlayer3;

        }
    }
}