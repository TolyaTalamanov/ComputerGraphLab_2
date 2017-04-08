using OpenTK.Graphics.ES10;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Talamanov_tomogram_visualizer
{

    class View
    {
        public int Clamp(int value, int min, int max)

        {

            if (value < min)

                return min;

            if (value > max)

                return max;

            return value;

        }
        public void setupView(int width,int height)
        {
            
            GL.MatrixMode(All.Projection);
            GL.LoadIdentity();
            GL.Ortho(0,Bin.X,0,Bin.Y,-1,1);
            GL.Viewport(0, 0, width, height);
        }
        Color TransferFunction(short value)
        {
            int min = 0;
            int max = 2000;
            int newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
            return Color.FromArgb(255, newVal, newVal, newVal);
        }
        public void DrawQuads(int layerNumber)
        {
            GL.Clear(Convert.ToInt32(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));
                       

        }
    }

}
