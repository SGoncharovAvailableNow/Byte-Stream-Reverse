using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Stream_Reverse.ByteReverse
{
    internal class ByteStreamReverse
    {
        public byte[] ReverseByte(byte[] bytes) 
        {
            var result = new List<byte>();

            for (int i = 0, y = 8; i < bytes.Length / 8; i++,y += 8) 
            {
                result.AddRange(bytes.ToList().GetRange(bytes.Length - y,8));
            }

            return result.ToArray();
        }

        public void ShowArray(byte[] bytes) 
        {
            foreach (byte b in bytes) 
            {
                Console.Write($" {b} ");
            }
            Console.WriteLine();
        }
    }
}
