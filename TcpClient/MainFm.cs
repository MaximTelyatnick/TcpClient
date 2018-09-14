using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WatsonTcp;
using TcpServer;
using Packet;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TcpClient
{
    public partial class MainFm : DevExpress.XtraEditors.XtraForm
    {
        public Timer signalTimer;
        public WatsonTcpClient client;
        public Utils.Command currentCommand;
        public string serverIp;

        public MainFm()
        {
            InitializeComponent();
            commandEdit.Properties.DataSource = Enum.GetNames(typeof(Utils.Command));
            commandEdit.Properties.ValueMember = "Column";
            commandEdit.Properties.DisplayMember = "Column";
        }

        private void connectServerBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                try
                {
                    client = new WatsonTcpClient(serverIp, 9000, ServerConnected, ServerDisconnected, MessageReceived, true);
                    connectServerBtn.Text = "Отключиться";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к серверу.\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                client = null;
                connectServerBtn.Text = "Подключиться";
            }
        }

        private void serverIpEdit_EditValueChanged(object sender, EventArgs e)
        {
            serverIp = serverIpEdit.Text;

            if (serverIp == "")
            {
                connectServerBtn.Enabled = false;
                startCommandBtn.Enabled = false;
            }
            else
            {
                connectServerBtn.Enabled = true;
                startCommandBtn.Enabled = true;
            }
        }

        public bool MessageReceived(byte[] data)
        {
            Object receivedObject = new Object();
            receivedObject = ByteArrayToObject(data);
            switch (((PacketDTO)receivedObject).command)
            {
                case Utils.Command.Not_correct_command:
                    Console.WriteLine(((PacketDTO)receivedObject).message);
                    messageEdit.MaskBox.AppendText(DateTime.Now +" "+ ((PacketDTO)receivedObject).message);
                    break;

                case Utils.Command.Get_server_plc_db1:
                case Utils.Command.Get_server_plc_db27:
                case Utils.Command.Get_server_plc_db28:
                case Utils.Command.Get_server_plc_db29:
                    Object taglist = new Object();
                    taglist = ByteArrayToObject(((PacketDTO)receivedObject).info);
                    Console.WriteLine(((PacketDTO)receivedObject).message);
                    Console.WriteLine("====================================");
                    Console.WriteLine("CellNumber: " + ((TagDTO)taglist).CellNumber);
                    Console.WriteLine("CurrentWeight: " + ((TagDTO)taglist).CurrentWeight);
                    Console.WriteLine("Error: " + ((TagDTO)taglist).Error);
                    Console.WriteLine("ErrorList: " + ((TagDTO)taglist).ErrorList);
                    Console.WriteLine("OldWeight: " + ((TagDTO)taglist).OldWeight);
                    Console.WriteLine("PLCDropoffWind: " + ((TagDTO)taglist).PLCDropoffWind);
                    Console.WriteLine("PLCLoadStatus: " + ((TagDTO)taglist).PLCLoadStatus);
                    Console.WriteLine("PLCSetClose: " + ((TagDTO)taglist).PLCSetClose);
                    Console.WriteLine("PLCSetOpen: " + ((TagDTO)taglist).PLCSetOpen);
                    Console.WriteLine("====================================");
                    break;

                default:
                    Console.WriteLine(((PacketDTO)receivedObject).message);
                    break;
            }

            //TagsDTO tagDto = new TagsDTO();
            //tagDto = ByteArrayToObject(data);
            //Console.WriteLine("Message from server:");
            //Console.WriteLine(tagDto.CurrentWeight);
            //Console.WriteLine(tagDto.OldWeight);
            return true;
        }

        public byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);

            return ms.ToArray();
        }

        public Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);

            return obj;
        }

        static bool ServerConnected()
        {
            Console.WriteLine("Server connected");
            return true;
        }

        static bool ServerDisconnected()
        {
            Console.WriteLine("Server disconnected");
            return true;
        }

        private void startCommandBtn_Click(object sender, EventArgs e)
        {
            switch (currentCommand)
            {
                case Utils.Command.Get_server_plc_db1:
                    signalTimer.Start();
                    break;

                case Utils.Command.Get_server_plc_db27:
                    signalTimer.Start();
                    break;

                case Utils.Command.Get_server_plc_db28:
                    signalTimer.Start();
                    break;

                case Utils.Command.Get_server_plc_db29:
                    signalTimer.Start();
                    break;
                case Utils.Command.Not_correct_command:
                    signalTimer.Stop();
                    break;
            }
        }

        private void commandEdit_EditValueChanged(object sender, EventArgs e)
        {
            currentCommand = (Utils.Command)commandEdit.EditValue;
        }

    }
}