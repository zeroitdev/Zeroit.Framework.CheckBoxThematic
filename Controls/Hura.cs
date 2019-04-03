// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Hura.cs" company="Zeroit Dev Technologies">
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

        
        private Color huraP1 = Color.FromArgb(50, 50, 50);
        private Color huraP2 = Color.FromArgb(87, 87, 87);
        private Color huraP3 = Color.Black;
        private Color huraP4 = Color.White;
        
        private void HuraOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.AntiAlias;


            GraphicsPath GP1 = Draw.CreateRound(0, 2, Height - 5, Height - 5, 5);
            GraphicsPath GP2 = Draw.CreateRound(1, 3, Height - 7, Height - 7, 5);

            PathGradientBrush PB1 = new PathGradientBrush(GP1);
            PB1.CenterColor = Color.FromArgb(50, 50, 50);
            PB1.SurroundColors = new Color[] { Color.FromArgb(45, 45, 45) };
            PB1.FocusScales = new PointF(0.3f, 0.3f);

            G.FillPath(PB1, GP1);
            G.DrawPath(new Pen(huraP1), GP1);
            G.DrawPath(new Pen(huraP2), GP2);

            if (Checked)
            {
                G.DrawLine(new Pen(huraP3,2f), 5, Height - 9, 8, Height - 7);
                G.DrawLine(new Pen(huraP3, 2f), 7, Height - 7, Height - 8, 7);

                G.DrawLine(new Pen(huraP4, 2f), 4, Height - 10, 7, Height - 8);
                G.DrawLine(new Pen(huraP4, 2f), 6, Height - 8, Height - 9, 6);
            }

            SizeF SZ1 = G.MeasureString(Text, Font);
            PointF PT1 = new PointF(Height - 3, Height / 2 - SZ1.Height / 2);

            G.DrawString(Text, Font, Brushes.Black, PT1.X + 1, PT1.Y + 1);
            G.DrawString(Text, Font, new SolidBrush(ForeColor), PT1);
        }


    }

}

