// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ButterScotch.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        private void ButterscotchCheckBox()
        {
            Height = 25;
        }

        
        private void ButterOnPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle selectionrect = new Rectangle(3, 3, 18, 18);
            Rectangle innerselectionrect = new Rectangle(4, 4, 17, 17);
            Rectangle selectrect = new Rectangle(6, 6, 16, 16);


            G.SmoothingMode = Smoothing;
            G.InterpolationMode = InterpolationMode;
            G.TextRenderingHint = TextRendering;
            G.Clear(BackColor);
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(20, 4, Width, 16), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });

            if (Checked)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), selectionrect);
                G.FillRectangle(new SolidBrush(Color.FromArgb(40, 37, 33)), innerselectionrect);
                G.DrawString("b", new Font("Marlett", 15, FontStyle.Bold), new SolidBrush(Color.FromArgb(246, 180, 12)), selectrect, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }
            else
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), selectionrect);
                G.FillRectangle(new SolidBrush(Color.FromArgb(40, 37, 33)), innerselectionrect);
                G.DrawString("b", new Font("Marlett", 15, FontStyle.Bold), new SolidBrush(Color.FromArgb(20, 18, 17)), selectrect, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }

            e.Graphics.DrawImage(B, new Point(0, 0));
            
            
        }

    }


}

