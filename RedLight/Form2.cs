using System;
using System.Windows.Forms;
using FlexCodeSDK;
using Npgsql;

namespace RedLight
{
    public partial class Details : Form
    {
        private const string HOST = "localhost";
        private const string USERNAME = "postgres";
        private const string PASSWORD = "admin";
        private const string PORT = "5432";
        private const string DB = "fp";

        private readonly string connStr = $"Host={HOST};Port={PORT};Username={USERNAME};Password={PASSWORD};Database={DB}";

        private const string SN = "SE20J04713";
        private const string VC = "15605307E5667BD";
        private const string AC = "KH1F61E963F820F9D59910W5";
        private const string PC = "helloWorld";


        FlexCodeSDK.FinFPVer ver;
        string empid = "";

        Npgsql.NpgsqlConnection conn = null;
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            ver = new FlexCodeSDK.FinFPVer();
            ver.FPVerificationID += new __FinFPVer_FPVerificationIDEventHandler(ver_FPVerificationID);
            ver.FPVerificationImage += new __FinFPVer_FPVerificationImageEventHandler(ver_FPVerificationImage);
            ver.FPVerificationStatus += new __FinFPVer_FPVerificationStatusEventHandler(ver_FPVerificationStatus);
            ver.AddDeviceInfo(SN, VC, AC);

            ver.PictureSampleHeight = (short)(fingerBox.Height * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips
            ver.PictureSampleWidth = (short)(fingerBox.Width * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips

            ver.PictureSamplePath = AppDomain.CurrentDomain.BaseDirectory + "Finger.bmp";

            conn = new NpgsqlConnection(connStr);
            conn.Open();

            string query = "SELECT u.username, f.finger_data from users u left join fingers f on f.user_id = u.id where f.finger_data is not null";

            using (var cmd = new NpgsqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found.");
                    return;
                }

                while (reader.Read())
                {
                    ver.FPLoad(reader.GetString(0), 0, reader.GetString(1), PC);
                }
                ver.FPVerificationStart();
            }
        }

        void ver_FPVerificationID(string ID, FingerNumber FingerNr)
        {
            empid = ID;
        }

        void ver_FPVerificationImage()
        {
            fingerBox.Load(AppDomain.CurrentDomain.BaseDirectory + "Finger.bmp");
        }

        void ver_FPVerificationStatus(VerificationStatus Status)
        {
            if (Status == VerificationStatus.v_OK)
            {
                textBox1.Text = textBox1.Text + "\r\n" + empid;
            }
            else if (Status == VerificationStatus.v_NotMatch)
            {
                textBox1.Text = textBox1.Text + "\r\n" + "Not recognized";
            }
            else if (Status == VerificationStatus.v_NoDevice)
            {
                textBox1.Text = textBox1.Text + "\r\n" + "DEVICE_NOT_DETECTED";
            }

            ver.FPVerificationStop();
            closeBtn.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fingerBox_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ver.FPVerificationStop();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
