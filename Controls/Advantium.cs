// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Advantium.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{
    /// <summary>
    /// Class CheckBoxThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.CheckBoxThematic.ThemeManagers.ThemeControl" />
    public partial class CheckBoxThematic
    {

        /// <summary>
        /// Advantiums the check.
        /// </summary>
        private void AdvantiumCheck()
        {
            //Size = new Size(100, 15);
            Height = 15;
            //MinimumSize = new Size(16, 16);
            //MaximumSize = new Size(600, 16);

        }
        /// <summary>
        /// The advantium c1
        /// </summary>
        Color advantiumC1 = Color.FromArgb(132, 192, 240);
        /// <summary>
        /// The advantium c2
        /// </summary>
        Color advantiumC2 = Color.LawnGreen;
        /// <summary>
        /// The advantium c3
        /// </summary>
        Color advantiumC3 = Color.LawnGreen;
        /// <summary>
        /// The advantium c4
        /// </summary>
        Color advantiumC4 = Color.FromArgb(42, 242, 77);
        /// <summary>
        /// The advantium c5
        /// </summary>
        Color advantiumC5 = Color.FromArgb(35, 35, 35);
        /// <summary>
        /// The advantium c6
        /// </summary>
        Color advantiumC6 = Color.FromArgb(35, 35, 35);
        /// <summary>
        /// The advantium p1
        /// </summary>
        Color advantiumP1 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The advantium p2
        /// </summary>
        Color advantiumP2 = Color.FromArgb(59, 59, 59);
        /// <summary>
        /// The advantium b1
        /// </summary>
        Color advantiumB1 = Color.LawnGreen;

        /// <summary>
        /// Advantiums the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void AdvantiumPaintHook(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Parent.BackColor);
            switch (Checked)
            {
                case true:
                    DrawGradient(G,advantiumC1, advantiumC2, 3, 3, 9, 9, 90);
                    DrawGradient(G, advantiumC3, advantiumC4, 4, 4, 7, 7, 90);
                    break;
                case false:
                    DrawGradient(G, advantiumC5, advantiumC5, 0, 0, 15, 15, 90);
                    break;
            }
            G.DrawRectangle(new Pen(new SolidBrush(advantiumP1)), 0, 0, 14, 14);
            G.DrawRectangle(new Pen(new SolidBrush(advantiumP2)), 1, 1, 12, 12);
            DrawText(new SolidBrush(ForeColor), 17, 0);
            DrawCorners( advantiumC6, new Rectangle(0, 0, 13, 13));
        }

    }
}
