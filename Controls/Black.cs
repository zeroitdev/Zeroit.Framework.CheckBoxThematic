// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Black.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{
    public partial class CheckBoxThematic
    {

        private void BlackCheckBox()
        {
            Size = new Size(158, 16);
            //MinimumSize = new Size(16, 16);
            //MaximumSize = new Size(600, 16);
            
        }

        

        private void BlackPaintHook()
        {
            
            G.Clear(Parent.BackColor);
            switch (Checked)
            {
                case true:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(30, 30, 30), 3, 3, 9, 9, 90);
                    DrawGradient(Color.FromArgb(65, 65, 65), Color.FromArgb(20, 20, 20), 4, 4, 7, 7, 90);
                    break;
                case false:
                    DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 0, 15, 15, 90);
                    break;
            }
            G.DrawRectangle(Pens.Black, 0, 0, 14, 14);
            G.DrawRectangle(Pens.Black, 2, 2, 10, 10);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 17, 0);
        }

    }
}
