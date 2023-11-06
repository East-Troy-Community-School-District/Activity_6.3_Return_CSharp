/*
 * Count Vowels
 * Pawelski
 * 11/5/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program and see what it does! How do
 * methods differ in CLI programs and GUI programs?
 * How are they similar?
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class CountVowelsForm : Form
    {
        public CountVowelsForm()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            string word = wordTextBox.Text.ToLower();
            vowelsLabel.Text = "There is(are) " + CountVowels(word)
                + " vowel(s) in that word.";
        }

        private int CountVowels(string word)
        {
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == 'a' || word[i] == 'e' || word[i] == 'i'
                    || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
