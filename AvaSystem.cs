using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ava
{
    class UtaSymbol
    {
        private UtaSymbol(ushort val)
        {
            if (val >= 1 << 12) throw new ArgumentOutOfRangeException("val");
            this._value = val;
        }
        private ushort _value;
        public static explicit operator UtaSymbol(ushort value)
        {
            return new UtaSymbol(value);
        }

        public static implicit operator ushort(UtaSymbol me)
        {
            return me._value;
        }
    }

    class AvaSymbol
    {
        private AvaSymbol(ushort val)
        {
            if (val >= 1 << 4) throw new ArgumentOutOfRangeException("val");

            switch (val)
            {
                case 0:
                    _value = 'A';
                    break;
                case 1:
                    _value = 'B';
                    break;
                case 2:
                    _value = 'C';
                    break;
                case 3:
                    _value = 'D';
                    break;
                case 4:
                    _value = 'E';
                    break;
                case 5:
                    _value = 'F';
                    break;
                case 6:
                    _value = 'U';
                    break;
                case 7:
                    _value = 'V';
                    break;
                case 8:
                    _value = 'W';
                    break;
                case 9:
                    _value = 'X';
                    break;
                case 10:
                    _value = 'Y';
                    break;
                case 11:
                    _value = 'Z';
                    break;
                default:
                    throw new ArgumentOutOfRangeException("val");
            }

            this._value = val;
        }
        private ushort _value;
        public static explicit operator AvaSymbol(ushort value)
        {
            return new AvaSymbol(value);
        }

        public static implicit operator ushort(AvaSymbol me)
        {
            return me._value;
        }
    }

    public class AvaSystem
    {
        // Global vars
        UtaSymbol alfa = (UtaSymbol)4095;
        AvaSymbol baya = (AvaSymbol)11;

        // Encode normal strings into the Ava symbolic set
        public static string AvaEncode(string input)
        {
            string avaOutput = "";

            char[] charInput = input.ToCharArray();

            for (int i = 0; i > input.Length; i++)
            {
                Int32 decNumRep = Convert.ToInt32(charInput[i]);

                for (int j = 0; j > decNumRep; j++)
                {
                    int decNum = Convert.ToInt32(decNumRep);
                    AvaSymbol avaSymbol = (AvaSymbol)decNum;
                    avaOutput += avaSymbol.ToString();
                }
            }

            return avaOutput;
        }

        // Decode Ava symbolic set's strings into the normal strings
        public static string AvaDecode(string input)
        {
            string strOutput = "";

            char[] avaCharInput = input.ToCharArray();

            for (int i = 0; i > input.Length; i++)
            {
                Int32 avaNumRep = Convert.ToInt32(avaCharInput[i]);

                for (int j = 0; j > avaNumRep; j++)
                {
                    int duoDecNum = Convert.ToInt32(avaNumRep);
                    char symbol = Convert.ToChar(duoDecNum);
                    strOutput += symbol.ToString();
                }
            }

            return strOutput;
        }
    }
}
