namespace Kogel.Record.Test
{
	partial class frmScreen
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.picScreen = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnOpenProgram = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpenCamera = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
			this.SuspendLayout();
			// 
			// picScreen
			// 
			this.picScreen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picScreen.Location = new System.Drawing.Point(0, 0);
			this.picScreen.Name = "picScreen";
			this.picScreen.Size = new System.Drawing.Size(910, 555);
			this.picScreen.TabIndex = 0;
			this.picScreen.TabStop = false;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 10);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "开始";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(93, 10);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 23);
			this.btnEnd.TabIndex = 2;
			this.btnEnd.Text = "结束";
			this.btnEnd.UseVisualStyleBackColor = true;
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnOpenProgram
			// 
			this.btnOpenProgram.Location = new System.Drawing.Point(174, 10);
			this.btnOpenProgram.Name = "btnOpenProgram";
			this.btnOpenProgram.Size = new System.Drawing.Size(117, 23);
			this.btnOpenProgram.TabIndex = 3;
			this.btnOpenProgram.Text = "测试录制程序界面";
			this.btnOpenProgram.UseVisualStyleBackColor = true;
			this.btnOpenProgram.Click += new System.EventHandler(this.btnOpenProgram_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(422, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "0";
			// 
			// btnOpenCamera
			// 
			this.btnOpenCamera.Location = new System.Drawing.Point(297, 10);
			this.btnOpenCamera.Name = "btnOpenCamera";
			this.btnOpenCamera.Size = new System.Drawing.Size(117, 23);
			this.btnOpenCamera.TabIndex = 5;
			this.btnOpenCamera.Text = "测试录制摄像头";
			this.btnOpenCamera.UseVisualStyleBackColor = true;
			this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
			// 
			// frmScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 555);
			this.Controls.Add(this.btnOpenCamera);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOpenProgram);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.picScreen);
			this.Name = "frmScreen";
			this.Text = "测试录制屏幕";
			((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picScreen;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnOpenProgram;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOpenCamera;
	}
}

