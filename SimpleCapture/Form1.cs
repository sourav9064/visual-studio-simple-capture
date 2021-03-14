using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using VisioForge.Types.OutputFormat;

namespace SimpleCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            videoCapture1.Video_CaptureDevice = videoCapture1.Video_CaptureDevicesInfo[0].Name;
            videoCapture1.Audio_CaptureDevice = videoCapture1.Audio_CaptureDevicesInfo[0].Name;
            videoCapture1.Output_Filename = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\c_sharp\\output.mp4";
            videoCapture1.Output_Format = new VFAVIOutput(); // defult AVI output with MJPEG for video and PCM for audio
            videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoCapture;

            videoCapture1.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            videoCapture1.Stop();
        }
    }
}
