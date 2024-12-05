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

            for (int counterBit = 8; counterBit <= bytes.Length; counterBit += 8)
            {
                result.AddRange(bytes.ToList().GetRange(bytes.Length - counterBit, 8));
            }

            return result.ToArray();
        }

        /// <summary>
        /// Reverse array of bytes
        /// </summary>
        /// <param name="bytes">Array of bytes</param>
        /// <returns> Reversed array of bytes </returns>
        public byte[][] ReverseByteWithChunk(byte[] bytes)
        {
            return bytes.Chunk(8).Reverse().ToArray();
        }

        public void ShowArray(byte[] bytes) 
        {
            foreach (byte b in bytes) 
            {
                Console.Write($" {b} ");
            }

            Console.WriteLine();
        }

        public void ShowSecondArray(byte[][] bytes)
        {
            foreach (byte[] arrayBytes in bytes)
            {
                foreach (byte b in arrayBytes) 
                {
                    Console.Write(b);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
