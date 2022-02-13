
namespace quig_ui
{
    partial class Form_Close
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
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNo
            // 
            this.buttonNo.AutoSize = true;
            this.buttonNo.Location = new System.Drawing.Point(231, 40);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(104, 25);
            this.buttonNo.TabIndex = 7;
            this.buttonNo.Text = "&No, do not close";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.AutoSize = true;
            this.buttonYes.Location = new System.Drawing.Point(231, 9);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(104, 25);
            this.buttonYes.TabIndex = 8;
            this.buttonYes.Text = "&Yes, close";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Would you like to close the current game and return to the main menu?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Close the current game?";
            // 
            // Form_Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonNo;
            this.ClientSize = new System.Drawing.Size(347, 76);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Close";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Close game?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}