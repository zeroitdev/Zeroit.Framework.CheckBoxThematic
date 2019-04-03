// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Orains.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        Color orainsBorderBox = Color.Black;
        Color orainsInnerBox = Color.FromArgb(40, 40, 40);
        

        private void OrainsCheckBox()
        {
            //this.Size = new Size(50, 17);
            Height = 17;
        }

        private void OrainsOnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            
            X = e.X;
            
        }

        

        private void OrainsPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;
            int Curve = 4;

            if (Checked)
            {
                G.FillRectangle(new SolidBrush(Color.Orange), new Rectangle(3, 3, 10, 10));
                G.DrawString("a", new Font("Marlett", 12), Brushes.Black, new Point(-2, 0));

                G.DrawRectangle(new Pen(orainsInnerBox), new Rectangle(1, 1, 14, 14));
                G.DrawRectangle(new Pen(orainsBorderBox), new Rectangle(0, 0, 16, 16));
                
            }
            else
            {

                G.DrawRectangle(new Pen(orainsInnerBox), new Rectangle(1, 1, 14, 14));
                G.DrawRectangle(new Pen(orainsBorderBox), new Rectangle(0, 0, 16, 16));
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Orange)), 3, 3, 10, 10);
            }

            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(22, 2));

        }

        

    }

}

