// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BCEvo.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Text;
using System.Windows.Forms;
using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{
    public partial class CheckBoxThematic
    {

        

        private void BCEvoCheckBox()
        {
            Transparent = true;
            //BackColor = Color.Transparent;
            //Size = new Size(125, 19);
            Height = 19;
            //MinimumSize = new Size(16, 19);
            //MaximumSize = new Size(600, 19);

        }

        


        
        private Rectangle _OBRect;
        private Rectangle _OBGRect;
        private Rectangle _IBRect;
        private SolidBrush _FCBrush;
        private Pen _OBPen;
        private LinearGradientBrush _IBBrush;
        private LinearGradientBrush _LBCBrush;
        private LinearGradientBrush _LBG;
        private LinearGradientBrush _BHighlightBrush;
        private Color _LBColor;
        private Color _LBColor2;
        private Color _IBColor;
        private Color _IBColor2;
        private Color _IBCColor;
        private Color _IBCColor2;
        private Color _BHColor;
        private Color _BHColor2;


        private void BCEvoPaintHook()
        {
            G.Clear(Parent.BackColor);
            // Declare variable values
            _OBRect = new Rectangle(0, 1, 15, 15);
            _OBGRect = new Rectangle(0, 1, 15, 7);
            _IBRect = new Rectangle(2, 3, 11, 11);
            _LBColor = Color.FromArgb(50, 255, 255, 255);
            _LBColor2 = Color.FromArgb(100, 255, 255, 255);
            _OBPen = new Pen(Color.FromArgb(255, 120, 120, 120));
            _IBColor = Color.FromArgb(255, 20, 20, 20);
            _IBColor2 = Color.FromArgb(255, 60, 60, 60);
            _IBCColor = Color.FromArgb(255, 100, 0, 0);
            _IBCColor2 = Color.FromArgb(255, 60, 0, 0);
            _BHColor = Color.FromArgb(30, 196, 196, 196);
            _BHColor2 = Color.FromArgb(13, 226, 226, 226);
            _LBG = new LinearGradientBrush(_OBRect, _LBColor, _LBColor2, LinearGradientMode.Vertical);
            _IBBrush = new LinearGradientBrush(_IBRect, _IBColor, _IBColor2, LinearGradientMode.Vertical);
            _LBCBrush = new LinearGradientBrush(_IBRect, _IBCColor, _IBCColor2, LinearGradientMode.Vertical);
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            _FCBrush = new SolidBrush(ForeColor);

            // Draw Checkbox BG
            G.FillRectangle(_LBG, _OBGRect);
            G.FillRectangle(_IBBrush, _IBRect);
            G.DrawRectangle(Pens.Black, _OBRect);

            switch (State)
            {
                case MouseState.Over:
                    _BHighlightBrush = new LinearGradientBrush(_OBRect, _BHColor2, _BHColor, LinearGradientMode.Vertical);
                    G.FillRectangle(_BHighlightBrush, _OBRect);
                    break;
                case MouseState.Down:
                    _BHighlightBrush = new LinearGradientBrush(_OBRect, _BHColor, _BHColor2, LinearGradientMode.Vertical);
                    G.FillRectangle(_BHighlightBrush, _OBRect);
                    break;
            }

            switch (Checked)
            {
                case true:
                    G.FillRectangle(_LBCBrush, _IBRect);
                    break;
                case false:
                    G.FillRectangle(_IBBrush, _IBRect);
                    break;
            }
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 19, 1);
        }

    }
}
