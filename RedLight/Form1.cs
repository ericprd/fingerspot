using System;
using System.Windows.Forms;
using FlexCodeSDK;
using Npgsql;


namespace RedLight
{
    public partial class Window : Form
    {
        //private const string HOST = "localhost";
        //private const string USERNAME = "postgres";
        //private const string PASSWORD = "admin";
        //private const string PORT = "5432";
        //private const string DB = "fp";

        //private readonly string connStr = $"Host={HOST};Port={PORT};Username={USERNAME};Password={PASSWORD};Database={DB}";

        //private const string SN = "SE20J04713";
        //private const string VC = "15605307E5667BD";
        //private const string AC = "KH1F61E963F820F9D59910W5";
        //private const string PC = "helloWorld";


        //FlexCodeSDK.FinFPVer ver;
        //string empid = "";

        //Npgsql.NpgsqlConnection conn = null;
        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Details details = new Details();
            details.Show();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            //    ver = new FlexCodeSDK.FinFPVer();
            //    ver.FPVerificationID += new __FinFPVer_FPVerificationIDEventHandler(ver_FPVerificationID);
            //    ver.FPVerificationImage += new __FinFPVer_FPVerificationImageEventHandler(ver_FPVerificationImage);
            //    ver.FPVerificationStatus += new __FinFPVer_FPVerificationStatusEventHandler(ver_FPVerificationStatus);

            //    ver.AddDeviceInfo(SN, VC, AC);

            //    ver.PictureSampleHeight = (short)(fingerBox.Height * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips
            //    ver.PictureSampleWidth = (short)(fingerBox.Width * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips

            //    ver.PictureSamplePath = AppDomain.CurrentDomain.BaseDirectory + "Finger.bmp";

            //    try
            //    {
            //        conn = new NpgsqlConnection(connStr);
            //        conn.Open();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Database connection failed: " + ex.Message);
            //    }
        }

        //void ver_FPVerificationID(string ID, FingerNumber FingerNr)
        //{
        //    empid = ID;
        //}

        //void ver_FPVerificationImage()
        //{
        //    fingerBox.Load(AppDomain.CurrentDomain.BaseDirectory + "Finger.bmp");
        //}

        //void ver_FPVerificationStatus(VerificationStatus Status)
        //{
        //    if (Status == VerificationStatus.v_OK)
        //    {
        //        textBox1.Text = textBox1.Text + "\r\n" + empid;
        //    }
        //    else if (Status == VerificationStatus.v_NotMatch)
        //    {
        //        textBox1.Text = textBox1.Text + "\r\n" + "Not recognized";
        //    }
        //    else if (Status == VerificationStatus.v_NoDevice)
        //    {
        //        textBox1.Text = textBox1.Text + "\r\n" + "DEVICE_NOT_DETECTED";
        //    }

        //    clearbtn.Enabled = true;
        //}
    }
}
