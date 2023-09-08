using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Snap7;

namespace VirPLCServerClientTest.Prg
{
    public class MyClient
    {
        Thread ThReadCyc;
        public List<IOModel> IOs = new List<IOModel>();

        Snap7.S7Client Client;
        public MyClient()
        {
            Client = new Snap7.S7Client();
        }

        public string Start(string IpAddr)
        {
            var sts = Client.ConnectTo(IpAddr, 0, 2);
            return Client.ErrorText(sts); ;
        }
        public void Stop()
        {
            ThReadCyc.Abort();
            Client.Disconnect();
        }



        public void Read()
        {
            ThReadCyc = new Thread(ReadCyc);
            ThReadCyc.Start();
        }



        public int ReadInt(int DBNo, int OffSet)
        {
            int result;
            int size = 2;
            byte[] buff = new byte[size];
            Client.AsDBRead(DBNo,OffSet, size, buff);
            result =  Client.DBGet(DBNo, buff, ref size);

            return result;
        }

        public int ReadDInt(int DBNo, int OffSet)
        {
            int result;
            int size = 4;
            byte[] buff = new byte[size];
         
            var sts = Client.DBRead(DBNo, OffSet, size, buff);
            result = S7.GetIntAt(buff, 0);
            
            return result;
        }
        public short WriteInt(ValType type, int DBNo, int Offset, short Value)
        {
            int result;
            int size = CalcSize(type);
            byte[] buff = new byte[size];
            S7.SetIntAt(buff, 0, Value);
            var sts =  Client.DBWrite(DBNo, Offset, size, buff);
            return Value;
        }

        public int CalcSize(ValType valType)
        {
            //    BOOL,// 1,
            //BYTE,// 1,
            //WORD,// 2,
            //DWORD,// 4,

            //INT, // 2,
            //DINT,// 4,

            switch (valType)
            {
                case ValType.BOOL:
                    return 1;
                case ValType.BYTE:
                    return 1;
                case ValType.WORD:
                    return 2;
                case ValType.DWORD:
                    return 4;
                case ValType.INT:
                    return 2;
                case ValType.DINT:
                    return 4;
                default:
                    return 0;
            }

        }


        void ReadCyc()
        {
            while (true)
            {
                for (int i = 0; i < IOs.Count; i++)
                {
                    var buff = BufferRead(IOs[i].DBNo, IOs[i].AddrOffset, IOs[i].Size);
                    IOs[i].Val = HelperR(buff, IOs[i]);
                    Thread.Sleep(100);
                }

            }
   
        }


        byte[] BufferRead(int DBNo, int OffSet, int size)
        {
            byte[] buff = new byte[size];

            var sts = Client.DBRead(DBNo, OffSet, size, buff);
            return buff;
        }
        string HelperR(byte[] Buffer, IOModel IO)
        {
            string resultValue = "";
            int IndexPos = 0; // IO.AddrOffset;


            switch (IO.Type)
            {
                case ValType.BOOL:
                    resultValue = S7.GetBitAt(Buffer, IndexPos, IO.AddrBit).ToString();
                    break;
                case ValType.BYTE:
                    resultValue = S7.GetByteAt(Buffer, IndexPos).ToString();
                    break;
                case ValType.WORD:
                    resultValue = S7.GetWordAt(Buffer, IndexPos).ToString();
                    break;
                case ValType.DWORD:
                    resultValue = S7.GetWordAt(Buffer, IndexPos).ToString();
                    break;
                case ValType.INT:
                    resultValue = S7.GetIntAt(Buffer, IndexPos).ToString();
                    break;
                case ValType.DINT:
                    resultValue = S7.GetDIntAt(Buffer, IndexPos).ToString();
                    break;

                default:
                    break;
            }

            return resultValue;
        }
        string HelperW(byte[] Buffer, IOModel IO, string SetValue)
        {
            string resultValue = "";
            int IndexPos = 0;

            switch (IO.Type)
            {
                case ValType.BOOL:
                    bool.TryParse(SetValue, out bool resultBool);
                    S7.SetBitAt(ref Buffer, IndexPos, IO.AddrBit, resultBool);
                    break;
                case ValType.BYTE:
                    byte.TryParse(SetValue, out byte resultByte);
                    S7.SetByteAt(Buffer, IndexPos, resultByte);
                    break;
                case ValType.WORD:
                    ushort.TryParse(SetValue, out ushort resultWord);
                    S7.SetWordAt(Buffer, IndexPos, resultWord);
                    break;
                case ValType.DWORD:
                    uint.TryParse(SetValue, out uint resultDWord);
                    S7.SetDWordAt(Buffer, IndexPos, resultDWord);
                    break;
                case ValType.INT:
                    short.TryParse(SetValue, out short resultShort);
                    S7.SetIntAt(Buffer, IndexPos, resultShort);
                    break;
                case ValType.DINT:
                    int.TryParse(SetValue, out int resultDint);
                    S7.SetDIntAt(Buffer, IndexPos, resultDint);
                    break;

                default:
                    break;
            }

            return resultValue;
        }










    }
}
