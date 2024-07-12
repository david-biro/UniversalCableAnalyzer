namespace UniversalCableAnalyzer
{
    partial class CProfilePinConfigWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CProfilePinConfigWindow));
            btnCreateProfile = new System.Windows.Forms.Button();
            lblTopDescr = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.Location = new System.Drawing.Point(429, 13);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Size = new System.Drawing.Size(149, 42);
            btnCreateProfile.TabIndex = 0;
            btnCreateProfile.Text = "Create profile";
            btnCreateProfile.UseVisualStyleBackColor = true;
            btnCreateProfile.Click += button1_Click;
            // 
            // lblTopDescr
            // 
            lblTopDescr.AutoSize = true;
            lblTopDescr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTopDescr.Location = new System.Drawing.Point(24, 18);
            lblTopDescr.Name = "lblTopDescr";
            lblTopDescr.Size = new System.Drawing.Size(394, 25);
            lblTopDescr.TabIndex = 1;
            lblTopDescr.Text = "Step 2) Set the A and B side pins of the cable";
            // 
            // CProfilePinConfigWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(693, 450);
            Controls.Add(lblTopDescr);
            Controls.Add(btnCreateProfile);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CProfilePinConfigWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "UniversalCableAnalyzer - Set connections";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label lblTopDescr;
    }
}