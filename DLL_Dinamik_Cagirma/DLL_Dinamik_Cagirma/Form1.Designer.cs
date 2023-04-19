namespace DLL_Dinamik_Cagirma
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
            this.button1 = new System.Windows.Forms.Button();
            this.Sayi1Txt = new System.Windows.Forms.TextBox();
            this.Sayi2Txt = new System.Windows.Forms.TextBox();
            this.SonucTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sayi1Txt
            // 
            this.Sayi1Txt.Location = new System.Drawing.Point(320, 89);
            this.Sayi1Txt.Name = "Sayi1Txt";
            this.Sayi1Txt.Size = new System.Drawing.Size(100, 22);
            this.Sayi1Txt.TabIndex = 1;
            // 
            // Sayi2Txt
            // 
            this.Sayi2Txt.Location = new System.Drawing.Point(320, 117);
            this.Sayi2Txt.Name = "Sayi2Txt";
            this.Sayi2Txt.Size = new System.Drawing.Size(100, 22);
            this.Sayi2Txt.TabIndex = 2;
            // 
            // SonucTxt
            // 
            this.SonucTxt.Location = new System.Drawing.Point(320, 187);
            this.SonucTxt.Name = "SonucTxt";
            this.SonucTxt.Size = new System.Drawing.Size(100, 22);
            this.SonucTxt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SonucTxt);
            this.Controls.Add(this.Sayi2Txt);
            this.Controls.Add(this.Sayi1Txt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sayi1Txt;
        private System.Windows.Forms.TextBox Sayi2Txt;
        private System.Windows.Forms.TextBox SonucTxt;
    }
}

