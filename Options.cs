using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dungeon_Teller
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();

            foreach (Control ctl in this.Controls)
            {
                if (ctl is CheckBox)
                {
                    ((CheckBox)ctl).CheckedChanged += new EventHandler(Button_Enable);
                }
                else if (ctl is RadioButton)
                {
                    ((RadioButton)ctl).CheckedChanged += new EventHandler(Button_Enable);
                }
                else if (ctl is TextBox)
                {
                    ((TextBox)ctl).TextChanged += new EventHandler(Button_Enable);
                }
                else if (ctl is NumericUpDown)
                {
                    ((NumericUpDown)ctl).ValueChanged += new EventHandler(Button_Enable);
                }
            }

        }

        void Button_Enable(object obj, EventArgs e)
        {
            btn_apply.Enabled = true;
        }

        private void Options_Load(object sender, EventArgs e)
        {

            if (cb_nma.Checked == true) toogleNMA();

        }


        private void toogleNMA()
        {
            tb_nma.Enabled = !tb_nma.Enabled;
            lnk_nma.Enabled = !lnk_nma.Enabled;
            lbl_nma.Enabled = !lbl_nma.Enabled;
            btn_nmaTest.Enabled = !btn_nmaTest.Enabled;
        }

        private void toogleProwl()
        {
            tb_prowl.Enabled = !tb_prowl.Enabled;
            lnk_prowl.Enabled = !lnk_prowl.Enabled;
            lbl_prowl.Enabled = !lbl_prowl.Enabled;
            btn_prowlTest.Enabled = !btn_prowlTest.Enabled;
        }

        private void toogleMail()
        {
            lbl_mailSMTP.Enabled = !lbl_mailSMTP.Enabled;
            lbl_mailAddress.Enabled = !lbl_mailAddress.Enabled;
            tb_mailTo.Enabled = !tb_mailTo.Enabled;
            tb_mailSMTP.Enabled = !tb_mailSMTP.Enabled;
            btn_mailTest.Enabled = !btn_mailTest.Enabled;
        }

        private void cb_nma_CheckedChanged(object sender, EventArgs e)
        {
            toogleNMA();
        }

        
        private void cb_prowl_CheckedChanged(object sender, EventArgs e)
        {
            toogleProwl();
        }

        private void cb_mail_CheckedChanged(object sender, EventArgs e)
        {
            toogleMail();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void applySettings()
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            applySettings();
            this.Hide();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            btn_apply.Enabled = false;
            applySettings();
        }


    }
}
