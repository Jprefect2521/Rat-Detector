namespace RatDetector
{
	// Token: 0x02000002 RID: 2
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000024BD File Offset: 0x000006BD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000024DC File Offset: 0x000006DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::RatDetector.Main));
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(354, 12);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(38, 20);
			this.button1.TabIndex = 0;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(317, 38);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Check";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.textBox1.Location = new global::System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(336, 20);
			this.textBox1.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(59, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Diagnosis: ";
			this.comboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"EN",
				"UA",
				"RU"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(261, 38);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(50, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "EN";
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(404, 74);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RAT Detector";
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ComboBox comboBox1;
	}
}
