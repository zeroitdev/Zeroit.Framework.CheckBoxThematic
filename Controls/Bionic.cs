﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Bionic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        private void BionicCheckBox()
        {
            Height = 16;
        }


        #region " Properties "


        private void BionicOnResize(EventArgs e)
        {
            Height = 16;
        }

        #endregion

        private void BionicOnPaint(PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.Clear(Parent.BackColor);

            G.FillRectangle(new SolidBrush(Color.FromArgb(29, 29, 29)), new Rectangle(0, 0, 15, 15));
            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(5, Color.White)), new Rectangle(0, 0, 15, 15));
                    break;
            }
            if (Checked)
            {
                G.FillRectangle(new LinearGradientBrush(new Point(4, 4), new Point(4, 11), Color.FromArgb(252, 132, 19), Color.FromArgb(212, 75, 31)), new Rectangle(4, 4, 7, 7));
            }
            G.DrawString(Text, new Font("Arial", 9), new SolidBrush(ForeColor), new Point(18, 0));
        }


    }
}
