// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Ambiance.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{
    /// <summary>
    /// Class CheckBoxThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.CheckBoxThematic.ThemeManagers.ThemeControl" />
    public partial class CheckBoxThematic
    {


        #region Variables


        #endregion
        #region Properties



        #endregion

        /// <summary>
        /// Ambiances the CheckBox.
        /// </summary>
        private void Ambiance_CheckBox()
        {
            
            //Size = new Size(171, 26);
            Height = 26;
        }


        /// <summary>
        /// Ambiances the on resize.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AmbianceOnResize(System.EventArgs e)
        {
            if (Width > 0 && Height > 0)
            {
                
                Height = 15;
            }

            Invalidate();
            
        }

        /// <summary>
        /// Shapers this instance.
        /// </summary>
        /// <returns>GraphicsPath.</returns>
        private GraphicsPath Shaper()
        {
            GraphicsPath Shape = new GraphicsPath();

            var MyDrawer = Shape;
            MyDrawer.AddArc(0, 0, 7, 7, 180, 90);
            MyDrawer.AddArc(7, 0, 7, 7, -90, 90);
            MyDrawer.AddArc(7, 7, 7, 7, 0, 90);
            MyDrawer.AddArc(0, 7, 7, 7, 90, 90);
            MyDrawer.CloseAllFigures();
            return Shape;
        }

        /// <summary>
        /// Ambiances the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void AmbianceOnPaint(PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;

            GraphicsPath Shape = Shaper();
            
            Rectangle R1 = new Rectangle(17, 0, Width, Height + 1);
            Rectangle R2 = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush GB = new LinearGradientBrush(new Rectangle(0, 0, 25, 25), Color.FromArgb(213, 85, 32), Color.FromArgb(224, 123, 82), 90);

            

            G.FillPath(GB, Shape);
            // Fill the body of the CheckBox
            G.DrawPath(new Pen(Color.FromArgb(182, 88, 55)), Shape);
            // Draw the border

            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(17, 0, Width, Height - 1), new StringFormat { LineAlignment = StringAlignment.Center });

            if (Checked)
            {
                G.DrawString("ü", new Font("Wingdings", 12), new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(-2, 1, Width, Height + 2), new StringFormat { LineAlignment = StringAlignment.Center });
            }
            
        }

    }
}
