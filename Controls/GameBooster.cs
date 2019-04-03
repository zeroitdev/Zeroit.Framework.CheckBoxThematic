// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="GameBooster.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {


        private void GameBoosterCheckBox()
        {
            //LockHeight = 17;
            //Width = 160;
            Height = 17;
        }

        private int gameBoosterX;
        private Color G1 = Color.FromArgb(65, 65, 65);
        private Color G2 = Color.FromArgb(122, 122, 122);

        private Color Edge = Color.Black;
        

        private void GameBoosterOnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            gameBoosterX = e.Location.X;
            
        }

        private void GameBoosterPaintHook()
        {
            G.Clear(Parent.BackColor);
            if (Checked)
            {
                LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(14, 16)), G1, G2, 90f);
                DrawGradient(Color.Black, Color.FromArgb(100, 100, 100), new Rectangle(2, 2, Height - 7, Height - 7), 45f);
                G.DrawRectangle(new Pen(Color.FromArgb(102, 102, 102)), 1, 1, Height - 5, Height - 5);
                G.FillRectangle(LGB, new Rectangle(new Point(3, 3), new Size(Height - 8, Height - 8)));
                DrawPixel(Color.FromArgb(42, 42, 42), 2, Height - 5);
                DrawPixel(Color.FromArgb(42, 42, 42), Height - 5, 2);
                DrawPixel(Color.FromArgb(42, 42, 42), 2, 2);
            }
            else
            {
                LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(14, 16)), G1, G2, 90f);
                DrawGradient(Color.Black, Color.FromArgb(101, 101, 101), new Rectangle(2, 2, Height - 7, Height - 7), 45f);
                G.DrawRectangle(new Pen(Color.FromArgb(102, 102, 102)), 1, 1, Height - 5, Height - 5);
                G.FillRectangle(LGB, new Rectangle(new Point(3, 3), new Size(Height - 8, Height - 8)));
                DrawPixel(Color.FromArgb(42, 42, 42), 2, Height - 5);
                DrawPixel(Color.FromArgb(42, 42, 42), Height - 5, 2);
                DrawPixel(Color.FromArgb(42, 42, 42), 2, 2);
            }

            if (State == MouseState.Over & gameBoosterX < 15)
            {
                SolidBrush SB = new SolidBrush(Color.FromArgb(70, Color.White));
                G.FillRectangle(SB, new Rectangle(new Point(0, 0), new Size(14, 14)));
            }
            else if (State == MouseState.Down & gameBoosterX < 15)
            {
                SolidBrush SB = new SolidBrush(Color.FromArgb(10, Color.Black));
                G.FillRectangle(SB, new Rectangle(new Point(0, 0), new Size(14, 14)));
            }

            HatchBrush HB = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(7, Color.Black), Color.Transparent);
            G.FillRectangle(HB, new Rectangle(new Point(0, 0), new Size(14, 14)));
            G.DrawRectangle(new Pen(Edge), new Rectangle(new Point(0, 0), new Size(14, 14)));

            if (Checked)
                G.DrawString("a", new Font("Marlett", 12), new SolidBrush(Color.FromArgb(214, 214, 214)), new Point(-3, -1));
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 19, -1);
        }

    }

}

