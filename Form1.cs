namespace QuitSmoking
{
    using System.Windows.Forms;
    
    public partial class Form1 : Form
    {
        int sec = 0;
        int min = 0;
        int hour = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (btnStart.Text == "Start")
            {
                timer1.Enabled = true;
                timer1.Start();
                btnStart.Text = "Stop";
            }
            else
            {
                btnStart.Text = "Start";
                timer1.Enabled= false;
                timer1.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec ++;
            if (sec > 59)
            {
                sec = 0;
                min++;
                if ( min == (int)num1.Value )
                {
                    min = 0;
                    notifyIcon1.ShowBalloonTip(3000);
                }
            }

            string strSec = sec.ToString();
            string strMin = min.ToString();
            string strHour = hour.ToString();
            if ( sec < 10)
            {
                strSec = "0" + sec;
            }
            if ( min < 10 )
            {
                strMin = "0" + min;
            }
            if ( hour < 10 )
            {
                strHour = "0" + hour;
            }

            lblTimer.Text = strHour + ":" + strMin + ":" + strSec;
        }
    }
}