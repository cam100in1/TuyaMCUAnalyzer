using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MethodInvoker = System.Windows.Forms.MethodInvoker;

namespace TuyaMCUAnalyzer
{
    class SinglePort
    {
        ComboBox comboBoxUART;
        Button buttonOpen;
        Label labelState;
        ComboBox comboBoxBaud;
        SerialPort serial;
        //Task task;
        CancellationTokenSource cts = new CancellationTokenSource();

        byte[] tmpBytes = new byte[8192];
        ByteRingBuffer incoming = new ByteRingBuffer();
        public delegate void PacketHandlerDelegate(byte[] data);
        PacketHandlerDelegate receiveCallback;
        
        public int totalBytesReceived;
        public SinglePort(Button BT, ComboBox CB, Label LB, PacketHandlerDelegate cb, ComboBox comboBoxBaud)
        {
            this.buttonOpen = BT;
            this.comboBoxUART = CB;
            this.labelState = LB;
            this.receiveCallback = cb;
            this.comboBoxBaud = comboBoxBaud;
            
            this.buttonOpen.Click += buttonOpen_Click;


            //task = Task.Run(() =>
            //{
            //    while (!cts.Token.IsCancellationRequested)
            //    {
            //        //runFrame();
            //        //Task.Delay(10000);
            //    }
            //}, cts.Token);

        }

        public void refreshStats()
        {
            int s = incoming.getSize();
            labelState.Invoke((MethodInvoker)delegate { labelState.Text = "Currently in ringbuffer: " + s + ", total recv: "+ totalBytesReceived; });
        }
        public void runFrame()
        {

            if (serial != null)
            {
                if (serial.IsOpen)
                {
                    while (serial.BytesToRead > 0)
                    {
                        int c = serial.BytesToRead;
                        serial.Read(tmpBytes, 0, c);
                        incoming.addData(tmpBytes, c);
                        totalBytesReceived += c;
                    }
                }
            }
            processIncoming();
            refreshStats();
        }
        void processIncoming()
        {
            // wait for header at least
            if (incoming.getSize() < 6)
            {
                return;
            }
            // read header
            byte[] dat = [];
            byte a = incoming.getByte(0);
            byte b = incoming.getByte(1);
            byte v = incoming.getByte(2);
            byte cmd = incoming.getByte(3);
            ushort len = incoming.getShort(4);
            // Message identifier check ( 0x55 0xAA )
            if (a == 0x55 && b == 0xaa)
            {
                // Message complete ?? 6 = identifier len = message len from header + checksum
                // int totalLen = 6 + len + 1;
                uint totalLen = 6u + len + 1u ;
                // if len miss match detected
                if (totalLen > incoming.getSize())
                    return;
                // read complete message
                try
                {
                    dat = incoming.getDataFromTo(0, totalLen);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("EX in processIncomming" + ex.Message);
                    return;
                }

                addReceived(dat);
                incoming.consumeBytes(totalLen);
                refreshStats();
            }
            else
            {
                incoming.consumeBytes(1);
                refreshStats();
            }
        }
        void addReceived(byte[] dat)
        {
            labelState.Invoke((MethodInvoker)delegate {
                this.receiveCallback(dat);
            });
        }
        bool openPort()
        {
            try
            {
                string serialName = comboBoxUART.SelectedItem.ToString();
                int baud = int.Parse(comboBoxBaud.Text);
                serial = new SerialPort(serialName, baud, Parity.None, 8, StopBits.One);
            }
            catch (Exception)
            {
                //addError("Serial port create exception: " + ex.ToString() + Environment.NewLine);
                return true;
            }
            try
            {
                serial.ReadBufferSize = 4096 * 2;
                serial.ReadBufferSize = 3000000;
            }
            catch (Exception)
            {
                //addWarning("Setting serial port buffer size exception: " + ex.ToString() + Environment.NewLine);
            }
            try
            {
                serial.Open();
            }
            catch (Exception)
            {
                //addError("Serial port open exception: " + ex.ToString() + Environment.NewLine);
                onComClose();
                return true;
            }
            return false;
        }
        void onComClose()
        {
            buttonOpen.Enabled = true;
            buttonOpen.Text = "Open";
        }
        public void closePort()
        {
            if (serial != null)
            {
                // cts.Cancel();
                serial.Close();
                serial.Dispose();
                serial = null;
            }
        }
        void tryOpenPort()
        {
            if (serial != null)
            {
                if (serial.IsOpen)
                    return;
            }
            incoming.clearBuffer();
            if (openPort() == false)
            {
                buttonOpen.Text = "Close";
            }
            else
            {
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (serial == null)
            {
                tryOpenPort();
            }
            else
            {
                closePort();
                buttonOpen.Text = "Open";
            }

        }
    }
}
