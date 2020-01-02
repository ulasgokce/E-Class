namespace EClass
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            this.rbAns1 = new System.Windows.Forms.RadioButton();
            this.rbAns2 = new System.Windows.Forms.RadioButton();
            this.rbAns3 = new System.Windows.Forms.RadioButton();
            this.rbAns4 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gbAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAns1
            // 
            this.rbAns1.AutoSize = true;
            this.rbAns1.Location = new System.Drawing.Point(62, 31);
            this.rbAns1.Name = "rbAns1";
            this.rbAns1.Size = new System.Drawing.Size(67, 17);
            this.rbAns1.TabIndex = 1;
            this.rbAns1.TabStop = true;
            this.rbAns1.Text = "1. cevap";
            this.rbAns1.UseVisualStyleBackColor = true;
            // 
            // rbAns2
            // 
            this.rbAns2.AutoSize = true;
            this.rbAns2.Location = new System.Drawing.Point(62, 55);
            this.rbAns2.Name = "rbAns2";
            this.rbAns2.Size = new System.Drawing.Size(67, 17);
            this.rbAns2.TabIndex = 2;
            this.rbAns2.TabStop = true;
            this.rbAns2.Text = "2. cevap";
            this.rbAns2.UseVisualStyleBackColor = true;
            // 
            // rbAns3
            // 
            this.rbAns3.AutoSize = true;
            this.rbAns3.Location = new System.Drawing.Point(62, 78);
            this.rbAns3.Name = "rbAns3";
            this.rbAns3.Size = new System.Drawing.Size(67, 17);
            this.rbAns3.TabIndex = 3;
            this.rbAns3.TabStop = true;
            this.rbAns3.Text = "3. cevap";
            this.rbAns3.UseVisualStyleBackColor = true;
            // 
            // rbAns4
            // 
            this.rbAns4.AutoSize = true;
            this.rbAns4.Location = new System.Drawing.Point(62, 101);
            this.rbAns4.Name = "rbAns4";
            this.rbAns4.Size = new System.Drawing.Size(67, 17);
            this.rbAns4.TabIndex = 4;
            this.rbAns4.TabStop = true;
            this.rbAns4.Text = "4. cevap";
            this.rbAns4.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(40, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(32, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Soru ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbAnswers
            // 
            this.gbAnswers.Controls.Add(this.rbAns1);
            this.gbAnswers.Controls.Add(this.rbAns2);
            this.gbAnswers.Controls.Add(this.rbAns3);
            this.gbAnswers.Controls.Add(this.rbAns4);
            this.gbAnswers.Location = new System.Drawing.Point(43, 172);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(367, 155);
            this.gbAnswers.TabIndex = 8;
            this.gbAnswers.TabStop = false;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(335, 333);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 9;
            this.btnNextQuestion.Text = "Sonraki Soru";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(360, 41);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(29, 13);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Süre";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 422);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Exam";
            this.Text = "Exam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exam_FormClosed);
            this.Load += new System.EventHandler(this.Exam_Load);
            this.gbAnswers.ResumeLayout(false);
            this.gbAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbAns1;
        private System.Windows.Forms.RadioButton rbAns2;
        private System.Windows.Forms.RadioButton rbAns3;
        private System.Windows.Forms.RadioButton rbAns4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblTimer;
    }
}