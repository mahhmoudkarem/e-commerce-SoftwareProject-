namespace e_commerce_SoftwareProject_
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formPass = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Label();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel1.Controls.Add(this.iconPictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.iconExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(390, 67);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Navy;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(56, 64);
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 27, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(265, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-Commerce Managment System";
            // 
            // formName
            // 
            this.formName.Location = new System.Drawing.Point(45, 249);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(285, 26);
            this.formName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // formPass
            // 
            this.formPass.ForeColor = System.Drawing.Color.Black;
            this.formPass.Location = new System.Drawing.Point(45, 334);
            this.formPass.Name = "formPass";
            this.formPass.Size = new System.Drawing.Size(285, 26);
            this.formPass.TabIndex = 3;
            this.formPass.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Navy;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBtn.Location = new System.Drawing.Point(80, 394);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(208, 43);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 93;
            this.iconPictureBox1.Location = new System.Drawing.Point(141, 84);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(93, 96);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(138, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please Login";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxpass.Font = new System.Drawing.Font("Elephant", 7F);
            this.checkBoxpass.Location = new System.Drawing.Point(186, 474);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(144, 22);
            this.checkBoxpass.TabIndex = 9;
            this.checkBoxpass.Text = "Show Passowrd";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Navy;
            this.btnclear.Location = new System.Drawing.Point(66, 474);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(46, 18);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconExit.BackColor = System.Drawing.Color.Navy;
            this.iconExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExit.ForeColor = System.Drawing.Color.Navy;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.iconExit.IconColor = System.Drawing.Color.Red;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 30;
            this.iconExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconExit.Location = new System.Drawing.Point(357, 0);
            this.iconExit.Margin = new System.Windows.Forms.Padding(0);
            this.iconExit.Name = "iconExit";
            this.iconExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.iconExit.Size = new System.Drawing.Size(32, 76);
            this.iconExit.TabIndex = 11;
            this.iconExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 574);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Login";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox formName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox formPass;
        private System.Windows.Forms.Button loginBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnclear;
        public System.Windows.Forms.CheckBox checkBoxpass;
        private FontAwesome.Sharp.IconButton iconExit;
    }
}

