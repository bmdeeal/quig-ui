
namespace quig_ui
{
    partial class Form_MissingGraphics
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
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(281, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Could not find graphics for placeholder-text.quig!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do?";
            // 
            // buttonNew
            // 
            this.buttonNew.AutoSize = true;
            this.buttonNew.Location = new System.Drawing.Point(12, 46);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(350, 25);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Create new, blank graphics file";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.AutoSize = true;
            this.buttonCopy.Location = new System.Drawing.Point(13, 77);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(349, 25);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "Copy existing graphics file";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(12, 108);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(350, 25);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel, do nothing";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form_MissingGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(374, 145);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_MissingGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Missing .png file...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCancel;
    }
}