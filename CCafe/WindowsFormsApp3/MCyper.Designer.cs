namespace WindowsFormsApp3
{
    partial class MCyper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OTBTN = new System.Windows.Forms.Button();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.ManageBTN = new System.Windows.Forms.Button();
            this.EditFDBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsolesDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.GamesDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.RoomsDGV = new System.Windows.Forms.DataGridView();
            this.AddCBTN = new System.Windows.Forms.Button();
            this.AddGBTN = new System.Windows.Forms.Button();
            this.AddRBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsolesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLp
            // 
            this.UserNameLp.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.UserNameLp.Location = new System.Drawing.Point(0, 200);
            this.UserNameLp.Name = "UserNameLp";
            this.UserNameLp.Size = new System.Drawing.Size(382, 45);
            this.UserNameLp.TabIndex = 6;
            this.UserNameLp.Text = "MANAGER";
            this.UserNameLp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.OTBTN);
            this.panel1.Controls.Add(this.HomeBTN);
            this.panel1.Controls.Add(this.UserNameLp);
            this.panel1.Controls.Add(this.ManageBTN);
            this.panel1.Controls.Add(this.EditFDBTN);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 720);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 84);
            this.panel3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 84);
            this.label2.TabIndex = 26;
            this.label2.Text = "EDIT CYBER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OTBTN
            // 
            this.OTBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OTBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OTBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OTBTN.FlatAppearance.BorderSize = 0;
            this.OTBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OTBTN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTBTN.ForeColor = System.Drawing.Color.White;
            this.OTBTN.Location = new System.Drawing.Point(0, 636);
            this.OTBTN.Margin = new System.Windows.Forms.Padding(0);
            this.OTBTN.Name = "OTBTN";
            this.OTBTN.Size = new System.Drawing.Size(382, 84);
            this.OTBTN.TabIndex = 28;
            this.OTBTN.Text = "OFFERS/TOURNMENTS";
            this.OTBTN.UseVisualStyleBackColor = false;
            this.OTBTN.Click += new System.EventHandler(this.OTBTN_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeBTN.FlatAppearance.BorderSize = 0;
            this.HomeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBTN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.ForeColor = System.Drawing.Color.White;
            this.HomeBTN.Location = new System.Drawing.Point(0, 300);
            this.HomeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(382, 84);
            this.HomeBTN.TabIndex = 27;
            this.HomeBTN.Text = "HOME";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // ManageBTN
            // 
            this.ManageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ManageBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManageBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ManageBTN.FlatAppearance.BorderSize = 0;
            this.ManageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageBTN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBTN.ForeColor = System.Drawing.Color.White;
            this.ManageBTN.Location = new System.Drawing.Point(0, 468);
            this.ManageBTN.Margin = new System.Windows.Forms.Padding(0);
            this.ManageBTN.Name = "ManageBTN";
            this.ManageBTN.Size = new System.Drawing.Size(382, 84);
            this.ManageBTN.TabIndex = 25;
            this.ManageBTN.Text = "MANAGE";
            this.ManageBTN.UseVisualStyleBackColor = false;
            this.ManageBTN.Click += new System.EventHandler(this.ManageBTN_Click);
            // 
            // EditFDBTN
            // 
            this.EditFDBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditFDBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditFDBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditFDBTN.FlatAppearance.BorderSize = 0;
            this.EditFDBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFDBTN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFDBTN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EditFDBTN.Location = new System.Drawing.Point(0, 384);
            this.EditFDBTN.Margin = new System.Windows.Forms.Padding(0);
            this.EditFDBTN.Name = "EditFDBTN";
            this.EditFDBTN.Size = new System.Drawing.Size(382, 84);
            this.EditFDBTN.TabIndex = 24;
            this.EditFDBTN.Text = "EDIT FOOD AND DRINKS";
            this.EditFDBTN.UseVisualStyleBackColor = false;
            this.EditFDBTN.Click += new System.EventHandler(this.EditFDBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(408, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Consoles";
            // 
            // ConsolesDGV
            // 
            this.ConsolesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConsolesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsolesDGV.Location = new System.Drawing.Point(413, 76);
            this.ConsolesDGV.Name = "ConsolesDGV";
            this.ConsolesDGV.RowHeadersWidth = 51;
            this.ConsolesDGV.RowTemplate.Height = 26;
            this.ConsolesDGV.Size = new System.Drawing.Size(614, 170);
            this.ConsolesDGV.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(408, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Games";
            // 
            // GamesDGV
            // 
            this.GamesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GamesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GamesDGV.Location = new System.Drawing.Point(413, 291);
            this.GamesDGV.Name = "GamesDGV";
            this.GamesDGV.RowHeadersWidth = 51;
            this.GamesDGV.RowTemplate.Height = 26;
            this.GamesDGV.Size = new System.Drawing.Size(614, 170);
            this.GamesDGV.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(408, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rooms";
            // 
            // RoomsDGV
            // 
            this.RoomsDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDGV.Location = new System.Drawing.Point(413, 507);
            this.RoomsDGV.Name = "RoomsDGV";
            this.RoomsDGV.RowHeadersWidth = 51;
            this.RoomsDGV.RowTemplate.Height = 26;
            this.RoomsDGV.Size = new System.Drawing.Size(614, 170);
            this.RoomsDGV.TabIndex = 26;
            // 
            // AddCBTN
            // 
            this.AddCBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.AddCBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddCBTN.FlatAppearance.BorderSize = 0;
            this.AddCBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCBTN.ForeColor = System.Drawing.Color.White;
            this.AddCBTN.Location = new System.Drawing.Point(1051, 196);
            this.AddCBTN.Name = "AddCBTN";
            this.AddCBTN.Size = new System.Drawing.Size(203, 50);
            this.AddCBTN.TabIndex = 30;
            this.AddCBTN.Text = "ADD";
            this.AddCBTN.UseVisualStyleBackColor = false;
            // 
            // AddGBTN
            // 
            this.AddGBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.AddGBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddGBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddGBTN.FlatAppearance.BorderSize = 0;
            this.AddGBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGBTN.ForeColor = System.Drawing.Color.White;
            this.AddGBTN.Location = new System.Drawing.Point(1051, 411);
            this.AddGBTN.Name = "AddGBTN";
            this.AddGBTN.Size = new System.Drawing.Size(203, 50);
            this.AddGBTN.TabIndex = 31;
            this.AddGBTN.Text = "ADD";
            this.AddGBTN.UseVisualStyleBackColor = false;
            // 
            // AddRBTN
            // 
            this.AddRBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.AddRBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddRBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRBTN.FlatAppearance.BorderSize = 0;
            this.AddRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRBTN.ForeColor = System.Drawing.Color.White;
            this.AddRBTN.Location = new System.Drawing.Point(1051, 627);
            this.AddRBTN.Name = "AddRBTN";
            this.AddRBTN.Size = new System.Drawing.Size(203, 50);
            this.AddRBTN.TabIndex = 32;
            this.AddRBTN.Text = "ADD";
            this.AddRBTN.UseVisualStyleBackColor = false;
            // 
            // MCyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.AddRBTN);
            this.Controls.Add(this.AddGBTN);
            this.Controls.Add(this.AddCBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RoomsDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GamesDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsolesDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MCyper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEditC";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsolesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UserNameLp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsolesDGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OTBTN;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button ManageBTN;
        private System.Windows.Forms.Button EditFDBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GamesDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView RoomsDGV;
        private System.Windows.Forms.Button AddCBTN;
        private System.Windows.Forms.Button AddGBTN;
        private System.Windows.Forms.Button AddRBTN;
    }
}