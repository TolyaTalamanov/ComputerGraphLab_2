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
        public Form1()
        {
            Bin bin = new Bin();
            bin.readBIN("C:\\Users\\ПК\\Documents\\GitHub\\ComputerGraphOpenTK\\testdate.bin");
            InitializeComponent();

        }
    }
}
