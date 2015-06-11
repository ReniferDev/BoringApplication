namespace BoringApplication
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
            this.ConsoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsoleRichTextBox
            // 
            this.ConsoleRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsoleRichTextBox.Location = new System.Drawing.Point(12, 150);
            this.ConsoleRichTextBox.Name = "ConsoleRichTextBox";
            this.ConsoleRichTextBox.Size = new System.Drawing.Size(673, 271);
            this.ConsoleRichTextBox.TabIndex = 0;
            this.ConsoleRichTextBox.Text = "";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(12, 118);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(128, 17);
            this.ConsoleLabel.TabIndex = 1;
            this.ConsoleLabel.Text = "Tu będzie konsola:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 433);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.ConsoleRichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "BoringApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleRichTextBox;
        private System.Windows.Forms.Label ConsoleLabel;
    }
}

