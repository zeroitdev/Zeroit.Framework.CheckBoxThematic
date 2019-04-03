// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="FlatUI.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {


        #region " Variables"

        private int W;
        private int H;
        private _Options O;

        
        #endregion

        #region " Properties"
        

        [Flags()]
        public enum _Options
        {
            Style1,
            Style2
        }

        [Category("Options")]
        public _Options Options
        {
            get { return O; }
            set { O = value; }
        }

        private void FlatOnResize(EventArgs e)
        {
            Height = 22;
        }

        #region " Colors"

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set { _BorderColor = value; }
        }

        #endregion

        #region " Mouse States"

        

        #endregion

        #endregion

        #region " Colors"

        private Color _BaseColor = Color.FromArgb(45, 47, 49);
        private Color _BorderColor = Draw._FlatColor;

        private Color _TextColor = Color.FromArgb(243, 243, 243);
        #endregion

        private void FlatCheckBox()
        {
            DoubleBuffered = true;
            Cursor = Cursors.Hand;
            //Size = new Size(112, 22);
            Height = 22;
        }

        private void FlatOnPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            W = Width - 1;
            H = Height - 1;

            Rectangle Base = new Rectangle(0, 2, Height - 5, Height - 5);

            
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.Clear(Parent.BackColor);

            switch (O)
            {
                case _Options.Style1:
                    //-- Style 1
                    //-- Base
                    G.FillRectangle(new SolidBrush(_BaseColor), Base);

                    switch (State)
                    {
                        case MouseState.Over:
                            //-- Base
                            G.DrawRectangle(new Pen(_BorderColor), Base);
                            break;
                        case MouseState.Down:
                            //-- Base
                            G.DrawRectangle(new Pen(_BorderColor), Base);
                            break;
                    }

                    //-- If Checked
                    if (Checked)
                    {
                        G.DrawString("ü", new Font("Wingdings", 18), new SolidBrush(_BorderColor), new Rectangle(5, 7, H - 9, H - 9), Draw.CenterSF);
                    }

                    //-- If Enabled
                    if (this.Enabled == false)
                    {
                        G.FillRectangle(new SolidBrush(Color.FromArgb(54, 58, 61)), Base);
                        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(140, 142, 143)), new Rectangle(20, 2, W, H), Draw.NearSF);
                    }

                    //-- Text
                    G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(20, 2, W, H), Draw.NearSF);
                    break;
                case _Options.Style2:
                    //-- Style 2
                    //-- Base
                    G.FillRectangle(new SolidBrush(_BaseColor), Base);

                    switch (State)
                    {
                        case MouseState.Over:
                            //-- Base
                            G.DrawRectangle(new Pen(_BorderColor), Base);
                            G.FillRectangle(new SolidBrush(Color.FromArgb(118, 213, 170)), Base);
                            break;
                        case MouseState.Down:
                            //-- Base
                            G.DrawRectangle(new Pen(_BorderColor), Base);
                            G.FillRectangle(new SolidBrush(Color.FromArgb(118, 213, 170)), Base);
                            break;
                    }

                    //-- If Checked
                    if (Checked)
                    {
                        G.DrawString("ü", new Font("Wingdings", 18), new SolidBrush(_BorderColor), new Rectangle(5, 7, H - 9, H - 9), Draw.CenterSF);
                    }

                    //-- If Enabled
                    if (this.Enabled == false)
                    {
                        G.FillRectangle(new SolidBrush(Color.FromArgb(54, 58, 61)), Base);
                        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(48, 119, 91)), new Rectangle(20, 2, W, H), Draw.NearSF);
                    }

                    //-- Text
                    G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(20, 2, W, H), Draw.NearSF);
                    break;
            }

            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            
        }

    }

}

