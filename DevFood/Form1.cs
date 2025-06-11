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
                txtTaxa2.Enabled = true;
                lblTaxa2.Enabled = true;
            }
            else
            {
                txtTaxa2.Enabled = false;
                lblTaxa2.Enabled = false;
            }

            //if (chkTaxa2.Checked)
            //{
            //    
            //}
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

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkTaxa1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaxa1.Checked)
            {
                txtVlrTaxa.Enabled = true;
                txtVlrTaxa.Visible = true;

                lblTaxa.Enabled = true;
                lblTaxa.Visible = true;
                lblTaxa2.Visible = true;

            }
            else
            {
                txtVlrTaxa.Enabled = false;
                lblTaxa.Enabled = false;
                txtVlrTaxa.Visible = false;


            }

        }

        private void rdSemTaxas_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rdComTaxas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdComTaxas.Checked)
            {
                chkTaxa1.Checked = true;
                chkTaxa1.Visible = true;
                chkTaxa2.Visible = true;
            }
            else
            {
                chkTaxa1.Checked = false;
                chkTaxa1.Visible = false;
                chkTaxa2.Checked = false;
                chkTaxa2.Visible = false;
                lblTaxa.Visible = false;
                lblTaxa2.Visible = false;
            }
        }

        private void chkTaxa2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTaxa2.Checked)
            {
                txtTaxa2.Enabled = true;
                txtTaxa2.Visible = true;
                lblTaxa2.Enabled = true;
                lblTaxa2.Enabled = true;
            }
            else
            {

                txtTaxa2.Enabled = false;
                txtTaxa2.Visible = false;
                lblTaxa2.Enabled = false;
                lblTaxa2.Enabled = false;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
