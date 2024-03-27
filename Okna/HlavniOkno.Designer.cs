namespace EvidenceKlicu
{
	partial class HlavniOkno
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			groupBox3 = new GroupBox();
			dataGridView1 = new DataGridView();
			groupBox2 = new GroupBox();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(895, 633);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Zamestnanci";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dataGridView1);
			groupBox3.Location = new Point(6, 81);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(883, 546);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Data";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(6, 22);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(871, 518);
			dataGridView1.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Location = new Point(6, 22);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(883, 53);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Úpravy";
			// 
			// HlavniOkno
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1620, 657);
			Controls.Add(groupBox1);
			Name = "HlavniOkno";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox3;
		private DataGridView dataGridView1;
		private GroupBox groupBox2;
	}
}