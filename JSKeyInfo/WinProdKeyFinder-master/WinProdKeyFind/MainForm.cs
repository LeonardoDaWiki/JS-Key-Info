using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Management;

namespace WinProdKeyFind
{

    public partial class MainForm : Form
    {

        #region Formular
        // Formularbezogene Einstellungen
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            this.ddl_Language.SelectedIndex = 0;
        }

        private void btn_InfosAuslesen_Click(object sender, EventArgs e)
        {
            // get the current Windows Product Key and display it
            txb_WinKey.Text = KeyDecoder.GetWindowsProductKeyFromRegistry();
            txb_OS.Text = GetOSInformation();
        }
        #endregion

        #region Kopier-Buttons
        //Buttons "Kopieren" -> Textboxwert wird in den Zwischenspeicher kopiert

        private void pbx_WinKey_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_WinKey.Text, true);
        }

        private void pbx_OfficeKey_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_OS.Text, true);
        }

        private void pbx_CopyAll_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txb_WinKey.Text + "\r\n" + txb_OS.Text, true);
        }
        #endregion

        #region Sprachauswahl
        // Umstellen der Sprache auf den zwei Flaggen-Buttons

        private void ddl_Language_Changed(object sender, EventArgs e)
        {

            if (ddl_Language.Text == "English")
            {
                lbl_WinKey.Text = "Windows key:";
                lbl_OfficeKey.Text = "Operating system:";
                btn_InfosAuslesen.Text = "refresh...";
            }
            else
            {
                lbl_WinKey.Text = "Windows-Schlüssel:";
                lbl_OfficeKey.Text = "Betriebssystem:";
                btn_InfosAuslesen.Text = "erneuern...";


            }
        }
        #endregion

        #region Info-Button
        // Ruft ein zweites Form mit Programminformationen auf

        private void pbx_Info_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.Focus();
            this.Visible = false;
        }
        #endregion

        #region OSInformation
        // Das Betriebssystem wird ausgelesen

        public string GetOSInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + " (" + (string)wmi["OSArchitecture"] + ")";
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }
        #endregion

    }
}
