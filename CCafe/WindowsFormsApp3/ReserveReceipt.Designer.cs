namespace CCafe
{
    partial class ReserveReceipt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.AddTourn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Trajan Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(235, 37);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(171, 29);
            this.StartDatePicker.TabIndex = 55;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.Label1.Location = new System.Drawing.Point(37, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(179, 23);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Reservation Date";
            // 
            // AddTourn
            // 
            this.AddTourn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.AddTourn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTourn.ForeColor = System.Drawing.Color.White;
            this.AddTourn.Location = new System.Drawing.Point(326, 506);
            this.AddTourn.Name = "AddTourn";
            this.AddTourn.Size = new System.Drawing.Size(154, 50);
            this.AddTourn.TabIndex = 58;
            this.AddTourn.Text = "Print";
            this.AddTourn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTourn.Click += new System.EventHandler(this.AddTourn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(230)))), ((int)(((byte)(164)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(559, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 50);
            this.label2.TabIndex = 59;
            this.label2.Text = "View";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReserveReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 565);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTourn);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReserveReceipt";
            this.ShowIcon = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label AddTourn;
        private System.Windows.Forms.Label label2;
    }
}