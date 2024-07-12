using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalCableAnalyzer
{
    public partial class DebugWindow : Form
    {
        private const string refmap = "Reference mapping: \r\n";
        private const string measmap = "Measured mapping: \r\n";
        private const string connectedto = "Connections [A] -> |B]: \r\n\r\n";
        private const string serialresponse = "Received from serialport: ";
        // response should look like <RESULT,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0>

        public DebugWindow()
        {
            InitializeComponent();
            FillUpForm();
            DebugDataHelper.GlobalPropertyChanged += this.HandleGlobalPropertyChanged;
        }


        public void FillUpForm()
        {
            lblRefMapping.Text = refmap + DebugDataHelper.RefMapping;
            lblMeasMapping.Text = measmap + DebugDataHelper.MeasMapping;
            lblConnToMeasMap.Text = connectedto + DebugDataHelper.ConnectedTo;
            lblSerialResponse.Text = serialresponse + DebugDataHelper.SerialResponse;
        }


        void HandleGlobalPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Refmapping":
                    lblRefMapping.Text = refmap + DebugDataHelper.RefMapping;
                    break;
                case "Measmapping":
                    lblMeasMapping.Text = measmap + DebugDataHelper.MeasMapping;
                    break;
                case "ConnectedTo":
                    lblConnToMeasMap.Text = connectedto + DebugDataHelper.ConnectedTo;
                    break;
                case "Serialresponse":
                    lblSerialResponse.Text = serialresponse + DebugDataHelper.SerialResponse;
                    break;
            }
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            MainWindow.SerialResponseForDebug = txtSimData.Text;
        }

        private void btnSimWireSch_Click_1(object sender, EventArgs e)
        {
            MainWindow.TestReference = MainWindow.ConvertWiringToSerial(MainWindow.ParseStringToDataStructure(txtSimWireSch.Text));
        }

        private void cbEnableDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableDebug.Checked)
            {
                MainWindow.DebugPinReference = true;
            }
            else { MainWindow.DebugPinReference = false; }
        }

        private void cbEnableSerialResponseDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableSerialResponseDebug.Checked)
            {
                MainWindow.DebugSerialResponse = true;
            }
            else { MainWindow.DebugSerialResponse = false; }
        }
    }
}
