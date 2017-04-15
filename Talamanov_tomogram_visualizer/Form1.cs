using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talamanov_tomogram_visualizer
{
    public partial class Form1 : Form
    {
       
        bool needReload = false;
        Bin bin = new Bin();
        View view = new View();
        bool loaded = false;
        int currentLayer = 0;
        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                Text = String.Format("CT Visualizer (fps = {0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        public Form1()
        {
           
            InitializeComponent();
            
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBin(str);
                trackBar1.SetRange(0, Bin.Z - 1);
                
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
                
            }
        }
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (rdBtnQuads.Checked)
                {
                    view.DrawQuads(currentLayer);
                }
                else if (rdBtnTexture.Checked)
                {
                    if (needReload)
                    {
                        view.generateTextureImage(currentLayer);
                        view.Load2DTexture();
                        needReload = false;
                    }
                    view.DrawTexture();
                    
                }
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
        }

        void Application_Idle(object sender , EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void tbMin_Scroll(object sender, EventArgs e)
        {
            if (tbMax.Value > tbMin.Value)
            {
                view.SetMinMaxTransferFunction(tbMin.Value, tbMax.Value);
                needReload = true;
            }
            else
                tbMin.Value++;
        }

        private void tbMax_Scroll(object sender, EventArgs e)
        {
            if (tbMax.Value > tbMin.Value)
            {
                view.SetMinMaxTransferFunction(tbMin.Value, tbMax.Value);
                needReload = true;
            }
            else
                tbMax.Value--;

        }
    }
}
