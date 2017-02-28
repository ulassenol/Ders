namespace Sinav_01
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
            this.dgvIlk = new System.Windows.Forms.DataGridView();
            this.dgvDescSonuc = new System.Windows.Forms.DataGridView();
            this.dgvASCSonuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASCSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIlk
            // 
            this.dgvIlk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlk.Location = new System.Drawing.Point(0, 0);
            this.dgvIlk.Name = "dgvIlk";
            this.dgvIlk.Size = new System.Drawing.Size(431, 206);
            this.dgvIlk.TabIndex = 0;
            // 
            // dgvDescSonuc
            // 
            this.dgvDescSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescSonuc.Location = new System.Drawing.Point(448, 0);
            this.dgvDescSonuc.Name = "dgvDescSonuc";
            this.dgvDescSonuc.Size = new System.Drawing.Size(380, 206);
            this.dgvDescSonuc.TabIndex = 1;
            // 
            // dgvASCSonuc
            // 
            this.dgvASCSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASCSonuc.Location = new System.Drawing.Point(0, 228);
            this.dgvASCSonuc.Name = "dgvASCSonuc";
            this.dgvASCSonuc.Size = new System.Drawing.Size(431, 231);
            this.dgvASCSonuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 461);
            this.Controls.Add(this.dgvASCSonuc);
            this.Controls.Add(this.dgvDescSonuc);
            this.Controls.Add(this.dgvIlk);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASCSonuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIlk;
        private System.Windows.Forms.DataGridView dgvDescSonuc;
        private System.Windows.Forms.DataGridView dgvASCSonuc;
    }
}

