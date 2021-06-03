
namespace KstTest
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
            this.TextBoxUnsorted = new System.Windows.Forms.RichTextBox();
            this.TextBoxSorted = new System.Windows.Forms.RichTextBox();
            this.LabelUnsorted = new System.Windows.Forms.Label();
            this.LabelSorted = new System.Windows.Forms.Label();
            this.ButtonRead = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonReadSort = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxUnsorted
            // 
            this.TextBoxUnsorted.Location = new System.Drawing.Point(12, 35);
            this.TextBoxUnsorted.Name = "TextBoxUnsorted";
            this.TextBoxUnsorted.Size = new System.Drawing.Size(362, 284);
            this.TextBoxUnsorted.TabIndex = 0;
            this.TextBoxUnsorted.Text = "";
            // 
            // TextBoxSorted
            // 
            this.TextBoxSorted.Location = new System.Drawing.Point(426, 35);
            this.TextBoxSorted.Name = "TextBoxSorted";
            this.TextBoxSorted.Size = new System.Drawing.Size(362, 284);
            this.TextBoxSorted.TabIndex = 1;
            this.TextBoxSorted.Text = "";
            // 
            // LabelUnsorted
            // 
            this.LabelUnsorted.AutoSize = true;
            this.LabelUnsorted.Location = new System.Drawing.Point(12, 14);
            this.LabelUnsorted.Name = "LabelUnsorted";
            this.LabelUnsorted.Size = new System.Drawing.Size(95, 15);
            this.LabelUnsorted.TabIndex = 2;
            this.LabelUnsorted.Text = "Unsorted Names";
            // 
            // LabelSorted
            // 
            this.LabelSorted.AutoSize = true;
            this.LabelSorted.Location = new System.Drawing.Point(426, 14);
            this.LabelSorted.Name = "LabelSorted";
            this.LabelSorted.Size = new System.Drawing.Size(81, 15);
            this.LabelSorted.TabIndex = 3;
            this.LabelSorted.Text = "Sorted Names";
            // 
            // ButtonRead
            // 
            this.ButtonRead.Location = new System.Drawing.Point(12, 325);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(362, 23);
            this.ButtonRead.TabIndex = 4;
            this.ButtonRead.Text = "Read Names";
            this.ButtonRead.UseVisualStyleBackColor = true;
            this.ButtonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(426, 325);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(362, 23);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "Sort Names";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonReadSort
            // 
            this.ButtonReadSort.Location = new System.Drawing.Point(300, 377);
            this.ButtonReadSort.Name = "ButtonReadSort";
            this.ButtonReadSort.Size = new System.Drawing.Size(91, 43);
            this.ButtonReadSort.TabIndex = 6;
            this.ButtonReadSort.Text = "Instant Sort and Save";
            this.ButtonReadSort.UseVisualStyleBackColor = true;
            this.ButtonReadSort.Click += new System.EventHandler(this.ButtonReadSort_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(411, 377);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(91, 43);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save To File";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonReadSort);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonRead);
            this.Controls.Add(this.LabelSorted);
            this.Controls.Add(this.LabelUnsorted);
            this.Controls.Add(this.TextBoxSorted);
            this.Controls.Add(this.TextBoxUnsorted);
            this.Name = "Form1";
            this.Text = "Name Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxUnsorted;
        private System.Windows.Forms.RichTextBox TextBoxSorted;
        private System.Windows.Forms.Label LabelUnsorted;
        private System.Windows.Forms.Label LabelSorted;
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonReadSort;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button button1;
    }
}

