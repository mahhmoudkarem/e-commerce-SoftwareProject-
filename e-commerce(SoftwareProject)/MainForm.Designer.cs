namespace e_commerce_SoftwareProject_
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Label();
            this.ordersBtn = new FontAwesome.Sharp.IconButton();
            this.usersBtn = new FontAwesome.Sharp.IconButton();
            this.categoriesBtn = new FontAwesome.Sharp.IconButton();
            this.customerBtn = new FontAwesome.Sharp.IconButton();
            this.productBtn = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 605);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.iconExit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.ordersBtn);
            this.panel2.Controls.Add(this.usersBtn);
            this.panel2.Controls.Add(this.categoriesBtn);
            this.panel2.Controls.Add(this.customerBtn);
            this.panel2.Controls.Add(this.productBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 131);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.iconExit.Location = new System.Drawing.Point(1202, -7);
            this.iconExit.Margin = new System.Windows.Forms.Padding(0);
            this.iconExit.Name = "iconExit";
            this.iconExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.iconExit.Size = new System.Drawing.Size(37, 42);
            this.iconExit.TabIndex = 12;
            this.iconExit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconExit.UseVisualStyleBackColor = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(961, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "ORDERS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(772, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "USERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "CATEGORIES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "CUSTOMERS";
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.BackColor = System.Drawing.Color.Navy;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Elephant", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(106, 110);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 18);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "PRODUCTS";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.Navy;
            this.ordersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.ForeColor = System.Drawing.Color.Navy;
            this.ordersBtn.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.ordersBtn.IconColor = System.Drawing.Color.White;
            this.ordersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ordersBtn.IconSize = 70;
            this.ordersBtn.Location = new System.Drawing.Point(963, 40);
            this.ordersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(80, 83);
            this.ordersBtn.TabIndex = 1;
            this.ordersBtn.UseVisualStyleBackColor = false;
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.Navy;
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.ForeColor = System.Drawing.Color.Navy;
            this.usersBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.usersBtn.IconColor = System.Drawing.Color.White;
            this.usersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersBtn.IconSize = 70;
            this.usersBtn.Location = new System.Drawing.Point(763, 40);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(0);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(80, 83);
            this.usersBtn.TabIndex = 1;
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackColor = System.Drawing.Color.Navy;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.ForeColor = System.Drawing.Color.Navy;
            this.categoriesBtn.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.categoriesBtn.IconColor = System.Drawing.Color.White;
            this.categoriesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.categoriesBtn.IconSize = 70;
            this.categoriesBtn.Location = new System.Drawing.Point(543, 40);
            this.categoriesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(80, 83);
            this.categoriesBtn.TabIndex = 2;
            this.categoriesBtn.UseVisualStyleBackColor = false;
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Navy;
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.ForeColor = System.Drawing.Color.Navy;
            this.customerBtn.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.customerBtn.IconColor = System.Drawing.Color.White;
            this.customerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.customerBtn.IconSize = 70;
            this.customerBtn.Location = new System.Drawing.Point(332, 40);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(0);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(80, 83);
            this.customerBtn.TabIndex = 1;
            this.customerBtn.UseVisualStyleBackColor = false;
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.Navy;
            this.productBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.ForeColor = System.Drawing.Color.Navy;
            this.productBtn.IconChar = FontAwesome.Sharp.IconChar.BagShopping;
            this.productBtn.IconColor = System.Drawing.Color.White;
            this.productBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productBtn.IconSize = 70;
            this.productBtn.Location = new System.Drawing.Point(115, 40);
            this.productBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(80, 83);
            this.productBtn.TabIndex = 0;
            this.productBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(276, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-Commerce Managment System";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 131);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1233, 474);
            this.mainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 679);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton productBtn;
        private FontAwesome.Sharp.IconButton ordersBtn;
        private FontAwesome.Sharp.IconButton usersBtn;
        private FontAwesome.Sharp.IconButton categoriesBtn;
        private FontAwesome.Sharp.IconButton customerBtn;
        private System.Windows.Forms.Label btnclear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconExit;
    }
}