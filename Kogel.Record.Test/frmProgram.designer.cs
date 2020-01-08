namespace Kogel.Record.Test
{
	partial class frmProgram
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.picScreen = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboProgram = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(279, 11);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 23);
			this.btnEnd.TabIndex = 5;
			this.btnEnd.Text = "结束";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(198, 11);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "开始";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// picScreen
			// 
			this.picScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picScreen.Location = new System.Drawing.Point(0, 0);
			this.picScreen.Name = "picScreen";
			this.picScreen.Size = new System.Drawing.Size(910, 555);
			this.picScreen.TabIndex = 3;
			this.picScreen.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "选择程序";
			// 
			// cboProgram
			// 
			this.cboProgram.FormattingEnabled = true;
			this.cboProgram.Location = new System.Drawing.Point(71, 14);
			this.cboProgram.Name = "cboProgram";
			this.cboProgram.Size = new System.Drawing.Size(121, 20);
			this.cboProgram.TabIndex = 6;
			// 
			// frmProgram
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 555);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboProgram);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.picScreen);
			this.Name = "frmProgram";
			this.Text = "测试录制程序界面";
			((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.PictureBox picScreen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboProgram;
	}
}