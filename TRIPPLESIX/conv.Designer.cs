
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conv));
            this.button1 = new System.Windows.Forms.Button();
            this.tenBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelException = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twoBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eightBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sixteenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "к кнопочкам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Backer);
            // 
            // tenBox
            // 
            this.tenBox.BackColor = System.Drawing.Color.White;
            this.tenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenBox.ForeColor = System.Drawing.Color.Black;
            this.tenBox.Location = new System.Drawing.Point(90, 78);
            this.tenBox.MaxLength = 19;
            this.tenBox.Name = "tenBox";
            this.tenBox.Size = new System.Drawing.Size(777, 23);
            this.tenBox.TabIndex = 0;
            this.tenBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConverterBase);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "кнвретр десятичных чисел в другие системы счисления.";
            // 
            // labelException
            // 
            this.labelException.AutoSize = true;
            this.labelException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelException.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelException.ForeColor = System.Drawing.Color.Maroon;
            this.labelException.Location = new System.Drawing.Point(90, 150);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(777, 75);
            this.labelException.TabIndex = 4;
            this.labelException.Text = "here will be exceptions for humans";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.twoBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.eightBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.sixteenBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tenBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelException, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.91562F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.91563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.91563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.91873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.91873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.91662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.499044F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(870, 477);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 75);
            this.label6.TabIndex = 13;
            this.label6.Text = "ошибки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 75);
            this.label2.TabIndex = 12;
            this.label2.Text = "ввод:";
            // 
            // twoBox
            // 
            this.twoBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.twoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoBox.ForeColor = System.Drawing.Color.White;
            this.twoBox.Location = new System.Drawing.Point(90, 378);
            this.twoBox.Name = "twoBox";
            this.twoBox.ReadOnly = true;
            this.twoBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.twoBox.Size = new System.Drawing.Size(777, 30);
            this.twoBox.TabIndex = 11;
            this.twoBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConverterBase);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 75);
            this.label5.TabIndex = 10;
            this.label5.Text = "Base2";
            // 
            // eightBox
            // 
            this.eightBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.eightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eightBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightBox.ForeColor = System.Drawing.Color.White;
            this.eightBox.Location = new System.Drawing.Point(90, 303);
            this.eightBox.Name = "eightBox";
            this.eightBox.ReadOnly = true;
            this.eightBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eightBox.Size = new System.Drawing.Size(777, 30);
            this.eightBox.TabIndex = 9;
            this.eightBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConverterBase);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 75);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base8";
            // 
            // sixteenBox
            // 
            this.sixteenBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.sixteenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sixteenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixteenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixteenBox.ForeColor = System.Drawing.Color.White;
            this.sixteenBox.Location = new System.Drawing.Point(90, 228);
            this.sixteenBox.Name = "sixteenBox";
            this.sixteenBox.ReadOnly = true;
            this.sixteenBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sixteenBox.Size = new System.Drawing.Size(777, 30);
            this.sixteenBox.TabIndex = 7;
            this.sixteenBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConverterBase);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 75);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base16";
            // 
            // conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(870, 477);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}