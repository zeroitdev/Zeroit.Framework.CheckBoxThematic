// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {

        
        private int X;

        private void CarbonFiberCheckbox()
        {
            //this.Size = new Size(50, 16);
            Height = 16;
        }

        private void CarbonOnTextChanged(System.EventArgs e)
        {
            //int textSize = 0;
            //textSize = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            //this.Width = 20 + textSize;
        }

        private void CarbonOnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            X = e.X;
            
        }

        

        #region "Color of Control"
        private void CarbonPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;
            G.DrawRectangle(new Pen(Color.FromArgb(29, 29, 29)), 1, 1, 14, 13);

            if (State == MouseState.Over)
            {
                G.DrawString("a", new Font("Marlett", 12), new SolidBrush(Color.FromArgb(13, Color.White)), new Point(-2, 0));
            }

            if (Checked)
            {
                HatchBrush HeaderHatch = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(50, Color.Black), Color.Transparent);
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), 2, 2, 12, 6);
                //Gloss
                G.FillRectangle(HeaderHatch, new Rectangle(2, 2, 12, 12));
                G.DrawString("a", new Font("Marlett", 12), new SolidBrush(Color.FromArgb(255, 150, 0)), new Point(-2, 0));
            }
            else
            {
                // Do Nothing ^^
            }

            G.DrawRectangle(new Pen(Color.FromArgb(6, 6, 6)), 0, 0, 16, 15);
            G.DrawRectangle(new Pen(Color.FromArgb(6, 6, 6)), 2, 2, 12, 11);
            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(0, 0, 0)), 17, 0);
            G.DrawString(Text, Font, new SolidBrush(ForeColor), 18, 1);
        }

        
        #endregion

    }

}

