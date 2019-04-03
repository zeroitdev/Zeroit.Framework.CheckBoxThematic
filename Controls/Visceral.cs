// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Visceral.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        //HELP FROM RECUPERARE

        #region " Control Help - MouseState & Flicker Control"
        
        private void VisceralOnResize(System.EventArgs e)
        {
            Height = 14;
        }
        
        #endregion

        public void VisceralCheckBox()
        {
            Size = new Size(145, 16);
            
        }

        private void VisceralOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;

            Rectangle checkBoxRectangle = new Rectangle(0, 0, Height - 1, Height - 1);

            G.Clear(Parent.BackColor);

            LinearGradientBrush bodyGrad = new LinearGradientBrush(checkBoxRectangle, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35), 120);
            G.FillRectangle(bodyGrad, bodyGrad.Rectangle);
            G.DrawRectangle(new Pen(Color.FromArgb(42, 47, 49)), new Rectangle(1, 1, Height - 3, Height - 3));
            G.DrawRectangle(new Pen(Color.FromArgb(87, 87, 89)), checkBoxRectangle);

            if (Checked)
            {
                Rectangle chkPoly = new Rectangle(checkBoxRectangle.X + checkBoxRectangle.Width / 4, checkBoxRectangle.Y + checkBoxRectangle.Height / 4, checkBoxRectangle.Width / 2, checkBoxRectangle.Height / 2);
                Point[] Poly = {
                new Point(chkPoly.X, chkPoly.Y + chkPoly.Height / 2),
                new Point(chkPoly.X + chkPoly.Width / 2, chkPoly.Y + chkPoly.Height),
                new Point(chkPoly.X + chkPoly.Width, chkPoly.Y)
            };
                G.SmoothingMode = SmoothingMode.HighQuality;
                Pen P1 = new Pen(Color.FromArgb(250, 255, 255, 255), 2);
                LinearGradientBrush chkGrad = new LinearGradientBrush(chkPoly, Color.FromArgb(200, 200, 200), Color.FromArgb(255, 255, 255), 0f);
                for (int i = 0; i <= Poly.Length - 2; i++)
                {
                    G.DrawLine(P1, Poly[i], Poly[i + 1]);
                }
            }
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(18, -1), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            

        }


    }

}

