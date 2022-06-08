using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Printing;

namespace AllcardPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Allcard.Printer.Evolis.Process prcs = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            if (prcs != null) prcs.FeedCard();
            LogToRTB(prcs.GetMessage);
        }

        private void btnEject_Click(object sender, EventArgs e)
        {           
            if (prcs != null) prcs.EjectCard();
            LogToRTB(prcs.GetMessage);
        }

        private void btnReadMag_Click(object sender, EventArgs e)
        {
            if (prcs == null) return;

            this.Enabled = false;
            if (prcs.ReadTracks())
            {
                txtTrack1.Text = prcs.Track1;
                txtTrack2.Text = prcs.Track2;
                txtTrack3.Text = prcs.Track3;
            }
            else
            {
                txtTrack1.Text = "";
                txtTrack2.Text = "";
                txtTrack3.Text = "";
            }

            LogToRTB(prcs.GetMessage);
            this.Enabled = true;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (prcs == null) return;           

            bool isContinue = true;
            if (string.IsNullOrEmpty(txtTrack1.Text) && string.IsNullOrEmpty(txtTrack2.Text) && string.IsNullOrEmpty(txtTrack3.Text))
            {
                MessageBox.Show("Track(s) are empty.", "Allcard Evolis Printer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtTrack1.Text) || string.IsNullOrEmpty(txtTrack2.Text) || string.IsNullOrEmpty(txtTrack3.Text))
            {
                if (MessageBox.Show("One of the track(s) is/are empty. Continue?", "Allcard Evolis Printer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) isContinue = false;
            }

            if (isContinue)
            {
                this.Enabled = false;
                prcs.Track1 = txtTrack1.Text;
                prcs.Track2 = txtTrack2.Text;
                prcs.Track3 = txtTrack3.Text;

                if (prcs.WriteMags())
                {
                    txtTrack1.Text = prcs.Track1;
                    txtTrack2.Text = prcs.Track2;
                    txtTrack3.Text = prcs.Track3;
                    MessageBox.Show("Success", "Allcard Evolis Printer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtTrack1.Text = "";
                    txtTrack2.Text = "";
                    txtTrack3.Text = "";
                    MessageBox.Show("Failed", "Allcard Evolis Printer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                LogToRTB(prcs.GetMessage);
                this.Enabled = true;
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {         
            //System.IO.File.AppendAllLines(@"D:\pagibig-evolis-log.txt", new[] { string.Concat(DateTime.Now.ToString(), " ", "TEST") });
            //return;
            
            
            string printerFile = System.IO.File.ReadAllText(string.Concat(Application.StartupPath, "\\printer"));
            prcs = new Allcard.Printer.Evolis.Process(printerFile);
            if (prcs.Initialize())
            {
                lblPrinterSerial.Text = String.Concat("Printer Serial: ", prcs.GetPrinterSerial());
                lblPrinterCounter.Text = String.Concat("Printer Counter: ", prcs.GetPrinterCounter().ToString());

                btnFeed.Enabled = true;
                btnEject.Enabled = true;
                grpMagstripe.Enabled = true;
                grpPrint.Enabled = true;
            }
            else
            {
                lblPrinterSerial.Text = String.Concat("Printer Serial: ");
                lblPrinterCounter.Text = String.Concat("Printer Counter: ");

                btnFeed.Enabled = false;
                btnEject.Enabled = false;
                grpMagstripe.Enabled = false;
                grpPrint.Enabled = false;
                LogToRTB(prcs.GetMessage);
                prcs = null;
            }           
        }

        private List<Allcard.Printer.Evolis.CardElement> cls = new List<Allcard.Printer.Evolis.CardElement>();

        private void DataForPrinting()
        {
            SolidBrush dBlack = new SolidBrush(Color.Black);
            Font fontName = new Font("ARIAL", 12, FontStyle.Bold);           

            Allcard.Printer.Evolis.CardElement cePhoto = new Allcard.Printer.Evolis.CardElement();
            cePhoto.Description = "Photo";
            cePhoto.Type = Allcard.Printer.Evolis.CardElement.ElementType.Img;
            cePhoto.Image = Image.FromFile(Application.StartupPath + @"\sample_photo.jpg");
            cePhoto.Point = new Point(100, 100);
            cePhoto.Width = 200;
            cePhoto.Height = 200;
            cls.Add(cePhoto);

            Allcard.Printer.Evolis.CardElement ceName = new Allcard.Printer.Evolis.CardElement();
            ceName.Description = "Name";
            ceName.Type = Allcard.Printer.Evolis.CardElement.ElementType.Str;
            ceName.StringValue = txtName.Text;
            ceName.Font = fontName;
            ceName.Color = dBlack;            
            ceName.Rectangle = new Rectangle(350, 100, 100, 100);
            cls.Add(ceName);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cls.Clear();
            DataForPrinting();

            if (!prcs.Print(cls, txtName.Text))
            {
                LogToRTB(prcs.GetMessage);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {          
            cls.Clear();
            DataForPrinting();

            if (!prcs.Preview(cls, txtName.Text))            
            {
                //MessageBox.Show(prcs.GetMessage);
                LogToRTB(prcs.GetMessage);
            }
        }        
        private void LogToRTB(string desc)
        {
            rtbLog.AppendText(string.Concat(DateTime.Now.ToString("hh:mm:ss"), " ", desc));
            rtbLog.ScrollToCaret();
            Application.DoEvents();
        }

        private void CheckPrinterQueue()
        {
            ////Get local print server
            //var server = new System.Printing.LocalPrintServer();

            ////Load queue for correct printer
            //System.Printing.PrintQueue queue = server.DefaultPrintQueue; //server.GetPrintQueue("Evolis Zenius", new string[0] { });

            ////Check some properties of printQueue    
            //bool isInError = queue.IsInError;
            //bool isOutOfPaper = queue.IsOutOfPaper;
            //bool isOffline = queue.IsOffline;
            //bool isBusy = queue.IsBusy;

            PrintServer m_PrintServer = new PrintServer();
            PrintQueueCollection m_PrintQueueCollection = m_PrintServer.GetPrintQueues(new[] { EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections });

            foreach (var p in m_PrintQueueCollection)
            {
                if (p.FullName == "Evolis Zenius")
                {
                    LogToRTB(p.IsOffline.ToString() + "\r");                    
                }
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prcs != null) prcs.GetCurrentPrinterJob();
            LogToRTB(prcs.GetMessage + "\r");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (prcs != null) prcs.ExecuteCommand(txtTrack1.Text);
            prcs.GetPrinterStatus();
            LogToRTB(prcs.GetMessage);
        }

        //Rmc(Read magnetic coercivity.) 
        //Rtp(Read type printer.) 

        //string res = BusinessHelper.PrinterSetEvent(btnOk.Text, lblPrinter.Text);
        //btnOk.Text = res;
        //        btnOk.Enabled = false;
        //        txtBox.Text = "Request:\r\n" + EspfClientProcessor.LastRequest + "\r\n\r\nAnswer:\r\n" + EspfClientProcessor.LastAnswer;

        //EspfServer00
        //"."
    }
}
