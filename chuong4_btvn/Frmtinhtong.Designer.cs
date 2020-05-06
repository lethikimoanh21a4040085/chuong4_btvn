namespace chuong4_btvn
{
    partial class Frmtinhtong
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.bnttinhtong = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " nhap a =";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(239, 75);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txta, "Nhap so nguyen a");
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nhap b =";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(239, 116);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtb, "Nhap so nguyen b");
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
            // 
            // bnttinhtong
            // 
            this.bnttinhtong.Location = new System.Drawing.Point(133, 181);
            this.bnttinhtong.Name = "bnttinhtong";
            this.bnttinhtong.Size = new System.Drawing.Size(75, 23);
            this.bnttinhtong.TabIndex = 4;
            this.bnttinhtong.Text = "tong";
            this.bnttinhtong.UseVisualStyleBackColor = true;
            this.bnttinhtong.Click += new System.EventHandler(this.bnttinhtong_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(275, 181);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(75, 23);
            this.btnlamlai.TabIndex = 5;
            this.btnlamlai.Text = "lam lai";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(399, 181);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "tong cac so tu a den b";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "nhap so nguyen";
            // 
            // Frmtinhtong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.bnttinhtong);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Name = "Frmtinhtong";
            this.Text = "Frmtinhtong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button bnttinhtong;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}