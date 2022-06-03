using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWin_Last
{
    public partial class MainForm : Form
    {
        private Button currentBtn;
        private Form activeForm = new Form();
        public MainForm()
        {
            InitializeComponent();
            bnt_Back.Visible = false;
        }

        private void disableButton()
        {
            foreach (Control prevBtn in pn_menu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.MediumAquamarine;
                    prevBtn.ForeColor = Color.Black;
                }
            }
        }
        private void activeButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    disableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(16, 65, 39);
                    currentBtn.ForeColor = Color.White;
                    bnt_Back.Visible = true;
                }
            }
        }
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_child.Controls.Add(childForm);
            pn_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }

        private void btn_Suat_Click(object sender, EventArgs e)
        {
            openChildForm(new Suat(), sender);
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer(), sender);
        }

        private void btn_Phim_Click(object sender, EventArgs e)
        {
            openChildForm(new Phim(), sender);
           
        }

        private void btn_Ptich_Click(object sender, EventArgs e)
        {
            openChildForm(new Analystic(), sender);
        }

        private void bnt_Back_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            disableButton();
            lbl_Title.Text = "HOME";
            currentBtn = null;
            bnt_Back.Visible = false;
        }

        
    }
}
