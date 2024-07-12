
using System;
using System.Windows.Forms;

namespace UniversalCableAnalyzer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            picRecomPinout = new PictureBox();
            lblMeasuredPinout = new Label();
            lblRecomPinout = new Label();
            picMeasuredPinout = new PictureBox();
            menuStrip1 = new MenuStrip();
            MenuCableTester = new ToolStripMenuItem();
            MenuItemLoadConnProf = new ToolStripMenuItem();
            MenuItemShowDbgData = new ToolStripMenuItem();
            MenuProfileCreator = new ToolStripMenuItem();
            lblTestResultValue = new Label();
            btnTest = new Button();
            lblRefFileValue = new Label();
            lblVersion = new Label();
            gbxRefFile = new GroupBox();
            gbxTestResult = new GroupBox();
            btnClean = new Button();
            ((System.ComponentModel.ISupportInitialize)picRecomPinout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMeasuredPinout).BeginInit();
            menuStrip1.SuspendLayout();
            gbxRefFile.SuspendLayout();
            gbxTestResult.SuspendLayout();
            SuspendLayout();
            // 
            // picRecomPinout
            // 
            picRecomPinout.BorderStyle = BorderStyle.FixedSingle;
            picRecomPinout.Location = new System.Drawing.Point(361, 90);
            picRecomPinout.Margin = new Padding(4, 5, 4, 5);
            picRecomPinout.Name = "picRecomPinout";
            picRecomPinout.Size = new System.Drawing.Size(1026, 370);
            picRecomPinout.TabIndex = 1;
            picRecomPinout.TabStop = false;
            // 
            // lblMeasuredPinout
            // 
            lblMeasuredPinout.AutoSize = true;
            lblMeasuredPinout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMeasuredPinout.Location = new System.Drawing.Point(361, 482);
            lblMeasuredPinout.Margin = new Padding(4, 0, 4, 0);
            lblMeasuredPinout.Name = "lblMeasuredPinout";
            lblMeasuredPinout.Size = new System.Drawing.Size(101, 25);
            lblMeasuredPinout.TabIndex = 5;
            lblMeasuredPinout.Text = "Measured:";
            // 
            // lblRecomPinout
            // 
            lblRecomPinout.AutoSize = true;
            lblRecomPinout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRecomPinout.Location = new System.Drawing.Point(361, 60);
            lblRecomPinout.Margin = new Padding(4, 0, 4, 0);
            lblRecomPinout.Name = "lblRecomPinout";
            lblRecomPinout.Size = new System.Drawing.Size(144, 25);
            lblRecomPinout.TabIndex = 10;
            lblRecomPinout.Text = "Recommended:";
            // 
            // picMeasuredPinout
            // 
            picMeasuredPinout.BorderStyle = BorderStyle.FixedSingle;
            picMeasuredPinout.Location = new System.Drawing.Point(361, 512);
            picMeasuredPinout.Margin = new Padding(4, 5, 4, 5);
            picMeasuredPinout.Name = "picMeasuredPinout";
            picMeasuredPinout.Size = new System.Drawing.Size(1026, 370);
            picMeasuredPinout.TabIndex = 6;
            picMeasuredPinout.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuCableTester, MenuProfileCreator });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1406, 35);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuCableTester
            // 
            MenuCableTester.DropDownItems.AddRange(new ToolStripItem[] { MenuItemLoadConnProf, MenuItemShowDbgData });
            MenuCableTester.Name = "MenuCableTester";
            MenuCableTester.Size = new System.Drawing.Size(122, 29);
            MenuCableTester.Text = "Cable Tester";
            // 
            // MenuItemLoadConnProf
            // 
            MenuItemLoadConnProf.Name = "MenuItemLoadConnProf";
            MenuItemLoadConnProf.Size = new System.Drawing.Size(305, 34);
            MenuItemLoadConnProf.Text = "Load connector profile...";
            MenuItemLoadConnProf.Click += MenuLoadConnProfile_Click;
            // 
            // MenuItemShowDbgData
            // 
            MenuItemShowDbgData.Name = "MenuItemShowDbgData";
            MenuItemShowDbgData.Size = new System.Drawing.Size(305, 34);
            MenuItemShowDbgData.Text = "Show debug data";
            MenuItemShowDbgData.Click += MenuShowDebugData_Click;
            // 
            // MenuProfileCreator
            // 
            MenuProfileCreator.Name = "MenuProfileCreator";
            MenuProfileCreator.Size = new System.Drawing.Size(141, 29);
            MenuProfileCreator.Text = "Profile Creator";
            MenuProfileCreator.Click += MenuProfileCreator_Click;
            // 
            // lblTestResultValue
            // 
            lblTestResultValue.AutoSize = true;
            lblTestResultValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTestResultValue.Location = new System.Drawing.Point(7, 57);
            lblTestResultValue.Name = "lblTestResultValue";
            lblTestResultValue.Size = new System.Drawing.Size(92, 48);
            lblTestResultValue.TabIndex = 14;
            lblTestResultValue.Text = "NaN";
            // 
            // btnTest
            // 
            btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTest.Location = new System.Drawing.Point(179, 332);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(154, 55);
            btnTest.TabIndex = 15;
            btnTest.Text = "Test!";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lblRefFileValue
            // 
            lblRefFileValue.AutoSize = true;
            lblRefFileValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRefFileValue.Location = new System.Drawing.Point(7, 37);
            lblRefFileValue.Margin = new Padding(4, 0, 4, 0);
            lblRefFileValue.Name = "lblRefFileValue";
            lblRefFileValue.Size = new System.Drawing.Size(115, 25);
            lblRefFileValue.TabIndex = 17;
            lblRefFileValue.Text = "NaN             ";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Dock = DockStyle.Right;
            lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblVersion.Location = new System.Drawing.Point(1343, 35);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(63, 21);
            lblVersion.TabIndex = 18;
            lblVersion.Text = "v0.0.16";
            // 
            // gbxRefFile
            // 
            gbxRefFile.Controls.Add(lblRefFileValue);
            gbxRefFile.Location = new System.Drawing.Point(16, 77);
            gbxRefFile.Name = "gbxRefFile";
            gbxRefFile.Size = new System.Drawing.Size(319, 92);
            gbxRefFile.TabIndex = 20;
            gbxRefFile.TabStop = false;
            gbxRefFile.Text = "Reference file";
            // 
            // gbxTestResult
            // 
            gbxTestResult.Controls.Add(lblTestResultValue);
            gbxTestResult.Location = new System.Drawing.Point(16, 175);
            gbxTestResult.Name = "gbxTestResult";
            gbxTestResult.Size = new System.Drawing.Size(319, 150);
            gbxTestResult.TabIndex = 21;
            gbxTestResult.TabStop = false;
            gbxTestResult.Text = "Test result";
            // 
            // btnClean
            // 
            btnClean.Location = new System.Drawing.Point(16, 332);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(154, 55);
            btnClean.TabIndex = 22;
            btnClean.Text = "Clean measured";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1406, 935);
            Controls.Add(btnClean);
            Controls.Add(gbxTestResult);
            Controls.Add(btnTest);
            Controls.Add(gbxRefFile);
            Controls.Add(lblVersion);
            Controls.Add(lblRecomPinout);
            Controls.Add(picMeasuredPinout);
            Controls.Add(lblMeasuredPinout);
            Controls.Add(picRecomPinout);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "UniversalCableAnalyzer";
            ((System.ComponentModel.ISupportInitialize)picRecomPinout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMeasuredPinout).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbxRefFile.ResumeLayout(false);
            gbxRefFile.PerformLayout();
            gbxTestResult.ResumeLayout(false);
            gbxTestResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void toolStripMenuItem3_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.PictureBox picRecomPinout;
        private System.Windows.Forms.Label lblMeasuredPinout;
        private System.Windows.Forms.Label lblRecomPinout;
        private System.Windows.Forms.PictureBox picMeasuredPinout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCableTester;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLoadConnProf;
        private System.Windows.Forms.ToolStripMenuItem MenuProfileCreator;
        private Label lblTestResultValue;
        private Button btnTest;
        private ToolStripMenuItem MenuItemShowDbgData;
        private Label lblRefFileValue;
        private Label lblVersion;
        private GroupBox gbxRefFile;
        private GroupBox gbxTestResult;
        private Button btnClean;
    }
}

