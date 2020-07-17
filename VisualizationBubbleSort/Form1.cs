using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizationBubbleSort
{
    public partial class Form1 : Form
    {
        private int[] Array;
        Graphics Graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Graphics = panel1.CreateGraphics();
            int NumEntries = panel1.Width;
            int MaxVal = panel1.Height;
            Array = new int[NumEntries];
            Graphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, NumEntries, MaxVal);
            Random rnd = new Random();
            // populate array
            for (int i = 0; i < NumEntries; i++)
            {
                Array[i] = rnd.Next(0, MaxVal);
            }

            // draw barrs into panel
            for (int i = 0; i < NumEntries; i++)
            {
                Graphics.FillRectangle(new SolidBrush(Color.White), i, MaxVal - Array[i], 1, MaxVal);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortEngine se = new BubbleSort();
            se.DoWork(Array, Graphics, panel1.Height);
        }
    }
}
