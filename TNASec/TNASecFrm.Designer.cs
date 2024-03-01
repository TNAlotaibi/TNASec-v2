namespace TNASec_v2
{
    partial class TNASecFrm
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDencrypt = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.keytxtBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.closelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(82, 116);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(114, 25);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.EnryptButtonClick);
            // 
            // btnDencrypt
            // 
            this.btnDencrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btnDencrypt.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnDencrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDencrypt.ForeColor = System.Drawing.Color.White;
            this.btnDencrypt.Location = new System.Drawing.Point(498, 116);
            this.btnDencrypt.Name = "btnDencrypt";
            this.btnDencrypt.Size = new System.Drawing.Size(108, 25);
            this.btnDencrypt.TabIndex = 2;
            this.btnDencrypt.Text = "Decrypt";
            this.btnDencrypt.UseVisualStyleBackColor = false;
            this.btnDencrypt.Click += new System.EventHandler(this.DecryptButtonClick);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(279, 116);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(113, 25);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy Result";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.CopyButtonClick);
            // 
            // keytxtBox
            // 
            this.keytxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.keytxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keytxtBox.ForeColor = System.Drawing.Color.Silver;
            this.keytxtBox.Location = new System.Drawing.Point(60, 79);
            this.keytxtBox.Name = "keytxtBox";
            this.keytxtBox.Size = new System.Drawing.Size(557, 14);
            this.keytxtBox.TabIndex = 4;
            this.keytxtBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.ForeColor = System.Drawing.Color.Silver;
            this.resultTextBox.Location = new System.Drawing.Point(47, 147);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(577, 161);
            this.resultTextBox.TabIndex = 7;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(3, 1);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(105, 25);
            this.titlelbl.TabIndex = 8;
            this.titlelbl.Text = "TNASec v2";
            this.titlelbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.titlelbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.titlelbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            // 
            // closelbl
            // 
            this.closelbl.AutoSize = true;
            this.closelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.closelbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closelbl.ForeColor = System.Drawing.Color.Red;
            this.closelbl.Location = new System.Drawing.Point(623, 1);
            this.closelbl.Name = "closelbl";
            this.closelbl.Size = new System.Drawing.Size(24, 25);
            this.closelbl.TabIndex = 9;
            this.closelbl.Text = "X";
            this.closelbl.Click += new System.EventHandler(this.closelbl_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(649, 1);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(648, 1);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(576, 1);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(561, 1);
            this.label6.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Cyan;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(577, 1);
            this.label8.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Cyan;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 161);
            this.label9.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Cyan;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(624, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1, 161);
            this.label10.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Cyan;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(645, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 32);
            this.label11.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Cyan;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 29);
            this.label12.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Cyan;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(561, 1);
            this.label13.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Cyan;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(57, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1, 18);
            this.label14.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Cyan;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(618, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1, 20);
            this.label15.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Cyan;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(618, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 20);
            this.label16.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Cyan;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(57, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1, 18);
            this.label17.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Cyan;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(57, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(561, 1);
            this.label18.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Cyan;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(57, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(561, 1);
            this.label19.TabIndex = 24;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox.ForeColor = System.Drawing.Color.Silver;
            this.inputTextBox.Location = new System.Drawing.Point(59, 49);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(557, 14);
            this.inputTextBox.TabIndex = 23;
            this.inputTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            // 
            // TNASecFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(646, 315);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closelbl);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.keytxtBox);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDencrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TNASecFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TNASec v2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this._MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDencrypt;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox keytxtBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label closelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

