using System;
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
    public partial class Mainmenu : Form
    {
        private DogovorAutoForm DogovorAutoForm;
        private DogovotPredpriytia DogovotPredpriytia;
        private DogovorPostForm DogovorPostForm;
        private Form ChildForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ChildForm != null)
            {
                ChildForm.Close();

            }
            ActivateButton(btnSender);
            ChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.White;
            childForm.Size = ChildForm.Size;

            this.panel5.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                
            }
        }

        public Mainmenu()
        {
            InitializeComponent();
            //DogovorAutoForm = new DogovorAutoForm() { Visible = false };
            //DogovotPredpriytia = new DogovotPredpriytia() { Visible = false };
            //DogovorPostForm = new DogovorPostForm() { Visible = false };
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DogovorAuto_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //DogovorAutoForm.Visible = true;
            OpenChildForm( new DogovorAutoForm(), sender);  
        }

        private void DogovorPred_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
           // DogovotPredpriytia.Visible = true;
            OpenChildForm(new DogovotPredpriytia(), sender);
        }

        private void DogovorPost_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //DogovorPostForm.Visible = true;
            OpenChildForm(new DogovorPostForm(), sender);
        }
    }
}
