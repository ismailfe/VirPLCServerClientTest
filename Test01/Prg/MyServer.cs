using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snap7;

namespace VirPLCServerClientTest.Prg_Server
{
    public class MyServer
    {
        S7Server S7Server;

        public MyServer()
        {
            S7Server = new Snap7.S7Server();
            
        }

        public string ServerStart(string IpAddr)
        {

            for (int i = 0; i < 6; i++)
            {
                byte[] myByte= new byte[1024];
                S7Server.RegisterArea(S7Server.srvAreaDB, i, ref myByte, myByte.Length);
            }

            // Number-DbNo-Buff-Size
            // S7Server.RegisterArea(S7Server.srvAreaDB, 1, ref DB1, DB1.Length);
            // S7Server.RegisterArea(S7Server.srvAreaDB, 2, ref DB2, DB2.Length);

            var sts = S7Server.StartTo(IpAddr);
            return S7Server.ErrorText(sts); ;
        }

        public void ServerStop()
        {
            S7Server.Stop();
        }
    }
}
