using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LogToRTB(prcs.GetPrinterCounter().ToString() + "\r");
            LogToRTB(prcs.GetPrinterSerial() + "\r");
            return;


            if (prcs != null) prcs.EjectCard();
            LogToRTB(prcs.GetMessage);
        }

        private void btnReadMag_Click(object sender, EventArgs e)
        {
            if (prcs == null) return;

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
                prcs.Track1 = txtTrack1.Text;
                prcs.Track2 = txtTrack2.Text;
                prcs.Track3 = txtTrack3.Text;

                if (prcs.WriteMags())
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
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            prcs = new Allcard.Printer.Evolis.Process("Evolis Zenius");
            if (prcs.Initialize())
            {
                btnFeed.Enabled = true;
                btnEject.Enabled = true;
                grpMagstripe.Enabled = true;
                grpPrint.Enabled = true;
            }
            else
            {               
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

            List<Allcard.Printer.Evolis.CardElement> cls = new List<Allcard.Printer.Evolis.CardElement>();


            Allcard.Printer.Evolis.CardElement cePhoto = new Allcard.Printer.Evolis.CardElement();
            cePhoto.Description = "Photo";
            cePhoto.Type = Allcard.Printer.Evolis.CardElement.ElementType.Img;
            cePhoto.ImageStream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(Application.StartupPath + @"\sample_photo.jpg"));
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
            ceName.Point = new Point(350, 100);
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
    }
}
