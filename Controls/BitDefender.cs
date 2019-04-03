// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BitDefender.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        #region "Init"
        #region "Event"
        
        #endregion

         private void BitdefenderCheckbox()
         {
            Width = 55;
            Height = 25;
            
         }

        private void BitdefenderOnResize(EventArgs e)
        {
            Width = 55;
            Height = 25;

        }
        #endregion

        #region "draw"

        #region "draw init object"

        #region "Declaration draw object"
         ContainerObjectDisposable cn;
         Rectangle R1;
         Rectangle R2;
         Rectangle R3;
         Rectangle R4;
         Rectangle R5;
         Rectangle R6;
         GraphicsPath GP1;
         GraphicsPath GP2;
         GraphicsPath GP3;
         GraphicsPath GP4;
         GraphicsPath GP5;
         GraphicsPath GP6;
         LinearGradientBrush LGB1;
         LinearGradientBrush LGB2;
         LinearGradientBrush LGB3;
         LinearGradientBrush LGB4;
         PathGradientBrush PGB1;
         SolidBrush B1;
         SolidBrush B2;
         SolidBrush B3;
         Pen P1;
         Pen P2;
         Size CheckSize;
         //Size oldsize;
        #endregion

        void Init(PaintEventArgs e)
         {
            
            cn = new ContainerObjectDisposable();
            R1 = new Rectangle(1, 1, Width - 2, Height - 2);
            R2 = new Rectangle(2, 2, Width - 4, Height - 4);

            GP1 = Helper.RoundRect(R1, 11);
            cn.AddObject(GP1);
            GP2 = Helper.RoundRect(R2, 11);
            cn.AddObject(GP2);

            B1 = new SolidBrush(Color.FromArgb(40, 40, 40));
            cn.AddObject(B1);
            if (Checked)
            {
                B2 = new SolidBrush(Color.FromArgb(84, 135, 171));
                PGB1 = new PathGradientBrush(GP2)
                {
                    CenterColor = Color.FromArgb(84, 135, 171),
                    SurroundColors = new Color[] { Color.FromArgb(113, 176, 200) },
                    FocusScales = new PointF(0.85f, 0.65f)
                };

            }
            else
            {
                B2 = new SolidBrush(Color.FromArgb(29, 29, 29));
                PGB1 = new PathGradientBrush(GP2)
                {
                    CenterColor = Color.FromArgb(29, 29, 29),
                    SurroundColors = new Color[] { Color.FromArgb(39, 39, 39) },
                    FocusScales = new PointF(0.85f, 0.65f)
                };
            }
            cn.AddObjectRange(new Brush[]{
            B2,
            PGB1
        });
            B3 = new SolidBrush(Color.FromArgb(107, 107, 107));
            cn.AddObject(B3);

            CheckSize = new Size(22, R2.Height);
            R3 = new Rectangle(Width - 2 - 22, 2, CheckSize.Width, CheckSize.Height);
            GP3 = Helper.RoundRect(R3, 11);
            R4 = new Rectangle(R3.X + 1, R3.Y + 1, R3.Width - 2, R3.Height - 2);
            GP4 = Helper.RoundRect(R4, 11);

            R5 = new Rectangle(0, 2, CheckSize.Width, CheckSize.Height);
            GP5 = Helper.RoundRect(R5, 11);
            R6 = new Rectangle(R5.X + 1, R5.Y + 1, R5.Width - 2, R5.Height - 2);
            GP6 = Helper.RoundRect(R6, 11);
            cn.AddObjectRange(new GraphicsPath[]{
            GP3,
            GP4,
            GP5,
            GP6
        });
            if (State == MouseState.Over)
            {
                LGB1 = new LinearGradientBrush(R3, Color.FromArgb(86, 86, 86), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical);
                LGB2 = new LinearGradientBrush(new Rectangle(R4.X - 1, R4.Y - 1, R4.Width + 2, R4.Height + 2), Color.FromArgb(147, 147, 147), Color.FromArgb(68, 68, 68), LinearGradientMode.Vertical);
                P1 = new Pen(LGB2);

                LGB3 = new LinearGradientBrush(R5, Color.FromArgb(86, 86, 86), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical);
                LGB4 = new LinearGradientBrush(new Rectangle(R6.X - 1, R6.Y - 1, R6.Width + 2, R6.Height + 2), Color.FromArgb(147, 147, 147), Color.FromArgb(68, 68, 68), LinearGradientMode.Vertical);
                P2 = new Pen(LGB4);

            }
            else
            {
                LGB1 = new LinearGradientBrush(R3, Color.FromArgb(59, 59, 59), Color.FromArgb(29, 29, 29), LinearGradientMode.Vertical);
                LGB2 = new LinearGradientBrush(new Rectangle(R4.X - 1, R4.Y - 1, R4.Width + 2, R4.Height + 2), Color.FromArgb(101, 101, 101), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical);
                P1 = new Pen(LGB2);

                LGB3 = new LinearGradientBrush(R5, Color.FromArgb(59, 59, 59), Color.FromArgb(29, 29, 29), LinearGradientMode.Vertical);
                LGB4 = new LinearGradientBrush(new Rectangle(R6.X - 1, R6.Y - 1, R6.Width + 2, R6.Height + 2), Color.FromArgb(101, 101, 101), Color.FromArgb(42, 42, 42), LinearGradientMode.Vertical);
                P2 = new Pen(LGB4);

            }
            cn.AddObjectRange(new Brush[]{
            LGB1,
            LGB2,
            LGB3,
            LGB4,
			//P1,
			//P2
		});

            cn.AddObjectRange(new Pen[]{

            P1,
            P2
        });


        }
        
        #endregion

        private void BitDefenderOnPaint(PaintEventArgs e)
        {
            
            Init(e);
            G.SmoothingMode = SmoothingMode.AntiAlias;
            G.InterpolationMode = InterpolationMode.HighQualityBicubic;
            G.FillPath(B1, GP1);


            if (Checked)
            {
                G.FillPath(B2, GP2);
                G.FillPath(PGB1, GP2);
                G.DrawPath(Pens.Black, GP2);
                if (State == MouseState.Over)
                {
                    G.FillPath(LGB1, GP3);
                    G.DrawPath(Pens.Black, GP3);
                    G.DrawPath(P1, GP4);
                    G.DrawString("ON", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.Black, 7, 6);
                    G.DrawString("ON", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.White, 7, 7);
                }
                else
                {
                    G.FillPath(LGB1, GP3);
                    G.DrawPath(Pens.Black, GP3);
                    G.DrawPath(P1, GP4);
                    G.DrawString("ON", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.Black, 7, 6);
                    G.DrawString("ON", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), Brushes.White, 7, 7);
                }
            }
            else
            {
                G.FillPath(B1, GP1);
                G.FillPath(B2, GP2);
                G.FillPath(PGB1, GP2);
                G.DrawPath(Pens.Black, GP2);
                if (State == MouseState.Over)
                {
                    G.FillPath(LGB3, GP5);
                    G.DrawPath(Pens.Black, GP5);
                    G.DrawPath(P2, GP6);
                    G.DrawString("OFF", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), new SolidBrush(ForeColor), Width - 29, 6);
                    G.DrawString("OFF", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), B3, Width - 29, 7);
                }
                else
                {
                    G.FillPath(LGB3, GP5);
                    G.DrawPath(Pens.Black, GP5);
                    G.DrawPath(P2, GP6);
                    G.DrawString("OFF", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), new SolidBrush(ForeColor), Width - 29, 6);
                    G.DrawString("OFF", new Font("Microsoft Sans Serif", 7, FontStyle.Bold), B3, Width - 29, 7);
                }

            }
            cn.Dispose();
        }

        

        
        #endregion

    }

}
