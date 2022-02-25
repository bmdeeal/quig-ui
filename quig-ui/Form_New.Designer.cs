
namespace quig_ui
{
    partial class Form_New
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
            this.textBoxGameLocation = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBrowseLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new game.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location to save in:";
            // 
            // textBoxGameLocation
            // 
            this.textBoxGameLocation.Location = new System.Drawing.Point(12, 42);
            this.textBoxGameLocation.Name = "textBoxGameLocation";
            this.textBoxGameLocation.Size = new System.Drawing.Size(264, 23);
            this.textBoxGameLocation.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.AutoSize = true;
            this.buttonCreate.Location = new System.Drawing.Point(12, 71);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(345, 25);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create new quig game";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(12, 102);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(345, 25);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel, return to main menu";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonBrowseLocation
            // 
            this.buttonBrowseLocation.Location = new System.Drawing.Point(282, 42);
            this.buttonBrowseLocation.Name = "buttonBrowseLocation";
            this.buttonBrowseLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseLocation.TabIndex = 5;
            this.buttonBrowseLocation.Text = "Browse";
            this.buttonBrowseLocation.UseVisualStyleBackColor = true;
            this.buttonBrowseLocation.Click += new System.EventHandler(this.buttonBrowseLocation_Click);
            // 
            // Form_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(369, 139);
            this.Controls.Add(this.buttonBrowseLocation);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxGameLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGameLocation;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBrowseLocation;
    }
}