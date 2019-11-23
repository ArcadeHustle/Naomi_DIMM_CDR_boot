namespace NaoIso
{
	// Token: 0x02000073 RID: 115
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000010B4 File Offset: 0x000004B4
		private void InitializeComponent()
		{
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.textBox6 = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.srcISODialog = new global::System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			global::System.Drawing.Point location = new global::System.Drawing.Point(18, 12);
			this.groupBox1.Location = location;
			this.groupBox1.Name = "groupBox1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(299, 180);
			this.groupBox1.Size = size;
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source Game";
			global::System.Drawing.Color white = global::System.Drawing.Color.White;
			this.textBox5.BackColor = white;
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(6, 134);
			this.textBox5.Location = location2;
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(202, 20);
			this.textBox5.Size = size2;
			this.textBox5.TabIndex = 6;
			this.label5.AutoSize = true;
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(3, 118);
			this.label5.Location = location3;
			this.label5.Name = "label5";
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(106, 13);
			this.label5.Size = size3;
			this.label5.TabIndex = 5;
			this.label5.Text = "Source game info file";
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(6, 95);
			this.textBox2.Location = location4;
			this.textBox2.Name = "textBox2";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(202, 20);
			this.textBox2.Size = size4;
			this.textBox2.TabIndex = 4;
			this.label2.AutoSize = true;
			global::System.Drawing.Point location5 = new global::System.Drawing.Point(6, 79);
			this.label2.Location = location5;
			this.label2.Name = "label2";
			global::System.Drawing.Size size5 = new global::System.Drawing.Size(62, 13);
			this.label2.Size = size5;
			this.label2.TabIndex = 3;
			this.label2.Text = "Source Key";
			global::System.Drawing.Point location6 = new global::System.Drawing.Point(268, 41);
			this.button1.Location = location6;
			this.button1.Name = "button1";
			global::System.Drawing.Size size6 = new global::System.Drawing.Size(28, 23);
			this.button1.Size = size6;
			this.button1.TabIndex = 2;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			global::System.Drawing.Color white2 = global::System.Drawing.Color.White;
			this.textBox1.BackColor = white2;
			global::System.Drawing.Point location7 = new global::System.Drawing.Point(6, 43);
			this.textBox1.Location = location7;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			global::System.Drawing.Size size7 = new global::System.Drawing.Size(256, 20);
			this.textBox1.Size = size7;
			this.textBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			global::System.Drawing.Point location8 = new global::System.Drawing.Point(6, 27);
			this.label1.Location = location8;
			this.label1.Name = "label1";
			global::System.Drawing.Size size8 = new global::System.Drawing.Size(107, 13);
			this.label1.Size = size8;
			this.label1.TabIndex = 0;
			this.label1.Text = "GD Track ISO Image";
			global::System.Drawing.Point location9 = new global::System.Drawing.Point(6, 95);
			this.textBox3.Location = location9;
			this.textBox3.Name = "textBox3";
			global::System.Drawing.Size size9 = new global::System.Drawing.Size(202, 20);
			this.textBox3.Size = size9;
			this.textBox3.TabIndex = 4;
			this.groupBox2.Controls.Add(this.textBox6);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label4);
			global::System.Drawing.Point location10 = new global::System.Drawing.Point(323, 12);
			this.groupBox2.Location = location10;
			this.groupBox2.Name = "groupBox2";
			global::System.Drawing.Size size10 = new global::System.Drawing.Size(299, 180);
			this.groupBox2.Size = size10;
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Destination Game";
			global::System.Drawing.Point location11 = new global::System.Drawing.Point(6, 134);
			this.textBox6.Location = location11;
			this.textBox6.Name = "textBox6";
			global::System.Drawing.Size size11 = new global::System.Drawing.Size(202, 20);
			this.textBox6.Size = size11;
			this.textBox6.TabIndex = 8;
			this.label6.AutoSize = true;
			global::System.Drawing.Point location12 = new global::System.Drawing.Point(3, 118);
			this.label6.Location = location12;
			this.label6.Name = "label6";
			global::System.Drawing.Size size12 = new global::System.Drawing.Size(125, 13);
			this.label6.Size = size12;
			this.label6.TabIndex = 7;
			this.label6.Text = "Destination game info file";
			this.label3.AutoSize = true;
			global::System.Drawing.Point location13 = new global::System.Drawing.Point(6, 79);
			this.label3.Location = location13;
			this.label3.Name = "label3";
			global::System.Drawing.Size size13 = new global::System.Drawing.Size(81, 13);
			this.label3.Size = size13;
			this.label3.TabIndex = 3;
			this.label3.Text = "Destination Key";
			global::System.Drawing.Point location14 = new global::System.Drawing.Point(6, 43);
			this.textBox4.Location = location14;
			this.textBox4.Name = "textBox4";
			global::System.Drawing.Size size14 = new global::System.Drawing.Size(287, 20);
			this.textBox4.Size = size14;
			this.textBox4.TabIndex = 1;
			this.label4.AutoSize = true;
			global::System.Drawing.Point location15 = new global::System.Drawing.Point(6, 27);
			this.label4.Location = location15;
			this.label4.Name = "label4";
			global::System.Drawing.Size size15 = new global::System.Drawing.Size(81, 13);
			this.label4.Size = size15;
			this.label4.TabIndex = 0;
			this.label4.Text = "Destination ISO";
			global::System.Drawing.Point location16 = new global::System.Drawing.Point(271, 204);
			this.button3.Location = location16;
			this.button3.Name = "button3";
			global::System.Drawing.Size size16 = new global::System.Drawing.Size(96, 26);
			this.button3.Size = size16;
			this.button3.TabIndex = 2;
			this.button3.Text = "Start";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			global::System.Drawing.Point location17 = new global::System.Drawing.Point(18, 238);
			this.progressBar1.Location = location17;
			this.progressBar1.Name = "progressBar1";
			global::System.Drawing.Size size17 = new global::System.Drawing.Size(600, 19);
			this.progressBar1.Size = size17;
			this.progressBar1.TabIndex = 3;
			this.srcISODialog.Filter = "ISO Files|*.iso";
			this.srcISODialog.Title = "Select ISO Image";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Color white3 = global::System.Drawing.Color.White;
			this.BackColor = white3;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(642, 271);
			base.ClientSize = clientSize;
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			this.Text = "Naomi GD ISO Converter";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002484 File Offset: 0x00001884
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_1)
		{
			if (A_1)
			{
				try
				{
					this.~Form1();
				}
				finally
				{
					base.Dispose(true);
				}
			}
			else
			{
				base.Dispose(false);
			}
		}

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.OpenFileDialog srcISODialog;
	}
}
