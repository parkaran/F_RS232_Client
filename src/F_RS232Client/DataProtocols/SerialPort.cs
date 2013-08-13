﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F_RS232Client.DataProtocols
{
    class SerialPort : DataProtocol, IWriteable
    {
        private System.IO.Ports.SerialPort internalPort;

        public SerialPort(string portName)
        {
            internalPort = new System.IO.Ports.SerialPort(portName);
        }

        #region DataProtocol implementation
        public void Open()
        {
            if (IsOpen)
                return;
            
            internalPort.Open();
        }

        public bool IsOpen
        {
            get
            {
                return internalPort.IsOpen;
            }
        }

        public void Close()
        {
            internalPort.Close();
        }
        #endregion

        #region IWriteable implementation
        public void Write(byte b)
        {
            internalPort.Write(new byte[] { b }, 0, 1);
        }

        public void Write(byte[] bytes)
        {
            internalPort.Write(bytes, 0, bytes.Length);
        }

        public void Write(string str)
        {
            internalPort.Write(str);
        }
        #endregion
    }
}
