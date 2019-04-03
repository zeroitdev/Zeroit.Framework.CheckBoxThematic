// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="iCheck.cs" company="Zeroit Dev Technologies">
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

        

        private void iCheckBox()
        {
            //Size = new Size(150, 17);
            Height = 17;
        }


        private void iCheckPaintHook()
        {
            G.Clear(Parent.BackColor);

            Rectangle xRect = new Rectangle(0, 0, 20, 16);
            Rectangle cRect = new Rectangle(21, 0, 20, 16);

            ColorBlend bg_cblend = new ColorBlend(3);
            bg_cblend.Colors[0] = Color.FromArgb(35, 35, 35);
            bg_cblend.Colors[1] = Color.FromArgb(52, 52, 52);
            bg_cblend.Colors[2] = bg_cblend.Colors[0];
            bg_cblend.Positions = new float[]{
            0,
            0.5f,
            1
        };
            LinearGradientBrush pBrush = new LinearGradientBrush(xRect, Color.Black, Color.Red, 90f);
            pBrush.InterpolationColors = bg_cblend;
            G.FillRectangles(pBrush, new RectangleF[]{
            cRect,
            xRect
        });

            //On And Off Switches
            if (Checked)
            {
                //b
                G.DrawString("b", new Font("Marlett", 16), Brushes.ForestGreen, new Point(18, -1));
                G.DrawString("r", new Font("Marlett", 11), new SolidBrush(Color.FromArgb(70, 70, 70)), new Point(1, 1));
            }
            else
            {
                G.DrawString("b", new Font("Marlett", 16), new SolidBrush(Color.FromArgb(70, 70, 70)), new Point(18, -1));
                G.DrawString("r", new Font("Marlett", 11), new SolidBrush(Color.FromArgb(180, 50, 50)), new Point(1, 1));
            }
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, 40, 16));
            G.DrawLine(Pens.Black, new Point(20, 0), new Point(20, 17));

            //Text
            G.DrawString(Text, new Font("Arial", 8), new SolidBrush(ForeColor), 44, 2);

        }


    }

}

