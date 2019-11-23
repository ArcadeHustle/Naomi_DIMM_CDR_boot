using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using <CppImplementationDetails>;

namespace NaoIso
{
	// Token: 0x02000073 RID: 115
	public partial class Form1 : Form
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00001030 File Offset: 0x00000430
		public Form1()
		{
			try
			{
				this.InitializeComponent();
				this.offset = 192512u;
				this.start = 47104u;
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00001088 File Offset: 0x00000488
		private void ~Form1()
		{
			if (this.components != null)
			{
				IDisposable disposable = this.components;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00001A84 File Offset: 0x00000E84
		private unsafe void button1_Click(object sender, EventArgs e)
		{
			if (this.srcISODialog.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = this.srcISODialog.FileName;
				this.textBox4.Text = this.srcISODialog.FileName + ".new";
				IntPtr hglobal = Marshal.StringToHGlobalAnsi(this.textBox1.Text);
				_iobuf* ptr;
				<Module>.fopen_s(&ptr, (sbyte*)hglobal.ToPointer(), (sbyte*)(&<Module>.??_C@_02JDPG@rb?$AA@));
				Marshal.FreeHGlobal(hglobal);
				if (ptr == null)
				{
					<Module>.fclose(ptr);
					MessageBox.Show("Can't open ISO image", "Error", MessageBoxButtons.OK);
				}
				else
				{
					$ArrayType$$$BY0M@$$CBE $ArrayType$$$BY0M@$$CBE = 0;
					*(ref $ArrayType$$$BY0M@$$CBE + 1) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 2) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 3) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 4) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 5) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 6) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 7) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 8) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 9) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 10) = byte.MaxValue;
					*(ref $ArrayType$$$BY0M@$$CBE + 11) = 0;
					uint num = 2048u;
					$ArrayType$$$BY0IAA@E $ArrayType$$$BY0IAA@E;
					<Module>.fread((void*)(&$ArrayType$$$BY0IAA@E), 12u, 1u, ptr);
					if (<Module>.memcmp((void*)(&$ArrayType$$$BY0IAA@E), (void*)(&$ArrayType$$$BY0M@$$CBE), 12u) == null)
					{
						num = 2352u;
						<Module>.fseek(ptr, 16, 0);
					}
					else
					{
						<Module>.fseek(ptr, 0, 0);
					}
					int i;
					for (i = 16; i < 200; i++)
					{
						if (num == 2352u)
						{
							<Module>.fseek(ptr, i * 2352 + 16, 0);
						}
						else
						{
							<Module>.fseek(ptr, i * 2048, 0);
						}
						<Module>.fread((void*)(&$ArrayType$$$BY0IAA@E), 2048u, 1u, ptr);
						if (<Module>.memcmp((void*)(&$ArrayType$$$BY0IAA@E), (void*)(&<Module>.??_C@_07NKOFPJFH@?$ABCD001?$AB?$AA@), 7u) == null)
						{
							break;
						}
					}
					if (i == 200)
					{
						<Module>.fclose(ptr);
						MessageBox.Show("Can't find ISO header", "Error", MessageBoxButtons.OK);
					}
					else
					{
						_iso_primary_record iso_primary_record;
						<Module>.memcpy((void*)(&iso_primary_record), (void*)(&$ArrayType$$$BY0IAA@E), 2048u);
						_rootdirrecord rootdirrecord;
						<Module>.memcpy((void*)(&rootdirrecord), ref iso_primary_record + 156, 33u);
						i = *(ref rootdirrecord + 2) - 45000;
						if (num == 2352u)
						{
							<Module>.fseek(ptr, i * 2352 + 16, 0);
						}
						else
						{
							<Module>.fseek(ptr, i * 2048, 0);
						}
						<Module>.fread((void*)(&$ArrayType$$$BY0IAA@E), 2048u, 1u, ptr);
						byte* ptr2 = (byte*)(&$ArrayType$$$BY0IAA@E);
						this.sz = 0u;
						bool flag = false;
						for (;;)
						{
							_rootdirrecord* ptr3 = (_rootdirrecord*)ptr2;
							if (*(byte*)ptr3 == 0)
							{
								if (!flag)
								{
									MessageBox.Show("Can't find Game Info File", "Error", MessageBoxButtons.OK);
								}
								break;
							}
							$ArrayType$$$BY0BAA@D $ArrayType$$$BY0BAA@D;
							<Module>.memcpy((void*)(&$ArrayType$$$BY0BAA@D), (void*)(ptr2 + 33), (uint)(*(byte*)(ptr3 + 32 / sizeof(_rootdirrecord))));
							*(ref $ArrayType$$$BY0BAA@D + *(byte*)(ptr3 + 32 / sizeof(_rootdirrecord))) = 0;
							this.sz += (uint)(*(int*)(ptr3 + 10 / sizeof(_rootdirrecord)));
							if ((<Module>.strstr((sbyte*)(&$ArrayType$$$BY0BAA@D), (sbyte*)(&<Module>.??_C@_04GKHLBAIJ@?4bin?$AA@)) != null || <Module>.strstr((sbyte*)(&$ArrayType$$$BY0BAA@D), (sbyte*)(&<Module>.??_C@_04GHIANNPF@?4BIN?$AA@)) != null) && *(int*)(ptr3 + 10 / sizeof(_rootdirrecord)) < 4096)
							{
								sbyte* ptr4 = <Module>.strchr((sbyte*)(&$ArrayType$$$BY0BAA@D), 59);
								if (ptr4 != null)
								{
									*(byte*)ptr4 = 0;
								}
								this.textBox5.Text = new string((sbyte*)(&$ArrayType$$$BY0BAA@D));
								this.textBox6.Text = new string((sbyte*)(&$ArrayType$$$BY0BAA@D));
								flag = true;
							}
							ptr2 += *(byte*)ptr3;
						}
						<Module>.fclose(ptr);
					}
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00001D9C File Offset: 0x0000119C
		private unsafe void button3_Click(object sender, EventArgs e)
		{
			IntPtr hglobal = Marshal.StringToHGlobalAnsi(this.textBox1.Text);
			_iobuf* ptr;
			<Module>.fopen_s(&ptr, (sbyte*)hglobal.ToPointer(), (sbyte*)(&<Module>.??_C@_02JDPG@rb?$AA@));
			if (ptr == null)
			{
				MessageBox.Show("Can't open ISO image", "Error", MessageBoxButtons.OK);
			}
			else
			{
				Marshal.FreeHGlobal(hglobal);
				hglobal = Marshal.StringToHGlobalAnsi(this.textBox4.Text);
				_iobuf* ptr2;
				<Module>.fopen_s(&ptr2, (sbyte*)hglobal.ToPointer(), (sbyte*)(&<Module>.??_C@_03ELIABIOC@w?$CLb?$AA@));
				if (ptr2 == null)
				{
					<Module>.fclose(ptr);
					MessageBox.Show("Can't open destination file", "Error", MessageBoxButtons.OK);
				}
				else
				{
					Marshal.FreeHGlobal(hglobal);
					this.start = 47104u;
					this.csz = 0u;
					int num = -1;
					$ArrayType$$$BY0BAAAA@E $ArrayType$$$BY0BAAAA@E;
					<Module>.fread((void*)(&$ArrayType$$$BY0BAAAA@E), 32u, 2048u, ptr);
					_iso_primary_record iso_primary_record;
					<Module>.memcpy((void*)(&iso_primary_record), ref $ArrayType$$$BY0BAAAA@E + 32768, 2048u);
					_rootdirrecord rootdirrecord;
					<Module>.memcpy((void*)(&rootdirrecord), ref iso_primary_record + 156, 33u);
					int num2 = *(ref rootdirrecord + 2) - 45000;
					this.progressBar1.Maximum = (int)this.sz;
					this.progressBar1.Minimum = 0;
					this.progressBar1.Value = 0;
					byte* ptr3 = ref $ArrayType$$$BY0BAAAA@E + num2 * 2048;
					for (;;)
					{
						_rootdirrecord* ptr4 = (_rootdirrecord*)ptr3;
						if (*(byte*)ptr4 == 0)
						{
							break;
						}
						if (*(int*)(ptr4 + 2 / sizeof(_rootdirrecord)) < 45056)
						{
							ptr3 += *(byte*)ptr4;
						}
						else
						{
							$ArrayType$$$BY0BAA@D $ArrayType$$$BY0BAA@D;
							<Module>.memcpy((void*)(&$ArrayType$$$BY0BAA@D), (void*)(ptr3 + 33), (uint)(*(byte*)(ptr4 + 32 / sizeof(_rootdirrecord))));
							*(ref $ArrayType$$$BY0BAA@D + *(byte*)(ptr4 + 32 / sizeof(_rootdirrecord))) = 0;
							sbyte* ptr5 = <Module>.strchr((sbyte*)(&$ArrayType$$$BY0BAA@D), 59);
							if (ptr5 != null)
							{
								*(byte*)ptr5 = 0;
							}
							<Module>.printf((sbyte*)(&<Module>.??_C@_03IKGEINEE@?$CFs?5?$AA@), ref $ArrayType$$$BY0BAA@D);
							<Module>.printf((sbyte*)(&<Module>.??_C@_04EPBFEBBF@?$CFX?9?$DO?$AA@), *(int*)(ptr4 + 2 / sizeof(_rootdirrecord)));
							if (*(int*)(ptr4 + 2 / sizeof(_rootdirrecord)) > 45056)
							{
								if (*(int*)(ptr4 + 10 / sizeof(_rootdirrecord)) > 1048576)
								{
									this.relocatebigfile(ptr, ptr2, ptr4);
								}
								else
								{
									this.relocatefile(ptr, ptr2, ptr4);
								}
								*(int*)(ptr4 + 6 / sizeof(_rootdirrecord)) = (int)this.bswap32((uint)(*(int*)(ptr4 + 2 / sizeof(_rootdirrecord))));
								<Module>.printf((sbyte*)(&<Module>.??_C@_03NBBHOIGN@?$CFX?6?$AA@), *(int*)(ptr4 + 2 / sizeof(_rootdirrecord)));
							}
							else
							{
								<Module>.printf((sbyte*)(&<Module>.??_C@_08IKLPECHA@Skipped?6?$AA@));
							}
							if ((<Module>.strstr((sbyte*)(&$ArrayType$$$BY0BAA@D), (sbyte*)(&<Module>.??_C@_04GKHLBAIJ@?4bin?$AA@)) != null || <Module>.strstr((sbyte*)(&$ArrayType$$$BY0BAA@D), (sbyte*)(&<Module>.??_C@_04GHIANNPF@?4BIN?$AA@)) != null) && *(int*)(ptr4 + 10 / sizeof(_rootdirrecord)) < 4096)
							{
								num = *(int*)(ptr4 + 2 / sizeof(_rootdirrecord));
								if (this.textBox6.Text != "")
								{
									hglobal = Marshal.StringToHGlobalAnsi(this.textBox6.Text);
									<Module>.memcpy((void*)(ptr3 + 33), (void*)hglobal.ToPointer(), <Module>.strlen((sbyte*)hglobal.ToPointer()) - 1);
									Marshal.FreeHGlobal(hglobal);
								}
							}
							ptr3 += *(byte*)ptr4;
						}
					}
					<Module>.fseek(ptr2, 92160000, 0);
					<Module>.fwrite((void*)(&$ArrayType$$$BY0BAAAA@E), 32u, 2048u, ptr2);
					<Module>.fseek(ptr2, 92467200, 0);
					<Module>.fwrite((void*)(&$ArrayType$$$BY0BAAAA@E), 32u, 2048u, ptr2);
					if (num != -1)
					{
						int num3 = (int)this.crc;
						<Module>.fseek(ptr2, num * 2048, 0);
						$ArrayType$$$BY0IAA@E $ArrayType$$$BY0IAA@E;
						<Module>.fread((void*)(&$ArrayType$$$BY0IAA@E), 2048u, 1u, ptr2);
						<Module>.memcpy(ref $ArrayType$$$BY0IAA@E + 12, (void*)(&num3), 4u);
						<Module>.fseek(ptr2, num * 2048, 0);
						<Module>.fwrite((void*)(&$ArrayType$$$BY0IAA@E), 2048u, 1u, ptr2);
					}
					<Module>.fclose(ptr);
					<Module>.fclose(ptr2);
					MessageBox.Show("Done", "Done", MessageBoxButtons.OK);
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000020E8 File Offset: 0x000014E8
		private uint bswap32(uint v)
		{
			return v << 24 | (v & 16711680u) >> 8 | (v & 65280u) << 8 | v >> 24;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002114 File Offset: 0x00001514
		private unsafe void relocatefile(_iobuf* f, _iobuf* f2, _rootdirrecord* rec)
		{
			int num = *(int*)(rec + 10 / sizeof(_rootdirrecord));
			<Module>.fseek(f, (*(int*)(rec + 2 / sizeof(_rootdirrecord)) - 45150 + 150) * 2048, 0);
			*(int*)(rec + 2 / sizeof(_rootdirrecord)) = *(int*)(rec + 2 / sizeof(_rootdirrecord)) - (int)this.offset;
			<Module>.fseek(f2, *(int*)(rec + 2 / sizeof(_rootdirrecord)) * 2048, 0);
			while (num != 0)
			{
				int num2 = 2048;
				if (num < 2048)
				{
					num2 = num;
				}
				$ArrayType$$$BY0IAA@E $ArrayType$$$BY0IAA@E;
				<Module>.fread((void*)(&$ArrayType$$$BY0IAA@E), (uint)num2, 1u, f);
				<Module>.fwrite((void*)(&$ArrayType$$$BY0IAA@E), (uint)num2, 1u, f2);
				this.start += 1u;
				this.csz += 2048u;
				this.progressBar1.Value = (int)this.csz;
				if (num > 2048)
				{
					num -= 2048;
				}
				else
				{
					num = 0;
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000021E8 File Offset: 0x000015E8
		private unsafe void byterev(byte* p1, byte* p2)
		{
			for (int i = 0; i < 8; i++)
			{
				p2[i] = p1[7 - i];
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002210 File Offset: 0x00001610
		private unsafe void relocatebigfile(_iobuf* f, _iobuf* f2, _rootdirrecord* rec)
		{
			int num = *(int*)(rec + 10 / sizeof(_rootdirrecord));
			<Module>.fseek(f, (*(int*)(rec + 2 / sizeof(_rootdirrecord)) - 45150 + 150) * 2048, 0);
			*(int*)(rec + 2 / sizeof(_rootdirrecord)) = *(int*)(rec + 2 / sizeof(_rootdirrecord)) - (int)this.offset;
			<Module>.fseek(f2, *(int*)(rec + 2 / sizeof(_rootdirrecord)) * 2048, 0);
			this.crc = uint.MaxValue;
			bool flag = false;
			_des_ctx des_ctx;
			_des_ctx des_ctx2;
			if (this.textBox2.Text != "" && this.textBox3.Text != "")
			{
				IntPtr hglobal = 0;
				hglobal = Marshal.StringToHGlobalAnsi(this.textBox2.Text);
				sbyte* ptr = (sbyte*)hglobal.ToPointer();
				$ArrayType$$$BY07E $ArrayType$$$BY07E;
				for (int i = 0; i < 8; i++)
				{
					$ArrayType$$$BY02D $ArrayType$$$BY02D = *(sbyte*)(ptr + i * 2 / sizeof(sbyte));
					*(ref $ArrayType$$$BY02D + 1) = (byte)(*(sbyte*)(ptr + (i * 2 + 1) / sizeof(sbyte)));
					*(ref $ArrayType$$$BY02D + 2) = 0;
					uint num2;
					<Module>.sscanf_s((sbyte*)(&$ArrayType$$$BY02D), (sbyte*)(&<Module>.??_C@_02EMFKHFLK@?$CFX?$AA@), ref num2);
					*(ref $ArrayType$$$BY07E + i) = (byte)(num2 & 255u);
				}
				Marshal.FreeHGlobal(hglobal);
				$ArrayType$$$BY07E $ArrayType$$$BY07E2;
				this.byterev((byte*)(&$ArrayType$$$BY07E), (byte*)(&$ArrayType$$$BY07E2));
				<Module>.des_setkey(&des_ctx, (byte*)(&$ArrayType$$$BY07E2));
				hglobal = Marshal.StringToHGlobalAnsi(this.textBox3.Text);
				ptr = (sbyte*)hglobal.ToPointer();
				for (int i = 0; i < 8; i++)
				{
					$ArrayType$$$BY02D $ArrayType$$$BY02D2 = *(sbyte*)(ptr + i * 2 / sizeof(sbyte));
					*(ref $ArrayType$$$BY02D2 + 1) = (byte)(*(sbyte*)(ptr + (i * 2 + 1) / sizeof(sbyte)));
					*(ref $ArrayType$$$BY02D2 + 2) = 0;
					uint num3;
					<Module>.sscanf_s((sbyte*)(&$ArrayType$$$BY02D2), (sbyte*)(&<Module>.??_C@_02EMFKHFLK@?$CFX?$AA@), ref num3);
					*(ref $ArrayType$$$BY07E + i) = (byte)(num3 & 255u);
				}
				Marshal.FreeHGlobal(hglobal);
				this.byterev((byte*)(&$ArrayType$$$BY07E), (byte*)(&$ArrayType$$$BY07E2));
				<Module>.des_setkey(&des_ctx2, (byte*)(&$ArrayType$$$BY07E2));
				flag = true;
			}
			while (num != 0)
			{
				int num4;
				if (num < 2048)
				{
					num4 = num;
				}
				else
				{
					num4 = 2048;
				}
				$ArrayType$$$BY0IAA@E $ArrayType$$$BY0IAA@E;
				<Module>.fread((void*)(&$ArrayType$$$BY0IAA@E), (uint)num4, 1u, f);
				if (flag)
				{
					for (int j = 0; j < num4; j += 8)
					{
						$ArrayType$$$BY07E $ArrayType$$$BY07E3;
						this.byterev(ref $ArrayType$$$BY0IAA@E + j, (byte*)(&$ArrayType$$$BY07E3));
						$ArrayType$$$BY07E $ArrayType$$$BY07E4;
						<Module>.des_ecb_crypt(&des_ctx, (byte*)(&$ArrayType$$$BY07E3), (byte*)(&$ArrayType$$$BY07E4), 1);
						<Module>.des_ecb_crypt(&des_ctx2, (byte*)(&$ArrayType$$$BY07E4), (byte*)(&$ArrayType$$$BY07E3), 0);
						this.byterev((byte*)(&$ArrayType$$$BY07E3), ref $ArrayType$$$BY0IAA@E + j);
					}
				}
				this.crc = <Module>.crc32((byte*)(&$ArrayType$$$BY0IAA@E), (uint)num4, this.crc);
				<Module>.fwrite((void*)(&$ArrayType$$$BY0IAA@E), (uint)num4, 1u, f2);
				this.start += 1u;
				this.csz += (uint)num4;
				this.progressBar1.Value = (int)this.csz;
				if (num > 2048)
				{
					num -= 2048;
				}
				else
				{
					num = 0;
				}
			}
		}

		// Token: 0x0400010D RID: 269
		private Container components;

		// Token: 0x0400010E RID: 270
		private uint offset;

		// Token: 0x0400010F RID: 271
		private uint start;

		// Token: 0x04000110 RID: 272
		private uint sz;

		// Token: 0x04000111 RID: 273
		private uint csz;

		// Token: 0x04000112 RID: 274
		private uint crc;
	}
}
