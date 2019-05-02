using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;

namespace AI_ChatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot AI = new Bot();
            AI.loadSettings(); // Load setting from its config folder 
            AI.loadAIMLFromFiles(); // Load AIML Files from its AIML folder
            AI.isAcceptingUserInput = false;// Disable user input for now
            User myuser = new User("Me",AI);// add the user through AI/Bot
            AI.isAcceptingUserInput = true;//Now The User Input is Enabled Again with this Code
            Request r = new Request(textBox1.Text, myuser, AI); //it will Request The Response From AIML Folders
            Result res = AI.Chat(r); //This Code It Will Get Result
            textBox2.Text = "Chat Bot: " + res.Output;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
