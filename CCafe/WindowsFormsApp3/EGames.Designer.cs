namespace WindowsFormsApp3
{
    partial class EGames
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
            this.UserNameLp = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FoodBTN = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLp
            // 
            this.UserNameLp.AutoSize = true;
            this.UserNameLp.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.UserNameLp.Location = new System.Drawing.Point(68, 244);
            this.UserNameLp.Name = "UserNameLp";
            this.UserNameLp.Size = new System.Drawing.Size(229, 46);
            this.UserNameLp.TabIndex = 6;
            this.UserNameLp.Text = "EMPLOYEE#";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(26, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(336, 205);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UserNameLp);
            this.panel1.Controls.Add(this.FoodBTN);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 720);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(798, 648);
            this.dataGridView1.TabIndex = 2;
            // 
            // FoodBTN
            // 
            this.FoodBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FoodBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FoodBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FoodBTN.FlatAppearance.BorderSize = 0;
            this.FoodBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodBTN.Font = new System.Drawing.Font("Tahoma", 18F);
            this.FoodBTN.ForeColor = System.Drawing.Color.White;
            this.FoodBTN.Location = new System.Drawing.Point(0, 490);
            this.FoodBTN.Margin = new System.Windows.Forms.Padding(0);
            this.FoodBTN.Name = "FoodBTN";
            this.FoodBTN.Size = new System.Drawing.Size(382, 84);
            this.FoodBTN.TabIndex = 5;
            this.FoodBTN.Text = "FOOD AND DRINKS";
            this.FoodBTN.UseVisualStyleBackColor = false;
            this.FoodBTN.Click += new System.EventHandler(this.FoodBTN_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Tahoma", 18F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(382, 84);
            this.HomeBtn.TabIndex = 21;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 84);
            this.panel2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label7.Location = new System.Drawing.Point(0, 406);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 84);
            this.label7.TabIndex = 21;
            this.label7.Text = "GAMES";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // EGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserNameLp;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button FoodBTN;
        private System.Windows.Forms.Label label7;
    }
}

