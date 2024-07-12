
namespace UniversalCableAnalyzer
{
    partial class DebugWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugWindow));
            lblRefMapping = new System.Windows.Forms.Label();
            lblMeasMapping = new System.Windows.Forms.Label();
            gbxDebugPinMapping = new System.Windows.Forms.GroupBox();
            lblConnToMeasMap = new System.Windows.Forms.Label();
            lblSerialResponse = new System.Windows.Forms.Label();
            lblSimData = new System.Windows.Forms.Label();
            gbxSimDataSerial = new System.Windows.Forms.GroupBox();
            cbEnableSerialResponseDebug = new System.Windows.Forms.CheckBox();
            btnSimulate = new System.Windows.Forms.Button();
            txtSimData = new System.Windows.Forms.TextBox();
            gbxSimWireSch = new System.Windows.Forms.GroupBox();
            cbEnableDebug = new System.Windows.Forms.CheckBox();
            btnSimWireSch = new System.Windows.Forms.Button();
            lblSimWireSch = new System.Windows.Forms.Label();
            txtSimWireSch = new System.Windows.Forms.TextBox();
            gbxDebugPinMapping.SuspendLayout();
            gbxSimDataSerial.SuspendLayout();
            gbxSimWireSch.SuspendLayout();
            SuspendLayout();
            // 
            // lblRefMapping
            // 
            lblRefMapping.AutoSize = true;
            lblRefMapping.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRefMapping.Location = new System.Drawing.Point(9, 32);
            lblRefMapping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRefMapping.Name = "lblRefMapping";
            lblRefMapping.Size = new System.Drawing.Size(129, 19);
            lblRefMapping.TabIndex = 0;
            lblRefMapping.Text = "Reference mapping:";
            // 
            // lblMeasMapping
            // 
            lblMeasMapping.AutoSize = true;
            lblMeasMapping.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMeasMapping.Location = new System.Drawing.Point(200, 32);
            lblMeasMapping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMeasMapping.Name = "lblMeasMapping";
            lblMeasMapping.Size = new System.Drawing.Size(131, 19);
            lblMeasMapping.TabIndex = 1;
            lblMeasMapping.Text = "Measured mapping:";
            // 
            // gbxDebugPinMapping
            // 
            gbxDebugPinMapping.Controls.Add(lblConnToMeasMap);
            gbxDebugPinMapping.Controls.Add(lblRefMapping);
            gbxDebugPinMapping.Controls.Add(lblMeasMapping);
            gbxDebugPinMapping.Location = new System.Drawing.Point(17, 20);
            gbxDebugPinMapping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gbxDebugPinMapping.Name = "gbxDebugPinMapping";
            gbxDebugPinMapping.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            gbxDebugPinMapping.Size = new System.Drawing.Size(777, 682);
            gbxDebugPinMapping.TabIndex = 2;
            gbxDebugPinMapping.TabStop = false;
            gbxDebugPinMapping.Text = "Connector pin mapping";
            // 
            // lblConnToMeasMap
            // 
            lblConnToMeasMap.AutoSize = true;
            lblConnToMeasMap.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblConnToMeasMap.Location = new System.Drawing.Point(387, 32);
            lblConnToMeasMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConnToMeasMap.Name = "lblConnToMeasMap";
            lblConnToMeasMap.Size = new System.Drawing.Size(148, 19);
            lblConnToMeasMap.TabIndex = 4;
            lblConnToMeasMap.Text = "Connections [A] -> |B]:";
            // 
            // lblSerialResponse
            // 
            lblSerialResponse.AutoSize = true;
            lblSerialResponse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSerialResponse.Location = new System.Drawing.Point(17, 707);
            lblSerialResponse.Name = "lblSerialResponse";
            lblSerialResponse.Size = new System.Drawing.Size(187, 21);
            lblSerialResponse.TabIndex = 3;
            lblSerialResponse.Text = "Received from serialport: ";
            // 
            // lblSimData
            // 
            lblSimData.AutoSize = true;
            lblSimData.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSimData.Location = new System.Drawing.Point(6, 90);
            lblSimData.Name = "lblSimData";
            lblSimData.Size = new System.Drawing.Size(352, 19);
            lblSimData.TabIndex = 4;
            lblSimData.Text = "e.g: <RESULT,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0>";
            // 
            // gbxSimDataSerial
            // 
            gbxSimDataSerial.Controls.Add(cbEnableSerialResponseDebug);
            gbxSimDataSerial.Controls.Add(btnSimulate);
            gbxSimDataSerial.Controls.Add(txtSimData);
            gbxSimDataSerial.Controls.Add(lblSimData);
            gbxSimDataSerial.Location = new System.Drawing.Point(811, 20);
            gbxSimDataSerial.Name = "gbxSimDataSerial";
            gbxSimDataSerial.Size = new System.Drawing.Size(434, 320);
            gbxSimDataSerial.TabIndex = 5;
            gbxSimDataSerial.TabStop = false;
            gbxSimDataSerial.Text = "Simulate data from serialport";
            // 
            // cbEnableSerialResponseDebug
            // 
            cbEnableSerialResponseDebug.AutoSize = true;
            cbEnableSerialResponseDebug.Location = new System.Drawing.Point(6, 160);
            cbEnableSerialResponseDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbEnableSerialResponseDebug.Name = "cbEnableSerialResponseDebug";
            cbEnableSerialResponseDebug.Size = new System.Drawing.Size(228, 29);
            cbEnableSerialResponseDebug.TabIndex = 7;
            cbEnableSerialResponseDebug.Text = "Simulate serial response";
            cbEnableSerialResponseDebug.UseVisualStyleBackColor = true;
            cbEnableSerialResponseDebug.CheckedChanged += cbEnableSerialResponseDebug_CheckedChanged;
            // 
            // btnSimulate
            // 
            btnSimulate.Location = new System.Drawing.Point(259, 157);
            btnSimulate.Name = "btnSimulate";
            btnSimulate.Size = new System.Drawing.Size(127, 42);
            btnSimulate.TabIndex = 6;
            btnSimulate.Text = "Set response";
            btnSimulate.UseVisualStyleBackColor = true;
            btnSimulate.Click += btnSimulate_Click;
            // 
            // txtSimData
            // 
            txtSimData.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSimData.Location = new System.Drawing.Point(6, 113);
            txtSimData.Name = "txtSimData";
            txtSimData.Size = new System.Drawing.Size(380, 26);
            txtSimData.TabIndex = 5;
            txtSimData.Text = "<RESULT,8,64,128,48,1,8,4,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0>";
            // 
            // gbxSimWireSch
            // 
            gbxSimWireSch.Controls.Add(cbEnableDebug);
            gbxSimWireSch.Controls.Add(btnSimWireSch);
            gbxSimWireSch.Controls.Add(lblSimWireSch);
            gbxSimWireSch.Controls.Add(txtSimWireSch);
            gbxSimWireSch.Location = new System.Drawing.Point(811, 347);
            gbxSimWireSch.Name = "gbxSimWireSch";
            gbxSimWireSch.Size = new System.Drawing.Size(434, 355);
            gbxSimWireSch.TabIndex = 6;
            gbxSimWireSch.TabStop = false;
            gbxSimWireSch.Text = "Simulate wiring schema";
            // 
            // cbEnableDebug
            // 
            cbEnableDebug.AutoSize = true;
            cbEnableDebug.Location = new System.Drawing.Point(6, 128);
            cbEnableDebug.Name = "cbEnableDebug";
            cbEnableDebug.Size = new System.Drawing.Size(206, 29);
            cbEnableDebug.TabIndex = 7;
            cbEnableDebug.Text = "Simulate connections";
            cbEnableDebug.UseVisualStyleBackColor = true;
            cbEnableDebug.CheckedChanged += cbEnableDebug_CheckedChanged;
            // 
            // btnSimWireSch
            // 
            btnSimWireSch.Location = new System.Drawing.Point(259, 125);
            btnSimWireSch.Name = "btnSimWireSch";
            btnSimWireSch.Size = new System.Drawing.Size(127, 42);
            btnSimWireSch.TabIndex = 7;
            btnSimWireSch.Text = "Set reference";
            btnSimWireSch.UseVisualStyleBackColor = true;
            btnSimWireSch.Click += btnSimWireSch_Click_1;
            // 
            // lblSimWireSch
            // 
            lblSimWireSch.AutoSize = true;
            lblSimWireSch.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSimWireSch.Location = new System.Drawing.Point(6, 58);
            lblSimWireSch.Name = "lblSimWireSch";
            lblSimWireSch.Size = new System.Drawing.Size(208, 19);
            lblSimWireSch.TabIndex = 7;
            lblSimWireSch.Text = "e.g:   5, 8, 7, [1,6], 4, 4, 2, 3, 0, 0 ";
            // 
            // txtSimWireSch
            // 
            txtSimWireSch.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSimWireSch.Location = new System.Drawing.Point(6, 82);
            txtSimWireSch.Name = "txtSimWireSch";
            txtSimWireSch.Size = new System.Drawing.Size(380, 26);
            txtSimWireSch.TabIndex = 0;
            txtSimWireSch.Text = "4, 7, 8, [5,6], 1, 4, 3, 2, 0, 0 ";
            // 
            // DebugWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1259, 743);
            Controls.Add(gbxSimWireSch);
            Controls.Add(gbxSimDataSerial);
            Controls.Add(lblSerialResponse);
            Controls.Add(gbxDebugPinMapping);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "DebugWindow";
            Text = "UniversalCableAnalyzer - Debug";
            gbxDebugPinMapping.ResumeLayout(false);
            gbxDebugPinMapping.PerformLayout();
            gbxSimDataSerial.ResumeLayout(false);
            gbxSimDataSerial.PerformLayout();
            gbxSimWireSch.ResumeLayout(false);
            gbxSimWireSch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRefMapping;
        private System.Windows.Forms.Label lblMeasMapping;
        private System.Windows.Forms.GroupBox gbxDebugPinMapping;
        private System.Windows.Forms.Label lblConnToMeasMap;
        private System.Windows.Forms.Label lblSerialResponse;
        private System.Windows.Forms.Label lblSimData;
        private System.Windows.Forms.GroupBox gbxSimDataSerial;
        private System.Windows.Forms.TextBox txtSimData;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.GroupBox gbxSimWireSch;
        private System.Windows.Forms.Label lblSimWireSch;
        private System.Windows.Forms.TextBox txtSimWireSch;
        private System.Windows.Forms.Button btnSimWireSch;
        private System.Windows.Forms.CheckBox cbEnableDebug;
        private System.Windows.Forms.CheckBox cbEnableSerialResponseDebug;
    }
}