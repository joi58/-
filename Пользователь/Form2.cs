﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пользователь
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _form1.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {

        }

        private void RepeatPassField_Click(object sender, EventArgs e)
        {

        }
    }
}
