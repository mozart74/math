namespace Math
{
    partial class frmMath
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
            lblN1 = new Label();
            lblSign = new Label();
            lblN2 = new Label();
            lblEqualSign = new Label();
            txtAnswer = new TextBox();
            lblAnswer = new Label();
            lblReminder = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            txtRealAnswer = new TextBox();
            lblReadRemainder = new Label();
            txtRealRemainder = new TextBox();
            SuspendLayout();
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(12, 9);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(38, 15);
            lblN1.TabIndex = 0;
            lblN1.Text = "label1";
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Location = new Point(56, 9);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(38, 15);
            lblSign.TabIndex = 2;
            lblSign.Text = "label2";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(100, 9);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(38, 15);
            lblN2.TabIndex = 3;
            lblN2.Text = "label3";
            lblN2.Click += label3_Click;
            // 
            // lblEqualSign
            // 
            lblEqualSign.AutoSize = true;
            lblEqualSign.Location = new Point(144, 9);
            lblEqualSign.Name = "lblEqualSign";
            lblEqualSign.Size = new Size(15, 15);
            lblEqualSign.TabIndex = 4;
            lblEqualSign.Text = "=";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(220, 6);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(47, 23);
            txtAnswer.TabIndex = 5;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(165, 9);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(46, 15);
            lblAnswer.TabIndex = 6;
            lblAnswer.Text = "&Answer";
            lblAnswer.Click += lblAnswer_Click;
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Location = new Point(286, 9);
            lblReminder.Name = "Remainder";
            lblReminder.Size = new Size(64, 15);
            lblReminder.TabIndex = 7;
            lblReminder.Text = "&Remainder";
            lblReminder.Click += label1_Click_2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(220, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 38);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "R&eal Answer";
            label1.Click += label1_Click_3;
            // 
            // txtRealAnswer
            // 
            txtRealAnswer.Location = new Point(217, 35);
            txtRealAnswer.Name = "txtRealAnswer";
            txtRealAnswer.Size = new Size(50, 23);
            txtRealAnswer.TabIndex = 11;
            txtRealAnswer.TextChanged += textBox2_TextChanged_1;
            // 
            // lblReadRemainder
            // 
            lblReadRemainder.AutoSize = true;
            lblReadRemainder.Location = new Point(273, 38);
            lblReadRemainder.Name = "lblReadRemainder";
            lblReadRemainder.Size = new Size(89, 15);
            lblReadRemainder.TabIndex = 12;
            lblReadRemainder.Text = "Real Ra&mainder";
            // 
            // txtRealRemainder
            // 
            txtRealRemainder.Location = new Point(356, 35);
            txtRealRemainder.Name = "txtRealRemainder";
            txtRealRemainder.Size = new Size(57, 23);
            txtRealRemainder.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 137);
            Controls.Add(txtRealRemainder);
            Controls.Add(lblReadRemainder);
            Controls.Add(txtRealAnswer);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblReminder);
            Controls.Add(lblAnswer);
            Controls.Add(txtAnswer);
            Controls.Add(lblEqualSign);
            Controls.Add(lblN2);
            Controls.Add(lblSign);
            Controls.Add(lblN1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN1;
        private Label lblSign;
        private Label lblN2;
        private Label lblEqualSign;
        private TextBox txtAnswer;
        private Label lblAnswer;
        private Label lblReminder;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private TextBox txtRealAnswer;
        private Label lblReadRemainder;
        private TextBox txtRealRemainder;
    }
}
