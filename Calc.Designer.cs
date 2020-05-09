namespace CalcV1
{
    partial class Calc
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.bttDec = new System.Windows.Forms.Button();
            this.bttBackspace = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tbDisplay.Location = new System.Drawing.Point(12, 12);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(352, 44);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TabStop = false;
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(182, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 4;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(182, 277);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(96, 277);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 8;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 7;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumpadClick);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(10, 363);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(252, 40);
            this.button0.TabIndex = 10;
            this.button0.Text = "button12";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumpadClick);
            // 
            // bttDec
            // 
            this.bttDec.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.bttDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bttDec.Location = new System.Drawing.Point(268, 105);
            this.bttDec.Name = "bttDec";
            this.bttDec.Size = new System.Drawing.Size(40, 80);
            this.bttDec.TabIndex = 11;
            this.bttDec.Text = ".";
            this.bttDec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttDec.UseVisualStyleBackColor = true;
            this.bttDec.Click += new System.EventHandler(this.bttDec_Click);
            // 
            // bttBackspace
            // 
            this.bttBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bttBackspace.Location = new System.Drawing.Point(12, 62);
            this.bttBackspace.Name = "bttBackspace";
            this.bttBackspace.Size = new System.Drawing.Size(352, 35);
            this.bttBackspace.TabIndex = 12;
            this.bttBackspace.Text = "⬅ ";
            this.bttBackspace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttBackspace.UseVisualStyleBackColor = true;
            this.bttBackspace.Click += new System.EventHandler(this.bttBackspace_Click);
            // 
            // btSign
            // 
            this.btSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btSign.Location = new System.Drawing.Point(268, 363);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(80, 40);
            this.btSign.TabIndex = 13;
            this.btSign.Text = "+/-";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.bttBackspace);
            this.Controls.Add(this.bttDec);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDisplay);
            this.Name = "Calc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button bttDec;
        private System.Windows.Forms.Button bttBackspace;
        private System.Windows.Forms.Button btSign;
    }
}

