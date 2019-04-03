// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="NYX.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        int newX;

        int newY;
        private void NYX_CheckBox()
        {
            Size = new Size(120, 20);
            //LockHeight = 20;
        }

        private void NYX_OnResize(EventArgs e)
        {
            Height = 20;
        }

        private void NYXOnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            newX = e.Location.X;
            newY = e.Location.Y;
            
        }

        

        //Coded by HΛWK
        private void NYXPaintHook()
        {
            G.Clear(Parent.BackColor);
            Point[] cbPoints = {
            new Point(3, 5),
            new Point(5, 3),
            new Point(14, 3),
            new Point(16, 5),
            new Point(16, 14),
            new Point(14, 16),
            new Point(5, 16),
            new Point(3, 14)
        };
            Point[] innerpoints = {
            new Point(4, 6),
            new Point(6, 4),
            new Point(13, 4),
            new Point(15, 6),
            new Point(15, 13),
            new Point(13, 15),
            new Point(6, 15),
            new Point(4, 13)
        };
            G.DrawPolygon(Pens.Black, cbPoints);
            ColorBlend checked_cblend = new ColorBlend(3);
            checked_cblend.Colors[0] = Color.FromArgb(90, 0, 0);
            checked_cblend.Colors[1] = Color.FromArgb(120, 0, 0);
            checked_cblend.Colors[2] = Color.FromArgb(180, 0, 0);
            checked_cblend.Positions = new float[]{
            0,
            0.7f,
            1
        };
            ColorBlend bg_cblend = new ColorBlend(3);
            bg_cblend.Colors[0] = Color.FromArgb(14, 14, 14);
            bg_cblend.Colors[1] = Color.FromArgb(12, 12, 12);
            bg_cblend.Colors[2] = Color.FromArgb(16, 16, 16);
            bg_cblend.Positions = new float[]{
            0,
            0.5f,
            1
        };
            //Checked
            if (Checked == true)
            {
                DrawGradient(checked_cblend, new Rectangle(4, 4, 12, 12), -45f);
                G.DrawPolygon(new Pen(new SolidBrush(Color.FromArgb(150, 0, 0))), innerpoints);
                G.DrawPolygon(Pens.Black, cbPoints);
            }
            else
            {
                DrawGradient(bg_cblend, new Rectangle(4, 4, 12, 12), -45f);
                G.DrawPolygon(Pens.Black, cbPoints);
            }
            //Highlight On MouseOver
            if (State == MouseState.Over && newX <= 16 && newY >= 4 && newY <= 16)
            {
                G.DrawPolygon(new Pen(new SolidBrush(Color.FromArgb(210, 210, 210))), cbPoints);
            }
            else if (State == MouseState.Down)
            {
                G.DrawPolygon(new Pen(new SolidBrush(Color.FromArgb(210, 210, 210))), cbPoints);
            }
            //Text
            DrawText(Brushes.Black, HorizontalAlignment.Left, 20, 1);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 19, 0);
        }

        

        private void NYXOnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (newX <= 16 && newY >= 4 && newY <= 16)
            {
                Checked = !Checked;
                if (checkedChanged != null)
                {
                    checkedChanged(this, EventArgs.Empty);
                }
            }
        }


    }

}

