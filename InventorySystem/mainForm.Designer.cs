﻿
namespace InventorySystem
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.viewStocks = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.viewOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // viewStocks
            // 
            this.viewStocks.BackColor = System.Drawing.Color.LightGreen;
            this.viewStocks.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.viewStocks.FlatAppearance.BorderSize = 0;
            this.viewStocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStocks.Location = new System.Drawing.Point(505, 247);
            this.viewStocks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewStocks.Name = "viewStocks";
            this.viewStocks.Size = new System.Drawing.Size(184, 40);
            this.viewStocks.TabIndex = 0;
            this.viewStocks.Text = "View Stocks";
            this.viewStocks.UseVisualStyleBackColor = false;
            this.viewStocks.Click += new System.EventHandler(this.viewStocks_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.LightGreen;
            this.addUser.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.addUser.Location = new System.Drawing.Point(132, 486);
            this.addUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(197, 45);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.LightGreen;
            this.logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logOut.Location = new System.Drawing.Point(505, 486);
            this.logOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(194, 45);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewOrders
            // 
            this.viewOrders.BackColor = System.Drawing.Color.LightGreen;
            this.viewOrders.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.viewOrders.FlatAppearance.BorderSize = 0;
            this.viewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrders.Location = new System.Drawing.Point(145, 251);
            this.viewOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewOrders.Name = "viewOrders";
            this.viewOrders.Size = new System.Drawing.Size(184, 36);
            this.viewOrders.TabIndex = 0;
            this.viewOrders.Text = "View Orders";
            this.viewOrders.UseVisualStyleBackColor = false;
            this.viewOrders.Click += new System.EventHandler(this.viewOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(527, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(165, 335);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(527, 333);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 131);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(234, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "INVENTARY MANAGMENT SYSTEM";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(815, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.viewOrders);
            this.Controls.Add(this.viewStocks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewStocks;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button viewOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}