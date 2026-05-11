using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Image_Encryption
{
    public partial class frmEncryption : Form
    {
        public frmEncryption()
        {
            InitializeComponent();
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;
        }

        public static void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();
            control.Region = new Region(path);
        }

       
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            ofdSelectImage.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            ofdSelectImage.FilterIndex = 1;
            ofdSelectImage.RestoreDirectory = true;

            if (ofdSelectImage.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file 
                string selectedFilePath = ofdSelectImage.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath); 

                pbImage.ImageLocation = selectedFilePath;
                llClear.Enabled = true;
            }
        }

        public static string GenerateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }

        private string ImageLocation()
        {
            string DestinationFolder = @"D:\ImageEncryption\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return "";
            }

            string fileName = pbImage.ImageLocation;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
      
            return DestinationFolder + GenerateGUID() + extn;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string PathImage = ImageLocation();
            clsEncryption.EncryptFile(pbImage.ImageLocation, PathImage, txtKey.Text);

            MessageBox.Show("The image is encrypted in D:\\ImageEncryption", "Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string PathImage = ImageLocation();
            clsEncryption.DecryptFile(pbImage.ImageLocation, PathImage, txtKey.Text);

            pbImage.Load( PathImage);
            MessageBox.Show("The image is Decrypted in D:\\ImageEncryption", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmEncryption_Shown(object sender, EventArgs e)
        {
            SetRoundedRegion(this, 60);
            SetRoundedRegion(btnDecrypt, 25);
            SetRoundedRegion(btnEncrypt, 25);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void frmEncryption_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void llClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            llClear.Enabled = false;
        }

        private void txtKey_Validating(object sender, CancelEventArgs e)
        {
            if (txtKey.Text.Length!=16)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtKey, "It must be 16 characters long.");
                btnDecrypt.Enabled= false;
                btnEncrypt.Enabled= false;
                return;
            }
            else
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
                errorProvider1.SetError(txtKey, null);
            }
        }

        private void frmEncryption_Load(object sender, EventArgs e)
        {
            txtKey.Text = "1234567890123456";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
