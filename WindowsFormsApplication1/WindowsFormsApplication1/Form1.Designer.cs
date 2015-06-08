namespace WindowsFormsApplication1
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.binario_button = new System.Windows.Forms.Button();
            this.decimal_button = new System.Windows.Forms.Button();
            this.hexa_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox.Location = new System.Drawing.Point(12, 12);
            this.textbox.MaxLength = 10;
            this.textbox.Name = "textbox";
            this.textbox.ReadOnly = true;
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 0;
            this.textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // binario_button
            // 
            this.binario_button.Location = new System.Drawing.Point(12, 38);
            this.binario_button.Name = "binario_button";
            this.binario_button.Size = new System.Drawing.Size(75, 23);
            this.binario_button.TabIndex = 1;
            this.binario_button.Text = "Binário";
            this.binario_button.UseVisualStyleBackColor = true;
            this.binario_button.Click += new System.EventHandler(this.binario_Click);
            // 
            // decimal_button
            // 
            this.decimal_button.Location = new System.Drawing.Point(12, 67);
            this.decimal_button.Name = "decimal_button";
            this.decimal_button.Size = new System.Drawing.Size(75, 23);
            this.decimal_button.TabIndex = 2;
            this.decimal_button.Text = "Decimal";
            this.decimal_button.UseVisualStyleBackColor = true;
            this.decimal_button.Click += new System.EventHandler(this.decimal_Click);
            // 
            // hexa_button
            // 
            this.hexa_button.Location = new System.Drawing.Point(12, 96);
            this.hexa_button.Name = "hexa_button";
            this.hexa_button.Size = new System.Drawing.Size(87, 23);
            this.hexa_button.TabIndex = 3;
            this.hexa_button.Text = "Hexadecimal";
            this.hexa_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 110);
            this.button1.TabIndex = 4;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Igual_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(12, 144);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(28, 23);
            this.button_1.TabIndex = 9;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Number_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(12, 173);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(28, 23);
            this.button_0.TabIndex = 12;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.Number_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(118, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 39);
            this.button6.TabIndex = 13;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.C_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hexa_button);
            this.Controls.Add(this.decimal_button);
            this.Controls.Add(this.binario_button);
            this.Controls.Add(this.textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button binario_button;
        private System.Windows.Forms.Button decimal_button;
        private System.Windows.Forms.Button hexa_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button6;
    }
}

