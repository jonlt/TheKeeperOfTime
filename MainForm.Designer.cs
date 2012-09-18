namespace TheKeeperOfTime
{
    partial class MainForm
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
            this.allDay = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allDay
            // 
            this.allDay.Location = new System.Drawing.Point(12, 39);
            this.allDay.Multiline = true;
            this.allDay.Name = "allDay";
            this.allDay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.allDay.Size = new System.Drawing.Size(551, 102);
            this.allDay.TabIndex = 2;
            this.allDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.allDay_KeyDown);
            this.allDay.Leave += new System.EventHandler(this.allDay_Leave);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 11);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(551, 20);
            this.input.TabIndex = 1;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 153);
            this.Controls.Add(this.input);
            this.Controls.Add(this.allDay);
            this.Name = "MainForm";
            this.Text = "The Keeper of Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox allDay;
        private System.Windows.Forms.TextBox input;
    }
}

