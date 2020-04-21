namespace loginpage
{
    partial class REGForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxcmp = new System.Windows.Forms.TextBox();
            this.textBoxurn = new System.Windows.Forms.TextBox();
            this.textBoxln = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxemadd = new System.Windows.Forms.TextBox();
            this.textBoxfn = new System.Windows.Forms.TextBox();
            this.buttonsub = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BackgroundImage = global::loginpage.Properties.Resources._407526_2534622765018_1237046617_1986534_1507684888_n;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBoxcmp);
            this.panel1.Controls.Add(this.textBoxurn);
            this.panel1.Controls.Add(this.textBoxln);
            this.panel1.Controls.Add(this.textBoxpass);
            this.panel1.Controls.Add(this.textBoxemadd);
            this.panel1.Controls.Add(this.textBoxfn);
            this.panel1.Controls.Add(this.buttonsub);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 368);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxcmp
            // 
            this.textBoxcmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcmp.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxcmp.Location = new System.Drawing.Point(234, 251);
            this.textBoxcmp.Multiline = true;
            this.textBoxcmp.Name = "textBoxcmp";
            this.textBoxcmp.Size = new System.Drawing.Size(190, 31);
            this.textBoxcmp.TabIndex = 6;
            this.textBoxcmp.Text = "Confirm Password";
            this.textBoxcmp.Enter += new System.EventHandler(this.textBoxcmp_Enter);
            this.textBoxcmp.Leave += new System.EventHandler(this.textBoxcmp_Leave);
            // 
            // textBoxurn
            // 
            this.textBoxurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxurn.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxurn.Location = new System.Drawing.Point(86, 197);
            this.textBoxurn.Multiline = true;
            this.textBoxurn.Name = "textBoxurn";
            this.textBoxurn.Size = new System.Drawing.Size(274, 31);
            this.textBoxurn.TabIndex = 6;
            this.textBoxurn.Text = "Username";
            this.textBoxurn.Enter += new System.EventHandler(this.textBoxurn_Enter);
            this.textBoxurn.Leave += new System.EventHandler(this.textBoxurn_Leave);
            // 
            // textBoxln
            // 
            this.textBoxln.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxln.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxln.Location = new System.Drawing.Point(234, 95);
            this.textBoxln.Multiline = true;
            this.textBoxln.Name = "textBoxln";
            this.textBoxln.Size = new System.Drawing.Size(190, 31);
            this.textBoxln.TabIndex = 6;
            this.textBoxln.Text = "Last Name";
            this.textBoxln.Enter += new System.EventHandler(this.textBoxln_Enter);
            this.textBoxln.Leave += new System.EventHandler(this.textBoxln_Leave);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxpass.Location = new System.Drawing.Point(23, 251);
            this.textBoxpass.Multiline = true;
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(190, 31);
            this.textBoxpass.TabIndex = 6;
            this.textBoxpass.Text = "Password";
            this.textBoxpass.Enter += new System.EventHandler(this.textBoxpass_Enter);
            this.textBoxpass.Leave += new System.EventHandler(this.textBoxpass_Leave);
            // 
            // textBoxemadd
            // 
            this.textBoxemadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxemadd.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxemadd.Location = new System.Drawing.Point(23, 144);
            this.textBoxemadd.Multiline = true;
            this.textBoxemadd.Name = "textBoxemadd";
            this.textBoxemadd.Size = new System.Drawing.Size(401, 31);
            this.textBoxemadd.TabIndex = 6;
            this.textBoxemadd.Text = "Email Address";
            this.textBoxemadd.Enter += new System.EventHandler(this.textBoxemadd_Enter);
            this.textBoxemadd.Leave += new System.EventHandler(this.textBoxemadd_Leave);
            // 
            // textBoxfn
            // 
            this.textBoxfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfn.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxfn.Location = new System.Drawing.Point(23, 95);
            this.textBoxfn.Multiline = true;
            this.textBoxfn.Name = "textBoxfn";
            this.textBoxfn.Size = new System.Drawing.Size(190, 31);
            this.textBoxfn.TabIndex = 200;
            this.textBoxfn.Text = "First Name";
            this.textBoxfn.Click += new System.EventHandler(this.gh);
            this.textBoxfn.Enter += new System.EventHandler(this.textBoxfn_Enter);
            this.textBoxfn.Leave += new System.EventHandler(this.textBoxfn_Leave);
            // 
            // buttonsub
            // 
            this.buttonsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonsub.FlatAppearance.BorderSize = 0;
            this.buttonsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsub.ForeColor = System.Drawing.Color.White;
            this.buttonsub.Location = new System.Drawing.Point(169, 309);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(103, 43);
            this.buttonsub.TabIndex = 5;
            this.buttonsub.Text = "SUBMIT";
            this.buttonsub.UseVisualStyleBackColor = false;
            this.buttonsub.Click += new System.EventHandler(this.buttonsub_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 89);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(434, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCOUNT INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // REGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 368);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGForm";
            this.Text = "REGForm";
            this.Load += new System.EventHandler(this.REGForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcmp;
        private System.Windows.Forms.TextBox textBoxurn;
        private System.Windows.Forms.TextBox textBoxln;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxemadd;
        private System.Windows.Forms.TextBox textBoxfn;
    }
}