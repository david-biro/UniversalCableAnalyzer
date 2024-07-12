using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversalCableAnalyzer
{
    internal class PinHoleDataElement
    {
        private int _id;
        private int[] _connectedTo;
        private int _serialResponseEncoded;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int[] ConnectedTo
        {
            get { return _connectedTo; }
            set { _connectedTo = value; }
        }

        public int SerialResponseEncoded
        {
            get { return _serialResponseEncoded; }
            set { _serialResponseEncoded = value; }
        }

        public PinHoleDataElement(int id, int[] connectedTo, int serialResponseEncoded)
        {
            _id = id;
            _connectedTo = connectedTo;
            _serialResponseEncoded = serialResponseEncoded;
        }
    }
}
