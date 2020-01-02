namespace EClass
{
    partial class AdminPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.tpQuestions = new System.Windows.Forms.TabPage();
            this.btnQuestionUpdate = new System.Windows.Forms.Button();
            this.btnQuestionDelete = new System.Windows.Forms.Button();
            this.btnQuestionAdd = new System.Windows.Forms.Button();
            this.dgwQuestions = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.tpQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpUsers);
            this.tabControl1.Controls.Add(this.tpQuestions);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.btnUserUpdate);
            this.tpUsers.Controls.Add(this.btnUserDelete);
            this.tpUsers.Controls.Add(this.btnUserAdd);
            this.tpUsers.Controls.Add(this.dgwUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(794, 552);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Kullanıcı Ekleme";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(665, 377);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(115, 44);
            this.btnUserUpdate.TabIndex = 19;
            this.btnUserUpdate.Text = "Kullanıcı Güncelle";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(564, 376);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(95, 45);
            this.btnUserDelete.TabIndex = 18;
            this.btnUserDelete.Text = "Kullanıcı Sil";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(458, 376);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(100, 44);
            this.btnUserAdd.TabIndex = 17;
            this.btnUserAdd.Text = "Kullanıcı Ekle";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // dgwUsers
            // 
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(6, 6);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.Size = new System.Drawing.Size(780, 364);
            this.dgwUsers.TabIndex = 16;
            // 
            // tpQuestions
            // 
            this.tpQuestions.Controls.Add(this.btnQuestionUpdate);
            this.tpQuestions.Controls.Add(this.btnQuestionDelete);
            this.tpQuestions.Controls.Add(this.btnQuestionAdd);
            this.tpQuestions.Controls.Add(this.dgwQuestions);
            this.tpQuestions.Location = new System.Drawing.Point(4, 22);
            this.tpQuestions.Name = "tpQuestions";
            this.tpQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuestions.Size = new System.Drawing.Size(794, 552);
            this.tpQuestions.TabIndex = 1;
            this.tpQuestions.Text = "Soru Yönetimi";
            this.tpQuestions.UseVisualStyleBackColor = true;
            // 
            // btnQuestionUpdate
            // 
            this.btnQuestionUpdate.Location = new System.Drawing.Point(667, 377);
            this.btnQuestionUpdate.Name = "btnQuestionUpdate";
            this.btnQuestionUpdate.Size = new System.Drawing.Size(115, 44);
            this.btnQuestionUpdate.TabIndex = 3;
            this.btnQuestionUpdate.Text = "Soru Güncelle";
            this.btnQuestionUpdate.UseVisualStyleBackColor = true;
            this.btnQuestionUpdate.Click += new System.EventHandler(this.btnQuestionUpdate_Click);
            // 
            // btnQuestionDelete
            // 
            this.btnQuestionDelete.Location = new System.Drawing.Point(586, 376);
            this.btnQuestionDelete.Name = "btnQuestionDelete";
            this.btnQuestionDelete.Size = new System.Drawing.Size(75, 45);
            this.btnQuestionDelete.TabIndex = 2;
            this.btnQuestionDelete.Text = "Soru Sil";
            this.btnQuestionDelete.UseVisualStyleBackColor = true;
            this.btnQuestionDelete.Click += new System.EventHandler(this.btnQuestionDelete_Click);
            // 
            // btnQuestionAdd
            // 
            this.btnQuestionAdd.Location = new System.Drawing.Point(505, 377);
            this.btnQuestionAdd.Name = "btnQuestionAdd";
            this.btnQuestionAdd.Size = new System.Drawing.Size(75, 44);
            this.btnQuestionAdd.TabIndex = 1;
            this.btnQuestionAdd.Text = "Soru Ekle";
            this.btnQuestionAdd.UseVisualStyleBackColor = true;
            this.btnQuestionAdd.Click += new System.EventHandler(this.btnQuestionAdd_Click);
            // 
            // dgwQuestions
            // 
            this.dgwQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwQuestions.Location = new System.Drawing.Point(8, 6);
            this.dgwQuestions.Name = "dgwQuestions";
            this.dgwQuestions.Size = new System.Drawing.Size(780, 364);
            this.dgwQuestions.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.tpQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpQuestions;
        private System.Windows.Forms.Button btnQuestionUpdate;
        private System.Windows.Forms.Button btnQuestionDelete;
        private System.Windows.Forms.Button btnQuestionAdd;
        private System.Windows.Forms.DataGridView dgwQuestions;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.DataGridView dgwUsers;
    }
}