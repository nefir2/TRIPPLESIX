
namespace TRIPPLESIX
{
    partial class conv
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
            this.button1 = new System.Windows.Forms.Button();
            this.tenBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelException = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sixteenBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eightBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.twoBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "к кнопочкам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Backer);
            // 
            // tenBox
            // 
            this.tenBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.tenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenBox.ForeColor = System.Drawing.Color.White;
            this.tenBox.Location = new System.Drawing.Point(94, 203);
            this.tenBox.Name = "tenBox";
            this.tenBox.Size = new System.Drawing.Size(822, 23);
            this.tenBox.TabIndex = 2;
            this.tenBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConvertBase);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "введите число, которое надо конвертировать в другие системы счисления:";
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelException, 2);
            this.labelException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelException.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelException.ForeColor = System.Drawing.Color.Maroon;
            this.labelException.Location = new System.Drawing.Point(3, 100);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(913, 100);
            this.labelException.TabIndex = 4;
            this.labelException.Text = "here will be exceptions if human write here not a number";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.twoBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.eightBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.sixteenBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tenBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelException, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.201681F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 597);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 100);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base10:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 85);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base16";
            // 
            // sixteenBox
            // 
            this.sixteenBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.sixteenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sixteenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixteenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixteenBox.ForeColor = System.Drawing.Color.White;
            this.sixteenBox.Location = new System.Drawing.Point(94, 303);
            this.sixteenBox.Name = "sixteenBox";
            this.sixteenBox.Size = new System.Drawing.Size(822, 23);
            this.sixteenBox.TabIndex = 7;
            this.sixteenBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConvertBase);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 85);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base8";
            // 
            // eightBox
            // 
            this.eightBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.eightBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightBox.ForeColor = System.Drawing.Color.White;
            this.eightBox.Location = new System.Drawing.Point(94, 388);
            this.eightBox.Name = "eightBox";
            this.eightBox.Size = new System.Drawing.Size(822, 23);
            this.eightBox.TabIndex = 9;
            this.eightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConvertBase);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 100);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base2";
            // 
            // twoBox
            // 
            this.twoBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.twoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.twoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoBox.ForeColor = System.Drawing.Color.White;
            this.twoBox.Location = new System.Drawing.Point(94, 473);
            this.twoBox.Name = "twoBox";
            this.twoBox.Size = new System.Drawing.Size(822, 23);
            this.twoBox.TabIndex = 11;
            this.twoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConvertBase);
            // 
            // conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(919, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "conv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "кновертер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closer);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tenBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox twoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eightBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sixteenBox;
        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}