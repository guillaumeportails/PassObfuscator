namespace PassObfuscator
{
    partial class FormPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.textBoxClear = new System.Windows.Forms.TextBox ();
            this.checkBoxHide = new System.Windows.Forms.CheckBox ();
            this.textBoxPass = new System.Windows.Forms.TextBox ();
            this.buttonCopy = new System.Windows.Forms.Button ();
            this.SuspendLayout ();
            // 
            // textBoxClear
            // 
            this.textBoxClear.Location = new System.Drawing.Point (13, 13);
            this.textBoxClear.Name = "textBoxClear";
            this.textBoxClear.PasswordChar = '#';
            this.textBoxClear.Size = new System.Drawing.Size (243, 26);
            this.textBoxClear.TabIndex = 0;
            this.textBoxClear.TextChanged += new System.EventHandler (this.textBoxClear_TextChanged);
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHide.Location = new System.Drawing.Point (262, 15);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size (56, 20);
            this.checkBoxHide.TabIndex = 1;
            this.checkBoxHide.Text = "Hide";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler (this.checkBox1_CheckedChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPass.Location = new System.Drawing.Point (13, 51);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ReadOnly = true;
            this.textBoxPass.Size = new System.Drawing.Size (243, 26);
            this.textBoxPass.TabIndex = 2;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font ("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy.Location = new System.Drawing.Point (263, 53);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size (62, 23);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler (this.buttonCopy_Click);
            // 
            // FormPass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size (337, 93);
            this.Controls.Add (this.buttonCopy);
            this.Controls.Add (this.textBoxPass);
            this.Controls.Add (this.checkBoxHide);
            this.Controls.Add (this.textBoxClear);
            this.Font = new System.Drawing.Font ("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPass";
            this.Text = "String obfuscator";
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClear;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonCopy;
    }
}

