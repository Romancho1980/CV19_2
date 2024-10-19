using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19_2.Data
{
    public class ComPort
    {
        public SerialPort _serialPort;

        public ComPort()
        {
            SerialPort asd=new SerialPort();
            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

        }
    }
}
