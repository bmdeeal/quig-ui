
namespace quig_ui
{
    partial class Form_OpenFile
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditCode = new System.Windows.Forms.Button();
            this.buttonEditGraphics = new System.Windows.Forms.Button();
            this.buttonConfigQuig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConfigEditors = new System.Windows.Forms.Button();
            this.buttonReadme = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusFilename = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.Location = new System.Drawing.Point(178, 9);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(201, 25);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play game";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "quig-ui main menu.";
            // 
            // buttonEditCode
            // 
            this.buttonEditCode.AutoSize = true;
            this.buttonEditCode.Location = new System.Drawing.Point(178, 40);
            this.buttonEditCode.Name = "buttonEditCode";
            this.buttonEditCode.Size = new System.Drawing.Size(201, 25);
            this.buttonEditCode.TabIndex = 2;
            this.buttonEditCode.Text = "Edit game code";
            this.buttonEditCode.UseVisualStyleBackColor = true;
            this.buttonEditCode.Click += new System.EventHandler(this.buttonEditCode_Click);
            // 
            // buttonEditGraphics
            // 
            this.buttonEditGraphics.AutoSize = true;
            this.buttonEditGraphics.Location = new System.Drawing.Point(178, 71);
            this.buttonEditGraphics.Name = "buttonEditGraphics";
            this.buttonEditGraphics.Size = new System.Drawing.Size(201, 25);
            this.buttonEditGraphics.TabIndex = 3;
            this.buttonEditGraphics.Text = "Edit game graphics";
            this.buttonEditGraphics.UseVisualStyleBackColor = true;
            this.buttonEditGraphics.Click += new System.EventHandler(this.buttonEditGraphics_Click);
            // 
            // buttonConfigQuig
            // 
            this.buttonConfigQuig.AutoSize = true;
            this.buttonConfigQuig.Location = new System.Drawing.Point(178, 102);
            this.buttonConfigQuig.Name = "buttonConfigQuig";
            this.buttonConfigQuig.Size = new System.Drawing.Size(201, 25);
            this.buttonConfigQuig.TabIndex = 4;
            this.buttonConfigQuig.Text = "Configure quig settings";
            this.buttonConfigQuig.UseVisualStyleBackColor = true;
            this.buttonConfigQuig.Click += new System.EventHandler(this.buttonQuigConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select an option.";
            // 
            // buttonConfigEditors
            // 
            this.buttonConfigEditors.AutoSize = true;
            this.buttonConfigEditors.Location = new System.Drawing.Point(178, 133);
            this.buttonConfigEditors.Name = "buttonConfigEditors";
            this.buttonConfigEditors.Size = new System.Drawing.Size(201, 25);
            this.buttonConfigEditors.TabIndex = 6;
            this.buttonConfigEditors.Text = "Configure editor settings";
            this.buttonConfigEditors.UseVisualStyleBackColor = true;
            this.buttonConfigEditors.Click += new System.EventHandler(this.buttonConfigEditors_Click);
            // 
            // buttonReadme
            // 
            this.buttonReadme.AutoSize = true;
            this.buttonReadme.Location = new System.Drawing.Point(178, 164);
            this.buttonReadme.Name = "buttonReadme";
            this.buttonReadme.Size = new System.Drawing.Size(201, 25);
            this.buttonReadme.TabIndex = 7;
            this.buttonReadme.Text = "View quig readme";
            this.buttonReadme.UseVisualStyleBackColor = true;
            this.buttonReadme.Click += new System.EventHandler(this.buttonReadme_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusFilename});
            this.statusStrip1.Location = new System.Drawing.Point(0, 259);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(391, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusFilename
            // 
            this.toolStripStatusFilename.Name = "toolStripStatusFilename";
            this.toolStripStatusFilename.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusFilename.Size = new System.Drawing.Size(182, 17);
            this.toolStripStatusFilename.Text = "Loaded \'placeholder-name.quig\'.";
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Location = new System.Drawing.Point(178, 195);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(201, 25);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close game";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Location = new System.Drawing.Point(178, 226);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(201, 25);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit quig-ui";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form_OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 281);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonReadme);
            this.Controls.Add(this.buttonConfigEditors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConfigQuig);
            this.Controls.Add(this.buttonEditGraphics);
            this.Controls.Add(this.buttonEditCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_OpenFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "placeholder-name.quig - quig-ui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_OpenFile_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_OpenFile_FormClosed);
            this.Load += new System.EventHandler(this.Form_OpenFile_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditCode;
        private System.Windows.Forms.Button buttonEditGraphics;
        private System.Windows.Forms.Button buttonConfigQuig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConfigEditors;
        private System.Windows.Forms.Button buttonReadme;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFilename;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonExit;
    }
}