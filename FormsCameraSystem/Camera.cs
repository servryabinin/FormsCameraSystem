using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace FormsCameraSystem
{
    public class Camera
    {
        private Socket udpSocket;
        private EndPoint cameraEndPoint;

        public Camera(string ipAddress, int port)
        {
            udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            udpSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            cameraEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            udpSocket.Bind(new IPEndPoint(IPAddress.Any, port));
        }

        public async Task<int> SendPacketAsync(byte[] packet)
        {
            return await udpSocket.SendToAsync(new ArraySegment<byte>(packet), SocketFlags.None, cameraEndPoint);
        }

        public async Task<byte[]> ReceivePacketAsync(byte[] buffer, EndPoint remotePoint, int timeout)
        {
            udpSocket.ReceiveTimeout = timeout;
            var result = await udpSocket.ReceiveFromAsync(new ArraySegment<byte>(buffer), SocketFlags.None, remotePoint);
            return buffer;
        }

        public byte[] PackageStopVideoCamera()
        {
            byte[] tx_buff = new byte[64];
            tx_buff[0] = 0x04;
            tx_buff[1] = 0x00;
            tx_buff[28] = 0x00;
            tx_buff[29] = 0x00;
            return tx_buff;
        }

        public byte[] PackageGetImageCamera(int udpDelay, int imageHeight, int imageWidth, int imageExposition, int imageFocus, byte recognizeCodeFlag)
        {
            byte[] tx_buff = new byte[120];
            tx_buff[0] = 0x04;
            tx_buff[1] = 0x00;
            BitConverter.GetBytes(udpDelay).CopyTo(tx_buff, 4);
            BitConverter.GetBytes(0).CopyTo(tx_buff, 8);
            BitConverter.GetBytes(0).CopyTo(tx_buff, 12);
            BitConverter.GetBytes(imageHeight).CopyTo(tx_buff, 16);
            BitConverter.GetBytes(imageWidth).CopyTo(tx_buff, 20);
            BitConverter.GetBytes(5).CopyTo(tx_buff, 24);
            tx_buff[28] = 0x01;
            tx_buff[29] = 0x01;
            tx_buff[30] = (byte)(imageExposition & 0xFF);
            tx_buff[31] = (byte)((imageExposition & 0xFF00) >> 8);
            tx_buff[32] = 0x00;
            tx_buff[33] = (byte)(imageFocus & 0xFF);
            tx_buff[34] = 0x00;
            tx_buff[35] = recognizeCodeFlag; // Используем переданный флаг для установки значения 35-го байта
            BitConverter.GetBytes(441398).CopyTo(tx_buff, 36);
            BitConverter.GetBytes(19).CopyTo(tx_buff, 40);
            tx_buff[44] = 0xA0;
            tx_buff[45] = 0x00;
            BitConverter.GetBytes((ushort)163).CopyTo(tx_buff, 46);
            BitConverter.GetBytes((ushort)24).CopyTo(tx_buff, 48);
            BitConverter.GetBytes((ushort)220).CopyTo(tx_buff, 50);
            BitConverter.GetBytes((ushort)50).CopyTo(tx_buff, 51);
            BitConverter.GetBytes((ushort)120).CopyTo(tx_buff, 52);
            tx_buff[54] = 0x00;
            BitConverter.GetBytes((ushort)30).CopyTo(tx_buff, 55);
            BitConverter.GetBytes((ushort)8).CopyTo(tx_buff, 56);
            BitConverter.GetBytes((ushort)15).CopyTo(tx_buff, 57);
            tx_buff[58] = 0x00;
            tx_buff[59] = 0x00;
            tx_buff[60] = 0x00;
            tx_buff[61] = 0x00;
            tx_buff[62] = 0x00;
            tx_buff[63] = 0x00;

            return tx_buff;
        }


        public byte[] PackageInitCamera()
        {
            return new byte[] { 0xB0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        }
    }

}
