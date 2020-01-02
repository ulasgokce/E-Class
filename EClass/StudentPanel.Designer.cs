namespace EClass
{
    partial class StudentPanel
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.btnPrevExamReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(71, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Öğrenci İsmi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Günlük Sınavı Başlat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav Geçmişini Incele :";
            // 
            // btnStartExam
            // 
            this.btnStartExam.Location = new System.Drawing.Point(9, 128);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(75, 23);
            this.btnStartExam.TabIndex = 3;
            this.btnStartExam.Text = "Başlat";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // btnPrevExamReview
            // 
            this.btnPrevExamReview.Location = new System.Drawing.Point(165, 128);
            this.btnPrevExamReview.Name = "btnPrevExamReview";
            this.btnPrevExamReview.Size = new System.Drawing.Size(75, 23);
            this.btnPrevExamReview.TabIndex = 4;
            this.btnPrevExamReview.Text = "İncele";
            this.btnPrevExamReview.UseVisualStyleBackColor = true;
            this.btnPrevExamReview.Click += new System.EventHandler(this.btnPrevExamReview_Click);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 262);
            this.Controls.Add(this.btnPrevExamReview);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Name = "StudentPanel";
            this.Text = "StudentPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Button btnPrevExamReview;
    }
}