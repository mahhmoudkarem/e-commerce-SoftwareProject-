namespace e_commerce_SoftwareProject_
{
    partial class UserModuleForm
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
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formUserName = new System.Windows.Forms.TextBox();
            this.formFullName = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.Label();
            this.formPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.formRepass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.iconExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 45);
            this.panel1.TabIndex = 0;
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
            this.iconExit.Location = new System.Drawing.Point(652, -7);
            this.iconExit.Margin = new System.Windows.Forms.Padding(0);
            this.iconExit.Name = "iconExit";
            this.iconExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.iconExit.Size = new System.Drawing.Size(37, 42);
            this.iconExit.TabIndex = 14;
            this.iconExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username :";
            // 
            // formUserName
            // 
            this.formUserName.Location = new System.Drawing.Point(199, 84);
            this.formUserName.Name = "formUserName";
            this.formUserName.Size = new System.Drawing.Size(407, 26);
            this.formUserName.TabIndex = 4;
            // 
            // formFullName
            // 
            this.formFullName.Location = new System.Drawing.Point(199, 128);
            this.formFullName.Name = "formFullName";
            this.formFullName.Size = new System.Drawing.Size(407, 26);
            this.formFullName.TabIndex = 6;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(36, 127);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(131, 26);
            this.FullName.TabIndex = 5;
            this.FullName.Text = "Full Name :";
            // 
            // formPassword
            // 
            this.formPassword.Location = new System.Drawing.Point(199, 176);
            this.formPassword.Name = "formPassword";
            this.formPassword.Size = new System.Drawing.Size(407, 26);
            this.formPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password :";
            // 
            // formPhone
            // 
            this.formPhone.Location = new System.Drawing.Point(199, 263);
            this.formPhone.Name = "formPhone";
            this.formPhone.Size = new System.Drawing.Size(407, 26);
            this.formPhone.TabIndex = 10;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(36, 262);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(87, 26);
            this.Phone.TabIndex = 9;
            this.Phone.Text = "Phone :";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(553, 314);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(92, 42);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.Location = new System.Drawing.Point(455, 314);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(92, 42);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Navy;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Transparent;
            this.saveBtn.Location = new System.Drawing.Point(357, 314);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 42);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // formRepass
            // 
            this.formRepass.Location = new System.Drawing.Point(199, 219);
            this.formRepass.Name = "formRepass";
            this.formRepass.Size = new System.Drawing.Size(407, 26);
            this.formRepass.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "RePassword :";
            // 
            // UserModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 370);
            this.Controls.Add(this.formRepass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.formPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.formPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formFullName);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.formUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Phone;
        private FontAwesome.Sharp.IconButton iconExit;
        public System.Windows.Forms.Button ClearBtn;
        public System.Windows.Forms.Button UpdateBtn;
        public System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.TextBox formUserName;
        public System.Windows.Forms.TextBox formFullName;
        public System.Windows.Forms.TextBox formPassword;
        public System.Windows.Forms.TextBox formPhone;
        public System.Windows.Forms.TextBox formRepass;
        private System.Windows.Forms.Label label3;
    }
}