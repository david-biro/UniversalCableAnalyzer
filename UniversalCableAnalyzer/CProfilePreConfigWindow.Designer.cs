namespace UniversalCableAnalyzer
{
    partial class CProfilePreConfigWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CProfilePreConfigWindow));
            lblTopDescr = new System.Windows.Forms.Label();
            gbxAside = new System.Windows.Forms.GroupBox();
            lblAsideName = new System.Windows.Forms.Label();
            txtAsideName = new System.Windows.Forms.TextBox();
            lblAsidePinCount = new System.Windows.Forms.Label();
            lblAsideRows = new System.Windows.Forms.Label();
            nudAsidePinCount = new System.Windows.Forms.NumericUpDown();
            nudAsideRows = new System.Windows.Forms.NumericUpDown();
            gbxBside = new System.Windows.Forms.GroupBox();
            lblBsideName = new System.Windows.Forms.Label();
            txtBsideName = new System.Windows.Forms.TextBox();
            nudBsidePinCount = new System.Windows.Forms.NumericUpDown();
            lblBsidePinCount = new System.Windows.Forms.Label();
            lblBsideRows = new System.Windows.Forms.Label();
            nudBsideRows = new System.Windows.Forms.NumericUpDown();
            btnNext = new System.Windows.Forms.Button();
            txtProfileName = new System.Windows.Forms.TextBox();
            lblProfileName = new System.Windows.Forms.Label();
            lblFileName = new System.Windows.Forms.Label();
            txtFileName = new System.Windows.Forms.TextBox();
            gbxGeneral = new System.Windows.Forms.GroupBox();
            lblXML = new System.Windows.Forms.Label();
            gbxAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAsidePinCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAsideRows).BeginInit();
            gbxBside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBsidePinCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBsideRows).BeginInit();
            gbxGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // lblTopDescr
            // 
            lblTopDescr.AutoSize = true;
            lblTopDescr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTopDescr.Location = new System.Drawing.Point(24, 18);
            lblTopDescr.Name = "lblTopDescr";
            lblTopDescr.Size = new System.Drawing.Size(336, 25);
            lblTopDescr.TabIndex = 0;
            lblTopDescr.Text = "Step 1) Set the properties of the cable";
            // 
            // gbxAside
            // 
            gbxAside.Controls.Add(lblAsideName);
            gbxAside.Controls.Add(txtAsideName);
            gbxAside.Controls.Add(lblAsidePinCount);
            gbxAside.Controls.Add(lblAsideRows);
            gbxAside.Controls.Add(nudAsidePinCount);
            gbxAside.Controls.Add(nudAsideRows);
            gbxAside.Location = new System.Drawing.Point(24, 228);
            gbxAside.Name = "gbxAside";
            gbxAside.Size = new System.Drawing.Size(354, 223);
            gbxAside.TabIndex = 1;
            gbxAside.TabStop = false;
            gbxAside.Text = "Cable A side";
            // 
            // lblAsideName
            // 
            lblAsideName.AutoSize = true;
            lblAsideName.Location = new System.Drawing.Point(33, 147);
            lblAsideName.Name = "lblAsideName";
            lblAsideName.Size = new System.Drawing.Size(114, 25);
            lblAsideName.TabIndex = 4;
            lblAsideName.Text = "A side name:";
            // 
            // txtAsideName
            // 
            txtAsideName.Location = new System.Drawing.Point(186, 133);
            txtAsideName.Name = "txtAsideName";
            txtAsideName.Size = new System.Drawing.Size(150, 31);
            txtAsideName.TabIndex = 3;
            txtAsideName.Text = "Connector A";
            // 
            // lblAsidePinCount
            // 
            lblAsidePinCount.AutoSize = true;
            lblAsidePinCount.Location = new System.Drawing.Point(33, 102);
            lblAsidePinCount.Name = "lblAsidePinCount";
            lblAsidePinCount.Size = new System.Drawing.Size(133, 25);
            lblAsidePinCount.TabIndex = 2;
            lblAsidePinCount.Text = "Total pin count:";
            // 
            // lblAsideRows
            // 
            lblAsideRows.AutoSize = true;
            lblAsideRows.Location = new System.Drawing.Point(33, 57);
            lblAsideRows.Name = "lblAsideRows";
            lblAsideRows.Size = new System.Drawing.Size(58, 25);
            lblAsideRows.TabIndex = 1;
            lblAsideRows.Text = "Rows:";
            // 
            // nudAsidePinCount
            // 
            nudAsidePinCount.Location = new System.Drawing.Point(186, 88);
            nudAsidePinCount.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudAsidePinCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAsidePinCount.Name = "nudAsidePinCount";
            nudAsidePinCount.Size = new System.Drawing.Size(69, 31);
            nudAsidePinCount.TabIndex = 0;
            nudAsidePinCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAsideRows
            // 
            nudAsideRows.Location = new System.Drawing.Point(186, 43);
            nudAsideRows.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudAsideRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAsideRows.Name = "nudAsideRows";
            nudAsideRows.Size = new System.Drawing.Size(69, 31);
            nudAsideRows.TabIndex = 0;
            nudAsideRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gbxBside
            // 
            gbxBside.Controls.Add(lblBsideName);
            gbxBside.Controls.Add(txtBsideName);
            gbxBside.Controls.Add(nudBsidePinCount);
            gbxBside.Controls.Add(lblBsidePinCount);
            gbxBside.Controls.Add(lblBsideRows);
            gbxBside.Controls.Add(nudBsideRows);
            gbxBside.Location = new System.Drawing.Point(400, 228);
            gbxBside.Name = "gbxBside";
            gbxBside.Size = new System.Drawing.Size(354, 223);
            gbxBside.TabIndex = 2;
            gbxBside.TabStop = false;
            gbxBside.Text = "Cable B side";
            // 
            // lblBsideName
            // 
            lblBsideName.AutoSize = true;
            lblBsideName.Location = new System.Drawing.Point(31, 147);
            lblBsideName.Name = "lblBsideName";
            lblBsideName.Size = new System.Drawing.Size(112, 25);
            lblBsideName.TabIndex = 5;
            lblBsideName.Text = "B side name:";
            // 
            // txtBsideName
            // 
            txtBsideName.Location = new System.Drawing.Point(187, 133);
            txtBsideName.Name = "txtBsideName";
            txtBsideName.Size = new System.Drawing.Size(150, 31);
            txtBsideName.TabIndex = 4;
            txtBsideName.Text = "Connector B";
            // 
            // nudBsidePinCount
            // 
            nudBsidePinCount.Location = new System.Drawing.Point(187, 88);
            nudBsidePinCount.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudBsidePinCount.Name = "nudBsidePinCount";
            nudBsidePinCount.Size = new System.Drawing.Size(69, 31);
            nudBsidePinCount.TabIndex = 4;
            nudBsidePinCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblBsidePinCount
            // 
            lblBsidePinCount.AutoSize = true;
            lblBsidePinCount.Location = new System.Drawing.Point(31, 102);
            lblBsidePinCount.Name = "lblBsidePinCount";
            lblBsidePinCount.Size = new System.Drawing.Size(133, 25);
            lblBsidePinCount.TabIndex = 3;
            lblBsidePinCount.Text = "Total pin count:";
            // 
            // lblBsideRows
            // 
            lblBsideRows.AutoSize = true;
            lblBsideRows.Location = new System.Drawing.Point(31, 57);
            lblBsideRows.Name = "lblBsideRows";
            lblBsideRows.Size = new System.Drawing.Size(58, 25);
            lblBsideRows.TabIndex = 3;
            lblBsideRows.Text = "Rows:";
            // 
            // nudBsideRows
            // 
            nudBsideRows.Location = new System.Drawing.Point(187, 43);
            nudBsideRows.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudBsideRows.Name = "nudBsideRows";
            nudBsideRows.Size = new System.Drawing.Size(69, 31);
            nudBsideRows.TabIndex = 2;
            nudBsideRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(611, 468);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(149, 42);
            btnNext.TabIndex = 3;
            btnNext.Text = "Go to next step";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new System.Drawing.Point(210, 43);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.Size = new System.Drawing.Size(150, 31);
            txtProfileName.TabIndex = 4;
            txtProfileName.Text = "Profile Name";
            // 
            // lblProfileName
            // 
            lblProfileName.AutoSize = true;
            lblProfileName.Location = new System.Drawing.Point(33, 57);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new System.Drawing.Size(171, 25);
            lblProfileName.TabIndex = 5;
            lblProfileName.Text = "Name of the profile:";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new System.Drawing.Point(33, 100);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new System.Drawing.Size(143, 25);
            lblFileName.TabIndex = 6;
            lblFileName.Text = "Name of the file:";
            // 
            // txtFileName
            // 
            txtFileName.Location = new System.Drawing.Point(209, 87);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new System.Drawing.Size(150, 31);
            txtFileName.TabIndex = 7;
            txtFileName.Text = "testcable";
            // 
            // gbxGeneral
            // 
            gbxGeneral.Controls.Add(lblXML);
            gbxGeneral.Controls.Add(lblProfileName);
            gbxGeneral.Controls.Add(txtFileName);
            gbxGeneral.Controls.Add(txtProfileName);
            gbxGeneral.Controls.Add(lblFileName);
            gbxGeneral.Location = new System.Drawing.Point(24, 72);
            gbxGeneral.Name = "gbxGeneral";
            gbxGeneral.Size = new System.Drawing.Size(466, 150);
            gbxGeneral.TabIndex = 8;
            gbxGeneral.TabStop = false;
            gbxGeneral.Text = "General";
            // 
            // lblXML
            // 
            lblXML.AutoSize = true;
            lblXML.Location = new System.Drawing.Point(366, 100);
            lblXML.Name = "lblXML";
            lblXML.Size = new System.Drawing.Size(44, 25);
            lblXML.TabIndex = 8;
            lblXML.Text = ".xml";
            // 
            // CProfilePreConfigWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(776, 528);
            Controls.Add(gbxGeneral);
            Controls.Add(btnNext);
            Controls.Add(gbxBside);
            Controls.Add(gbxAside);
            Controls.Add(lblTopDescr);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CProfilePreConfigWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "UniversalCableAnalyzer - Create cable profile";
            gbxAside.ResumeLayout(false);
            gbxAside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAsidePinCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAsideRows).EndInit();
            gbxBside.ResumeLayout(false);
            gbxBside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBsidePinCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBsideRows).EndInit();
            gbxGeneral.ResumeLayout(false);
            gbxGeneral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTopDescr;
        private System.Windows.Forms.GroupBox gbxAside;
        private System.Windows.Forms.GroupBox gbxBside;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nudAsideRows;
        private System.Windows.Forms.NumericUpDown nudAsidePinCount;
        private System.Windows.Forms.Label lblAsideRows;
        private System.Windows.Forms.NumericUpDown nudBsideRows;
        private System.Windows.Forms.Label lblAsidePinCount;
        private System.Windows.Forms.NumericUpDown nudBsidePinCount;
        private System.Windows.Forms.Label lblBsidePinCount;
        private System.Windows.Forms.Label lblBsideRows;
        private System.Windows.Forms.Label lblAsideName;
        private System.Windows.Forms.TextBox txtAsideName;
        private System.Windows.Forms.Label lblBsideName;
        private System.Windows.Forms.TextBox txtBsideName;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox gbxGeneral;
        private System.Windows.Forms.Label lblXML;
    }
}