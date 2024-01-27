namespace TodoWinformApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                CheckBox checkbox = new CheckBox();
                checkbox.AutoSize = true;
                checkbox.Name = "checkbox" + i.ToString();
                checkbox.Text = "checkbox" + i.ToString();
                checkbox.MouseClick += checkBox_MouseClick;
                checkbox.Size = new Size(159, 36);
                Controls.Add(checkbox);

            }
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
