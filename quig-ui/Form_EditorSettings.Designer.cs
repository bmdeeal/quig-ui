
namespace quig_ui
{
    partial class Form_EditorSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonCodeBrowse = new System.Windows.Forms.Button();
            this.buttonGraphicsBrowse = new System.Windows.Forms.Button();
            this.textBoxGraphics = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code and graphics editor settings.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editor for .quig code:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(12, 42);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(230, 23);
            this.textBoxCode.TabIndex = 12;
            this.textBoxCode.Text = "notepad.exe";
            // 
            // buttonCodeBrowse
            // 
            this.buttonCodeBrowse.Location = new System.Drawing.Point(248, 42);
            this.buttonCodeBrowse.Name = "buttonCodeBrowse";
            this.buttonCodeBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonCodeBrowse.TabIndex = 13;
            this.buttonCodeBrowse.Text = "Browse";
            this.buttonCodeBrowse.UseVisualStyleBackColor = true;
            this.buttonCodeBrowse.Click += new System.EventHandler(this.buttonCodeBrowse_Click);
            // 
            // buttonGraphicsBrowse
            // 
            this.buttonGraphicsBrowse.Location = new System.Drawing.Point(248, 86);
            this.buttonGraphicsBrowse.Name = "buttonGraphicsBrowse";
            this.buttonGraphicsBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonGraphicsBrowse.TabIndex = 15;
            this.buttonGraphicsBrowse.Text = "Browse";
            this.buttonGraphicsBrowse.UseVisualStyleBackColor = true;
            this.buttonGraphicsBrowse.Click += new System.EventHandler(this.buttonGraphicsBrowse_Click);
            // 
            // textBoxGraphics
            // 
            this.textBoxGraphics.Location = new System.Drawing.Point(12, 86);
            this.textBoxGraphics.Name = "textBoxGraphics";
            this.textBoxGraphics.Size = new System.Drawing.Size(230, 23);
            this.textBoxGraphics.TabIndex = 14;
            this.textBoxGraphics.Text = "mspaint.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editor for .png graphics:";
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(12, 208);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(311, 25);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save new settings";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(12, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(311, 25);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel changes";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.Location = new System.Drawing.Point(12, 146);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(311, 25);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset settings to default";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.Location = new System.Drawing.Point(12, 115);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(311, 25);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "Associate .quig files with quig-ui";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Form_EditorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(335, 241);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonGraphicsBrowse);
            this.Controls.Add(this.textBoxGraphics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCodeBrowse);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_EditorSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor settings";
            this.Load += new System.EventHandler(this.Form_EditorSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonCodeBrowse;
        private System.Windows.Forms.Button buttonGraphicsBrowse;
        private System.Windows.Forms.TextBox textBoxGraphics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRegister;
    }
}