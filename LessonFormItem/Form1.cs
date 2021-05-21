using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonFormItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba Dünya");
            cBoxNames.Items.Add("Samet");
            cBoxNames.Items.Add("Semih");
            cBoxNames.Items.Add("Mustafa");
            lblDisplay.Text = "Kimse seçilmedi.";
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if(cBoxNames.Text == "" && txtAge.Text == "")
            {
                MessageBox.Show("Boş bırakma kardeşim!");
            }
            else if(cBoxNames.Text == "")
            {
                MessageBox.Show("Kişi seçiniz!");
            }
            else if (txtAge.Text == "")
            {
                MessageBox.Show("Yaşını giriniz!");
            }
            else
            {
                lblDisplay.Text = cBoxNames.Text + " yaşı " + txtAge.Text;
            }
            
        }

        private void btnClickMe2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Kimse seçilmedi.";
            cBoxNames.Text = "";
            txtAge.Text = "";
        }
    }
}
