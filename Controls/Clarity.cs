// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Clarity.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        
        
        Color BorderBox = Color.Black;
        Color InnerBox = Color.FromArgb(40, 40, 40);
        

        
        private void iClarityPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;
            int Curve = 4;

            if (Checked)
            {
                G.FillRectangle(new SolidBrush(Color.White), new Rectangle(3, 3, 10, 10));
                G.DrawString("a", new Font("Marlett", 12), Brushes.White, new Point(-2, 0));

                G.DrawRectangle(new Pen(InnerBox), new Rectangle(1, 1, 14, 14));
                G.DrawRectangle(new Pen(BorderBox), new Rectangle(0, 0, 16, 16));
                
            }
            else
            {

                G.DrawRectangle(new Pen(InnerBox), new Rectangle(1, 1, 14, 14));
                G.DrawRectangle(new Pen(BorderBox), new Rectangle(0, 0, 16, 16));
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), 3, 3, 10, 10);
            }

            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(22, 2));

        }

        private void iClarityCheckBox()
        {
            //this.Size = new Size(50, 17);
            Height = 17;
        }

    }

}

