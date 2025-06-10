using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdComTaxas.Checked = true;
            chkTaxa1.Checked = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void rdComTaxas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdComTaxas.Checked)
            {
                chkTaxa1.Visible = true;
                chkTaxa2.Visible = true;
                lblTaxa.Visible = true;
                txtVlrTaxa.Visible = true;
            }
        }

        private void rdSemTaxas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSemTaxas.Checked)
            {
                chkTaxa1.Visible = false;
                chkTaxa2.Visible = false;

                chkTaxa1.Checked = false;
                chkTaxa2.Checked = false;
            }
        }

        private void chkTaxa2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaxa2.Checked)
            {
                txtVlrTaxa.Enabled = true;
                lblTaxa.Enabled = true;
            }
            else
            {
                txtVlrTaxa.Enabled = false;
                lblTaxa.Enabled = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
