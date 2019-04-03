// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Recon.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    public partial class CheckBoxThematic
    {


        #region " Properties "
        
        #endregion

        private void ReconCheck()
        {
            //Size = new Size(90, 15);
            Height = 15;
        }

        private void ReconOnResize(EventArgs e)
        {
            Height = 15;
        }

        private void ReconPaintHook()
        {
            G.Clear(Parent.BackColor);
            DrawGradient(Color.FromArgb(18, 18, 18), Color.FromArgb(28, 28, 28), 0, 0, 15, 15, 90);

            switch (Checked)
            {
                case true:

                    DrawGradient(Color.FromArgb(18, 18, 18), Color.FromArgb(28, 28, 28), 0, 0, 15, 15, 270);
                    DrawGradient(Color.FromArgb(100, 40, 40, 40), Color.Transparent, 0, 0, 15, 15, 90);

                    DrawGradient(Color.FromArgb(5, this.ForeColor), Color.Transparent, 0, 0, 15, 15, 90);
                    DrawGradient(Color.FromArgb(9, this.ForeColor), Color.Transparent, 0, 0, 15, 15, 270);

                    G.DrawRectangle(new Pen(Color.FromArgb(10, 10, 10)), 3, 3, 11, 11);
                    DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(30, 30, 30), 0, 0, 15, 15, 90);
                    break;
            }

            DrawBorders(Pens.Black, new Pen(Color.FromArgb(52, 52, 52)), new Rectangle(0, 0, 15, 15));
            DrawText(HorizontalAlignment.Left, this.ForeColor, 17, 0);
        }

    }

}

