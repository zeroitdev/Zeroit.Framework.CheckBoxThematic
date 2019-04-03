// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Simpla.cs" company="Zeroit Dev Technologies">
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
        
        private void SimplaOnResize(System.EventArgs e)
        {
            Height = 16;
        }
        
        #endregion

        public enum ColorSchemes
        {
            Green,
            Blue,
            White,
            Red
        }
        private ColorSchemes _ColorScheme = ColorSchemes.Blue;
        public ColorSchemes ColorScheme
        {
            get { return _ColorScheme; }
            set
            {
                _ColorScheme = value;
                Invalidate();
            }
        }

        private void SimplaCheckBox()
        {
            Size = new Size(145, 16);
            
        }

        private void SimplaOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle checkBoxRectangle = new Rectangle(0, 0, Height - 1, Height - 1);

            G.SmoothingMode = Smoothing;
            G.CompositingQuality = CompositingQuality.HighQuality;
            G.TextRenderingHint = TextRendering;

            G.Clear(Parent.BackColor);

            LinearGradientBrush bodyGrad = new LinearGradientBrush(checkBoxRectangle, Color.FromArgb(40, 40, 40), Color.FromArgb(30, 30, 30), 90);
            G.FillRectangle(bodyGrad, bodyGrad.Rectangle);
            G.DrawRectangle(new Pen(Color.FromArgb(56, 56, 56)), checkBoxRectangle);

            if (Checked)
            {
                Font t = new Font("Marlett", 20, FontStyle.Regular);
                switch (ColorScheme)
                {
                    case ColorSchemes.Green:
                        G.DrawString("a", t, new SolidBrush(Color.FromArgb(159, 207, 1)), -9, -7);
                        break;
                    case ColorSchemes.Blue:
                        G.DrawString("a", t, new SolidBrush(Color.FromArgb(0, 161, 207)), -9, -7);
                        break;
                    case ColorSchemes.White:
                        G.DrawString("a", t, new SolidBrush(Color.FromArgb(254, 254, 254)), -9, -7);
                        break;
                    case ColorSchemes.Red:
                        G.DrawString("a", t, new SolidBrush(Color.FromArgb(209, 1, 1)), -9, -7);
                        break;
                }
            }

            Brush nb = new SolidBrush(ForeColor);
            G.DrawString(Text, Font, nb, new Point(19, 9), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            

        }


    }

}

