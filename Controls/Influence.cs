// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Influence.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {


        #region " Control Help - MouseState & Flicker Control"
        
        private void InfluenceOnResize(System.EventArgs e)
        {
            Height = 16;
        }
        
        #endregion

        private void InfluenceCheckBox()
        {
            //Size = new Size(145, 16);
            Height = 16;
        }

        private void InfluenceOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            G.SmoothingMode = Smoothing;

            Rectangle checkBoxRectangle = new Rectangle(0, 0, Height - 1, Height - 1);

            G.Clear(Parent.BackColor);

            switch (Checked)
            {
                case false:
                    LinearGradientBrush g1 = new LinearGradientBrush(checkBoxRectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90);
                    G.FillPath(g1, Draw.RoundRect(checkBoxRectangle, 2));
                    G.DrawPath(new Pen(Color.FromArgb(80, 97, 94, 90)), Draw.RoundRect(new Rectangle(1, 1, Height - 3, Height - 3), 2));
                    G.DrawPath(Pens.Black, Draw.RoundRect(checkBoxRectangle, 2));
                    break;
                case true:
                    LinearGradientBrush g11 = new LinearGradientBrush(checkBoxRectangle, Color.FromArgb(10, 10, 10), Color.FromArgb(16, 16, 16), 90);
                    G.FillPath(g11, Draw.RoundRect(checkBoxRectangle, 2));
                    HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
                    G.FillPath(h1, Draw.RoundRect(new Rectangle(0, 0, Height - 1, Height - 2), 2));
                    LinearGradientBrush s1 = new LinearGradientBrush(new Rectangle(0, 0, Height - 1, Height / 2), Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90);
                    G.FillPath(s1, Draw.RoundRect(new Rectangle(0, 0, Height - 1, Height / 2 - 1), 2));
                    G.DrawPath(new Pen(Color.FromArgb(80, 97, 94, 90)), Draw.RoundRect(new Rectangle(1, 1, Height - 3, Height - 3), 2));
                    G.DrawPath(Pens.Black, Draw.RoundRect(checkBoxRectangle, 2));

                    Rectangle chkPoly = new Rectangle(checkBoxRectangle.X + checkBoxRectangle.Width / 4, checkBoxRectangle.Y + checkBoxRectangle.Height / 4, checkBoxRectangle.Width / 2, checkBoxRectangle.Height / 2);
                    Point[] Poly = {
                    new Point(chkPoly.X, chkPoly.Y + chkPoly.Height / 2),
                    new Point(chkPoly.X + chkPoly.Width / 2, chkPoly.Y + chkPoly.Height),
                    new Point(chkPoly.X + chkPoly.Width, chkPoly.Y)
                };
                    if (Checked)
                    {
                        G.SmoothingMode = Smoothing;
                        Pen P1 = new Pen(Color.FromArgb(250, 255, 255, 255), 2);
                        for (int i = 0; i <= Poly.Length - 2; i++)
                        {
                            G.DrawLine(P1, Poly[i], Poly[i + 1]);
                        }
                    }

                    break;
            }

            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(16, 1), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            
        }


    }

}

