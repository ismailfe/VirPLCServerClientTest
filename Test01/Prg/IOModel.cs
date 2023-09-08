using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirPLCServerClientTest.Prg
{
    public class IOModel
    {
        public ValType Type { get; set; }
        public int DBNo { get; set; }
        public int AddrOffset { get; set; } //Addr Byte
        public int AddrBit { get; set; }
        public int Size { get; set; }
        public string Val { get; set; }
    }
}
