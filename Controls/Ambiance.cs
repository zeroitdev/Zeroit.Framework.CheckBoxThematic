// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Ambiance.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Checkbox control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
