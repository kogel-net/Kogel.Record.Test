using AForge.Video;
using Kogel.Record.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kogel.Record.Extension.WindowApi;

namespace Kogel.Record.Test
{
	public partial class frmProgram : Form
	{
		private ProgramRecorder recorder { get; set; }
		private string recorderPath { get; set; }
		private List<WindowInfo> programList { get; set; }

		public frmProgram()
		{
			InitializeComponent();
			recorderPath = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("MMddHHmmss") + ".mp4";
			//初始化所有桌面程序
			programList = WindowApi.GetAllDesktopWindows().Where(x => !string.IsNullOrEmpty(x.szWindowName)).ToList();
			this.cboProgram.DataSource = programList.Select(x => x.szWindowName).ToList();
		}

		/// <summary>
		/// 开始
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStart_Click(object sender, EventArgs e)
		{
			recorder = new ProgramRecorder(programList[this.cboProgram.SelectedIndex].hWnd, this.cboProgram.SelectedText, recorderPath, 10, true);
			//开始并设置显示器
			recorder.Start(VideoStreamer_NewFrame);
		}

		/// <summary>
		/// 每帧录制帧数回调
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="eventArgs"></param>
		private void VideoStreamer_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			this.picScreen.Image = (Bitmap)eventArgs.Frame.Clone();
		}

		/// <summary>
		/// 结束
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEnd_Click(object sender, EventArgs e)
		{
			recorder.End();
		}
	}
}
