using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirPLCServerClientTest.Prg;
using VirPLCServerClientTest.Prg_Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VirPLCServerClientTest
{
    public partial class Form1 : Form
    {
        MyServer myServer;
        MyClient myClient;
        Timer tmr = new Timer();
        public Form1()
        {
            InitializeComponent();
            myServer = new MyServer();
            myClient = new MyClient();

            CreateDefaultIOs();

            tmr.Interval = 1000;
            tmr.Tick += Tmr_Tick;
            tmr.Start();

            cboxValType.DataSource = Enum.GetValues(typeof(ValType));
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            ListUpdate();
        }

        public void ListUpdate()
        {
            listBox2.Items.Clear();
            for (int i = 0; i < myClient.IOs.Count; i++)
            {
                var itm = myClient.IOs[i].DBNo + " | " + myClient.IOs[i].AddrOffset + " | " + myClient.IOs[i].Type + " | " + myClient.IOs[i].Val;
                listBox2.Items.Add(itm);
            }
        }

        string IPAddr = "192.168.1.101";

        void CreateDefaultIOs()
        {
            IOModel io1  = new IOModel();
            io1.DBNo = 1;
            io1.AddrOffset = 0;
            io1.Type = ValType.INT;
            io1.Size = myClient.CalcSize(io1.Type);
            myClient.IOs.Add(io1);

            IOModel io2 = new IOModel();
            io2.DBNo = 1;
            io2.AddrOffset = 2;
            io2.Type = ValType.INT;
            io2.Size = myClient.CalcSize(io2.Type);
            myClient.IOs.Add(io2);


        }



        void ServerRun()
        {
            txtStsServer.Text = myServer.ServerStart(txtIPServer.Text);

            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }

        void ServerStop()
        {
            myServer.ServerStop();

            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }

        void ClientConnect()
        {
            txtStsClient.Text = myClient.Start(txtIPServer.Text);
            myClient.Read();

            btnEkle.Enabled = false;
            btnStopClient.Enabled  = true;
            btnClientStart.Enabled = false;
            btnClientWriteData.Enabled = true;
        }
        
        void ClientStop()
        {
            btnEkle.Enabled = true;
            btnStopClient.Enabled = false;
            btnClientStart.Enabled =  true;
            btnClientWriteData.Enabled = false;
        }


        private void btnClientWriteData_Click(object sender, EventArgs e)
        {
            myClient.WriteInt(ValType.INT, (int)numDBno.Value, (int)numOffset.Value, (short)numVal.Value);
        }

        private void btnClientStart_Click(object sender, EventArgs e)
        {
            ClientConnect();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            ServerRun();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            IOModel io = new IOModel();
            io.DBNo = (int)numDbNoAdd.Value;
            io.AddrOffset = (int)numOffsetAdd.Value;
            io.Type = (ValType) Enum.Parse(typeof(ValType), cboxValType.Text);
            io.AddrBit = (int) numBitAdd.Value;
            io.Size = myClient.CalcSize(io.Type);
            myClient.IOs.Add(io);
            ListUpdate();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            ServerStop();
        }

        private void btnStopClient_Click(object sender, EventArgs e)
        {
            ClientStop();
        }
    }
}
