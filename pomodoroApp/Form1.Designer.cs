namespace pomodoroApp
{
    partial class Form1
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
            BakingCake = new TextBox();
            WorkDuration = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            WaitingTime = new Label();
            ButtonStart = new Button();
            ButtonStop = new Button();
            label4 = new Label();
            label5 = new Label();
            ShortBreak = new NumericUpDown();
            LongBreak = new NumericUpDown();
            Lapse = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)WorkDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShortBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LongBreak).BeginInit();
            SuspendLayout();
            // 
            // BakingCake
            // 
            BakingCake.BackColor = SystemColors.ActiveCaption;
            BakingCake.Location = new Point(19, 18);
            BakingCake.Multiline = true;
            BakingCake.Name = "BakingCake";
            BakingCake.Size = new Size(765, 40);
            BakingCake.TabIndex = 0;
            BakingCake.Text = "Baking a Cake";
            // 
            // WorkDuration
            // 
            WorkDuration.Location = new Point(89, 83);
            WorkDuration.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            WorkDuration.Name = "WorkDuration";
            WorkDuration.Size = new Size(115, 27);
            WorkDuration.TabIndex = 1;
            WorkDuration.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 85);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "minute";
            // 
            // WaitingTime
            // 
            WaitingTime.AutoSize = true;
            WaitingTime.Font = new Font("Tw Cen MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WaitingTime.Location = new Point(342, 232);
            WaitingTime.Name = "WaitingTime";
            WaitingTime.Size = new Size(148, 70);
            WaitingTime.TabIndex = 4;
            WaitingTime.Text = "25:00";
            // 
            // ButtonStart
            // 
            ButtonStart.BackColor = Color.MediumSpringGreen;
            ButtonStart.Location = new Point(244, 334);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(148, 56);
            ButtonStart.TabIndex = 5;
            ButtonStart.Text = "Start";
            ButtonStart.UseVisualStyleBackColor = false;
            // 
            // ButtonStop
            // 
            ButtonStop.BackColor = Color.LightCoral;
            ButtonStop.Location = new Point(425, 334);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(140, 56);
            ButtonStop.TabIndex = 6;
            ButtonStop.Text = "Stop";
            ButtonStop.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 133);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Short Break";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 174);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 8;
            label5.Text = "Long Break";
            // 
            // ShortBreak
            // 
            ShortBreak.Location = new Point(144, 131);
            ShortBreak.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            ShortBreak.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            ShortBreak.Name = "ShortBreak";
            ShortBreak.Size = new Size(60, 27);
            ShortBreak.TabIndex = 9;
            ShortBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // LongBreak
            // 
            LongBreak.Location = new Point(144, 174);
            LongBreak.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            LongBreak.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            LongBreak.Name = "LongBreak";
            LongBreak.Size = new Size(60, 27);
            LongBreak.TabIndex = 10;
            LongBreak.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // Lapse
            // 
            Lapse.AutoSize = true;
            Lapse.Location = new Point(43, 232);
            Lapse.Name = "Lapse";
            Lapse.Size = new Size(47, 20);
            Lapse.TabIndex = 11;
            Lapse.Text = "Lapse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 174);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 12;
            label7.Text = "Breaking time 4:59";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 542);
            Controls.Add(label7);
            Controls.Add(Lapse);
            Controls.Add(LongBreak);
            Controls.Add(ShortBreak);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ButtonStop);
            Controls.Add(ButtonStart);
            Controls.Add(WaitingTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WorkDuration);
            Controls.Add(BakingCake);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)WorkDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShortBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)LongBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BakingCake;
        private NumericUpDown WorkDuration;
        private Label label1;
        private Label label2;
        private Label WaitingTime;
        private Button ButtonStart;
        private Button ButtonStop;
        private Label label4;
        private Label label5;
        private NumericUpDown ShortBreak;
        private NumericUpDown LongBreak;
        private Label Lapse;
        private Label label7;
    }
}
