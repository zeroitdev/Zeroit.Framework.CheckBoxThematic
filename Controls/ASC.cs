// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ASC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{
    public partial class CheckBoxThematic
    {

        private void ASCCheckBox()
        {
            //Size = new Size(50 + (Text.Length * 5), 17);
            Height = 17;
        }

        private void ASCOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G = e.Graphics;
            G.SmoothingMode = Smoothing;
            G.Clear(Parent.BackColor);

            Height = 17;

            Rectangle boxRect = new Rectangle(1, 1, Height - 3, Height - 3);
            G.DrawEllipse(new Pen(Color.FromArgb(30, 140, 240), 2), boxRect);

            int textY = ((Height - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2));
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point((Height - 1) + 4, textY));

            if (_checked)
                G.DrawString("a", new Font("Marlett", 17), new SolidBrush(Color.FromArgb(120, 180, 255)), new Point(-3, -5));


        }

        

    }
}
