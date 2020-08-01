namespace FileTrim
{
    partial class RmvLettersForm
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
            this.let_filePathTextBox = new System.Windows.Forms.TextBox();
            this.let_browseBtn = new System.Windows.Forms.Button();
            this.let_cutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.let_newFileTextBox = new System.Windows.Forms.TextBox();
            this.let_manualBtn = new System.Windows.Forms.Button();
            this.let_confBtn = new System.Windows.Forms.Button();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // let_filePathTextBox
            // 
            this.let_filePathTextBox.Location = new System.Drawing.Point(37, 67);
            this.let_filePathTextBox.Name = "let_filePathTextBox";
            this.let_filePathTextBox.ReadOnly = true;
            this.let_filePathTextBox.Size = new System.Drawing.Size(594, 22);
            this.let_filePathTextBox.TabIndex = 1;
            // 
            // let_browseBtn
            // 
            this.let_browseBtn.Location = new System.Drawing.Point(37, 104);
            this.let_browseBtn.Name = "let_browseBtn";
            this.let_browseBtn.Size = new System.Drawing.Size(90, 34);
            this.let_browseBtn.TabIndex = 2;
            this.let_browseBtn.Text = "Browse";
            this.let_browseBtn.UseVisualStyleBackColor = true;
            this.let_browseBtn.Click += new System.EventHandler(this.let_browseBtn_Click);
            // 
            // let_cutBtn
            // 
            this.let_cutBtn.Location = new System.Drawing.Point(163, 104);
            this.let_cutBtn.Name = "let_cutBtn";
            this.let_cutBtn.Size = new System.Drawing.Size(95, 34);
            this.let_cutBtn.TabIndex = 3;
            this.let_cutBtn.Text = "Cut Name";
            this.let_cutBtn.UseVisualStyleBackColor = true;
            this.let_cutBtn.Click += new System.EventHandler(this.let_cutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "New file name:";
            // 
            // let_newFileTextBox
            // 
            this.let_newFileTextBox.Location = new System.Drawing.Point(37, 250);
            this.let_newFileTextBox.Name = "let_newFileTextBox";
            this.let_newFileTextBox.ReadOnly = true;
            this.let_newFileTextBox.Size = new System.Drawing.Size(594, 22);
            this.let_newFileTextBox.TabIndex = 5;
            // 
            // let_manualBtn
            // 
            this.let_manualBtn.Location = new System.Drawing.Point(37, 290);
            this.let_manualBtn.Name = "let_manualBtn";
            this.let_manualBtn.Size = new System.Drawing.Size(131, 34);
            this.let_manualBtn.TabIndex = 6;
            this.let_manualBtn.Text = "Manual Re-Entry";
            this.let_manualBtn.UseVisualStyleBackColor = true;
            this.let_manualBtn.Click += new System.EventHandler(this.let_manualBtn_Click);
            // 
            // let_confBtn
            // 
            this.let_confBtn.Location = new System.Drawing.Point(327, 360);
            this.let_confBtn.Name = "let_confBtn";
            this.let_confBtn.Size = new System.Drawing.Size(108, 41);
            this.let_confBtn.TabIndex = 7;
            this.let_confBtn.Text = "Confirm";
            this.let_confBtn.UseVisualStyleBackColor = true;
            this.let_confBtn.Click += new System.EventHandler(this.let_confBtn_Click);
            // 
            // RmvLettersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.let_confBtn);
            this.Controls.Add(this.let_manualBtn);
            this.Controls.Add(this.let_newFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.let_cutBtn);
            this.Controls.Add(this.let_browseBtn);
            this.Controls.Add(this.let_filePathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RmvLettersForm";
            this.Text = "FileTrim - Remove Letters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox let_filePathTextBox;
        private System.Windows.Forms.Button let_browseBtn;
        private System.Windows.Forms.Button let_cutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox let_newFileTextBox;
        private System.Windows.Forms.Button let_manualBtn;
        private System.Windows.Forms.Button let_confBtn;
    }
}