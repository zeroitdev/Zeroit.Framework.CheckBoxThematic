// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Meph.cs" company="Zeroit Dev Technologies">
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


        #region " Control Help - MouseState & Flicker Control"
        Color _accentColor = Color.Maroon;

        private void MephOnResize(System.EventArgs e)
        {
            Height = 24;
        }

        #endregion


        private void MephCheckBox()
        {
            //Size = new Size(250, 24);
            Height = 24;
        }

        private void MephOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle radioBtnRectangle = new Rectangle(0, 0, Height - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(5, 5, Height - 11, Height - 11);

            G.SmoothingMode = SmoothingMode.HighQuality;
            G.CompositingQuality = CompositingQuality.HighQuality;
            G.TextRenderingHint = TextRendering;

            G.Clear(BackColor);

            LinearGradientBrush bgGrad = new LinearGradientBrush(radioBtnRectangle, Color.FromArgb(50, 50, 50), Color.FromArgb(40, 40, 40), 90);
            G.FillRectangle(bgGrad, radioBtnRectangle);
            G.DrawRectangle(new Pen(Color.FromArgb(20, 20, 20)), radioBtnRectangle);
            G.DrawRectangle(new Pen(Color.FromArgb(55, 55, 55)), new Rectangle(1, 1, Height - 3, Height - 3));

            if (Checked)
            {
                LinearGradientBrush fillGradient = new LinearGradientBrush(InnerRect, _accentColor, Color.FromArgb(_accentColor.R + 5, _accentColor.G + 5, _accentColor.B + 5), 90);
                G.FillRectangle(fillGradient, InnerRect);
                G.DrawRectangle(new Pen(Color.FromArgb(25, 25, 25)), InnerRect);
            }

            Brush nb = new SolidBrush(ForeColor);
            G.DrawString(Text, Font, nb, new Point(28, 12), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            

        }


    }

}

