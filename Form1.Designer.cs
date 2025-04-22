namespace BMI_Calculator
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
            this.Registration = new System.Windows.Forms.GroupBox();
            this.weight_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.height_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.GroupBox();
            this.resulttext = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Registration.SuspendLayout();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.weight_textbox);
            this.Registration.Controls.Add(this.label2);
            this.Registration.Controls.Add(this.label1);
            this.Registration.Controls.Add(this.height_textbox);
            this.Registration.Controls.Add(this.button1);
            this.Registration.Location = new System.Drawing.Point(24, 12);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(518, 67);
            this.Registration.TabIndex = 0;
            this.Registration.TabStop = false;
            this.Registration.Text = "Registration";
            // 
            // weight_textbox
            // 
            this.weight_textbox.Location = new System.Drawing.Point(267, 24);
            this.weight_textbox.Name = "weight_textbox";
            this.weight_textbox.Size = new System.Drawing.Size(108, 20);
            this.weight_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight(kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height(cm)";
            // 
            // height_textbox
            // 
            this.height_textbox.Location = new System.Drawing.Point(78, 27);
            this.height_textbox.Name = "height_textbox";
            this.height_textbox.Size = new System.Drawing.Size(108, 20);
            this.height_textbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.Result.Controls.Add(this.resulttext);
            this.Result.Controls.Add(this.trackBar1);
            this.Result.Controls.Add(this.label9);
            this.Result.Controls.Add(this.label8);
            this.Result.Controls.Add(this.label7);
            this.Result.Controls.Add(this.label6);
            this.Result.Controls.Add(this.label5);
            this.Result.Controls.Add(this.label4);
            this.Result.Controls.Add(this.label3);
            this.Result.Location = new System.Drawing.Point(24, 85);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(518, 144);
            this.Result.TabIndex = 1;
            this.Result.TabStop = false;
            this.Result.Text = "Result";
            // 
            // resulttext
            // 
            this.resulttext.Location = new System.Drawing.Point(17, 103);
            this.resulttext.Name = "resulttext";
            this.resulttext.Size = new System.Drawing.Size(463, 28);
            this.resulttext.TabIndex = 6;
            this.resulttext.Text = "Your result can be seen here.";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 65);
            this.trackBar1.Maximum = 280;
            this.trackBar1.Minimum = 150;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(506, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 250;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Salmon;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Obesity";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSalmon;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Overweight";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Normal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Underweight";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "23";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "18.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 251);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Registration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox height_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.TextBox weight_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resulttext;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

