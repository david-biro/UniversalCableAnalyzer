using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Management;
using System.Text;


namespace UniversalCableAnalyzer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
            graphics.Dispose();
        }

        List<Label> _refConnectorA;
        List<Label> _refConnectorB;
        List<Label> _measConnectorA;
        List<Label> _measConnectorB;
        private DebugWindow _dbgFormCurrentInstance = null;
        private CProfilePreConfigWindow _profileCreatorWindowInstance = null;
        private SerialPort _serialPort = new SerialPort();
        private PinHoleDataElement[] _dataElementsA;     // size is pinconnector A pincount
        private PinHoleDataElement[] _dataElementsB;     // size is pinconnector B pincount
        private int _margin = 25;    // from the edge of the picturebox, both top and left

        // variables for testing, static, DebugWindow set them
        public static int[] TestReference = new int[32];
        public static string SerialResponseForDebug = "";
        public static bool DebugPinReference = false;
        public static bool DebugSerialResponse = false;


        // drawing the reference profile, after the reference profile XML is loaded
        private void DrawRefProfileAB(string profilename)
        {
            picRecomPinout.Controls.Clear();
            _refConnectorA = new List<Label>();
            _refConnectorB = new List<Label>();
            XmlConnectorProfile.Read(profilename);
            Graphics graphics = this.CreateGraphics();
            graphics.Dispose();

            // CONNECTOR A
            int c1_x = 1;
            int c1_y = 1;
            for (int i = 0; i < XmlConnectorProfile.PinCountA; i++)
            {
                Label newlblA = new();
                _refConnectorA.Add(newlblA);
                _refConnectorA[i].Text = NulToNan(XmlConnectorProfile.ConnectedToA[i]);
                _refConnectorA[i].Font = new Font("Arial", 7);
                _refConnectorA[i].Left = c1_x * 50 - _margin; _refConnectorA[i].Top = c1_y * 50 - _margin;

                if (c1_x < (XmlConnectorProfile.PinCountA / XmlConnectorProfile.RowCountA))
                {
                    c1_x++;
                }
                else
                {
                    c1_x = 1;
                    c1_y++;
                }
                _refConnectorA[i].Height = 50; _refConnectorA[i].Width = 50;
                _refConnectorA[i].BackColor = Color.MediumAquamarine;
                _refConnectorA[i].BorderStyle = BorderStyle.FixedSingle;
                picRecomPinout.Controls.Add(_refConnectorA[i]);
            }
            Label a = new();
            a.Width = 1200;
            a.Text = XmlConnectorProfile.ConnNameA + " side";
            a.Left = 20;
            a.Top = _refConnectorA[1].Top - _margin;
            picRecomPinout.Controls.Add(a);

            // CONNECTOR B
            int c2_x = 1;
            int c2_y = 1;
            int distance = _refConnectorA[XmlConnectorProfile.PinCountA - 1].Top + _margin;
            for (int i = 0; i < XmlConnectorProfile.PinCountB; i++)
            {
                Label newlblB = new();
                _refConnectorB.Add(newlblB);
                _refConnectorB[i].Text = NulToNan(XmlConnectorProfile.PinHoleB[i].ToString());
                _refConnectorB[i].Font = new Font("Arial", 7);
                _refConnectorB[i].Left = c2_x * 50 - _margin;
                _refConnectorB[i].Top = (c2_y * 50) + distance;
                if (c2_x < (XmlConnectorProfile.PinCountB / XmlConnectorProfile.RowCountB))
                {
                    c2_x++;
                }
                else
                {
                    c2_x = 1;
                    c2_y++;
                }
                _refConnectorB[i].Height = 50; _refConnectorB[i].Width = 50;
                _refConnectorB[i].BackColor = Color.Aquamarine;
                _refConnectorB[i].BorderStyle = BorderStyle.FixedSingle;
                picRecomPinout.Controls.Add(_refConnectorB[i]);
            }
            Label b = new();
            b.Width = 1200;
            b.Text = XmlConnectorProfile.ConnNameB + " side";
            b.Left = 20;
            b.Top = _refConnectorB[1].Top - _margin;
            picRecomPinout.Controls.Add(b);
            FormResizer(picRecomPinout, _refConnectorA, _refConnectorB);
        }


        private void FormResizer(PictureBox pictureBox, List<Label> connectorALabels, List<Label> connectorBLabels)
        {
            if (connectorALabels[connectorALabels.Count - 1].Right >= connectorBLabels[connectorBLabels.Count - 1].Right)
            {
                pictureBox.Width = connectorALabels[connectorALabels.Count - 1].Right + _margin;
            }
            else pictureBox.Width = connectorBLabels[connectorBLabels.Count - 1].Right + _margin;
            pictureBox.Height = connectorBLabels[connectorBLabels.Count - 1].Bottom + _margin;

            lblMeasuredPinout.Top = picRecomPinout.Bottom + 20;
            picMeasuredPinout.Top = lblMeasuredPinout.Bottom + 5;


            if (picMeasuredPinout.Right > picRecomPinout.Right)
            {
                this.ClientSize = new Size(picMeasuredPinout.Right + _margin, picMeasuredPinout.Bottom + _margin);
            }
            else this.ClientSize = new Size(picRecomPinout.Right + _margin, picMeasuredPinout.Bottom + _margin);
        }


        public static string NulToNan(string str)
        {
            string _str;
            if (str == "NaN")
                _str = "0";
            else if (str == "0")
                _str = "NaN";
            else if (str == "")
                _str = "NaN";
            else
                _str = str;
            return _str;
        }

  
        private string BlockingSerialSender(string message, string portName)
        {
            string response = "";
            try
            {
                _serialPort.PortName = portName;
                _serialPort.BaudRate = 115200;
                _serialPort.ReadTimeout = 1000;
                _serialPort.Open();
                _serialPort.WriteLine(message);
                response = _serialPort.ReadLine();
            }
            catch (TimeoutException)
            { return response; }
            finally
            {
                if (_serialPort.IsOpen) _serialPort.Close();
            }
            return response;
        }


        private List<int[]> ConvertWiringArrayToWiringList(string[] positionsFromXML)
        {
            List<int[]> intArrayList = new List<int[]>();

            foreach (string item in positionsFromXML)
            {
                if (item.StartsWith("[") && item.EndsWith("]"))
                {
                    // remove the brackets and split the contents by comma
                    string[] numbers = item.Trim('[', ']').Split(',');

                    int[] intArray = new int[numbers.Length];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        intArray[i] = int.Parse(numbers[i].Trim());
                    }

                    intArrayList.Add(intArray);
                }
                else
                {
                    int value = int.Parse(item.Trim());
                    intArrayList.Add(new int[] { value });
                }
            }
            return intArrayList;
        }

     
        private void CompareRefWithMeas(int[] refs, int[] meas)
        {
            int[] _result = new int[XmlConnectorProfile.PinCountB];
            string _ref = "";
            string _meas = "";

            for (int i = 0; i < XmlConnectorProfile.PinCountB; i++)
            {
                if (refs[i] == meas[i])
                {
                    _result[i] = 1;
                }
                _ref = _ref + "\r\n" + refs[i];
                _meas = _meas + "\r\n" + meas[i];
            }

            DebugDataHelper.MeasMapping = _meas;
            DebugDataHelper.RefMapping = _ref;

            if (Array.TrueForAll(_result, x => x == 1))
            { lblTestResultValue.ForeColor = Color.LimeGreen; lblTestResultValue.Text = "CABLE OK"; }
            else
            { lblTestResultValue.ForeColor = Color.Red; lblTestResultValue.Text = "CABLE NOT OK"; }
        }


        // this function is for setting the color
        private static Color CompareRefWithMeas(Label refs, Label meas)
        {
            Color _measPinColor;

            if (refs.Text == meas.Text) _measPinColor = Color.MediumAquamarine;
            else _measPinColor = Color.Red;

            return _measPinColor;
        }


        private static int[] GetBinaryOnesPositions(int number)
        {
            // convert the integer number to a bit array with the leftmost bit being the least significant bit (LSB)
            BitArray bits = new BitArray(BitConverter.GetBytes(number));

            // find the positions of the connectedto '1' values in an array
            List<int> positions = new List<int>();
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i])
                {
                    positions.Add(i + 1);
                }
            }

            if (positions.Count == 0)
            {
                positions.Add(0);
            }

            return positions.ToArray(); // [3,4,5] -> 001110  or  [1,7] -> 1000001
        }


        private void FillDataStructures(int[] serialresponse)
        {
            // BEGIN TESTDATA 
            // int[] testData_PCIe_PSU = new int[] { 8, 64, 128, 48, 1, 8, 4, 2, 0, 0 ...};    // test data we get from serial
            // binary representative in reverse order
            // 0001 0000 0000 0000 0000 0000 0000 0000 -> 8 -> connected to 4th pin
            // 0000 0010 0000 0000 0000 0000 0000 0000 -> 64 -> connected to 7th pin
            // 0000 0001 0000 0000 0000 0000 0000 0000 -> 128 -> connected to 8th pin
            // 0000 1100 0000 0000 0000 0000 0000 0000 -> 48 -> connected to 5th and 6th pin
            // 1000 0000 0000 0000 0000 0000 0000 0000 -> 1
            // 0001 0000 0000 0000 0000 0000 0000 0000 -> 8
            // 0010 0000 0000 0000 0000 0000 0000 0000 -> 4
            // 0100 0000 0000 0000 0000 0000 0000 0000 -> 2
            // 0000 0000 0000 0000 0000 0000 0000 0000 -> 0
            // 0000 0000 0000 0000 0000 0000 0000 0000 -> 0
            //
            // testData_PCIe_PSU_reverse {4, 7, 8, <5,6>, 1, 4, 3, 2}
            // END TESTDATA

            List<int[]> ABPositions = new List<int[]>();
            //{ 5, 1, 4, 4, 4, 0, 5, 0, 0, 0 }; the items of the list are arrays, because one pin can have multiple connections to the other side
            //{    2,                        };

            for (int f = 0; f < serialresponse.Length; f++)
            {
                ABPositions.Add(GetBinaryOnesPositions(serialresponse[f]));  // ABPositions -> A side connections
            }

            int pincntb = 1;    // increase it from one to accomodate to real world
            _dataElementsB = new PinHoleDataElement[XmlConnectorProfile.PinCountB];  // we must initialize for the B pinhole size 
            for (int y = 0; y < XmlConnectorProfile.PinCountB; y++)
            {
                var matchingArrays = ABPositions.Where(a => a.Contains(pincntb));
                var indices = matchingArrays.Select(a => ABPositions.IndexOf(a));
                _dataElementsB[y] = new PinHoleDataElement(pincntb, indices.ToArray(), serialresponse[y]); // B side connections
                pincntb++;
            }

            int pincnta = 1;    // increase it from one to accomodate to real world
            _dataElementsA = new PinHoleDataElement[XmlConnectorProfile.PinCountA];  // we must initialize for the A pinhole size 
            for (int z = 0; z < XmlConnectorProfile.PinCountA; z++)
            {
                _dataElementsA[z] = new PinHoleDataElement(pincnta, ABPositions[z], serialresponse[z]);
                pincnta++;
            }

            DrawMeasProfileA(_dataElementsA);
            DrawMeasProfileB(_dataElementsB);
            ConvertWiringToSerial(ABPositions);
            FormResizer(picMeasuredPinout, _measConnectorA, _measConnectorB);
        }


        public static int[] ConvertWiringToSerial(List<int[]> connectedto)
        {
            // fill with PCIe-PSU test data
            //List<int[]> ABPositions = new List<int[]>   // fill with PCIe-PSU test data
            //{
            //    new int[] {4},
            //    new int[] {7},
            //    new int[] {8},
            //    new int[] {5, 6},
            //    new int[] {1},
            //    new int[] {4},
            //    new int[] {3},
            //    new int[] {2}
            //};

            List<string> binaryNumbers = new List<string>();
            List<int> decimalNumbers = new List<int>();

            foreach (int[] positions in connectedto)
            {
                int maxPosition = positions.Max();
                StringBuilder binaryString = new StringBuilder();

                if (positions.Contains(0))
                {
                    binaryString.Append('0');
                }
                else
                {
                    for (int i = maxPosition; i >= 1; i--)
                    {
                        if (positions.Contains(i))
                        {
                            binaryString.Append('1');
                        }
                        else
                        {
                            binaryString.Append('0');
                        }
                    }
                }

                string binary = binaryString.ToString();
                binaryNumbers.Add(binary);
                int decimalNumber = binary.Contains('1') ? Convert.ToInt32(binary, 2) : 0;
                decimalNumbers.Add(decimalNumber);
            }

            int targetIndex = 32;

            for (int i = binaryNumbers.Count; i < targetIndex; i++)
            {
                binaryNumbers.Insert(binaryNumbers.Count, "0");
            }

            int[] binaryNumbersArray = binaryNumbers.Select(binary => Convert.ToInt32(binary, 2)).ToArray();

            return binaryNumbersArray;
        }


        public static List<int[]> ParseStringToDataStructure(string input)
        {
            List<int[]> dataStructure = new List<int[]>();

            StringBuilder currentElement = new StringBuilder();
            bool insideBrackets = false;

            void AddElement()
            {
                if (currentElement.Length > 0)
                {
                    string[] elements = currentElement.ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] array = Array.ConvertAll(elements, int.Parse);
                    dataStructure.Add(array);
                    currentElement.Clear();
                }
            }

            foreach (char c in input)
            {
                if (c == '[')
                {
                    insideBrackets = true;
                    currentElement.Clear();
                }
                else if (c == ']')
                {
                    insideBrackets = false;
                    AddElement();
                    currentElement.Clear();
                }
                else if (c == ',' && !insideBrackets)
                {
                    AddElement();
                }
                else
                {
                    currentElement.Append(c);
                }
            }

            AddElement();

            return dataStructure;
        }


        // drawing function for connector A
        private void DrawMeasProfileA(PinHoleDataElement[] m_pinArray)
        {
            int drawX = 1;  // local helper variable for drawing
            int drawY = 1;  // local helper variable for drawing 
            _measConnectorA = new List<Label>();
            for (int i = 0; i < m_pinArray.Length; i++)
            {
                Label newlblA = new();
                if (!(m_pinArray[i] == null))
                {
                    _measConnectorA.Add(newlblA);
                    string str = "";
                    for (int j = 0; j < m_pinArray[i].ConnectedTo.Length; j++)
                    {
                        str += NulToNan(m_pinArray[i].ConnectedTo[j].ToString()) + ",";
                    }

                    if (m_pinArray[i].ConnectedTo.Length > 1)
                    {

                        str = str.Remove(str.Length - 1);
                        _measConnectorA[i].Text = "[" + str + "]";
                    }
                    else
                    {
                        str = str.Replace(",", "");
                        _measConnectorA[i].Text = str;
                    }

                    DebugDataHelper.ConnectedTo += i + 1 + "  ->  " + _measConnectorA[i].Text + Environment.NewLine;
                    _measConnectorA[i].Font = new Font("Arial", 7);
                    _measConnectorA[i].Left = drawX * 50 - _margin;
                    _measConnectorA[i].Top = (drawY * 50) - _margin;
                    int PinCount_A = XmlConnectorProfile.PinCountA;
                    int RowCount_A = XmlConnectorProfile.RowCountA;
                    if (drawX < (PinCount_A / RowCount_A))
                    {
                        drawX++;
                    }
                    else
                    {
                        drawX = 1;
                        drawY++;
                    }
                    _measConnectorA[i].Height = 50; _measConnectorA[i].Width = 50;
                    _measConnectorA[i].BackColor = CompareRefWithMeas(_refConnectorA[i], _measConnectorA[i]);
                    _measConnectorA[i].BorderStyle = BorderStyle.FixedSingle;
                    picMeasuredPinout.Controls.Add(_measConnectorA[i]);
                }
            }
            Label a = new();
            a.Width = 1200;
            a.Text = XmlConnectorProfile.ConnNameA + " side";
            a.Left = 20;
            a.Top = _measConnectorA[1].Top - _margin;
            picMeasuredPinout.Controls.Add(a);
        }


        // drawing function for connector B
        private void DrawMeasProfileB(PinHoleDataElement[] m_pinArray)
        {
            int drawX = 1;
            int drawY = 1;
            _measConnectorB = new List<Label>();
            int distance = _measConnectorA[XmlConnectorProfile.PinCountA - 1].Top + _margin;
            for (int i = 0; i < m_pinArray.Length; i++)
            {
                Label newlblB = new();
                if (!(m_pinArray[i] == null))
                {
                    _measConnectorB.Add(newlblB);
                    _measConnectorB[i].Text += NulToNan((i + 1).ToString());
                    _measConnectorB[i].Font = new Font("Arial", 7);
                    int PinCount_B = XmlConnectorProfile.PinCountB;
                    int RowCount_B = XmlConnectorProfile.RowCountB;
                    _measConnectorB[i].Left = drawX * 50 - _margin;
                    _measConnectorB[i].Top = (drawY * 50) + distance;
                    if (drawX < (PinCount_B / RowCount_B))
                    {
                        drawX++;
                    }
                    else
                    {
                        drawX = 1;
                        drawY++;
                    }

                    _measConnectorB[i].Height = 50; _measConnectorB[i].Width = 50;
                    _measConnectorB[i].BackColor = Color.Aquamarine;
                    _measConnectorB[i].BorderStyle = BorderStyle.FixedSingle;
                    picMeasuredPinout.Controls.Add(_measConnectorB[i]);
                }
            }
            Label b = new();
            b.Width = 1200;
            b.Text = XmlConnectorProfile.ConnNameB + " side";
            b.Left = 20;
            b.Top = _measConnectorB[1].Top - _margin;
            picMeasuredPinout.Controls.Add(b);
        }


        private static void ResetDebugVariables()
        {
            DebugDataHelper.MeasMapping = "";
            DebugDataHelper.RefMapping = "";
            DebugDataHelper.ConnectedTo = "";
            DebugDataHelper.SerialResponse = "";
        }


        private void CleanMeasBox()
        {
            picMeasuredPinout.Controls.Clear();
        }


        // not used function, reverse of ConvertWiringToSerial function
        //public void ConvertSerialToWiring(int[] incoming)
        //{
        //    List<int[]> ABPositions = new List<int[]>();
        //    //{ 5, 1, 4, 4, 4, 0, 5, 0, 0, 0 }; the items of the list are arrays
        //    //{    2,                        };
        //
        //    for (int f = 0; f < incoming.Length; f++)
        //    {
        //        ABPositions.Add(GetBinaryOnesPositions(incoming[f]));
        //    }
        //
        //    int pincntb = 1;
        //    PinHoleDataElement[] XMLitemB = new PinHoleDataElement[32];
        //    int[] XMLitemA = new int[8];
        //    for (int y = 0; y < ABPositions.Count; y++)
        //    {
        //        var matchingArrays = ABPositions.Where(a => a.Contains(pincntb));
        //        var indices = matchingArrays.Select(a => ABPositions.IndexOf(a));
        //        XMLitemB[y] = new PinHoleDataElement(pincntb, indices.ToArray(), incoming[y]);
        //        pincntb++;
        //    }
        //}


        // not used function
        //private static int[] DecimalToBinary(int number)
        //{
        //    string binaryString = Convert.ToString(number, 2);  // convert to connectedto string
        //    int[] binaryArray = new int[binaryString.Length];   // create an array to store connectedto bits
        //
        //    for (int i = 0; i < binaryString.Length; i++)
        //    {
        //        binaryArray[i] = binaryString[binaryString.Length - 1 - i] == '1' ? 1 : 0; // convert each character to an integer and store in array
        //    }
        //
        //    return binaryArray;
        //}


        private void DbgFormClosed(object sender, FormClosedEventArgs e)
        {
            _dbgFormCurrentInstance = null;
        }

        private void ProfileCreatorWindowClosed(object sender, FormClosedEventArgs e)
        {
            _profileCreatorWindowInstance = null;
        }

        private void MenuProfileCreator_Click(object sender, EventArgs e)
        {
            if (_profileCreatorWindowInstance == null)
            {
                _profileCreatorWindowInstance = new CProfilePreConfigWindow();
                _profileCreatorWindowInstance.FormClosed += ProfileCreatorWindowClosed;
                _profileCreatorWindowInstance.StartPosition = FormStartPosition.CenterParent;
                _profileCreatorWindowInstance.Show();
            }
            _profileCreatorWindowInstance.BringToFront();
        }

        private void MenuLoadConnProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse XML Files";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.InitialDirectory = System.Environment.CurrentDirectory;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DrawRefProfileAB(openFileDialog1.FileName);
                lblRefFileValue.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void MenuShowDebugData_Click(object sender, EventArgs e)
        {
            if (_dbgFormCurrentInstance == null)
            {
                _dbgFormCurrentInstance = new DebugWindow();
                _dbgFormCurrentInstance.FormClosed += DbgFormClosed;
                _dbgFormCurrentInstance.StartPosition = FormStartPosition.CenterParent;
                _dbgFormCurrentInstance.Show();
            }
            _dbgFormCurrentInstance.BringToFront();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanMeasBox();
            lblTestResultValue.Text = "NaN";
            lblTestResultValue.ForeColor = Color.Black;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ResetDebugVariables();
            CleanMeasBox();
            // CH340 VID and PID
            string vid = "1A86";
            string pid = "7523";

            string pattern = @"COM\d+";
            Regex regex = new Regex(pattern);

            List<string> foundPortNames = new List<string>();
            string cableTesterDevicePortName = "";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE '%VID_{vid}%&PID_{pid}%'"))
            {
                foreach (ManagementObject device in searcher.Get())
                {
                    string deviceId = device.Properties["DeviceID"].Value.ToString();
                    string portName = device.Properties["Name"].Value.ToString();
                    Match match = regex.Match(portName);
                    if (match.Success)
                    {
                        foundPortNames.Add(match.Value);
                    }
                }
            }

            string response = "";
            // loop through each port and try sending the message
            foreach (string portName in foundPortNames)
            {
                response = BlockingSerialSender("<HELLOTESTER>", portName);
                DebugDataHelper.SerialResponse = response;
                if (response.Contains("<HELLOPC>"))
                {
                    cableTesterDevicePortName = portName;
                    DebugDataHelper.SerialResponse = portName;
                    break;
                }
            }

            if (DebugSerialResponse)
            {
                response = SerialResponseForDebug;
                DebugDataHelper.SerialResponse = response;
            }
            if (cableTesterDevicePortName == "")
            {
                MessageBox.Show("The cable tester device is not detected!");
            }
            else
            {
                response = BlockingSerialSender("<START>", cableTesterDevicePortName);
                DebugDataHelper.SerialResponse = response;
            }

            // extract substring representing integer array
            int startIndex = response.IndexOf(',') + 1;
            int endIndex = response.LastIndexOf('>');
            if (endIndex == -1)
            {
                // handle error if closing '>' is not found
                MessageBox.Show("Invalid input string: closing '>' not found");
                return;
            }
            int length = endIndex - startIndex;
            string integerArrayString = response.Substring(startIndex, length);

            // split integer array string by comma
            string[] integerStrings = integerArrayString.Split(',');

            // convert strings to integers and store in integer array, this will be the numbers from serialport
            int[] integerArrayFromSerial = new int[integerStrings.Length];
            for (int i = 0; i < integerStrings.Length; i++)
            {
                int.TryParse(integerStrings[i], out integerArrayFromSerial[i]);
            }

            FillDataStructures(integerArrayFromSerial);     // we call the data structure builder for the response we got from serialport and fill up measured DataElementsA and measured DataElementsB

            if (DebugPinReference) // debug mode
            {
                CompareRefWithMeas(TestReference, integerArrayFromSerial);
            }// in "else" we must compare two int[], one from serial, other from the XML, but from XML, first
             // we need to put the decimal numbers into "connectedto" encoded positions
            else CompareRefWithMeas(ConvertWiringToSerial(ConvertWiringArrayToWiringList(XmlConnectorProfile.ConnectedToA)), integerArrayFromSerial);
        }
    }
}
