using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)pizzaListBox.SelectedItem;
        }

        

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void smallRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
           if (smallRadioBttn.Checked)
            {
                textBox2.Text = "small";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            smallRadioBttn.Checked = true;
            medRadioBttn.Checked = true; 
            largeRadioBttn.Checked = true;
            xlargeRadioBttn.Checked = true;
            ccCheckBox.Checked = true;
            spriteCheckBox.Checked = true;
            dietCCCheckBox.Checked = true;
        }

        private void largeRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (largeRadioBttn.Checked)
            {
                textBox2.Text = "Large";
            }
        }

        private void medRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (medRadioBttn.Checked)
            {
                textBox2.Text = "Medium";
            }
        }

        private void xlargeRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (xlargeRadioBttn.Checked)
            {
                textBox2.Text = "Extra Large";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ccCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ccCheckBox.Checked)
            {
                textBox3.Text = "Coca Cola";
            }
        }

        private void spriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteCheckBox.Checked)
            {
                textBox3.Text = "Sprite";
            }
        }

        private void dietCCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dietCCCheckBox.Checked)
            {
                textBox3.Text = "Diet Cola";
            }
        }
    }
}
