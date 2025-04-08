using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Lab1
{
	internal class Shif
	{
		private char[] lfsr;
		private StringBuilder shiftedBits;
		private byte[] messageBytes, crypted;
		private int act = 1;

		public Shif(string lfsr, byte[] message)
		{
			this.lfsr = lfsr.ToCharArray();
			this.messageBytes = message;
			Siphre();
		}

		private uint Polynomial(char[] lfsr)
		{
			uint bit26 = (uint)(lfsr[0] - '0');
			uint bit7 = (uint)(lfsr[19] - '0');
			uint bit6 = (uint)(lfsr[20] - '0');
			uint bit0 = (uint)(lfsr[26] - '0');

			return (bit26 ^ bit7 ^ bit6 ^ bit0);
		}

		public void Siphre()
		{
			shiftedBits = new StringBuilder();
			crypted = new byte[messageBytes.Length];

			for (int i = 0; i < messageBytes.Length; i++)
			{
				byte keyByte = 0;

				for (int bit = 0; bit < 8; bit++)
				{
					uint newBit = Polynomial(lfsr);
					shiftedBits.Append(lfsr[0]); 

					keyByte |= (byte)((lfsr[0] - '0') << (7 - bit));

					// Сдвиг LFSR
					Array.Copy(lfsr, 1, lfsr, 0, lfsr.Length - 1);
					lfsr[^1] = (newBit == 1) ? '1' : '0';
				}

				crypted[i] = (byte)(messageBytes[i] ^ keyByte);

				// 🔹 Отладочный вывод
				Console.WriteLine($"messageBytes[{i}]: {Convert.ToString(messageBytes[i], 2).PadLeft(8, '0')}");
				Console.WriteLine($"keyByte: {Convert.ToString(keyByte, 2).PadLeft(8, '0')}");
				Console.WriteLine($"XOR result: {Convert.ToString(crypted[i], 2).PadLeft(8, '0')}");
			}
		}



		public string PrintInputBits()
		{
			StringBuilder outp = new StringBuilder();
			foreach (byte b in messageBytes)
			{
				outp.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
			}
			return outp.ToString();
		}

		public string PrintOutputBits()
		{
			StringBuilder outp = new StringBuilder();
			foreach (byte b in crypted)
			{
				outp.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
			}
			return outp.ToString();
		}

		public string PrintShiftedBits()
		{
			return shiftedBits.ToString();
		}

		public byte[] GetRes()
		{
			return crypted;
		}
	}
}
