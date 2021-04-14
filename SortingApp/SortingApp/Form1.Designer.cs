
namespace SortingApp
{
    partial class frmMain
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
            this.btnSort = new System.Windows.Forms.Button();
            this.txbNumbers = new System.Windows.Forms.TextBox();
            this.lblAsk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(235, 195);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(187, 33);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sorba rendez";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txbNumbers
            // 
            this.txbNumbers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txbNumbers.Location = new System.Drawing.Point(12, 85);
            this.txbNumbers.Name = "txbNumbers";
            this.txbNumbers.Size = new System.Drawing.Size(408, 29);
            this.txbNumbers.TabIndex = 4;
            this.txbNumbers.TextChanged += new System.EventHandler(this.txbNumbers_TextChanged);
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAsk.ForeColor = System.Drawing.Color.White;
            this.lblAsk.Location = new System.Drawing.Point(12, 43);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(408, 21);
            this.lblAsk.TabIndex = 3;
            this.lblAsk.Text = "Kérem adjon meg egy számsort, tetszőleges elválasztóval:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(434, 240);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txbNumbers);
            this.Controls.Add(this.lblAsk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.TextBox txbNumbers;
        private System.Windows.Forms.Label lblAsk;
    }
}

