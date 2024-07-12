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
    public partial class CProfilePreConfigWindow : Form
    {
        public CProfilePreConfigWindow()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int numRowsA = (int)nudAsideRows.Value;
            int numPinsA = (int)nudAsidePinCount.Value;
            int numRowsB = (int)nudBsideRows.Value;
            int numPinsB = (int)nudBsidePinCount.Value;

            string sideAName = txtAsideName.Text;
            string sideBName = txtBsideName.Text;
            string profileName = txtProfileName.Text;
            string fileName = txtFileName.Text;

            CProfilePinConfigWindow cpcw = new CProfilePinConfigWindow(numRowsA, numPinsA, numRowsB, numPinsB, profileName, fileName, sideAName, sideBName);
            cpcw.Show();
        }
    }
}
