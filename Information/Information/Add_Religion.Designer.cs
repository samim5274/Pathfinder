namespace Information
{
    partial class Add_Religion
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
            this.btnAddReligion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReligionId = new System.Windows.Forms.TextBox();
            this.txtReligionName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddReligion
            // 
            this.btnAddReligion.Location = new System.Drawing.Point(303, 166);
            this.btnAddReligion.Name = "btnAddReligion";
            this.btnAddReligion.Size = new System.Drawing.Size(126, 39);
            this.btnAddReligion.TabIndex = 0;
            this.btnAddReligion.Text = "Add Religion";
            this.btnAddReligion.UseVisualStyleBackColor = true;
            this.btnAddReligion.Click += new System.EventHandler(this.btnAddReligion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Religion Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Religion Name";
            // 
            // txtReligionId
            // 
            this.txtReligionId.Location = new System.Drawing.Point(192, 59);
            this.txtReligionId.Name = "txtReligionId";
            this.txtReligionId.Size = new System.Drawing.Size(225, 22);
            this.txtReligionId.TabIndex = 3;
            // 
            // txtReligionName
            // 
            this.txtReligionName.Location = new System.Drawing.Point(192, 112);
            this.txtReligionName.Name = "txtReligionName";
            this.txtReligionName.Size = new System.Drawing.Size(225, 22);
            this.txtReligionName.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(171, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Add_Religion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 271);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtReligionName);
            this.Controls.Add(this.txtReligionId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddReligion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Add_Religion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Religion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddReligion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReligionId;
        private System.Windows.Forms.TextBox txtReligionName;
        private System.Windows.Forms.Button btnExit;
    }
}