// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Aryan.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{
    //Button
    /// <summary>
    /// Class CheckBoxThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.CheckBoxThematic.ThemeManagers.ThemeControl" />
    public partial class CheckBoxThematic
    {

        /// <summary>
        /// Aryans the CheckBox.
        /// </summary>
        private void AryanCheckBox()
        {
            //Size = new Size(100, 15);
            Height = 15;
            //MinimumSize = new Size(16, 16);
            //MaximumSize = new Size(600, 16);
        }

        /// <summary>
        /// The aryan c1
        /// </summary>
        Color aryanC1 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The aryan c2
        /// </summary>
        Color aryanC2 = Color.FromArgb(255, Color.Red);
        /// <summary>
        /// The aryan c3
        /// </summary>
        Color aryanC3 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The aryan c4
        /// </summary>
        Color aryanC4 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The aryan c5
        /// </summary>
        Color aryanC5 = Color.FromArgb(35, 35, 35);
        /// <summary>
        /// The aryan c6
        /// </summary>
        Color aryanC6 = Color.FromArgb(25,25,25);
        /// <summary>
        /// The aryan p1
        /// </summary>
        Color aryanP1 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The aryan p2
        /// </summary>
        Color aryanP2 = Color.FromArgb(59, 59, 59);
        /// <summary>
        /// The aryan b1
        /// </summary>
        Color aryanB1 = Color.FromArgb(255, Color.Red);

        /// <summary>
        /// Aryans the paint hook.
        /// </summary>
        private void AryanPaintHook()
        {
            G.Clear(Parent.BackColor);

            HatchBrush R = new HatchBrush(HatchStyle.Trellis, Parent.BackColor, Parent.BackColor);
            G.FillRectangle(R, ClientRectangle);

            switch (Checked)
            {
                case true:
                    DrawGradient(aryanC1, aryanC2, 3, 3, 9, 9, 90);
                    DrawGradient(aryanC3, aryanC4, 4, 4, 7, 7, 90);
                    break;
                case false:
                    DrawGradient(aryanC5, aryanC5, 0, 0, 15, 15, 90);
                    break;
            }
            G.DrawRectangle(new Pen(new SolidBrush(aryanP1)), 0, 0, 14, 14);
            G.DrawRectangle(new Pen(new SolidBrush(aryanP2)), 1, 1, 12, 12);
            DrawText(new SolidBrush(ForeColor), 17, 0);
            DrawCorners(aryanC6, new Rectangle(0, 0, 13, 13));
        }

    }
}
