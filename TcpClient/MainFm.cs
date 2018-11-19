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
using Packet;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace TcpClient
{
    public partial class MainFm : DevExpress.XtraEditors.XtraForm
    {
        public Timer signalTimer;
        public WatsonTcpClient client;
        public PacketDTO currentPacket;
        public string serverIp;
  

        public MainFm()
        {
            InitializeComponent();

            serverIpEdit.Text = "191.168.3.3";

            commandTypeEdit.Properties.DataSource = Enum.GetValues(typeof(Utils.TypeCommand));
            commandControlEdit.Properties.DataSource = Enum.GetValues(typeof(Utils.ControlCommand));
            idDbEdit.EditValue = 0;
            idPlcEdit.EditValue = 0;

            disconnectServerBtn.Enabled = false;

        }

        private void connectServerBtn_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                try
                {
                    client = new WatsonTcpClient(serverIp, 9000, ServerConnected, ServerDisconnected, MessageReceived, true);



                    if (client != null)
                    {
                        client.Send(ObjectToByteArray(new PacketDTO(Utils.TypeCommand.Control, Utils.ControlCommand.Connected, Convert.ToInt32(idPlcEdit.EditValue), Convert.ToString(namePlcEdit.EditValue), Convert.ToInt32(idDbEdit.EditValue), Convert.ToString(nameDbEdit.EditValue), null, null)));
                        connectServerBtn.Enabled = false;
                        disconnectServerBtn.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Помилка авторизації на сервері", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при подключении к серверу.\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            switch (((PacketDTO)receivedObject).typeCommand)
            {
                case Utils.TypeCommand.Control:
                    Console.WriteLine(((PacketDTO)receivedObject).message);

                    switch (((PacketDTO)receivedObject).controlCommand)
	                {
                        
                        //case Utils.ControlCommand.Control:
                            


                        //    break;
                        
                        case Utils.ControlCommand.Write:

                            Object taglist = new Object();
                            taglist = ByteArrayToObject(((PacketDTO)receivedObject).info);

                            var peremen = ((IEnumerable)taglist).Cast<object>().ToList();
                            
                            foreach (var item in peremen)
                            {
                                Invoke(new AddMessageLogDelegate(AddMessageLog), new object[] { ((DataItemsQueryDTO)item).Name + " " });
                                Invoke(new AddMessageLogDelegate(AddMessageLog), new object[] { ((DataItemsQueryDTO)item).Offset + " " });
                                Invoke(new AddMessageLogDelegate(AddMessageLog), new object[] { ((DataItemsQueryDTO)item).CurrentValue + Environment.NewLine });
                                
                                
                               // Console.WriteLine("CurrentWeight: " + ((DataItemsQueryDTO)item).CurrentValue);
                            }
                            
                            //    Console.WriteLine(((PacketDTO)receivedObject).message);
                            //Console.WriteLine("====================================");
                            ////Console.WriteLine("CellNumber: " + ((DataItemsQueryDTO)taglist).Name + " " +);
                            //Console.WriteLine("CurrentWeight: " + ((TagDTO)taglist).CurrentWeight);
                            //Console.WriteLine("Error: " + ((TagDTO)taglist).Error);
                            //Console.WriteLine("ErrorList: " + ((TagDTO)taglist).ErrorList);
                            //Console.WriteLine("OldWeight: " + ((TagDTO)taglist).OldWeight);
                            //Console.WriteLine("PLCDropoffWind: " + ((TagDTO)taglist).PLCDropoffWind);
                            //Console.WriteLine("PLCLoadStatus: " + ((TagDTO)taglist).PLCLoadStatus);
                            //Console.WriteLine("PLCSetClose: " + ((TagDTO)taglist).PLCSetClose);
                            //Console.WriteLine("PLCSetOpen: " + ((TagDTO)taglist).PLCSetOpen);
                            //Console.WriteLine("====================================");


                            break;

		                default:

                            break;
	                }
                    break;

                default:
                    Console.WriteLine(((PacketDTO)receivedObject).message);
                    break;
            }

            return true;
        }

        public delegate void AddMessageLogDelegate(string message);

        public void AddMessageLog(string message)
        {
            messageEdit.MaskBox.AppendText(message);
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

         currentPacket = new PacketDTO((Utils.TypeCommand)commandTypeEdit.EditValue, (Utils.ControlCommand?)commandControlEdit.EditValue, Convert.ToInt32(idPlcEdit.EditValue), Convert.ToString(namePlcEdit.EditValue), Convert.ToInt32(idDbEdit.EditValue), Convert.ToString(nameDbEdit.EditValue), (string)textMessageEdit.EditValue, null);


            switch (currentPacket.typeCommand)
            {
                case Utils.TypeCommand.Control:

                    client.Send(ObjectToByteArray(currentPacket));

                    break;

                case Utils.TypeCommand.Inform:

                    client.Send(ObjectToByteArray(currentPacket));

                    break;

                default:
                    break;
            }
        }

        private void commandEdit_EditValueChanged(object sender, EventArgs e)
        {

            //Console.WriteLine("Server connected");


            switch ((Utils.TypeCommand)commandTypeEdit.EditValue)
            {
                case Utils.TypeCommand.Control:

                    break;

            }

        }

        private void disconnectServerBtn_Click(object sender, EventArgs e)
        {
           if(client != null)
            {
                try
                {
                    client.Send(ObjectToByteArray(new PacketDTO(Utils.TypeCommand.Control, Utils.ControlCommand.Disconnected, 0, null, 0, null, null, null)));
                    client = null;
                    connectServerBtn.Enabled = true;
                    disconnectServerBtn.Enabled = false;
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка завершения работы клиента.\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void MainFm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                client.Send(ObjectToByteArray(new PacketDTO(Utils.TypeCommand.Control, Utils.ControlCommand.Disconnected, 0,null, 0, null, null, null)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка завершения работы клиента.\n" + ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

    }
}