// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ASC.cs" company="Zeroit Dev Technologies">
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
