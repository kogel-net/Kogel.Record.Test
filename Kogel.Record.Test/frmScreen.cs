using AForge.Video;
using AForge.Video.FFMPEG;
using Kogel.Record.Extension;
using Kogel.Record.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kogel.Record.Test
{
	public partial class frmScreen : Form
	{
		private IRecorder recorder { get; set; }
		private string recorderPath { get; set; }
		public frmScreen()
		{
			InitializeComponent();
			//初始化录制器
			recorderPath = AppDomain.CurrentDomain.BaseDirectory + DateTime.Now.ToString("MMddHHmmss") + ".avi";
			recorder = new ScreenRecorderExtension(recorderPath, 10, true);
		}

		/// <summary>
		/// 开始录制
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStart_Click(object sender, EventArgs e)
		{
			//开始并设置显示器
			recorder.Start(VideoStreamer_NewFrame);
		}

		int totalFrame = 1;

		/// <summary>
		/// 每帧录制帧数回调
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="eventArgs"></param>
		private void VideoStreamer_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			this.picScreen.Image = (Bitmap)eventArgs.Frame.Clone();
			try
			{
				this.label1.Invoke(new EventHandler((s, e) =>
				{
					this.label1.Text = (totalFrame++).ToString();
				}));
			}
			catch { }
		}

		/// <summary>
		/// 结束录制
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEnd_Click(object sender, EventArgs e)
		{
			recorder.End();
		}

		private void btnOpenProgram_Click(object sender, EventArgs e)
		{
			new frmProgram().Show();
		}

		private void btnOpenCamera_Click(object sender, EventArgs e)
		{
			new frmCamera().Show();
		}
	}

	/// <summary>
	/// 屏幕录制扩展
	/// </summary>
	public class ScreenRecorderExtension : ScreenRecorder
	{
		public ScreenRecorderExtension(string aviFilePath, int defaultFrameRate = 10, bool isLoopingWav = false, VideoCodec videoCodec = VideoCodec.MSMPEG4v2) :
			base(aviFilePath, defaultFrameRate, isLoopingWav, videoCodec)
		{

		}

		//鼠标颜色
		Pen mousePen = new Pen(new SolidBrush(Color.Black));
		protected override void VideoStreamer_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			//绘制鼠标
			Bitmap bitmap = eventArgs.Frame;//得到鼠标后的图
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawEllipse(mousePen, new Rectangle(Control.MousePosition.X, Control.MousePosition.Y, 10, 10));
			}
			base.VideoStreamer_NewFrame(sender, new NewFrameEventArgs(bitmap));
		}
	}
}
