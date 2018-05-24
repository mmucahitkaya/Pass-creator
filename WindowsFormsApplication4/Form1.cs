using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        static string[] CharacterSets= new string[] { "0123456789", "abcdefghijklmnopqestuwxyz" , "ABCDEFGHIJKLMNOPQRSTUVWXYZ" , "!@#$%^&*()-+" };
        static int PasswordLength = 10;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenPassButton_Click(object sender, EventArgs e)
        {
            string Password = "";
            string tempCharset = "";
            char tempCharacter;
            int tempIndex = 0;
            Random rastgele = new Random();
            for (int i = 0; i < PasswordLength; i++)
            {
                tempIndex = rastgele.Next(0, 4);
                tempCharset = CharacterSets[tempIndex];
                tempCharacter = tempCharset[rastgele.Next(0, tempCharset.Length)];
                Password = Password + tempCharacter;
            }
            PassBox.Text = Password;


        }
    }
}
