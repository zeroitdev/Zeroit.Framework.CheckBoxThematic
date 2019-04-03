// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Orains.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

