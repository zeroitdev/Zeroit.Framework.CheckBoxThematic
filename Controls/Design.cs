﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Design.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {


        private void DesignCheckBox()
        {
            LockHeight = 16;
        }

        
        private Color designC1 = Color.FromArgb(35,Color.White);
        private Color designC2 = Color.FromArgb(5, 255,255,255);
        private Color designC3 = Color.Transparent;
        private Color designC4 = Color.FromArgb(40, 255,255,255);
        private Color designC5 = Color.FromArgb(8, 8, 8);
        private Color designC6 = Color.FromArgb(16, 16, 16);
        private Color designP1 = Color.FromArgb(26, 26, 26);
        private Color designP2 = Color.FromArgb(0,0,0);
        private Color designP3 = Color.FromArgb(0, 0, 0);
        private Color designB1 = Color.FromArgb(5, Color.White);

        private Color designB2 = Color.FromArgb(255,255,255);
        

        private void DesignPaintHook()
        {
            G.Clear(Parent.BackColor);
            //BackColor = Color.FromArgb(25, 25, 25);

            DrawBorders(new Pen(designP1), 0, 0, _Field, _Field, 1);
            DrawGradient(designC1, designC2, 0, 0, _Field, _Field / 2);

            if (Checked)
            {
                DrawGradient(designC3, designC4, 2, 2, _Field - 4, _Field - 4);
            }
            else
            {
                DrawGradient(designC5, designC6, 2, 2, _Field - 4, _Field - 4, 90);
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(designB1), 0, 0, _Field, _Field);
            }

            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, _Field + 3, 0);

            DrawBorders(new Pen(designP2), 0, 0, _Field, _Field, 2);
            DrawBorders(new Pen(designP3), 0, 0, _Field, _Field);

            DrawCorners(BackColor, 0, 0, _Field, _Field);
        }

        private int _Field = 16;
        public int Field
        {
            get { return _Field; }
            set
            {
                if (value < 4)
                    return;
                _Field = value;
                LockHeight = value;
                Invalidate();
            }
        }

    }

}

