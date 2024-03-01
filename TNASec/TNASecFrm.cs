using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNASec_v2
{
    public partial class TNASecFrm : Form
    {
        // Variables for move the form
        public static int X, Y;
        public static bool isMouseDown = false;

        //Main variables
        Random rndm = new Random();
        int rndmNumber = 0;
        string HexLetter = "ABCDEF";
        char[] ArrayChars = { 'ሐ', 'አ', 'ម', 'ఎ', 'л', '噸', '我', 'ए', 'फ', 'Ф', 'ؤ', 'ء', 'ئ', 'Q', '+', '!', '@', '~', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', '_', '-', '>', '<', '이', '자', '형', 'ó', 'ʻ', 'ü' };
        public TNASecFrm()
        {
            InitializeComponent();
            inputTextBox.ForeColor = Color.DarkGray;
            inputTextBox.TextAlign = HorizontalAlignment.Center;
            inputTextBox.Text = "Input Text";

            keytxtBox.ForeColor = Color.DarkGray;
            keytxtBox.TextAlign = HorizontalAlignment.Center;
            keytxtBox.Text = "Password";
        }

        private void EnryptButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputTextBox.Text) || string.IsNullOrWhiteSpace(keytxtBox.Text) || keytxtBox.TextAlign == HorizontalAlignment.Center || inputTextBox.TextAlign == HorizontalAlignment.Center)
                {
                    for (int i = 3; i > 0; i--)
                    {
                        new Thread(WaitToCloseMsgBox).Start();
                        MessageBox.Show("text or password is empty!\nclosing after " + i.ToString() + " seconds", "TNASec v2", MessageBoxButtons.OK);
                    
                    }
                    return;
                }

                var key = XOREncrpytion.ToBinary(keytxtBox.Text);
                resultTextBox.Text = EncryptString(inputTextBox.Text, key);
           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something wrong!", "Error in encrypt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ReturnByteFromHex(string hex)
        {
            byte[] Text = new byte[hex.Length / 2];
            for (int i = 0; i < Text.Length; i++)
            {
                Text[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return Text;
        }
        private string ConvertStringToASCII(string Text)
        {
            byte[] ASCIINumber = Encoding.ASCII.GetBytes(Text);
            string StringStore = null;
            foreach (int value in ASCIINumber)
            {
                StringStore += ConvertASCIIToHex(value);
            }
            return StringStore;
        }

        private string ConvertASCIIToHex(int ASCIINumber)
        {
        DoAgain:
            int newNum = rndm.Next(0, 10);
            if (newNum == rndmNumber) goto DoAgain;
            rndmNumber = newNum;
            string Hex = string.Format("{0:X}", ASCIINumber);
            if (IsDigit(Hex[0]) && IsDigit(Hex[1]))
            {
                return newNum + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + Hex[0].ToString() + ArrayChars[newNum] + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + Hex[1].ToString();
            }
            return newNum + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString() + Hex[0].ToString() + Converter(Hex[1].ToString(), true) + ArrayChars[newNum] +  ArrayChars[rndm.Next(0, ArrayChars.Length)].ToString();
        }
        private string Decrypt(string Hex)
        {
            if (Hex == "Error") return Hex + " in decrypt :)";
            string text = string.Empty, result = string.Empty;
            try
            {
                foreach (char chr in Hex)
                {
                    if (IsDigit(chr))
                    {
                        text += chr;
                    }
                    else if (IsDigit(Hex[Hex.IndexOf(chr) - 1]) && HexLetter.Contains(chr.ToString()))
                    {
                        text += chr;
                    }
                }
                for (int z = 0; z <= text.Length - 3; z += 3)
                {
                    result += Encoding.ASCII.GetString(ReturnByteFromHex(text[z + 1].ToString() + text[z + 2].ToString()));
                }
                return result;
            }
            catch
            {
                return "Error in decrypt :)";
            }
        }
        private string Converter(string text, bool HexLetter)
        {
            try
            {
                if (HexLetter)
                {
                    return text.Replace("A", "हजार番目の手紙").Replace("B", "ब番目の手紙").Replace("C", "သုံး番目の手紙").Replace("E", "ສີ່番目の手紙").Replace("F", "è番目の手紙");
                }
                else
                {
                    for (var index = 0; index < ArrayChars.Length - 1; index++)
                    {
                        if (text.Contains(ArrayChars[index].ToString()))
                        {
                            return text.Replace("हजार番目の手紙", "A").Replace("ब番目の手紙", "B").Replace("သုံး番目の手紙", "C").Replace("ສີ່番目の手紙", "E").Replace("è番目の手紙", "F");
                        }
                    }
                    return "Error";
                }
            }
            catch
            {
                return "Error";
            }

        }
        private bool IsDigit(char chr) => Char.IsDigit(chr);

        private string EncryptString(string text, string password)
        {
            string result = ConvertStringToASCII(text) + password;
            return result;
        }

        private void DecryptButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(inputTextBox.Text) || string.IsNullOrWhiteSpace(keytxtBox.Text) || keytxtBox.TextAlign == HorizontalAlignment.Center || inputTextBox.TextAlign == HorizontalAlignment.Center)
                {
                    MessageBox.Show("text or password is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                var key = XOREncrpytion.ConvertBinaryToText(inputTextBox.Text.Substring(inputTextBox.Text.IndexOf("♢")));
                if (key == keytxtBox.Text)
                {
                    resultTextBox.Text = Decrypt(Converter(inputTextBox.Text.Substring(0, inputTextBox.Text.IndexOf("♢")), false));
                }
                else
                {
                    MessageBox.Show("Incorrect Password. try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        public void WaitToCloseMsgBox()
        {
            Thread.Sleep(1000);
            Microsoft.VisualBasic.Interaction.AppActivate(System.Diagnostics.Process.GetCurrentProcess().Id);
            SendKeys.SendWait(" ");
        }
     
        private void CopyButtonClick(object sender, EventArgs e)
        {
            var lastValue = btnCopy.Text;
            Clipboard.SetText(resultTextBox.Text);
            btnCopy.Text = "Copied";
            Task.Run(() =>
            {
                // Count 2 seconds ..
                for (int i = 2/* <--- Number of Seconds */; i > 0; i--)
                {
                    Thread.Sleep(1000);
                }
                btnCopy.Text = lastValue;
            });

        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void _MouseDown(object sender, MouseEventArgs e)
        {
            var TypeOfSender = sender.GetType();
            switch (TypeOfSender)
            {
                case Type _ when TypeOfSender == typeof(TextBox):
                    {
                        var textbox = sender as TextBox;
                        if (textbox.Text == "Input Text" || textbox.Text == "Password")
                        {
                            textbox.ForeColor = Color.White;
                            textbox.TextAlign = HorizontalAlignment.Left;
                            textbox.Clear();
                        }

                    }
                    break;
                case Type _ when TypeOfSender == typeof(Label) || TypeOfSender == typeof(TNASecFrm):
                    {
                        isMouseDown = true;
                        X = e.X;
                        Y = e.Y;
                        Opacity = 0.9;
                    }
                    break;
            }

        }
        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
                SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
        }
        private void _MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            Opacity = 1.0;
        }
    }
}