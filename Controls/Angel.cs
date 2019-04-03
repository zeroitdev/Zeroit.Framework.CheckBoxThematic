// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Angel.cs" company="Zeroit Dev Technologies">
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


        #region " Back End "

        #region " Declarations "
        
        
        #endregion
        
        
        // Get more free themes at ThemesVB.NET
        #region " Properties "

        

        #endregion

        #region " Misc "

        /// <summary>
        /// Initializes a new instance of the <see cref="AngelCheckBox"/> class.
        /// </summary>
        private void AngelCheckBox()
        {
            Height = 18;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void AngelOnResize(EventArgs e)
        {
            Height = 18;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void AngelOnTextChanged(EventArgs e)
        {
            Width = TextRenderer.MeasureText(Text, Font).Width + 16;
            
        }

        #endregion

        #endregion
        // Get more free themes at ThemesVB.NET
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        private void AngelOnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Parent.BackColor);
            G.FillRectangle(new LinearGradientBrush(new Point(1, 1), new Point(1, 16), Color.FromArgb(52, 78, 108), Color.FromArgb(22, 45, 67)), new Rectangle(1, 1, 15, 15));
            G.DrawRectangle(new Pen(Color.FromArgb(70, 103, 143)), new Rectangle(1, 1, 15, 15));
            if (Checked)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.White)), new Rectangle(4, 4, 10, 10));
            }
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(22, 0));
            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), new Rectangle(2, 2, 13, 13));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), new Rectangle(2, 2, 13, 13));
                    break;
            }
        }

    }
}
