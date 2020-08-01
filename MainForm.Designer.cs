namespace FileTrim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.letterBtn = new System.Windows.Forms.RadioButton();
            this.numberBtn = new System.Windows.Forms.RadioButton();
            this.mainConfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileTrim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "This tool was designed to remove specified characters from file names.\r\nBe sure t" +
    "he selected folder is the one you want, otherwise, any changes cannot be undone." +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "By: Armani Jay Rivera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "I would like to remove:";
            // 
            // letterBtn
            // 
            this.letterBtn.AutoSize = true;
            this.letterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterBtn.Location = new System.Drawing.Point(68, 277);
            this.letterBtn.Name = "letterBtn";
            this.letterBtn.Size = new System.Drawing.Size(74, 22);
            this.letterBtn.TabIndex = 4;
            this.letterBtn.TabStop = true;
            this.letterBtn.Text = "Letters";
            this.letterBtn.UseVisualStyleBackColor = true;
            this.letterBtn.CheckedChanged += new System.EventHandler(this.letterBtn_CheckedChanged);
            // 
            // numberBtn
            // 
            this.numberBtn.AutoSize = true;
            this.numberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBtn.Location = new System.Drawing.Point(68, 318);
            this.numberBtn.Name = "numberBtn";
            this.numberBtn.Size = new System.Drawing.Size(90, 22);
            this.numberBtn.TabIndex = 5;
            this.numberBtn.TabStop = true;
            this.numberBtn.Text = "Numbers";
            this.numberBtn.UseVisualStyleBackColor = true;
            // 
            // mainConfBtn
            // 
            this.mainConfBtn.Location = new System.Drawing.Point(333, 371);
            this.mainConfBtn.Name = "mainConfBtn";
            this.mainConfBtn.Size = new System.Drawing.Size(135, 38);
            this.mainConfBtn.TabIndex = 6;
            this.mainConfBtn.Text = "Confirm";
            this.mainConfBtn.UseVisualStyleBackColor = true;
            this.mainConfBtn.Click += new System.EventHandler(this.mainConfBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainConfBtn);
            this.Controls.Add(this.numberBtn);
            this.Controls.Add(this.letterBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FileTrim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton letterBtn;
        private System.Windows.Forms.RadioButton numberBtn;
        private System.Windows.Forms.Button mainConfBtn;
    }
}

