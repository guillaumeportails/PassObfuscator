using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassObfuscator
{
    public partial class FormPass : Form
    {
        public FormPass ()
        {
            InitializeComponent ();
            checkBox1_CheckedChanged (null, null);
        }

        private void checkBox1_CheckedChanged (object sender, EventArgs e)
        {
            textBoxClear.PasswordChar = (checkBoxHide.Checked) ? '#' : '\0';
        }

        private void textBoxClear_TextChanged (object sender, EventArgs e)
        {
            textBoxPass.Text = Jam (textBoxClear.Text);
        }

        private void buttonCopy_Click (object sender, EventArgs e)
        {
            Clipboard.SetText (textBoxPass.Text);
        }


        private String mSet = "abcdefghijklmnopqrstuvwxyz0123456789"; //ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private String Jam (String c)
        {
            StringBuilder o = new StringBuilder (c.Length);

            // Calculer une graine, de facon non commutative
            int s32 = 9821 * c.Length + 211327;
            for (int i = 0; i < c.Length; ++i) s32 = (s32 << 1) ^ ((int)c[i]);

            // Egrainer le generateur pseudo-alea
            for (int i = 0; i < c.Length; ++i)
            {
                s32 = 9821 * s32 + 211327;

                int j = s32 % mSet.Length;
                if (j < 0) j += mSet.Length;
                o.Append (mSet[j]);
            }
            return o.ToString();
        }

    }
}
