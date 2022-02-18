
namespace quig_ui
{
    partial class Form_NoFile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonConfigQuig = new System.Windows.Forms.Button();
            this.buttonConfigEditors = new System.Windows.Forms.Button();
            this.buttonReadme = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to quig!";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(12, 24);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(182, 15);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "This is quig-ui, version x.y-status.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "(C) 2022 B.M.Deeal.";
            // 
            // buttonOpen
            // 
            this.buttonOpen.AutoSize = true;
            this.buttonOpen.Location = new System.Drawing.Point(221, 40);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(193, 25);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open existing game";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.AutoSize = true;
            this.buttonNew.Location = new System.Drawing.Point(221, 9);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(193, 25);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "Create new game";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonConfigQuig
            // 
            this.buttonConfigQuig.AutoSize = true;
            this.buttonConfigQuig.Location = new System.Drawing.Point(221, 71);
            this.buttonConfigQuig.Name = "buttonConfigQuig";
            this.buttonConfigQuig.Size = new System.Drawing.Size(193, 25);
            this.buttonConfigQuig.TabIndex = 5;
            this.buttonConfigQuig.Text = "Configure quig settings";
            this.buttonConfigQuig.UseVisualStyleBackColor = true;
            this.buttonConfigQuig.Click += new System.EventHandler(this.buttonConfigQuig_Click);
            // 
            // buttonConfigEditors
            // 
            this.buttonConfigEditors.AutoSize = true;
            this.buttonConfigEditors.Location = new System.Drawing.Point(221, 102);
            this.buttonConfigEditors.Name = "buttonConfigEditors";
            this.buttonConfigEditors.Size = new System.Drawing.Size(193, 25);
            this.buttonConfigEditors.TabIndex = 6;
            this.buttonConfigEditors.Text = "Configure editor settings";
            this.buttonConfigEditors.UseVisualStyleBackColor = true;
            this.buttonConfigEditors.Click += new System.EventHandler(this.buttonConfigEditors_Click);
            // 
            // buttonReadme
            // 
            this.buttonReadme.AutoSize = true;
            this.buttonReadme.Location = new System.Drawing.Point(221, 133);
            this.buttonReadme.Name = "buttonReadme";
            this.buttonReadme.Size = new System.Drawing.Size(193, 25);
            this.buttonReadme.TabIndex = 7;
            this.buttonReadme.Text = "View quig readme";
            this.buttonReadme.UseVisualStyleBackColor = true;
            this.buttonReadme.Click += new System.EventHandler(this.buttonReadme_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.AutoSize = true;
            this.buttonAbout.Location = new System.Drawing.Point(221, 164);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(193, 25);
            this.buttonAbout.TabIndex = 8;
            this.buttonAbout.Text = "About quig-ui";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Location = new System.Drawing.Point(221, 195);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(193, 25);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit quig-ui";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "No file loaded.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select an option.";
            // 
            // Form_NoFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonReadme);
            this.Controls.Add(this.buttonConfigEditors);
            this.Controls.Add(this.buttonConfigQuig);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_NoFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No file loaded - quig-ui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_NoFile_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_NoFile_FormClosed);
            this.Load += new System.EventHandler(this.Form_NoFile_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonConfigQuig;
        private System.Windows.Forms.Button buttonConfigEditors;
        private System.Windows.Forms.Button buttonReadme;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
    }
}

