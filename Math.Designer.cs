namespace Math
{
    partial class Math
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
            lblRemainder = new Label();
            txtRemainder = new TextBox();
            lblRealAnswer = new Label();
            txtRealAnswer = new TextBox();
            lblRealRemainder = new Label();
            txtRealRemainder = new TextBox();
            btnEnter = new Button();
            textBox1 = new TextBox();
            l = new Label();
            SuspendLayout();
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(12, 9);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(0, 15);
            lblN1.TabIndex = 0;
            lblN1.Click += lblN1_Click;
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Location = new Point(56, 9);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(0, 15);
            lblSign.TabIndex = 2;
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(100, 9);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(0, 15);
            lblN2.TabIndex = 3;
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
            // 
            // lblRemainder
            // 
            lblRemainder.AutoSize = true;
            lblRemainder.Location = new Point(286, 9);
            lblRemainder.Name = "lblRemainder";
            lblRemainder.Size = new Size(64, 15);
            lblRemainder.TabIndex = 7;
            lblRemainder.Text = "Remainder";
            lblRemainder.Click += lblRemainder_Click;
            // 
            // txtRemainder
            // 
            txtRemainder.Location = new Point(356, 6);
            txtRemainder.Name = "txtRemainder";
            txtRemainder.Size = new Size(57, 23);
            txtRemainder.TabIndex = 8;
            // 
            // lblRealAnswer
            // 
            lblRealAnswer.AutoSize = true;
            lblRealAnswer.Location = new Point(140, 38);
            lblRealAnswer.Name = "lblRealAnswer";
            lblRealAnswer.Size = new Size(71, 15);
            lblRealAnswer.TabIndex = 10;
            lblRealAnswer.Text = "R&eal Answer";
            lblRealAnswer.Click += label1_Click_3;
            // 
            // txtRealAnswer
            // 
            txtRealAnswer.Location = new Point(217, 35);
            txtRealAnswer.Name = "txtRealAnswer";
            txtRealAnswer.Size = new Size(50, 23);
            txtRealAnswer.TabIndex = 11;
            // 
            // lblRealRemainder
            // 
            lblRealRemainder.AutoSize = true;
            lblRealRemainder.Location = new Point(273, 38);
            lblRealRemainder.Name = "lblRealRemainder";
            lblRealRemainder.Size = new Size(89, 15);
            lblRealRemainder.TabIndex = 12;
            lblRealRemainder.Text = "Real Ra&mainder";
            // 
            // txtRealRemainder
            // 
            txtRealRemainder.Location = new Point(374, 35);
            txtRealRemainder.Name = "txtRealRemainder";
            txtRealRemainder.Size = new Size(57, 23);
            txtRealRemainder.TabIndex = 13;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(220, 102);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 23);
            textBox1.TabIndex = 14;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(144, 38);
            l.Name = "l";
            l.Size = new Size(71, 15);
            l.TabIndex = 15;
            l.Text = "Real Answer";
            l.Click += label1_Click;
            // 
            // Math
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 137);
            Controls.Add(l);
            Controls.Add(textBox1);
            Controls.Add(txtRealRemainder);
            Controls.Add(lblRealRemainder);
            Controls.Add(txtRealAnswer);
            Controls.Add(btnEnter);
            Controls.Add(lblRemainder);
            Controls.Add(lblAnswer);
            Controls.Add(txtAnswer);
            Controls.Add(lblEqualSign);
            Controls.Add(lblN2);
            Controls.Add(lblSign);
            Controls.Add(lblN1);
            Name = "Math";
            Text = "frmMath";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblReminder_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblN1;
        private Label lblSign;
        private Label lblN2;
        private Label lblEqualSign;
        private TextBox txtAnswer;
        private Label lblAnswer;
        private Label lblRemainder;
        private TextBox txtRemainder;
        private Button btnEnter;
        private Label lblRealAnswer;
        private TextBox txtRealAnswer;
        private Label lblRealRemainder;
        private TextBox txtRealRemainder;
        private TextBox textBox1;
        private Label l;
    }
}
