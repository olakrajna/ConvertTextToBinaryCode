namespace zadanie_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string[] dane = new string[500];
        private string[] dane_reversed = new string[500];
        private string ciag_binarny;
        private string[] wiadomosc_odebrana_odwrocona = new string[500];
        private string wiadomosc_odebrana;
        private int i;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nadajnik = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.odbiornik = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.endButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(348, 160);
            this.textBox1.TabIndex = 0;
            // 
            // nadajnik
            // 
            this.nadajnik.AutoSize = true;
            this.nadajnik.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nadajnik.Location = new System.Drawing.Point(113, 12);
            this.nadajnik.Name = "nadajnik";
            this.nadajnik.Size = new System.Drawing.Size(121, 28);
            this.nadajnik.TabIndex = 1;
            this.nadajnik.Text = "NADAJNIK";
            this.nadajnik.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(407, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(348, 160);
            this.textBox2.TabIndex = 0;
            this.textBox2.UseWaitCursor = true;
            // 
            // odbiornik
            // 
            this.odbiornik.AutoSize = true;
            this.odbiornik.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.odbiornik.Location = new System.Drawing.Point(509, 12);
            this.odbiornik.Name = "odbiornik";
            this.odbiornik.Size = new System.Drawing.Size(130, 28);
            this.odbiornik.TabIndex = 1;
            this.odbiornik.Text = "ODBIORNIK";
            this.odbiornik.Click += new System.EventHandler(this.label1_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LightCoral;
            this.sendButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Location = new System.Drawing.Point(92, 219);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(142, 34);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "WYŚLIJ";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightCoral;
            this.clearButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(497, 219);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(142, 34);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "WYCZYŚĆ";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kod binarny:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 310);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(743, 94);
            this.textBox3.TabIndex = 6;
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.LightCoral;
            this.endButton.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endButton.Location = new System.Drawing.Point(312, 270);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(110, 34);
            this.endButton.TabIndex = 7;
            this.endButton.Text = "ZAKOŃCZ";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(767, 416);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.odbiornik);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nadajnik);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS232 symulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nadajnik;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label odbiornik;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button endButton;
    }
}

