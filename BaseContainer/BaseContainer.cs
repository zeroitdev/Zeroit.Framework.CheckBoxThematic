// ***********************************************************************
// Assembly         : Zeroit.Framework.CheckBoxThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 06-08-2018
// ***********************************************************************
// <copyright file="BaseContainer.cs" company="Zeroit Dev Technologies">
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Zeroit.Framework.CheckBoxThematic.ThemeManagers;

namespace Zeroit.Framework.CheckBoxThematic.Controls
{

    /// <summary>
    /// Class CheckBoxThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.CheckBoxThematic.ThemeManagers.ThemeControl" />
    [Designer(typeof(CheckBoxThematicDesigner))]
    public partial class CheckBoxThematic : ThemeControl
    {

        #region Private Fields

        /// <summary>
        /// The check box style
        /// </summary>
        private CheckBoxStyles checkBoxStyle = CheckBoxStyles.ASC;
        /// <summary>
        /// The state
        /// </summary>
        private MouseState State = MouseState.None;
        #endregion

        #region Public Properties

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.HighQuality;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.ClearTypeGridFit;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }


        #endregion

        #region Interpolation Mode

        /// <summary>
        /// The interpolation mode
        /// </summary>
        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

        /// <summary>
        /// Gets or sets the interpolation mode.
        /// </summary>
        /// <value>The interpolation mode.</value>
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Pixel Offset
        /// <summary>
        /// The pixel offset mode
        /// </summary>
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

        /// <summary>
        /// Gets or sets the pixel offset mode.
        /// </summary>
        /// <value>The pixel offset mode.</value>
        public PixelOffsetMode PixelOffsetMode
        {
            get { return pixelOffsetMode; }
            set
            {
                pixelOffsetMode = value;
                Invalidate();
            }
        }



        #endregion

        /// <summary>
        /// Gets or sets the CheckBox style.
        /// </summary>
        /// <value>The CheckBox style.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">value - null</exception>
        public CheckBoxStyles CheckBoxStyle
        {
            get { return checkBoxStyle; }
            set {

                switch (value)
                {
                    case CheckBoxStyles.ASC:
                        ASCCheckBox();
                        break;
                    case CheckBoxStyles.Advantium:
                        AdvantiumCheck();
                        break;
                    case CheckBoxStyles.Ambiance:
                        Ambiance_CheckBox();
                        break;
                    case CheckBoxStyles.Angel:
                        AngelCheckBox();
                        break;
                    case CheckBoxStyles.Aryan:
                        AryanCheckBox();
                        break;
                    case CheckBoxStyles.BCEvo:
                        BCEvoCheckBox();
                        break;
                    case CheckBoxStyles.Bionic:
                        BionicCheckBox();
                        break;
                    case CheckBoxStyles.Bitdefender:
                        BitdefenderCheckbox();
                        break;
                    case CheckBoxStyles.Black:
                        BlackCheckBox();
                        break;
                    case CheckBoxStyles.Butterscotch:
                        ButterscotchCheckBox();
                        break;
                    case CheckBoxStyles.CarbonFibre:
                        CarbonFiberCheckbox();
                        break;
                    //case CheckBoxStyles.Chrome:
                    //    break;
                    case CheckBoxStyles.iClarity:
                        iClarityCheckBox();
                        break;
                    case CheckBoxStyles.Visceral:
                        VisceralCheckBox();
                        break;
                    case CheckBoxStyles.Design:
                        break;
                    case CheckBoxStyles.Evolve:
                        break;
                    case CheckBoxStyles.Excision:
                        ExcisionCheckBox();
                        break;
                    case CheckBoxStyles.Flat:
                        FlatCheckBox();
                        break;
                    case CheckBoxStyles.Frog:
                        FrogCheckbox();
                        break;
                    case CheckBoxStyles.Gamer:
                        GameBoosterCheckBox();
                        break;
                    case CheckBoxStyles.Hura:
                        break;
                    case CheckBoxStyles.Influence:
                        InfluenceCheckBox();
                        break;
                    case CheckBoxStyles.iCheck:
                        iCheckBox();
                        break;
                    case CheckBoxStyles.Meph:
                        MephCheckBox();
                        break;
                    case CheckBoxStyles.NS:
                        break;
                    case CheckBoxStyles.NYX:
                        NYX_CheckBox();
                        break;
                    case CheckBoxStyles.Orains:
                        OrainsCheckBox();
                        break;
                    case CheckBoxStyles.Recon:
                        ReconCheck();
                        break;
                    case CheckBoxStyles.Simpla:
                        SimplaCheckBox();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                }
                checkBoxStyle = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxThematic"/> class.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public CheckBoxThematic()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.ContainerControl, true);

            DoubleBuffered = true;
            Transparent = true;

            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    ASCCheckBox();
                    break;
                case CheckBoxStyles.Advantium:
                    AdvantiumCheck();
                    break;
                case CheckBoxStyles.Ambiance:
                    Ambiance_CheckBox();
                    break;
                case CheckBoxStyles.Angel:
                    AngelCheckBox();
                    break;
                case CheckBoxStyles.Aryan:
                    AryanCheckBox();
                    break;
                case CheckBoxStyles.BCEvo:
                    BCEvoCheckBox();
                    break;
                case CheckBoxStyles.Bionic:
                    BionicCheckBox();
                    break;
                case CheckBoxStyles.Bitdefender:
                    BitdefenderCheckbox();
                    break;
                case CheckBoxStyles.Black:
                    BlackCheckBox();
                    break;
                case CheckBoxStyles.Butterscotch:
                    ButterscotchCheckBox();
                    break;
                case CheckBoxStyles.CarbonFibre:
                    break;
                //case CheckBoxStyles.Chrome:
                //    break;
                case CheckBoxStyles.iClarity:
                    iClarityCheckBox();
                    break;
                case CheckBoxStyles.Visceral:
                    VisceralCheckBox();
                    break;
                case CheckBoxStyles.Design:
                    break;
                case CheckBoxStyles.Evolve:
                    break;
                case CheckBoxStyles.Excision:
                    ExcisionCheckBox();
                    break;
                case CheckBoxStyles.Flat:
                    FlatCheckBox();
                    break;
                case CheckBoxStyles.Frog:
                    FrogCheckbox();
                    break;
                case CheckBoxStyles.Gamer:
                    GameBoosterCheckBox();
                    break;
                case CheckBoxStyles.Hura:
                    break;
                case CheckBoxStyles.Influence:
                    InfluenceCheckBox();
                    break;
                case CheckBoxStyles.iCheck:
                    iCheckBox();
                    break;
                case CheckBoxStyles.Meph:
                    MephCheckBox();
                    break;
                case CheckBoxStyles.NS:
                    break;
                case CheckBoxStyles.NYX:
                    NYX_CheckBox();
                    break;
                case CheckBoxStyles.Orains:
                    OrainsCheckBox();
                    break;
                case CheckBoxStyles.Recon:
                    ReconCheck();
                    break;
                case CheckBoxStyles.Simpla:
                    SimplaCheckBox();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        #endregion

        #region Overrides


        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void PaintHook(PaintEventArgs e)
        {
            G = e.Graphics;
            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    ASCOnPaint(e);
                    break;
                case CheckBoxStyles.Advantium:
                    AdvantiumPaintHook(e);
                    break;
                case CheckBoxStyles.Ambiance:
                    AmbianceOnPaint(e);
                    break;
                case CheckBoxStyles.Angel:
                    AngelOnPaint(e);
                    break;
                case CheckBoxStyles.Aryan:
                    AryanPaintHook();
                    break;
                case CheckBoxStyles.BCEvo:
                    BCEvoPaintHook();
                    break;
                case CheckBoxStyles.Bionic:
                    BionicOnPaint(e);
                    break;
                case CheckBoxStyles.Bitdefender:
                    BitDefenderOnPaint(e);
                    break;
                case CheckBoxStyles.Black:
                    BlackPaintHook();
                    break;
                case CheckBoxStyles.Butterscotch:
                    ButterOnPaint(e);
                    break;
                case CheckBoxStyles.CarbonFibre:
                    CarbonPaintHook();
                    break;
                //case CheckBoxStyles.Chrome:
                //    //ChromePaintHook(e);
                //    break;
                case CheckBoxStyles.iClarity:
                    iClarityPaintHook();
                    break;
                case CheckBoxStyles.Visceral:
                    VisceralOnPaint(e);
                    break;
                case CheckBoxStyles.Design:
                    DesignPaintHook();
                    break;
                case CheckBoxStyles.Evolve:
                    EvolvePaintHook();
                    break;
                case CheckBoxStyles.Excision:
                    ExcisionOnPaint(e);
                    break;
                case CheckBoxStyles.Flat:
                    FlatOnPaint(e);
                    break;
                case CheckBoxStyles.Frog:
                    FrogOnPaintHook(e);
                    break;
                case CheckBoxStyles.Gamer:
                    GameBoosterPaintHook();
                    break;
                case CheckBoxStyles.Hura:
                    HuraOnPaint(e);
                    break;
                case CheckBoxStyles.Influence:
                    InfluenceOnPaint(e);
                    break;
                case CheckBoxStyles.iCheck:
                    iCheckPaintHook();
                    break;
                case CheckBoxStyles.Meph:
                    MephOnPaint(e);
                    break;
                case CheckBoxStyles.NS:
                    NSOnPaint();
                    break;
                case CheckBoxStyles.NYX:
                    NYXPaintHook();
                    break;
                case CheckBoxStyles.Orains:
                    OrainsPaintHook();
                    break;
                case CheckBoxStyles.Recon:
                    ReconPaintHook();
                    break;
                case CheckBoxStyles.Simpla:
                    SimplaOnPaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    ASCCheckBox();
                    break;
                case CheckBoxStyles.Advantium:
                    AdvantiumCheck();
                    break;
                case CheckBoxStyles.Ambiance:
                    Ambiance_CheckBox();
                    break;
                case CheckBoxStyles.Angel:
                    AngelOnResize(e);
                    break;
                case CheckBoxStyles.Aryan:
                    AryanCheckBox();
                    break;
                case CheckBoxStyles.BCEvo:
                    BCEvoCheckBox();
                    break;
                case CheckBoxStyles.Bionic:
                    BionicOnResize(e);
                    break;
                case CheckBoxStyles.Bitdefender:
                    BitdefenderOnResize(e);
                    break;
                case CheckBoxStyles.Black:
                    BlackCheckBox();
                    break;
                case CheckBoxStyles.Butterscotch:
                    ButterscotchCheckBox();
                    break;
                case CheckBoxStyles.CarbonFibre:
                    CarbonFiberCheckbox();
                    break;
                //case CheckBoxStyles.Chrome:
                //    break;
                case CheckBoxStyles.iClarity:
                    iClarityCheckBox();
                    break;
                case CheckBoxStyles.Visceral:
                    VisceralOnResize(e);
                    break;
                case CheckBoxStyles.Design:
                    break;
                case CheckBoxStyles.Evolve:
                    ExcisionCheckBox();
                    break;
                case CheckBoxStyles.Excision:
                    break;
                case CheckBoxStyles.Flat:
                    FlatOnResize(e);
                    break;
                case CheckBoxStyles.Frog:
                    FrogCheckbox();
                    break;
                case CheckBoxStyles.Gamer:
                    GameBoosterCheckBox();
                    break;
                case CheckBoxStyles.Hura:
                    break;
                case CheckBoxStyles.Influence:
                    InfluenceOnResize(e);
                    break;
                case CheckBoxStyles.iCheck:
                    iCheckBox();
                    break;
                case CheckBoxStyles.Meph:
                    MephOnResize(e);
                    break;
                case CheckBoxStyles.NS:
                    break;
                case CheckBoxStyles.NYX:
                    NYX_OnResize(e);
                    break;
                case CheckBoxStyles.Orains:
                    OrainsCheckBox();
                    break;
                case CheckBoxStyles.Recon:
                    ReconCheck();
                    break;
                case CheckBoxStyles.Simpla:
                    SimplaOnResize(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnClick(System.EventArgs e)
        {
            _checked = !_checked;
            if (checkedChanged != null)
            {
                checkedChanged(this, EventArgs.Empty);
            }

            base.OnClick(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseClick" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    break;
                case CheckBoxStyles.Advantium:
                    break;
                case CheckBoxStyles.Ambiance:
                    break;
                case CheckBoxStyles.Angel:
                    break;
                case CheckBoxStyles.Aryan:
                    break;
                case CheckBoxStyles.BCEvo:
                    break;
                case CheckBoxStyles.Bionic:
                    break;
                case CheckBoxStyles.Bitdefender:
                    break;
                case CheckBoxStyles.Black:
                    break;
                case CheckBoxStyles.Butterscotch:
                    break;
                case CheckBoxStyles.CarbonFibre:
                    break;
                //case CheckBoxStyles.Chrome:
                //    //ChromeOnMouseClick(e);
                //    break;
                case CheckBoxStyles.iClarity:
                    break;
                case CheckBoxStyles.Visceral:
                    break;
                case CheckBoxStyles.Design:
                    break;
                case CheckBoxStyles.Evolve:
                    break;
                case CheckBoxStyles.Excision:
                    break;
                case CheckBoxStyles.Flat:
                    break;
                case CheckBoxStyles.Frog:
                    break;
                case CheckBoxStyles.Gamer:
                    break;
                case CheckBoxStyles.Hura:
                    break;
                case CheckBoxStyles.Influence:
                    break;
                case CheckBoxStyles.iCheck:
                    break;
                case CheckBoxStyles.Meph:
                    break;
                case CheckBoxStyles.NS:
                    break;
                case CheckBoxStyles.NYX:
                    break;
                case CheckBoxStyles.Orains:
                    break;
                case CheckBoxStyles.Recon:
                    break;
                case CheckBoxStyles.Simpla:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    break;
                case CheckBoxStyles.Advantium:
                    break;
                case CheckBoxStyles.Ambiance:
                    break;
                case CheckBoxStyles.Angel:
                    break;
                case CheckBoxStyles.Aryan:
                    break;
                case CheckBoxStyles.BCEvo:
                    break;
                case CheckBoxStyles.Bionic:
                    break;
                case CheckBoxStyles.Bitdefender:
                    break;
                case CheckBoxStyles.Black:
                    break;
                case CheckBoxStyles.Butterscotch:
                    break;
                case CheckBoxStyles.CarbonFibre:
                    break;
                //case CheckBoxStyles.Chrome:
                //    break;
                case CheckBoxStyles.iClarity:
                    break;
                case CheckBoxStyles.Visceral:
                    break;
                case CheckBoxStyles.Design:
                    break;
                case CheckBoxStyles.Evolve:
                    break;
                case CheckBoxStyles.Excision:
                    break;
                case CheckBoxStyles.Flat:
                    break;
                case CheckBoxStyles.Frog:
                    break;
                case CheckBoxStyles.Gamer:
                    GameBoosterOnMouseMove(e);
                    break;
                case CheckBoxStyles.Hura:
                    break;
                case CheckBoxStyles.Influence:
                    break;
                case CheckBoxStyles.iCheck:
                    break;
                case CheckBoxStyles.Meph:
                    break;
                case CheckBoxStyles.NS:
                    break;
                case CheckBoxStyles.NYX:
                    NYXOnMouseMove(e);
                    break;
                case CheckBoxStyles.Orains:
                    OrainsOnMouseMove(e);
                    break;
                case CheckBoxStyles.Recon:
                    break;
                case CheckBoxStyles.Simpla:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseEnter" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseLeave" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;

            if (_checked)
            {
                _checked = false;
            }
            else
            {
                _checked = true;
            }

            if (checkedChanged != null)
            {
                checkedChanged(this, EventArgs.Empty);
            }

            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    break;
                case CheckBoxStyles.Advantium:
                    break;
                case CheckBoxStyles.Ambiance:
                    break;
                case CheckBoxStyles.Angel:
                    break;
                case CheckBoxStyles.Aryan:
                    break;
                case CheckBoxStyles.BCEvo:
                    break;
                case CheckBoxStyles.Bionic:
                    break;
                case CheckBoxStyles.Bitdefender:
                    break;
                case CheckBoxStyles.Black:
                    break;
                case CheckBoxStyles.Butterscotch:
                    break;
                case CheckBoxStyles.CarbonFibre:
                    break;
                //case CheckBoxStyles.Chrome:
                //    break;
                case CheckBoxStyles.iClarity:
                    break;
                case CheckBoxStyles.Visceral:
                    break;
                case CheckBoxStyles.Design:
                    break;
                case CheckBoxStyles.Evolve:
                    break;
                case CheckBoxStyles.Excision:
                    break;
                case CheckBoxStyles.Flat:
                    break;
                case CheckBoxStyles.Frog:
                    break;
                case CheckBoxStyles.Gamer:
                    break;
                case CheckBoxStyles.Hura:
                    break;
                case CheckBoxStyles.Influence:
                    break;
                case CheckBoxStyles.iCheck:
                    break;
                case CheckBoxStyles.Meph:
                    break;
                case CheckBoxStyles.NS:
                    break;
                case CheckBoxStyles.NYX:
                    NYXOnMouseDown(e);
                    break;
                case CheckBoxStyles.Orains:
                    break;
                case CheckBoxStyles.Recon:
                    break;
                case CheckBoxStyles.Simpla:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);

            State = MouseState.Over;

            Checked = !Checked;
            Focus();

            
            Invalidate();

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            Width = TextRenderer.MeasureText(Text, Font).Width + 16;

            switch (CheckBoxStyle)
            {
                case CheckBoxStyles.ASC:
                    
                    break;
                case CheckBoxStyles.Advantium:
                    
                    break;
                case CheckBoxStyles.Ambiance:
                    
                    break;
                case CheckBoxStyles.Angel:
                    AngelOnTextChanged(e);
                    break;
                case CheckBoxStyles.Aryan:
                    
                    break;
                case CheckBoxStyles.BCEvo:
                    
                    break;
                case CheckBoxStyles.Bionic:
                    
                    break;
                case CheckBoxStyles.Bitdefender:
                    break;
                case CheckBoxStyles.Black:
                    break;
                case CheckBoxStyles.Butterscotch:
                    break;
                case CheckBoxStyles.CarbonFibre:
                    break;
                //case CheckBoxStyles.Chrome:
                //    break;
                case CheckBoxStyles.iClarity:
                    break;
                case CheckBoxStyles.Visceral:
                    break;
                case CheckBoxStyles.Design:
                    break;
                case CheckBoxStyles.Evolve:
                    break;
                case CheckBoxStyles.Excision:
                    break;
                case CheckBoxStyles.Flat:
                    break;
                case CheckBoxStyles.Frog:
                    break;
                case CheckBoxStyles.Gamer:
                    break;
                case CheckBoxStyles.Hura:
                    break;
                case CheckBoxStyles.Influence:
                    break;
                case CheckBoxStyles.iCheck:
                    break;
                case CheckBoxStyles.Meph:
                    break;
                case CheckBoxStyles.NS:
                    break;
                case CheckBoxStyles.NYX:
                    break;
                case CheckBoxStyles.Orains:
                    break;
                case CheckBoxStyles.Recon:
                    break;
                case CheckBoxStyles.Simpla:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Invalidate();
        }


        /// <summary>
        /// The checked
        /// </summary>
        private bool _checked;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CheckBoxThematic"/> is checked.
        /// </summary>
        /// <value><c>true</c> if checked; otherwise, <c>false</c>.</value>
        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                Invalidate();
                this.CheckChanged(this, EventArgs.Empty);
            }
        }


        #endregion

        #region Event Creation

        /////Implement this in the Property you want to trigger the event///////////////////////////
        // 
        //  For Example this will be triggered by the Value Property
        //
        //  public int Value
        //   { 
        //      get { return _value;}
        //      set
        //         {
        //          
        //              _value = value;
        //
        //              this.CheckChanged(EventArgs.Empty);
        //              Invalidate();
        //          }
        //    }
        //
        ////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// The checked changed
        /// </summary>
        private CheckedChangedEventHandler checkedChanged;

        /// <summary>
        /// Delegate CheckedChangedEventHandler
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public delegate void CheckedChangedEventHandler(object sender, EventArgs e);

        /// <summary>
        /// Triggered when the Value changes
        /// </summary>

        public event CheckedChangedEventHandler CheckedChanged
        {
            add
            {
                this.checkedChanged = this.checkedChanged + value;
            }
            remove
            {
                this.checkedChanged = this.checkedChanged - value;
            }
        }

        /// <summary>
        /// Checks the changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void CheckChanged(object sender, EventArgs e)
        {
            if (this.checkedChanged == null)
                return;
            this.checkedChanged((object)this, e);
        }


        #endregion

        #region Draw Borders
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="rect">The rect.</param>
        protected void DrawBorders(Graphics G,Pen p1, Pen p2, Rectangle rect)
        {
            G.DrawRectangle(p1, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
            G.DrawRectangle(p2, rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3);
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Graphics G, Pen p1, int offset)
        {
            DrawBorders(G, p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Graphics G, Pen p1, Rectangle r, int offset)
        {
            DrawBorders(G, p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Graphics G, Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(G, p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Graphics G, Pen p1)
        {
            DrawBorders(G, p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Graphics G, Pen p1, Rectangle r)
        {
            DrawBorders(G, p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Graphics G, Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>Pen.</returns>
        public Pen ToPen(Color color)
        {
            return new Pen(color);
        }

        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>Brush.</returns>
        public Brush ToBrush(Color color)
        {
            return new SolidBrush(color);
        }

        #endregion

        #region Draw Gradient

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="C1">The c1.</param>
        /// <param name="C2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        private void DrawGradient(Graphics G, Color C1, Color C2, int x, int y, int width, int height, int angle)
        {
            LinearGradientBrush linBrush = new LinearGradientBrush(new Rectangle(x, y, width, height), C1, C2, angle);
            G.FillRectangle(linBrush, new Rectangle(x, y, width, height));

        }

        #endregion

        
    }
}
