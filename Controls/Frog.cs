// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Frog.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        private void FrogCheckbox()
        {
            this.Height = 18;
        }
        
        private void FrogOnPaintHook(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = Smoothing;

            
            G.Clear(Parent.BackColor);
            Color border = Color.FromArgb(255, 200, 200, 200);
            Color Border = Color.FromArgb(160, border);
            LinearGradientBrush LGBNone = new LinearGradientBrush(new Point(0, 0), new Point(0, Height - 1), Color.FromArgb(255, 65, 65, 65), Color.FromArgb(255, 50, 50, 50));
            LinearGradientBrush LGBOver = new LinearGradientBrush(new Point(0, 0), new Point(0, Height - 1), Color.FromArgb(255, 65, 65, 65), Color.FromArgb(255, 40, 40, 40));
            LinearGradientBrush LGBDown = new LinearGradientBrush(new Point(0, 0), new Point(0, Height - 1), Color.FromArgb(255, 65, 65, 65), Color.FromArgb(255, 30, 30, 30));
            Point[] Polygon = null;
            Point[] Polygon2 = null;
            Polygon = new Point[] {
            new Point(0, 0),
            new Point(18 - 1, 0),
            new Point(18 - 1, 18 - 7),
            new Point(18 - 2, 18 - 6),
            new Point(18 - 3, 18 - 5),
            new Point(18 - 4, 18 - 4),
            new Point(18 - 5, 18 - 3),
            new Point(18 - 6, 18 - 2),
            new Point(18 - 7, 18 - 1),
            new Point(0, 18 - 1)
        };
            Polygon2 = new Point[] {
            new Point(1, 1),
            new Point(18 - 2, 1),
            new Point(18 - 2, 18 - 7),
            new Point(18 - 7, 18 - 2),
            new Point(1, 18 - 2)
        };
            switch (State)
            {
                case MouseState.Down:
                    G.FillPolygon(LGBDown, Polygon);
                    break;
                case MouseState.None:
                    G.FillPolygon(LGBNone, Polygon);
                    break;
                case MouseState.Over:
                    G.FillPolygon(LGBOver, Polygon);
                    break;
            }
            G.DrawPolygon(Pens.Black, Polygon);
            G.DrawPolygon(new Pen(Border), Polygon2);
            if ((Checked == true))
            {
                G.DrawString("a", new Font("Webdings", 13), new SolidBrush(border), new Point(-2, -2));
            }
            G.DrawString(Text, Font, new SolidBrush(ForeColor), 20, 2);

            e.Graphics.DrawImage((Bitmap) B.Clone(), 0, 0);
        }

    }

}

