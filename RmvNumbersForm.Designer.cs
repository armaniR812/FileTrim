namespace FileTrim
{
    partial class RmvNumbersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.num_filePathTextBox = new System.Windows.Forms.TextBox();
            this.num_browseBtn = new System.Windows.Forms.Button();
            this.num_cutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_newFileTextBox = new System.Windows.Forms.TextBox();
            this.num_manualBtn = new System.Windows.Forms.Button();
            this.num_confBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select file(s) to rename:";
            // 
            // num_filePathTextBox
            // 
            this.num_filePathTextBox.Location = new System.Drawing.Point(37, 68);
            this.num_filePathTextBox.Name = "num_filePathTextBox";
            this.num_filePathTextBox.ReadOnly = true;
            this.num_filePathTextBox.Size = new System.Drawing.Size(594, 22);
            this.num_filePathTextBox.TabIndex = 1;
            // 
            // num_browseBtn
            // 
            this.num_browseBtn.Location = new System.Drawing.Point(37, 105);
            this.num_browseBtn.Name = "num_browseBtn";
            this.num_browseBtn.Size = new System.Drawing.Size(91, 35);
            this.num_browseBtn.TabIndex = 2;
            this.num_browseBtn.Text = "Browse";
            this.num_browseBtn.UseVisualStyleBackColor = true;
            this.num_browseBtn.Click += new System.EventHandler(this.num_browseBtn_Click);
            // 
            // num_cutBtn
            // 
            this.num_cutBtn.Location = new System.Drawing.Point(162, 105);
            this.num_cutBtn.Name = "num_cutBtn";
            this.num_cutBtn.Size = new System.Drawing.Size(93, 35);
            this.num_cutBtn.TabIndex = 3;
            this.num_cutBtn.Text = "Cut Name";
            this.num_cutBtn.UseVisualStyleBackColor = true;
            this.num_cutBtn.Click += new System.EventHandler(this.num_cutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "New file name:";
            // 
            // num_newFileTextBox
            // 
            this.num_newFileTextBox.Location = new System.Drawing.Point(37, 251);
            this.num_newFileTextBox.Name = "num_newFileTextBox";
            this.num_newFileTextBox.ReadOnly = true;
            this.num_newFileTextBox.Size = new System.Drawing.Size(594, 22);
            this.num_newFileTextBox.TabIndex = 5;
            // 
            // num_manualBtn
            // 
            this.num_manualBtn.Location = new System.Drawing.Point(37, 290);
            this.num_manualBtn.Name = "num_manualBtn";
            this.num_manualBtn.Size = new System.Drawing.Size(136, 35);
            this.num_manualBtn.TabIndex = 6;
            this.num_manualBtn.Text = "Manual Re-Entry";
            this.num_manualBtn.UseVisualStyleBackColor = true;
            this.num_manualBtn.Click += new System.EventHandler(this.num_manualBtn_Click);
            // 
            // num_confBtn
            // 
            this.num_confBtn.Location = new System.Drawing.Point(326, 359);
            this.num_confBtn.Name = "num_confBtn";
            this.num_confBtn.Size = new System.Drawing.Size(108, 39);
            this.num_confBtn.TabIndex = 7;
            this.num_confBtn.Text = "Confirm";
            this.num_confBtn.UseVisualStyleBackColor = true;
            this.num_confBtn.Click += new System.EventHandler(this.num_confBtn_Click);
            // 
            // RmvNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_confBtn);
            this.Controls.Add(this.num_manualBtn);
            this.Controls.Add(this.num_newFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_cutBtn);
            this.Controls.Add(this.num_browseBtn);
            this.Controls.Add(this.num_filePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RmvNumbersForm";
            this.Text = "FileTrim - Remove Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_filePathTextBox;
        private System.Windows.Forms.Button num_browseBtn;
        private System.Windows.Forms.Button num_cutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num_newFileTextBox;
        private System.Windows.Forms.Button num_manualBtn;
        private System.Windows.Forms.Button num_confBtn;
    }
}