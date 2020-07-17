using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace VisualizationBubbleSort
{
    class BubbleSort : SortEngine
    {
        private bool _sorted = false;
        private int[] array;
        private Graphics graphics;
        private int maxVal;
        Brush WhiteBrush = new SolidBrush(Color.White);
        Brush BlackBrush = new SolidBrush(Color.Black);

        public void DoWork(int[] arr, Graphics graphics, int maxVal)
        {
            this.array = arr;
            this.graphics = graphics;
            this.maxVal = maxVal;

            while (!_sorted)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1]) 
                    {
                        Swap(i, i + 1);
                    }
                }
                _sorted = IsSorted();
            }

        }

        private void Swap(int i, int v)
        {
            int temp = array[i];
            array[i] = array[v];
            array[v] = temp;

            graphics.FillRectangle(BlackBrush, i, 0, 1, maxVal);
            graphics.FillRectangle(BlackBrush, v, 0, 1, maxVal);

            graphics.FillRectangle(WhiteBrush, i, maxVal - array[i], 1, maxVal);
            graphics.FillRectangle(WhiteBrush, v, maxVal - array[v], 1, maxVal);

        }

        private bool IsSorted()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) return false;
            }
            return true;
        }
    }
}
