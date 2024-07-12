using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UniversalCableAnalyzer
{
    class DebugDataHelper
    {
        private static string _measMapping;
        private static string _refMapping;
        private static string _connectedTo;
        private static string _serialResponse;

        public static string MeasMapping
        {
            get => _measMapping;
            set
            {
                _measMapping = value;
                OnGlobalPropertyChanged(nameof(MeasMapping));
            }
        }

        public static string RefMapping
        {
            get => _refMapping;
            set
            {
                _refMapping = value;
                OnGlobalPropertyChanged(nameof(RefMapping));
            }
        }

        public static string ConnectedTo
        {
            get => _connectedTo;
            set
            {
                _connectedTo = value;
                OnGlobalPropertyChanged(nameof(ConnectedTo));
            }
        }

        public static string SerialResponse
        {
            get => _serialResponse;
            set
            {
                _serialResponse = value;
                OnGlobalPropertyChanged(nameof(SerialResponse));
            }
        }

        public static event PropertyChangedEventHandler GlobalPropertyChanged = delegate { };

        static void OnGlobalPropertyChanged(string propertyName)
        {
            GlobalPropertyChanged(
                typeof(DebugWindow),
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
