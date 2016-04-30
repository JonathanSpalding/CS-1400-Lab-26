// Author: Jonathan Spalding
// Assignment: Lab 13
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 2/18/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
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

namespace Using_a_File_Open_Dialogue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nlab 26");
        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // The openToolStripMenuItem_Click Method
        // Purpose: opens file explorer to find a file, and then reads the first line of that file, and outputs it in the text box.
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // declares a Stream reference. The Open method returns a Stream reference that we will store in reference variable myStream.
            Stream myStream = null;
            // creates an OpenFileDialogue object.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //defines the initial directory to use when the File Open dialogue is displayed.
            openFileDialog1.InitialDirectory = "c://";
            //defines the file extensions to show in the file dialogue.
            openFileDialog1.Filter = "text files (*txt)|*txt";
            //displays the File Open dialogue and checks the return value to make sure that this operation worked.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Line 10 opens the file and assigns the reference to the stream object to myStream. If the file did not open for some reason the reference will be null.
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    //creates a StreamReader object using the Stream myStream as its parameter.
                    StreamReader data = new StreamReader(myStream);
                    //reads one line of data from the file and stores it in the Text property of the Control TextBox object. Here I have named that TextBox object textBox.
                    Control.Text = data.ReadLine( );
                }
            }
        }
    }
}
