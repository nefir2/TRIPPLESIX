
namespace TRIPPLESIX
{
    partial class calendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar4 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 1, 1, 0, 0, 0, 0), new System.DateTime(2022, 1, 7, 0, 0, 0, 0));
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.85061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.07358F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.00223F));
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.23688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.76311F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 667);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(205, 9);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 1, 7, 0, 0, 0, 0), new System.DateTime(2022, 1, 13, 0, 0, 0, 0));
            this.monthCalendar2.ShowWeekNumbers = true;
            this.monthCalendar2.TabIndex = 1;
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Location = new System.Drawing.Point(401, 9);
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 2, 1, 0, 0, 0, 0), new System.DateTime(2022, 2, 7, 0, 0, 0, 0));
            this.monthCalendar3.ShowWeekNumbers = true;
            this.monthCalendar3.TabIndex = 2;
            // 
            // monthCalendar4
            // 
            this.monthCalendar4.Location = new System.Drawing.Point(599, 9);
            this.monthCalendar4.Name = "monthCalendar4";
            this.monthCalendar4.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 1, 1, 0, 0, 0, 0), new System.DateTime(2022, 1, 7, 0, 0, 0, 0));
            this.monthCalendar4.ShowWeekNumbers = true;
            this.monthCalendar4.TabIndex = 3;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 667);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "calendar";
            this.Text = "calendar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MonthCalendar monthCalendar4;
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}