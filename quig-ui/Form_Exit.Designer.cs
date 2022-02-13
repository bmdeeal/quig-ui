
namespace quig_ui
{
    partial class Form_Exit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are you sure you would like to quit?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exit quig-ui?";
            // 
            // buttonYes
            // 
            this.buttonYes.AutoSize = true;
            this.buttonYes.Location = new System.Drawing.Point(227, 9);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(98, 25);
            this.buttonYes.TabIndex = 4;
            this.buttonYes.Text = "&Yes, quit";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.AutoSize = true;
            this.buttonNo.Location = new System.Drawing.Point(227, 40);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(98, 25);
            this.buttonNo.TabIndex = 3;
            this.buttonNo.Text = "&No, do not quit";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // Form_Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonNo;
            this.ClientSize = new System.Drawing.Size(334, 76);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exit?";
            this.Load += new System.EventHandler(this.Form_Exit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
    }
}