using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prochem
{
    public class Domain
    {
        private SerialPort _serialPort = new SerialPort();
        private string _comPort;
        private string _receiveData;
        private int _baudRate;
        public delegate void DataReceiveEvent();
        public static event DataReceiveEvent DataReceived;
        public Domain()
        {
            _serialPort.DataReceived += _serialPort_DataReceived;
        }

        private async void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _receiveData = await GetSerialPortContent();
            DataReceived();
        }
        public string GetReceiveData()
        {
            return _receiveData;
        }
        public void Send(string content)
        {
            if (_serialPort.IsOpen != true)
            {
                _serialPort.Open();
            }
            _serialPort.Write($"{content}\r\n");
        }
        /// <summary>
        /// 檢查ComPort是否存在
        /// </summary>
        /// <param name="comPort"></param>
        public void CheckComPort(string comPort)
        {
            if (GetComPortList().Where(x => x.Equals(comPort)).Count() == 0)
            {
                throw new Exception($"TestConnect: ComPort {comPort} 不存在");
            }
        }
        /// <summary>
        /// 測試ComPort連線
        /// </summary>
        /// <param name="comPort"></param>
        public bool TestConnection(string comPort,int baudRate)
        {
            try
            {
                CheckComPort(comPort);
                _baudRate = baudRate;
                _serialPort.BaudRate = _baudRate;
                _serialPort.PortName = comPort;

                if (_serialPort.IsOpen == true)
                {
                    _serialPort.Close();
                }

                _serialPort.Open();
                _comPort = comPort;
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"TestConnect:{ex.Message}");
            }
            return true;
        }
        /// <summary>
        /// 取的ComPort列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetComPortList()
        {
            return SerialPort.GetPortNames().ToList();
        }
        private async Task<string> GetSerialPortContent()
        {
            string content = "";
            try
            {
                content = await new StreamReader(_serialPort.BaseStream).ReadLineAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"GetSerialPortContent():{ex.Message}");
            }
            return content;
        }
        public void Disconnect()
        {
            if (_serialPort.IsOpen == true)
            {
                _serialPort.Close();
            }
        }
    }
}
