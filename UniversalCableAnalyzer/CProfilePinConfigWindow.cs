using CheckComboBoxTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace UniversalCableAnalyzer
{
    public partial class CProfilePinConfigWindow : Form
    {
        public CProfilePinConfigWindow(int numRowsA, int numPinsA, int numRowsB, int numPinsB, string profileName, string fileName, string ASideName, string BSideName)
        {
            InitializeComponent();

            _numPinsA = numPinsA;
            _numRowsA = numRowsA;
            _numPinsB = numPinsB;
            _numRowsB = numRowsB;
            _profileName = profileName;
            _fileName = fileName;
            _ASideName = ASideName;
            _BSideName = BSideName;

            CreateControlsA();
            CreateControlsB();
            ArrangeControls();
        }

        private int _numPinsA = 0;
        private int _numRowsA = 0;
        private int _numPinsB = 0;
        private int _numRowsB = 0;
        private string _profileName;
        private string _fileName;
        private string _ASideName;
        private string _BSideName;
        private GroupBox groupBoxA;
        private GroupBox groupBoxB;
        private CheckedComboBox ccbPinA;
        private CheckedComboBox ccbPinB;
        private Label lblPinHoleNrA;
        private Label lblPinHoleNrB;

        private void CreateControlsA()
        {
            List<object> pins = new List<object>(); // stores the B side pinholes
            groupBoxA = new GroupBox();
            groupBoxA.Text = "Side \"A\"";
            groupBoxA.Location = new Point(30, 70);

            for (int i = 1; i <= _numPinsB; i++)    // we need to have the B side pinhole numbers !!
            {
                pins.Add(i);
            }

            int rowSizeA = _numPinsA / _numRowsA;
            if (_numPinsA % _numRowsA != 0)
            {
                rowSizeA++;
            }

            int drawX = 1;
            int drawY = 1;
            for (int i = 1; i <= _numPinsA; i++)
            {

                ccbPinA = new CheckedComboBox();
                ccbPinA.Name = "ccbPinA" + i;
                ccbPinA.Items.Add("NaN");         // for no connection
                ccbPinA.Items.AddRange(pins.ToArray());
                ccbPinA.Location = new Point(drawX * 82 - 60, drawY * 82 - 20);
                ccbPinA.Size = new Size(82, 20);
                lblPinHoleNrA = new Label();
                lblPinHoleNrA.Size = new Size(42, 25);
                lblPinHoleNrA.Text = i + ")";
                lblPinHoleNrA.Name = "lblPinHoleNrA" + i + ")";
                lblPinHoleNrA.Location = new Point(ccbPinA.Location.X + 25, ccbPinA.Location.Y - 25);  // label positioned to the center of the checkedcombobox located below
                groupBoxA.Controls.Add(ccbPinA);
                groupBoxA.Controls.Add(lblPinHoleNrA);
                if (drawX < rowSizeA)
                {
                    drawX++;
                }
                else
                {
                    drawX = 1;
                    drawY++;
                }
            }
            groupBoxA.Size = new Size(rowSizeA * ccbPinA.Size.Width + ccbPinA.Size.Width + 40, 300);
            this.Controls.Add(groupBoxA);
        }


        private void CreateControlsB()
        {
            List<object> pins = new List<object>(); // stores the A side pinhole
            groupBoxB = new GroupBox();
            groupBoxB.Text = "Side \"B\"";
            groupBoxB.Location = new Point(30, 400);

            for (int i = 1; i <= _numPinsA; i++)    // we need to have the A side pinhole numbers !!
            {
                pins.Add(i);
            }

            int rowsizeB = _numPinsB / _numRowsB;
            if (_numPinsB % _numRowsB != 0)
            {
                rowsizeB++;
            }

            int drawX = 1;
            int drawY = 1;
            for (int i = 1; i <= _numPinsB; i++)
            {
                ccbPinB = new CheckedComboBox();
                ccbPinB.Name = "ccbPinB" + i;
                ccbPinB.Items.Add("NaN");         // for no connection
                ccbPinB.Items.AddRange(pins.ToArray());
                ccbPinB.Location = new Point(drawX * 82 - 60, drawY * 82 - 20);
                ccbPinB.Size = new Size(82, 20);
                lblPinHoleNrB = new Label();
                lblPinHoleNrB.Size = new Size(42, 25);
                lblPinHoleNrB.Text = i + ")";
                lblPinHoleNrB.Name = "lblPinHoleNrB" + i + ")";
                lblPinHoleNrB.Location = new Point(ccbPinB.Location.X + 25, ccbPinB.Location.Y - 25);  // label positioned to the center of the checkedcombobox located below
                groupBoxB.Controls.Add(ccbPinB);
                groupBoxB.Controls.Add(lblPinHoleNrB);

                if (drawX < rowsizeB)
                {
                    drawX++;
                }
                else
                {
                    drawX = 1;
                    drawY++;
                }
            }
            groupBoxB.Size = new Size(rowsizeB * ccbPinB.Size.Width + ccbPinB.Size.Width + 40, 300);
            this.Controls.Add(groupBoxB);
        }


        private void ArrangeControls()
        {
            int x = 0;
            int y = 0;
            foreach (Control control in this.Controls)
            {
                if (control.Right > x)
                {
                    x = control.Right;
                }

                if (control.Bottom > y)
                {
                    y = control.Bottom;
                }
            }

            Size = new Size(x + 160, y + 160);
            btnCreateProfile.Location = new Point(this.Size.Width - 34 - btnCreateProfile.Width, this.Size.Height - 68 - btnCreateProfile.Height);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (XmlWriter writer = XmlWriter.Create(_fileName + ".xml"))
            {
                writer.WriteComment(_profileName + " connector type");
                // Start writing the XML file
                writer.WriteStartElement("Main");

                // Write the variables to the XML file, Connector1
                writer.WriteStartElement("Side1");
                writer.WriteStartElement("SideName");
                writer.WriteValue(_ASideName);
                writer.WriteEndElement();
                writer.WriteStartElement("PinCount");
                writer.WriteValue(_numPinsA);
                writer.WriteEndElement();
                writer.WriteStartElement("RowCount");
                writer.WriteValue(_numRowsA);
                writer.WriteEndElement();
                writer.WriteComment("Pins");

                for (int i = 0; i < _numPinsA; i++)
                {
                    writer.WriteStartElement("Pin" + (i + 1));
                    writer.WriteStartElement("PinHole");
                    writer.WriteValue(i + 1);
                    writer.WriteEndElement();
                    writer.WriteStartElement("ConnectedTo");
                    writer.WriteValue(MainWindow.NulToNan(getComboBoxValuesForXML("A", i + 1).ToString()));
                    writer.WriteEndElement();
                    writer.WriteStartElement("Color");
                    writer.WriteValue("1");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                // Write the variables to the XML file, Connector2
                writer.WriteStartElement("Side2");
                writer.WriteStartElement("SideName");
                writer.WriteValue(_BSideName);
                writer.WriteEndElement();
                writer.WriteStartElement("PinCount");
                writer.WriteValue(_numPinsB);
                writer.WriteEndElement();
                writer.WriteStartElement("RowCount");
                writer.WriteValue(_numRowsB);
                writer.WriteEndElement();
                writer.WriteComment("Pins");

                for (int i = 0; i < _numPinsB; i++)
                {
                    writer.WriteStartElement("Pin" + (i + 1));
                    writer.WriteStartElement("PinHole");
                    writer.WriteValue(i + 1);
                    writer.WriteEndElement();
                    writer.WriteStartElement("ConnectedTo");
                    writer.WriteValue(MainWindow.NulToNan(getComboBoxValuesForXML("B", i + 1).ToString()));
                    writer.WriteEndElement();
                    writer.WriteStartElement("Color");
                    writer.WriteValue("1");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                // End the XML file
                writer.WriteEndElement();
            }
        }


        private object getComboBoxValuesForXML(string connector, int ccomboBoxIndex)
        {
            string comboBoxName = "ccbPin" + connector + ccomboBoxIndex;
            CheckedComboBox comboBox = this.Controls.Find(comboBoxName, true).FirstOrDefault() as CheckedComboBox;
            if (comboBox != null)
            {
                return FormatString(comboBox.Text);     // 1, 2  -> [1,2]  or   1 -> 1
            }
            else
            {
                return null;
            }
        }


        public string FormatString(string input)
        {
            string[] numbers = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length == 1)
            {
                // Only one number, leave it untouched
                return numbers[0];
            }
            else if (numbers.Length == 2)
            {
                // Two numbers, format them as [number1, number2]
                return $"[{numbers[0]},{numbers[1]}]";
            }
            else
            {
                // Invalid input format
                return "Invalid input format";
            }
        }
    }
}
