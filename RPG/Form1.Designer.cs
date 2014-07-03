namespace RPG
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.strBox = new System.Windows.Forms.TextBox();
            this.dexBox = new System.Windows.Forms.TextBox();
            this.conBox = new System.Windows.Forms.TextBox();
            this.intBox = new System.Windows.Forms.TextBox();
            this.wisBox = new System.Windows.Forms.TextBox();
            this.chaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(120, 226);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 3;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(13, 94);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(100, 20);
            this.strBox.TabIndex = 4;
            // 
            // dexBox
            // 
            this.dexBox.Location = new System.Drawing.Point(120, 93);
            this.dexBox.Name = "dexBox";
            this.dexBox.Size = new System.Drawing.Size(100, 20);
            this.dexBox.TabIndex = 5;
            // 
            // conBox
            // 
            this.conBox.Location = new System.Drawing.Point(13, 121);
            this.conBox.Name = "conBox";
            this.conBox.Size = new System.Drawing.Size(100, 20);
            this.conBox.TabIndex = 6;
            // 
            // intBox
            // 
            this.intBox.Location = new System.Drawing.Point(120, 120);
            this.intBox.Name = "intBox";
            this.intBox.Size = new System.Drawing.Size(100, 20);
            this.intBox.TabIndex = 7;
            // 
            // wisBox
            // 
            this.wisBox.Location = new System.Drawing.Point(13, 148);
            this.wisBox.Name = "wisBox";
            this.wisBox.Size = new System.Drawing.Size(100, 20);
            this.wisBox.TabIndex = 8;
            // 
            // chaBox
            // 
            this.chaBox.Location = new System.Drawing.Point(120, 148);
            this.chaBox.Name = "chaBox";
            this.chaBox.Size = new System.Drawing.Size(100, 20);
            this.chaBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chaBox);
            this.Controls.Add(this.wisBox);
            this.Controls.Add(this.intBox);
            this.Controls.Add(this.conBox);
            this.Controls.Add(this.dexBox);
            this.Controls.Add(this.strBox);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.TextBox dexBox;
        private System.Windows.Forms.TextBox conBox;
        private System.Windows.Forms.TextBox intBox;
        private System.Windows.Forms.TextBox wisBox;
        private System.Windows.Forms.TextBox chaBox;

    }
}