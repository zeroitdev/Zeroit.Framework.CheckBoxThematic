// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
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

