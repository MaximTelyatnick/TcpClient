using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WatsonTcp;
using Packet;
using System.Timers;

using System.Windows.Forms;

namespace TcpClient
{
    public class Program
    {
     

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFm());

            //client = new WatsonTcpClient("191.168.3.3", 9000, ServerConnected, ServerDisconnected, MessageReceived, true);
            
            //signalTimer = new Timer();
            //signalTimer.Interval = 1000;
            //signalTimer.Elapsed += signalTimer_Elapsed;

            //bool runForever = true;
            //while (runForever)
            //{
            //    Console.Write("Command [q cls send]: ");
            //    string userInput = Console.ReadLine();
            //    if (String.IsNullOrEmpty(userInput)) continue;

            //    switch (userInput)
            //    {
            //        case "start_timer_db1":
            //            command = "get_plc_info_db1";
            //            signalTimer.Start();
            //            break;

            //        case "start_timer_db27":
            //            command = "get_plc_info_db27";
            //            signalTimer.Start();
            //            break;

            //        case "start_timer_db28":
            //            command = "get_plc_info_db28";
            //            signalTimer.Start();
            //            break;

            //        case "start_timer_db29":
            //            command = "get_plc_info_db29";
            //            signalTimer.Start();
            //            break;
            //        case "ts":
            //            signalTimer.Stop();
            //            break;
            //    }
            //}
        }

        

        //static void signalTimer_Elapsed(object sender, EventArgs e)
        //{
        //    client.Send(Encoding.UTF8.GetBytes(command));
        //}

        

        //static Object ByteArrayToObject(byte[] arrBytes)
        //{
        //    MemoryStream memStream = new MemoryStream();
        //    BinaryFormatter binForm = new BinaryFormatter();
        //    memStream.Write(arrBytes, 0, arrBytes.Length);
        //    memStream.Seek(0, SeekOrigin.Begin);
        //    Object obj = (Object)binForm.Deserialize(memStream);

        //    return obj;
        //}

        //public byte[] ObjectToByteArray(Object obj)
        //{
        //    if (obj == null)
        //        return null;

        //    BinaryFormatter bf = new BinaryFormatter();
        //    MemoryStream ms = new MemoryStream();
        //    bf.Serialize(ms, obj);

        //    return ms.ToArray();
        //}

        //static void StartTimer(int dbNumber)
        //{
        //    signalTimer.Start();
        //}
    }
}
