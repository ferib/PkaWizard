using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ManyMonkeys.Cryptography
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public sealed class XOR : SymmetricAlgorithm, ICryptoTransform
	{
		public XOR() 
		{
			Trace.Write("XOR::XOR\n");

			this.LegalKeySizesValue = new KeySizes[]{new KeySizes(128,128,0)}; // this is in bits - typical of MS
			this.KeySize = 128; // also in bits

			this.LegalBlockSizesValue = new KeySizes[]{new KeySizes(128,128,0)}; // this is in bits - typical of MS
			this.BlockSize = 128; // also in bits
		}

		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
		{
			Trace.Write("XOR::CreateEncryptor2\n");
			key.CopyTo(Key,0);
			iv.CopyTo(IV,0);
			return this;
		}

		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
		{
			Trace.Write("XOR::CreateDecryptor2\n");
			key.CopyTo(Key,0);
			iv.CopyTo(IV,0);
			return this;
		}

		public override void GenerateIV()
		{
			Trace.Write("XOR::GenerateIV\n"); // we are delaing with bytes not bits so we need to /8
			IV = new byte[16]{0x0,0x1,0x2,0x3,0x4,0x5,0x6,0x7,0x8,0x9,0xa,0xb,0xc,0xd,0xe,0xf};
		}

		public override void GenerateKey()
		{
			Trace.Write("XOR::GenerateKey\n"); // we are delaing with bytes not bits so we need to /8
			Key = new byte[16]{0x0,0x1,0x2,0x3,0x4,0x5,0x6,0x7,0x8,0x9,0xa,0xb,0xc,0xd,0xe,0xf};
		}

		public void Dispose()
		{
			Trace.Write("XORTransform::Dispose\n");
		}

		public int TransformBlock(
			byte[] inputBuffer,
			int inputOffset,
			int inputCount,
			byte[] outputBuffer,
			int outputOffset
			)
		{
			Trace.Write(String.Format("XORTransform::TransformBlock {0} {1} {2}\n", inputOffset, inputCount, outputOffset));

			for (int i=0;i<inputCount;i++)
			{
				outputBuffer[i+outputOffset] = (byte)(inputBuffer[i+inputOffset] ^ Key[i]); 
			}

			return inputCount;
		}

		public byte[] TransformFinalBlock(
			byte[] inputBuffer,
			int inputOffset,
			int inputCount
			)
		{
			Trace.Write(String.Format("XORTransform::TransformFinalBlock {0} {1}\n", inputOffset, inputCount));
			byte []outputBuffer = new byte[inputCount]; 
			for (int i=0;i<inputCount;i++)
			{
				outputBuffer[i] = (byte)(inputBuffer[i+inputOffset] ^ Key[i]); 
			}
			return outputBuffer;
		}

		public bool CanReuseTransform
		{
			get
			{
				Trace.Write("XORTransform::CanReuseTransform get\n");
				return canReuseTransform;
			}
		}

		public bool CanTransformMultipleBlocks
		{
			get
			{
				Trace.Write("XORTransform::CanTransformMultipleBlocks get\n");
				return canTransformMultipleBlocks;
			}
		}

		public int InputBlockSize
		{
			get
			{
				Trace.Write("XORTransform::InputBlockSize get\n");
				return inputBlockSize;
			}
		}

		public int OutputBlockSize
		{
			get
			{
				Trace.Write("XORTransform::OutputBlockSize get\n");
				return outputBlockSize;
			}
		}

		private bool canReuseTransform = true;
		private bool canTransformMultipleBlocks = false;
		private int inputBlockSize = 16;
		private int outputBlockSize = 16;

	}

}
