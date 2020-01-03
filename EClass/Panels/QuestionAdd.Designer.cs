namespace EClass
{
    partial class QuestionAdd
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtChoice4 = new System.Windows.Forms.TextBox();
            this.txtChoice2 = new System.Windows.Forms.TextBox();
            this.txtChoice1 = new System.Windows.Forms.TextBox();
            this.txtChoice3 = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCatagory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(52, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtChoice4
            // 
            this.txtChoice4.Location = new System.Drawing.Point(221, 235);
            this.txtChoice4.MaxLength = 350;
            this.txtChoice4.Multiline = true;
            this.txtChoice4.Name = "txtChoice4";
            this.txtChoice4.Size = new System.Drawing.Size(100, 20);
            this.txtChoice4.TabIndex = 1;
            // 
            // txtChoice2
            // 
            this.txtChoice2.Location = new System.Drawing.Point(221, 157);
            this.txtChoice2.Multiline = true;
            this.txtChoice2.Name = "txtChoice2";
            this.txtChoice2.Size = new System.Drawing.Size(100, 20);
            this.txtChoice2.TabIndex = 2;
            // 
            // txtChoice1
            // 
            this.txtChoice1.Location = new System.Drawing.Point(52, 157);
            this.txtChoice1.MaxLength = 350;
            this.txtChoice1.Multiline = true;
            this.txtChoice1.Name = "txtChoice1";
            this.txtChoice1.Size = new System.Drawing.Size(100, 20);
            this.txtChoice1.TabIndex = 3;
            // 
            // txtChoice3
            // 
            this.txtChoice3.Location = new System.Drawing.Point(52, 235);
            this.txtChoice3.MaxLength = 350;
            this.txtChoice3.Multiline = true;
            this.txtChoice3.Name = "txtChoice3";
            this.txtChoice3.Size = new System.Drawing.Size(100, 20);
            this.txtChoice3.TabIndex = 4;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(39, 38);
            this.txtQuestion.MaxLength = 350;
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(160, 92);
            this.txtQuestion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doğru Seçenek :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yanlış Seçenek :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yanlış Seçenek :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yanlış Seçenek :";
            // 
            // cbCatagory
            // 
            this.cbCatagory.FormattingEnabled = true;
            this.cbCatagory.Location = new System.Drawing.Point(221, 59);
            this.cbCatagory.Name = "cbCatagory";
            this.cbCatagory.Size = new System.Drawing.Size(121, 21);
            this.cbCatagory.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kategoriler :";
            // 
            // QuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 388);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCatagory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtChoice3);
            this.Controls.Add(this.txtChoice1);
            this.Controls.Add(this.txtChoice2);
            this.Controls.Add(this.txtChoice4);
            this.Controls.Add(this.btnSave);
            this.Name = "QuestionAdd";
            this.Text = "TeacherLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestinAdd_FormClosed);
            this.Load += new System.EventHandler(this.QuestinAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtChoice4;
        private System.Windows.Forms.TextBox txtChoice2;
        private System.Windows.Forms.TextBox txtChoice1;
        private System.Windows.Forms.TextBox txtChoice3;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCatagory;
        private System.Windows.Forms.Label label6;
    }
}