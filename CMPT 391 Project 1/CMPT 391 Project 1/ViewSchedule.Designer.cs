namespace CMPT_391_Project_1
{
    partial class ViewSchedule
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
            this.fallScheduleBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winterScheduleBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fallScheduleBox
            // 
            this.fallScheduleBox.FormattingEnabled = true;
            this.fallScheduleBox.ItemHeight = 16;
            this.fallScheduleBox.Location = new System.Drawing.Point(80, 64);
            this.fallScheduleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fallScheduleBox.Name = "fallScheduleBox";
            this.fallScheduleBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.fallScheduleBox.Size = new System.Drawing.Size(260, 372);
            this.fallScheduleBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "WINTER SCHEDULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "FALL SCHEDULE";
            // 
            // winterScheduleBox
            // 
            this.winterScheduleBox.FormattingEnabled = true;
            this.winterScheduleBox.ItemHeight = 16;
            this.winterScheduleBox.Location = new System.Drawing.Point(445, 64);
            this.winterScheduleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winterScheduleBox.Name = "winterScheduleBox";
            this.winterScheduleBox.Size = new System.Drawing.Size(260, 372);
            this.winterScheduleBox.TabIndex = 5;
            this.winterScheduleBox.SelectedIndexChanged += new System.EventHandler(this.winterScheduleBox_SelectedIndexChanged);
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winterScheduleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fallScheduleBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewSchedule";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox fallScheduleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox winterScheduleBox;
    }
}