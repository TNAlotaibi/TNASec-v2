using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNASec_v2
{
    internal class XOREncrpytion
    {

        private static string Key = "10101110";
        public static string ToBinary(string Text)
        {
            try
            {
                var result = "";
                StringBuilder tempbyte = new StringBuilder();
                string[] Binary = ConvertTextToBinary(Text).ToArray();
                for (int index = 0; index < Binary.Length; index++)
                {
                    string Byte = Binary[index];
                    for (int indexByte = 0; indexByte < Byte.Length; indexByte++)
                    {
                        char bit = Byte[indexByte];
                        tempbyte.Append(ExclusiveOR(bit, Key[indexByte]));

                    }
                    result += Arithmetic(tempbyte.ToString() + " ", 1254995);
                    tempbyte.Clear();
                }
                result = result.Substring(0, result.Length - 1);
                return result;
            }
            catch
            {

            }
            return null;
        }
        public static string ExclusiveOR(char bit, char key) => bit == key ? "0" : "1";

        
        public static string Arithmetic(string str, int key)
        {
            string builder = string.Empty;
            foreach (char c in str.ToCharArray())
            {
                builder += ((char)(c ^ key));
            }
            return builder;
        }
   
 
        static IEnumerable<string> ConvertTextToBinary(string Text)
        {
            for (int index = 0; index < Text.Length; index++)
            {
                char Char = Text[index];
                var decimalNumber = ASCII.KeyByValue(Char);
                if (decimalNumber == -1) { break; }
                string BinaryBytes = string.Join("", ((IEnumerable)CheckTheLargestByte(decimalNumber)).Cast<object>());
                yield return BinaryBytes;
            }
        }
        static int[] CheckTheLargestByte(int decimalNumber)
        {
            int[][] BytesOfBinary =
            {
                new int[] { 1, 2, 4, 8, 16, 32, 64, 128 }, // 8 bits
                new int [] { 0, 0, 0, 0, 0, 0, 0, 0 } // Default use zero
            };
            for (var c = 7; c > -1; c--)
            {
                if (decimalNumber >= BytesOfBinary[0][c])
                {
                    decimalNumber -= BytesOfBinary[0][c];
                    BytesOfBinary[1][BytesOfBinary[1].Length - c - 1] = 1;
                }
            }
            return BytesOfBinary[1];
        }

        // ---------------------------Decrypt---------------------------

       public static string ConvertBinaryToText(string EncryptText)
        {
            var binary = Arithmetic(EncryptText, 1254995).Split(' ');
            var Binartnew = "";
            foreach (var bin in binary)
            {
                for (int i = 0; i < bin.Length; i++)
                {
                    Binartnew += ExclusiveOR(bin[i], Key[i]);
                }
                Binartnew += " ";
            }
            string result = string.Empty;
            string[] Arrays = Binartnew.Replace(" ", ",").Split(',');
            byte[] Buffer = new byte[Arrays.Length];
            for (int index = 0; index < Arrays.Length; index++)
            {
                string bin = string.IsNullOrWhiteSpace(Arrays[index]) ? "00100000" : Arrays[index];
                if (int.Parse(bin) == 00100000 || int.Parse(bin) == 100000)
                {
                    Buffer[index] = (byte)32;
                    continue;
                }
                int res = 0;
                for (int num = 0; num <= bin.Length - 1; num++)
                {
                    int binaryNumber = int.Parse(bin[num].ToString());
                    if (binaryNumber == 1)
                    {
                        res += (int)(1 * CPower(2, bin.Length - num - 1));
                    }
                    else continue;
                }
                Buffer[index] = (byte)res;
            }
            result = ConvertdecimalToASCIIChar(Buffer);
            result = result.Substring(0, result.Length - 1);
            return result;
        }
        static double CPower(int Number, int RaisedPower)
        {
            var Result = 1;

            switch (RaisedPower)
            {
                case 0:
                    return Result;
                default:
                    {
                        do
                            Result *= Number;
                        while (--RaisedPower > 0);
                        return Result;
                    }
            }
        }
        static string ConvertdecimalToASCIIChar(byte[] BytesArray)
        {
            string result = string.Empty;
            foreach (byte b in BytesArray)
            {
                result += ASCII.ASCIIValues[b];
            }

            return result;
        }
    }
}