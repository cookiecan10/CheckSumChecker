using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Threading;
using System.Drawing;

namespace CheckSumChecker
{
    public partial class Form1 : Form
    {
        FileInfo file;
        Hasher h;
        string fileName = "";
        public Form1()
        {
            InitializeComponent();
            this.Text = "CheckSumChecker";
        }

        string[] hashFunctions = new string[] { "MD5","SHA1","SHA256","SHA384","SHA512", };

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectHashFunctionBox.Items.AddRange(hashFunctions);
            SelectHashFunctionBox.Text = hashFunctions[0];
        }

        //Opens a "Browse Files" thingy
        private void BrowseButton_Click(object sender, EventArgs e)
        {

            using (var FD = new System.Windows.Forms.OpenFileDialog())
            {
                if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileToOpen = FD.FileName;

                    file = new System.IO.FileInfo(FD.FileName);

                    FilePath.Text = file.ToString();
                    fileName = file.Name;
                    CheckSumBox.Text = fileName;
                    ErrorLabel.Text = "";
                    IncorrectLabel.Text = "";
                }
            }
        }

        //Turns a Byte Array into a Hexadecimal string
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        //Changes the background of the hashbox to red or white depending on if the correct values are in it
        public void GivenHashCorrect()
        {
            if (GivenTextBox.Text == "" || CheckSumBox.Text == "" || CheckSumBox.Text == fileName || CheckSumBox.Text == "CheckSum")
            {
                CheckSumBox.BackColor = Color.FloralWhite;
                CheckSumBox.ForeColor = Color.Black;
                IncorrectLabel.Text = "";
            }
            else if(GivenTextBox.Text == CheckSumBox.Text)
            {
                CheckSumBox.BackColor = Color.FloralWhite;
                CheckSumBox.ForeColor = Color.Black;
                IncorrectLabel.ForeColor = Color.Black;
                IncorrectLabel.Text = "CheckSum Correct!";
            }
            else
            {
                CheckSumBox.BackColor = Color.Red;
                CheckSumBox.ForeColor = Color.White;
                IncorrectLabel.ForeColor = Color.Red;
                IncorrectLabel.Text = "CheckSum is incorrect";
            }
            
        }

        //Runs when you click "Hash"
        private void HashButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            if (File.Exists(FilePath.Text))
            {
                //Byte Array
                byte[] hashValue;

                Hasher h = new Hasher();

                //Create a fileStream for the file
                using (FileStream fileStream = File.OpenRead(FilePath.Text))
                {
                    //Make sure it's positioned at the beginning of the stream
                    fileStream.Position = 0;

                    if (SelectHashFunctionBox.Text == "MD5")//MD5
                    {
                        CheckSumBox.Text = h.HashMD5(fileStream);
                    }
                    else if (SelectHashFunctionBox.Text == "SHA1")//SHA1
                    {
                        CheckSumBox.Text = h.HashSHA1(fileStream);
                    }
                    else if (SelectHashFunctionBox.Text == "SHA256")//SHA256
                    {
                        CheckSumBox.Text = h.HashSHA256(fileStream);
                    }
                    else if (SelectHashFunctionBox.Text == "SHA384")//SHA384
                    {
                        CheckSumBox.Text = h.HashSHA384(fileStream);
                    }
                    else if (SelectHashFunctionBox.Text == "SHA512")//SHA512
                    {
                        CheckSumBox.Text = h.HashSHA512(fileStream);
                    }
                    else//If you somehow choose an invalid Hash function
                    {
                        ErrorLabel.Text = "This is not a valid Hash function";
                    }
                    GivenHashCorrect();
                }
            }
            else
            {
                ErrorLabel.Text = "This is not a valid File path";
            }
        }

        //Runs when you drag a file into the form
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Debug.WriteLine(e.Data);
        }

        //runs when you actually drop a file into the form
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string f in files) FilePath.Text = f;
            CheckSumBox.Text = "";
            ErrorLabel.Text = "";
            IncorrectLabel.Text = "";
        }

        //Runs every time the "Given Hash" textbox is changed
        private void GivenTextBox_TextChanged(object sender, EventArgs e)
        {
            GivenHashCorrect();
        }
    }
}
