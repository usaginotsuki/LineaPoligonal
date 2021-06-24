using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LineaPoligonal
{
    class Linea
    {

        private int iPosX,iPosY, mPosX, mPosY, endX, endY;
        private Point iPos, ePos;
        private Graphics mGrap;
        private Pen mPen, mPenFill;
        private int init=0;
        private List<PointF> points = new List<PointF>();

        public void DrawPoligon(PictureBox picCanvas, TextBox posX, TextBox posY)
        {
            if (init == 0)
            {
                iPos.X = int.Parse(posX.Text);
                iPos.Y = int.Parse(posY.Text);
            }


            mPen = new Pen(Color.Black);
            mPenFill = new Pen(Color.Black);
            mPosX = int.Parse(posX.Text);
            mPosY = int.Parse(posY.Text);
            PointF puntoi = new PointF(mPosX, mPosY);
            points.Add(new PointF(mPosX, mPosY));

            mGrap = picCanvas.CreateGraphics();

            if (points.Count != 1)
            {
                mGrap.DrawLines(mPen, points.ToArray());

            }
            init++;
        }

        public void EndPolygon(PictureBox picCanvas, TextBox posX, TextBox posY)
        {
            mPen = new Pen(Color.Black);

            ePos.X = int.Parse(posX.Text);
            ePos.Y = int.Parse(posY.Text);

            mGrap.DrawLine(mPen, iPos, ePos);

            init = 0;
        }

    }

    
}
