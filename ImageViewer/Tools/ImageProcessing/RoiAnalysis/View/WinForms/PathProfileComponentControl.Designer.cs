#region License

// Copyright (c) 2006-2007, ClearCanvas Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice, 
//      this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, 
//      this list of conditions and the following disclaimer in the documentation 
//      and/or other materials provided with the distribution.
//    * Neither the name of ClearCanvas Inc. nor the names of its contributors 
//      may be used to endorse or promote products derived from this software without 
//      specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR 
// PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
// OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE 
// GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 
// ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
// OF SUCH DAMAGE.

#endregion

namespace ClearCanvas.ImageViewer.Tools.ImageProcessing.RoiAnalysis.View.WinForms
{
    partial class PathProfileComponentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._plotSurface = new NPlot.Windows.PlotSurface2D();
            this.SuspendLayout();
            // 
            // _plotSurface
            // 
            this._plotSurface.AutoScaleAutoGeneratedAxes = false;
            this._plotSurface.AutoScaleTitle = false;
            this._plotSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._plotSurface.DateTimeToolTip = false;
            this._plotSurface.Legend = null;
            this._plotSurface.LegendZOrder = -1;
            this._plotSurface.Location = new System.Drawing.Point(16, 16);
            this._plotSurface.Name = "_plotSurface";
            this._plotSurface.RightMenu = null;
            this._plotSurface.ShowCoordinates = true;
            this._plotSurface.Size = new System.Drawing.Size(350, 260);
            this._plotSurface.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this._plotSurface.TabIndex = 0;
            this._plotSurface.Text = "plotSurface2D1";
            this._plotSurface.Title = "";
            this._plotSurface.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._plotSurface.XAxis1 = null;
            this._plotSurface.XAxis2 = null;
            this._plotSurface.YAxis1 = null;
            this._plotSurface.YAxis2 = null;
            // 
            // PathProfileComponentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._plotSurface);
            this.Name = "PathProfileComponentControl";
            this.Size = new System.Drawing.Size(386, 304);
            this.ResumeLayout(false);

        }

        #endregion

		private NPlot.Windows.PlotSurface2D _plotSurface;
    }
}
