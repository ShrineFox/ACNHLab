using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACNHLab.Classes
{
    class Bcsv
    {
		public static DataGridView dataGridView1 = new DataGridView();
		public static DataGridView dataGridView2 = new DataGridView();

		public static string EntryNbr;

		public static int int_EntryNbr;

		public static string EntrySize;

		public static int int_EntrySize;

		public static string ColumnNbr;

		public static int int_ColumnNbr;

		public static List<int> list_ColumnSize = new List<int>();

		public static List<int> list_ColumnLength = new List<int>();

		public static List<string> list_ColumnHeader = new List<string>();

		public static List<string> list_ColumnType = new List<string>();

		public static string numVersion = "v0.0i build 28102020";

		public static void Read(string FilePath)
		{
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.ForeColor = Color.Black;
			EntryNbr = string.Empty;
			int_EntryNbr = 0;
			EntrySize = string.Empty;
			int_EntrySize = 0;
			ColumnNbr = string.Empty;
			int_ColumnNbr = 0;
			dataGridView1.DataSource = null;
			dataGridView1.Rows.Clear();
			dataGridView1.Columns.Clear();
			dataGridView1.Refresh();
			dataGridView2.DataSource = null;
			dataGridView2.Rows.Clear();
			dataGridView2.Refresh();
			list_ColumnSize.Clear();
			list_ColumnHeader.Clear();
			list_ColumnLength.Clear();
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(FilePath)))
			{
				string text = string.Empty;
				string text2 = string.Empty;
				string text3 = string.Empty;
				for (int i = 15; i >= 12; i--)
				{
					binaryReader.BaseStream.Position = (long)i;
					text += binaryReader.ReadByte().ToString("x2");
				}
				for (int j = 11; j >= 10; j--)
				{
					binaryReader.BaseStream.Position = (long)j;
					text2 += binaryReader.ReadByte().ToString("x2");
				}
				if (Snippet.InvertString(Hex.FromHexToString(text)) == "BCSV" || (text2 == "0100" && Snippet.InvertString(Hex.FromHexToString(text)) != "BCSV"))
				{
					for (int k = 3; k >= 0; k--)
					{
						binaryReader.BaseStream.Position = (long)k;
						EntryNbr += binaryReader.ReadByte().ToString("x2");
					}
					for (int l = 7; l >= 4; l--)
					{
						binaryReader.BaseStream.Position = (long)l;
						EntrySize += binaryReader.ReadByte().ToString("x2");
					}
					for (int m = 9; m >= 8; m--)
					{
						binaryReader.BaseStream.Position = (long)m;
						ColumnNbr += binaryReader.ReadByte().ToString("x2");
					}
					int_EntryNbr = int.Parse(EntryNbr, NumberStyles.HexNumber);
					int_EntrySize = int.Parse(EntrySize, NumberStyles.HexNumber);
					int_ColumnNbr = int.Parse(ColumnNbr, NumberStyles.HexNumber);
					dataGridView1.ColumnCount = int_ColumnNbr;
					int num = 8;
					int num2 = 3;
					int num3 = 28;
					if (text2 == "0100" && Snippet.InvertString(Hex.FromHexToString(text)) != "BCSV")
					{
						num3 = 12;
					}
					else
					{
						for (int n = 17; n >= 16; n--)
						{
							binaryReader.BaseStream.Position = (long)n;
							text3 += binaryReader.ReadByte().ToString("x2");
						}
						num3 = 28;
					}
					int[] array = new int[int_ColumnNbr];
					for (int num4 = 0; num4 <= int_ColumnNbr - 1; num4++)
					{
						string text4 = string.Empty;
						for (int num5 = num3 + num2; num5 >= num3; num5--)
						{
							binaryReader.BaseStream.Position = (long)num5;
							text4 += binaryReader.ReadByte().ToString("x2");
						}
						string text5 = string.Empty;
						for (int num6 = num3 + num2 + 4; num6 >= num3 + num2 + 1; num6--)
						{
							binaryReader.BaseStream.Position = (long)num6;
							text5 += binaryReader.ReadByte().ToString("x2");
						}
						dataGridView1.Columns[num4].Name = text4;
						if (text4 == "54706054")
						{
							dataGridView1.Columns[num4].DefaultCellStyle.BackColor = Color.LightGray;
							dataGridView1.Columns[num4].DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
						}
						list_ColumnHeader.Add(text4);
						list_ColumnLength.Add(int.Parse(text5, NumberStyles.HexNumber));
						array[num4] = int.Parse(text5, NumberStyles.HexNumber);
						num3 += num;
						list_ColumnSize.Add(0);
					}
					for (int num7 = 0; num7 < int_EntryNbr; num7++)
					{
						dataGridView1.Rows.Add();
						for (int num8 = 0; num8 <= int_ColumnNbr - 1; num8++)
						{
							int num9 = num3 + array[num8];
							int num10;
							if (num8 + 1 >= int_ColumnNbr)
							{
								num10 = num3 + int_EntrySize;
							}
							else
							{
								num10 = num3 + array[num8 + 1];
							}
							int num11 = num10 - num9;
							if (num11 < 0)
							{
								num11 *= -1;
							}
							list_ColumnSize[num8] = num11;
							if (num11 <= 2)
							{
								((DataGridViewTextBoxColumn)dataGridView1.Columns[num8]).MaxInputLength = num11 * 2 + 1;
							}
							else
							{
								((DataGridViewTextBoxColumn)dataGridView1.Columns[num8]).MaxInputLength = num11 * 2;
							}
							string text6 = string.Empty;
							for (int num12 = num10 - 1; num12 >= num9; num12--)
							{
								binaryReader.BaseStream.Position = (long)num12;
								if (binaryReader.BaseStream.Position > binaryReader.BaseStream.Length)
								{
									break;
								}
								text6 += binaryReader.ReadByte().ToString("x2");
							}
							if (text6 != null || text6 != "")
							{
								switch (num11)
								{
									case 0:
										dataGridView1.Rows[num7].Cells[num8].Value = "Error";
										goto IL_A30;
									case 1:
										dataGridView1.Rows[num7].Cells[num8].Value = int.Parse(text6, NumberStyles.HexNumber);
										goto IL_A30;
									case 2:
										dataGridView1.Rows[num7].Cells[num8].Value = int.Parse(text6, NumberStyles.HexNumber);
										goto IL_A30;
									case 3:
									case 6:
									case 7:
										break;
									case 4:
										dataGridView1.Rows[num7].Cells[num8].Value = text6.ToUpper();
										goto IL_A30;
									case 5:
										dataGridView1.Rows[num7].Cells[num8].Value = text6.ToUpper();
										dataGridView1.Rows[num7].Cells[num8].Style.BackColor = Color.LightGray;
										goto IL_A30;
									case 8:
										dataGridView1.Rows[num7].Cells[num8].Value = text6.ToUpper();
										dataGridView1.Rows[num7].Cells[num8].ToolTipText = Hex.FromHexToString(text6);
										goto IL_A30;
									default:
										if (num11 != 16)
										{
											if (num11 != 32)
											{
												break;
											}
										}
										else
										{
											dataGridView1.Rows[num7].Cells[num8].Value = text6.ToUpper();
											try
											{
												Color backColor = ColorTranslator.FromHtml(Hex.FromHexToString(text6.ToUpper()).Substring(0, 7));
												dataGridView1.Rows[num7].Cells[num8].Style.BackColor = backColor;
												goto IL_A30;
											}
											catch
											{
												goto IL_A30;
											}
										}
										dataGridView1.Rows[num7].Cells[num8].Value = Hex.FromHexToString(text6);
										dataGridView1.Rows[num7].Cells[num8].ToolTipText = Hex.FromHexToString_JP(Snippet.InvertString(Snippet.InvertHex(text6)));
										goto IL_A30;
								}
								dataGridView1.Rows[num7].Cells[num8].Value = Hex.FromHexToString(text6);
								dataGridView1.Rows[num7].Cells[num8].ToolTipText = Hex.FromHexToString_JP(Snippet.InvertString(Snippet.InvertHex(text6)));
								dataGridView1.Rows[num7].Cells[num8].Style.BackColor = Color.LightPink;
							}
							else
							{
								dataGridView1.Rows[num7].Cells[num8].Value = text6.ToUpper();
							}
						IL_A30:;
						}
						num3 += int_EntrySize;
					}
					int num13 = 0;
					while (num13 < list_ColumnHeader.Count)
					{
						string text7;
						switch (list_ColumnSize[num13])
						{
							case 1:
								text7 = "int8";
								break;
							case 2:
								text7 = "int16";
								break;
							case 3:
								goto IL_AC4;
							case 4:
								text7 = "int32/hash/float";
								break;
							case 5:
								text7 = "raw";
								break;
							default:
								goto IL_AC4;
						}
					IL_ACB:
						if (dataGridView2.Columns.Count == 0)
							dataGridView2.Columns.Add("","");
						dataGridView2.Rows.Add(new object[]
						{
							list_ColumnHeader[num13],
							list_ColumnSize[num13],
							text7
						});
						dataGridView1.Columns[num13].ToolTipText = list_ColumnSize[num13].ToString();
						num13++;
						continue;
					IL_AC4:
						text7 = "String";
						goto IL_ACB;
					}
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
				}
				else
				{
					MessageBox.Show("Invalid File Format (" + Snippet.InvertString(Hex.FromHexToString(text)) + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		public static void Write(string FilePath)
		{
			//int rowCount = 0;
			BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(FilePath));
			binaryWriter.BaseStream.Position = 0L;
			binaryWriter.Write(dataGridView1.Rows.Count - 1);
			binaryWriter.BaseStream.Position = 4L;
			binaryWriter.Write(int_EntrySize);
			binaryWriter.BaseStream.Position = 8L;
			binaryWriter.Write(dataGridView1.Columns.Count);
			binaryWriter.BaseStream.Position = 10L;
			binaryWriter.Write(257);
			binaryWriter.BaseStream.Position = 12L;
			binaryWriter.Write(ToByteArray(Hex.StringToHex("VSCB")));
			binaryWriter.BaseStream.Position = 16L;
			binaryWriter.Write(10500);
			int num = 28;
			foreach (object obj in dataGridView1.Columns)
			{
				DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
				string headerText = dataGridView1.Columns[dataGridViewColumn.Index].HeaderText;
				int value = list_ColumnLength[dataGridViewColumn.Index];
				int num2 = list_ColumnSize[dataGridViewColumn.Index];
				binaryWriter.BaseStream.Position = (long)num;
				binaryWriter.Write(ToByteArray(LittleEndian(headerText)));
				num += 4;
				binaryWriter.BaseStream.Position = (long)num;
				binaryWriter.Write(value);
				num += 4;
			}
			foreach (object obj2 in ((IEnumerable)dataGridView1.Rows))
			{
				//rowCount++;
				#if DEBUG
					//Output.Log($"Row {rowCount}");
				#endif
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
				if (dataGridViewRow.Index >= dataGridView1.Rows.Count - 1)
				{
					break;
				}
				int num3 = 0;
				binaryWriter.BaseStream.Position = (long)num;
				binaryWriter.Write(num);
				//int cellCount = 0;
				foreach (object obj3 in dataGridViewRow.Cells)
				{
					//cellCount++;
					#if DEBUG
						//Output.Log($"Writing Cell {cellCount}");
					#endif
					DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
					binaryWriter.BaseStream.Position = (long)(num + list_ColumnLength[num3]);
					string text;
					if (dataGridViewCell.Value == null)
					{
						text = string.Empty;
					}
					else
					{
						text = dataGridViewCell.Value.ToString();
					}
					switch (list_ColumnSize[num3])
					{
						case 1:
							binaryWriter.Write(ToByteArray(LittleEndian(Hex.IntToHex(int.Parse(text)))));
							break;
						case 2:
							{
								LittleEndian(text);
								string num4 = Hex.IntToHex(int.Parse(text));
								binaryWriter.Write(ToByteArray(LittleEndian(num4)));
								break;
							}
						case 3:
							goto IL_31B;
						case 4:
							binaryWriter.Write(ToByteArray(LittleEndian(text)));
							break;
						case 5:
							binaryWriter.Write(ToByteArray(text));
							break;
						default:
							goto IL_31B;
					}
				IL_32D:
					num3++;
					continue;
				IL_31B:
					binaryWriter.Write(ToByteArray(Hex.StringToHex(text)));
					goto IL_32D;
				}
				num += int_EntrySize;
			}
			binaryWriter.Close();
		}

		internal class Snippet
		{
			public static string InvertString(string s)
			{
				char[] array = s.ToCharArray();
				Array.Reverse(array);
				return new string(array);
			}

			public static string InvertHexString(string InputText)
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i <= InputText.Length - 2; i += 2)
				{
					stringBuilder.Append(new StringBuilder(InputText.Substring(i, i + 2)).ToString().Reverse<char>());
				}
				return stringBuilder.ToString();
			}

			public static string crc32b_Hash(string text_to_hash)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(text_to_hash);
				return BitConverter.ToString(new Crc32().ComputeHash(bytes)).ToLower().Replace("-", "");
			}

			public static string InvertHex(string Hex_Str)
			{
				string text = "";
				for (int i = 0; i < Hex_Str.Length - 1; i += 2)
				{
					text += Hex_Str[i + 1].ToString();
					text += Hex_Str[i].ToString();
				}
				return text;
			}
		}

		public static byte[] ToByteArray(string HexString)
		{
			int length = HexString.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
			}
			return array;
		}
		private static string LittleEndian(string num)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(num, 16));
			string text = "";
			foreach (byte b in bytes)
			{
				text += b.ToString("X2");
			}
			return text;
		}

		internal class Crc32
		{
			public Crc32()
			{
				ChecksumTable = new uint[256];
				for (uint num = 0U; num < 256U; num += 1U)
				{
					uint num2 = num;
					for (int i = 0; i < 8; i++)
					{
						num2 = (((num2 & 1U) != 0U) ? (Polynomial ^ num2 >> 1) : (num2 >> 1));
					}
					ChecksumTable[(int)num] = num2;
				}
			}

			public byte[] ComputeHash(Stream stream)
			{
				uint num = uint.MaxValue;
				int num2;
				while ((num2 = stream.ReadByte()) != -1)
				{
					num = (ChecksumTable[(int)((num & 255U) ^ (uint)((byte)num2))] ^ num >> 8);
				}
				byte[] bytes = BitConverter.GetBytes(~num);
				Array.Reverse(bytes);
				return bytes;
			}

			public byte[] ComputeHash(byte[] data)
			{
				byte[] result;
				using (MemoryStream memoryStream = new MemoryStream(data))
				{
					result = ComputeHash(memoryStream);
				}
				return result;
			}

			private readonly uint[] ChecksumTable;

			private readonly uint Polynomial = 3988292384U;
		}

		public class Hex
		{
			public static string StringToHex(string text_value)
			{
				return BitConverter.ToString(Encoding.Default.GetBytes(text_value)).Replace("-", "");
			}

			public static float HexStringToFloat(string hex)
			{
				float result;
				try
				{
					result = BitConverter.ToSingle(BitConverter.GetBytes(uint.Parse(hex, NumberStyles.AllowHexSpecifier)), 0);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}

			public static string IntToHex(int num)
			{
				return num.ToString("X4");
			}

			public static string FloatToHexString(float f)
			{
				return "0x" + BitConverter.ToInt32(BitConverter.GetBytes(f), 0).ToString("X8");
			}

			public static string FromHexToString(string hexString)
			{
				byte[] array = new byte[hexString.Length / 2];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
				}
				return Snippet.InvertString(Encoding.Default.GetString(array));
			}

			public static string FromHexToString_JP(string hexString)
			{
				byte[] array = new byte[hexString.Length / 2];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
				}
				return Encoding.UTF8.GetString(array);
			}

			public static string StringToHexString(string str)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (byte b in Encoding.ASCII.GetBytes(str))
				{
					stringBuilder.Append(b.ToString("X2"));
				}
				return stringBuilder.ToString();
			}

			public bool IsHexString(string test)
			{
				return Regex.IsMatch(test, "\\A\\b[0-9a-fA-F]+\\b\\Z");
			}
		}
	}
}
