// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Excision.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {


        #region " Control Help - MouseState & Flicker Control"
        
        private void ExcisionOnResize(System.EventArgs e)
        {
            Height = 16;
        }
        
        #endregion


        private void ExcisionCheckBox()
        {
            //Size = new Size(145, 16);
            Height = 16;
        }

        private void ExcisionOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle checkBoxRectangle = new Rectangle(0, 0, Height, Height - 1);
            Rectangle Inner = new Rectangle(1, 1, Height - 2, Height - 3);

            G.SmoothingMode = Smoothing;
            G.CompositingQuality = CompositingQuality.HighQuality;
            G.TextRenderingHint = TextRendering;

            G.Clear(Parent.BackColor);

            LinearGradientBrush bodyGrad = new LinearGradientBrush(checkBoxRectangle, Color.FromArgb(60, 60, 60), Color.FromArgb(45, 45, 45), 90);
            G.FillRectangle(bodyGrad, bodyGrad.Rectangle);
            G.DrawRectangle(new Pen(Color.FromArgb(26, 26, 26)), checkBoxRectangle);
            G.DrawRectangle(new Pen(Color.FromArgb(70, 70, 70)), Inner);

            if (Checked)
            {
                Font t = new Font("Marlett", 10, FontStyle.Regular);
                G.DrawString("a", t, new SolidBrush(Color.FromArgb(222, 222, 222)), -1.5f, 0);
            }

            Font drawFont = new Font("Tahoma", 8, FontStyle.Bold);
            Brush nb = new SolidBrush(ForeColor);
            G.DrawString(Text, drawFont, nb, new Point(18, 7), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            

        }


    }

}

