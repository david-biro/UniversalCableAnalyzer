using System;
using System.IO;
using System.Xml;


namespace UniversalCableAnalyzer
{
    public class XmlConnectorProfile
    {
        private static string _connNameA; // connector name on connector side A
        private static string _connNameB; // connector name on connector side B
        private static int _pinCountA; // pin count on connector side A
        private static int _pinCountB; // pin count on connector side B
        private static int _rowCountA; // row count on connector side A
        private static int _rowCountB; // row count on connector side B
        private static string[] _pinHoleA; // PinHole on connector side A
        private static string[] _pinHoleB; // PinHole on connector side B
        private static string[] _connectedToA; // ConnectedTo on connector side A
        private static string[] _connectedToB; // ConnectedTo on connector side B
        private static string[] _colorsA; // pin colors on connector side A
        private static string[] _colorsB; // pin colors on connector side B

        public static string ConnNameA
        {
            get => _connNameA;
            set => _connNameA = value;
        }

        public static string ConnNameB
        {
            get => _connNameB;
            set => _connNameB = value;
        }

        public static int PinCountA
        {
            get => _pinCountA;
            set => _pinCountA = value;
        }

        public static int PinCountB
        {
            get => _pinCountB;
            set => _pinCountB = value;
        }

        public static int RowCountA
        {
            get => _rowCountA;
            set => _rowCountA = value;
        }

        public static int RowCountB
        {
            get => _rowCountB;
            set => _rowCountB = value;
        }

        public static string[] PinHoleA
        {
            get => _pinHoleA;
            set => _pinHoleA = value;
        }

        public static string[] PinHoleB
        {
            get => _pinHoleB;
            set => _pinHoleB = value;
        }

        public static string[] ConnectedToA
        {
            get => _connectedToA;
            set => _connectedToA = value;
        }

        public static string[] ConnectedToB
        {
            get => _connectedToB;
            set => _connectedToB = value;
        }

        public static string[] ColorsA
        {
            get => _colorsA;
            set => _colorsA = value;
        }

        public static string[] ColorsB
        {
            get => _colorsB;
            set => _colorsB = value;
        }

        public static void Read(string fname)
        {
            XmlDocument xDoc = new();
            try
            {
                xDoc.Load(fname);
            }
            catch (DirectoryNotFoundException)
            {
                return;
            }
            catch (Exception)
            {
                return;
            }

            XmlNode conn1 = xDoc.SelectSingleNode("Main/Side1/SideName/text()");
            ConnNameA = conn1.Value.ToString();
            XmlNode conn2 = xDoc.SelectSingleNode("Main/Side2/SideName/text()");
            ConnNameB = conn2.Value.ToString();
            XmlNode temp1 = xDoc.SelectSingleNode("Main/Side1/PinCount/text()");
            PinCountA = Convert.ToInt32(temp1.Value);
            XmlNode temp2 = xDoc.SelectSingleNode("Main/Side2/PinCount/text()");
            PinCountB = Convert.ToInt32(temp2.Value);
            XmlNode temp3 = xDoc.SelectSingleNode("Main/Side1/RowCount/text()");
            RowCountA = Convert.ToInt32(temp3.Value);
            XmlNode temp4 = xDoc.SelectSingleNode("Main/Side2/RowCount/text()");
            RowCountB = Convert.ToInt32(temp4.Value);

            ConnectedToA = new string[PinCountA];
            ConnectedToB = new string[PinCountB];
            PinHoleA = new string[PinCountA];
            PinHoleB = new string[PinCountB];
            ColorsA = new string[PinCountA];
            ColorsB = new string[PinCountB];

            for (int i = 0; i < PinCountA; i++)
            {
                int j = i + 1;

                XmlNode temp5 = xDoc.SelectSingleNode($"Main/Side1/Pin{j}/ConnectedTo/text()");
                ConnectedToA[i] = temp5.Value.ToString();
                XmlNode temp6 = xDoc.SelectSingleNode($"Main/Side1/Pin{j}/PinHole/text()");
                PinHoleA[i] = temp6.Value.ToString();
                XmlNode temp7 = xDoc.SelectSingleNode($"Main/Side1/Pin{j}/Color/text()");
                ColorsA[i] = temp7.Value.ToString();
            }

            for (int i = 0; i < PinCountB; i++)
            {
                int j = i + 1;

                XmlNode temp8 = xDoc.SelectSingleNode($"Main/Side2/Pin{j}/ConnectedTo/text()");
                ConnectedToB[i] = temp8.Value.ToString();
                XmlNode temp9 = xDoc.SelectSingleNode($"Main/Side2/Pin{j}/PinHole/text()");
                PinHoleB[i] = temp9.Value.ToString();
                XmlNode temp10 = xDoc.SelectSingleNode($"Main/Side2/Pin{j}/Color/text()");
                ColorsB[i] = temp10.Value.ToString();
            }
        }
    }
}