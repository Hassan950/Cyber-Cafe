namespace CCafe
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.SignUPBTN = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignInBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RePasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // SignUPBTN
            // 
            this.SignUPBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUPBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignUPBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUPBTN.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUPBTN.ForeColor = System.Drawing.Color.White;
            this.SignUPBTN.Location = new System.Drawing.Point(434, 485);
            this.SignUPBTN.Margin = new System.Windows.Forms.Padding(0);
            this.SignUPBTN.Name = "SignUPBTN";
            this.SignUPBTN.Size = new System.Drawing.Size(413, 71);
            this.SignUPBTN.TabIndex = 12;
            this.SignUPBTN.Text = "SIGN UP";
            this.SignUPBTN.UseVisualStyleBackColor = false;
            this.SignUPBTN.Click += new System.EventHandler(this.SignUPBTN_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(434, 281);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(412, 32);
            this.PasswordTB.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 600);
            this.panel1.TabIndex = 6;
            // 
            // SignInBTN
            // 
            this.SignInBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignInBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignInBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignInBTN.FlatAppearance.BorderSize = 0;
            this.SignInBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBTN.ForeColor = System.Drawing.Color.White;
            this.SignInBTN.Location = new System.Drawing.Point(686, 0);
            this.SignInBTN.Margin = new System.Windows.Forms.Padding(0);
            this.SignInBTN.Name = "SignInBTN";
            this.SignInBTN.Size = new System.Drawing.Size(135, 48);
            this.SignInBTN.TabIndex = 10;
            this.SignInBTN.Text = "SIGN IN";
            this.SignInBTN.UseVisualStyleBackColor = false;
            this.SignInBTN.Click += new System.EventHandler(this.SignInBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Retype Password";
            // 
            // RePasswordTB
            // 
            this.RePasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RePasswordTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordTB.Location = new System.Drawing.Point(434, 390);
            this.RePasswordTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RePasswordTB.Name = "RePasswordTB";
            this.RePasswordTB.PasswordChar = '*';
            this.RePasswordTB.Size = new System.Drawing.Size(412, 32);
            this.RePasswordTB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "User ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserNameTB
            // 
            this.UserNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.Location = new System.Drawing.Point(434, 171);
            this.UserNameTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(412, 32);
            this.UserNameTB.TabIndex = 21;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RePasswordTB);
            this.Controls.Add(this.SignInBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUPBTN);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUPBTN;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SignInBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RePasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTB;
    }
}