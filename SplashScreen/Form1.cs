using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        static string device_name = "COM3";
        static int baud_rate = 19200;
        SerialPort sp = new SerialPort(device_name, baud_rate, Parity.None, 8, StopBits.One);
      
        public Form1()
        {
            InitializeComponent();
            backlightOn.CheckedChanged += new EventHandler(backlightButtons_CheckedChanged);
            backlightOff.CheckedChanged += new EventHandler(backlightButtons_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // open port 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            byte[] clear_screen = new byte[2] { 0xFE, 0x58 };

            // setup screen
            try
            {
                sp.Open();
                sp.Write(clear_screen, 0, clear_screen.Length);
            }
            catch (Exception E) { MessageBox.Show(E.ToString(), "Error"); }

            if (sp.IsOpen == true)
            {
                MessageBox.Show("Connected to port.");
            }
        }

        // close port 
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                sp.Close();
                sp.Dispose();
            }
            catch (Exception E) { MessageBox.Show(E.ToString(), "Error"); }

            if (sp.IsOpen == false)
            {
                MessageBox.Show("Disconnected from port.");
            }
        }

        // convert hex string to byte array 
        public byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        // write to screen
        public void btnWrite_Click(object sender, EventArgs e)
        {
            
            string str = tbLine1.Text.PadRight(20) + tbLine2.Text.PadRight(20) + tbLine3.Text.PadRight(20) + tbLine4.Text.PadRight(20);
            string change_screen = "FE40";

            // convert string to hex string
            char[] c = str.ToCharArray();
            string strHex = string.Empty;
            foreach (char letter in c)
            {
                int val = Convert.ToInt32(letter);
                string str_to_hex = String.Format("{0:X}", val);
                strHex += str_to_hex;
            }

            // convert hex string to binary 
            string save_screen = (change_screen + strHex);
            byte[] result = StringToByteArray(save_screen);
            
            try
            {
                sp.Write(str);
                sp.Write(result, 0, result.Length);
            }
            catch (Exception E) { MessageBox.Show(E.ToString(), "Error"); 
        }

        // turn backlight on/off 
        private void backlightButtons_CheckedChanged (object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string display_on = "FE42";
            byte[] display_off = new byte[2] { 0xFE, 0x46 };
            int backlight = 0;
            string backlight_hex = backlight.ToString("X02");
            
            // convert hex string to binary
            string blstring = (display_on + backlight_hex);
            byte[] result = StringToByteArray(blstring);

            if (backlightOn.Checked)
            {
                sp.Write(result, 0, result.Length);
            }

            if (backlightOff.Checked)
            {
                sp.Write(display_off, 0, display_off.Length);
            }
        }

        // set and save brightness
        private void btnBrightness_Click(object sender, EventArgs e)
        {
            int brightness = int.Parse(tbBrightness.Text);
            string brightness_command = "FE98";

            try
            {
                // convert int to hex string
                if (brightness > 15)
                {
                    string contrast_hex = brightness.ToString("X");
                    string cstring = (brightness_command + contrast_hex);
                    byte[] result = StringToByteArray(cstring);
                    sp.Write(result, 0, result.Length);
                }
                else
                {
                    string contrast_hex = brightness.ToString("X02");
                    string cstring = (brightness_command + contrast_hex);
                    byte[] result = StringToByteArray(cstring);
                    sp.Write(result, 0, result.Length);
                }

            }
            catch (Exception E) { MessageBox.Show(E.ToString(), "Error"); }
        }

        // set and save contrast
        private void btnContrast_Click(object sender, EventArgs e)
        {
            int contrast = int.Parse(tbContrast.Text);
            string contrast_command = "FE91";

            try
            {
                // convert int to hex string
                if (contrast > 15)
                {
                    string contrast_hex = contrast.ToString("X");
                    string cstring = (contrast_command + contrast_hex);
                    byte[] result = StringToByteArray(cstring);
                    sp.Write(result, 0, result.Length);
                }
                else
                {
                    string contrast_hex = contrast.ToString("X02");
                    string cstring = (contrast_command + contrast_hex);
                    byte[] result = StringToByteArray(cstring);
                    sp.Write(result, 0, result.Length);
                }

            }
            catch (Exception E) { MessageBox.Show(E.ToString(), "Error"); }
        }
    }
}
