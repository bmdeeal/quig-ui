
namespace quig_ui
{
    partial class Form_QuigSettings
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
            this.radioButtonHardware = new System.Windows.Forms.RadioButton();
            this.radioButtonHardwareVSync = new System.Windows.Forms.RadioButton();
            this.radioButtonSoftware = new System.Windows.Forms.RadioButton();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonQuigBrowse = new System.Windows.Forms.Button();
            this.textBoxQuigLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "quig in-game settings.";
            // 
            // radioButtonHardware
            // 
            this.radioButtonHardware.AutoSize = true;
            this.radioButtonHardware.Location = new System.Drawing.Point(12, 42);
            this.radioButtonHardware.Name = "radioButtonHardware";
            this.radioButtonHardware.Size = new System.Drawing.Size(149, 19);
            this.radioButtonHardware.TabIndex = 2;
            this.radioButtonHardware.TabStop = true;
            this.radioButtonHardware.Text = "Hardware (fast, default)";
            this.radioButtonHardware.UseVisualStyleBackColor = true;
            // 
            // radioButtonHardwareVSync
            // 
            this.radioButtonHardwareVSync.AutoSize = true;
            this.radioButtonHardwareVSync.Location = new System.Drawing.Point(12, 67);
            this.radioButtonHardwareVSync.Name = "radioButtonHardwareVSync";
            this.radioButtonHardwareVSync.Size = new System.Drawing.Size(234, 19);
            this.radioButtonHardwareVSync.TabIndex = 3;
            this.radioButtonHardwareVSync.TabStop = true;
            this.radioButtonHardwareVSync.Text = "Hardware v-sync (requires 60hz display)";
            this.radioButtonHardwareVSync.UseVisualStyleBackColor = true;
            // 
            // radioButtonSoftware
            // 
            this.radioButtonSoftware.AutoSize = true;
            this.radioButtonSoftware.Location = new System.Drawing.Point(12, 92);
            this.radioButtonSoftware.Name = "radioButtonSoftware";
            this.radioButtonSoftware.Size = new System.Drawing.Size(202, 19);
            this.radioButtonSoftware.TabIndex = 4;
            this.radioButtonSoftware.TabStop = true;
            this.radioButtonSoftware.Text = "Software (slow, most compatible)";
            this.radioButtonSoftware.UseVisualStyleBackColor = true;
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Location = new System.Drawing.Point(12, 117);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(114, 19);
            this.checkBoxFullscreen.TabIndex = 5;
            this.checkBoxFullscreen.Text = "Run in fullscreen";
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Graphics mode:";
            // 
            // buttonReset
            // 
            this.buttonReset.AutoSize = true;
            this.buttonReset.Location = new System.Drawing.Point(12, 186);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(234, 25);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset settings to default";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(12, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(234, 25);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel changes";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.Location = new System.Drawing.Point(12, 248);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(234, 25);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save new settings";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonQuigBrowse
            // 
            this.buttonQuigBrowse.Location = new System.Drawing.Point(171, 157);
            this.buttonQuigBrowse.Name = "buttonQuigBrowse";
            this.buttonQuigBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonQuigBrowse.TabIndex = 17;
            this.buttonQuigBrowse.Text = "Browse";
            this.buttonQuigBrowse.UseVisualStyleBackColor = true;
            this.buttonQuigBrowse.Click += new System.EventHandler(this.buttonQuigBrowse_Click);
            // 
            // textBoxQuigLocation
            // 
            this.textBoxQuigLocation.Location = new System.Drawing.Point(12, 157);
            this.textBoxQuigLocation.Name = "textBoxQuigLocation";
            this.textBoxQuigLocation.Size = new System.Drawing.Size(153, 23);
            this.textBoxQuigLocation.TabIndex = 16;
            this.textBoxQuigLocation.Text = "quig.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Location of quig:";
            // 
            // Form_QuigSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(258, 284);
            this.Controls.Add(this.buttonQuigBrowse);
            this.Controls.Add(this.textBoxQuigLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxFullscreen);
            this.Controls.Add(this.radioButtonSoftware);
            this.Controls.Add(this.radioButtonHardwareVSync);
            this.Controls.Add(this.radioButtonHardware);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_QuigSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "  quig settings";
            this.Load += new System.EventHandler(this.Form_QuigSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonHardware;
        private System.Windows.Forms.RadioButton radioButtonHardwareVSync;
        private System.Windows.Forms.RadioButton radioButtonSoftware;
        private System.Windows.Forms.CheckBox checkBoxFullscreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonQuigBrowse;
        private System.Windows.Forms.TextBox textBoxQuigLocation;
        private System.Windows.Forms.Label label3;
    }
}