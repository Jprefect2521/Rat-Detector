using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RatDetector
{
	// Token: 0x02000002 RID: 2
	public partial class Main : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Main()
		{
			this.rATVectors.Add(new RATVector("VirusRAT.Downloable", "urlmon.dll", "75-00-72-00-6C-00-6D-00-6F-00-6E-00-2E-00-64-00-6C-00-6C"));
			this.rATVectors.Add(new RATVector("VirtusRAT.Downloable", "URLDownloadToFile", "55-00-52-00-4C-00-44-00-6F-00-77-00-6E-00-6C-00-6F-00-61-00-64-00-54-00-6F-00-46-00-69-00-6C-00-65"));
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020B2 File Offset: 0x000002B2
		private string TranslateToUA(string ru, bool ua = true)
		{
			if (!ua)
			{
				return ru;
			}
			return ru.Replace("и", "i");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020CC File Offset: 0x000002CC
		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Executable files|*.exe;*.dll;*.bin;*.cfg";
				openFileDialog.Title = "Open a ratted file";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.textBox1.Text = openFileDialog.FileName;
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000212C File Offset: 0x0000032C
		private void setValue(bool virus, int detects)
		{
			this.clickedOnce = true;
			this.lastDetects = detects;
			if (detects != 0)
			{
				if (this.comboBox1.SelectedIndex == 0)
				{
					if (detects == 1)
					{
						this.label1.Text = "Diagnosis: RATTED file! (" + detects.ToString() + " detection)";
					}
					else
					{
						this.label1.Text = "Diagnosis: RATTED file! (" + detects.ToString() + " detections)";
					}
				}
				else if (detects == 1)
				{
					this.label1.Text = this.TranslateToUA("Диагноз: ЗаРАТченный файл! (" + detects.ToString() + " детект)", this.comboBox1.SelectedIndex == 1);
				}
				else if (detects % 2 == 0 || detects % 3 == 0 || detects % 4 == 0)
				{
					this.label1.Text = this.TranslateToUA("Диагноз: ЗаРАТченный файл! (" + detects.ToString() + " детекта)", this.comboBox1.SelectedIndex == 1);
				}
				else if (detects % 5 == 0 || detects % 7 == 0 || detects % 6 == 0 || detects % 8 == 0 || detects % 9 == 0 || detects == 0)
				{
					this.label1.Text = this.TranslateToUA("Диагноз: ЗаРАТченный файл! (" + detects.ToString() + " детектов)", this.comboBox1.SelectedIndex == 1);
				}
				this.label1.ForeColor = Color.DarkRed;
				return;
			}
			this.label1.Text = ((this.comboBox1.SelectedIndex == 0) ? "Diagnosis: Clean!" : this.TranslateToUA("Диагноз: Чистен!", this.comboBox1.SelectedIndex == 1));
			this.label1.ForeColor = Color.DarkGreen;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022DC File Offset: 0x000004DC
		private void button2_Click(object sender, EventArgs e)
		{
			if (!File.Exists(this.textBox1.Text))
			{
				return;
			}
			int num = 0;
			string text = File.ReadAllText(this.textBox1.Text);
			for (int i = 0; i < this.rATVectors.Count; i++)
			{
				if (text.Contains(this.rATVectors[i].m_find))
				{
					num++;
				}
			}
			if (num != 0)
			{
				this.setValue(num > 0, num);
				return;
			}
			string text2 = BitConverter.ToString(File.ReadAllBytes(this.textBox1.Text));
			for (int j = 0; j < this.rATVectors.Count; j++)
			{
				if (text2.Contains(this.rATVectors[j].m_alt))
				{
					num++;
				}
			}
			if (num != 0)
			{
				this.setValue(num > 0, num);
				return;
			}
			this.setValue(false, 0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023B6 File Offset: 0x000005B6
		private void Main_Load(object sender, EventArgs e)
		{
			this.comboBox1.Location = new Point(261, 39);
			this.comboBox1.Size = new Size(50, 23);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023E4 File Offset: 0x000005E4
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Text = ((this.comboBox1.SelectedIndex != 0) ? this.TranslateToUA("РАТ Обнаруживатель", this.comboBox1.SelectedIndex == 1) : "RAT Detector");
			if (this.comboBox1.SelectedIndex != 0)
			{
				this.button2.Text = this.TranslateToUA("Проверка", this.comboBox1.SelectedIndex == 1);
			}
			else
			{
				this.button2.Text = "Check";
			}
			if (!this.clickedOnce)
			{
				this.label1.Text = ((this.comboBox1.SelectedIndex != 0) ? this.TranslateToUA("Диагноз: ", this.comboBox1.SelectedIndex == 1) : "Diagnosis: ");
				return;
			}
			this.setValue(this.lastDetects > 0, this.lastDetects);
		}

		// Token: 0x04000001 RID: 1
		private List<RATVector> rATVectors = new List<RATVector>();

		// Token: 0x04000002 RID: 2
		private bool clickedOnce;

		// Token: 0x04000003 RID: 3
		private int lastDetects;
	}
}
