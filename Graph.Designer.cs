﻿


namespace VTools
{
    public partial class Graph
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
          this.plot = new NPlot.Windows.PlotSurface2D();
          this.SuspendLayout();
          // 
          // plot
          // 
          this.plot.AutoScaleAutoGeneratedAxes = true;
          this.plot.AutoScaleTitle = true;
          this.plot.BackColor = System.Drawing.SystemColors.ControlLightLight;
          this.plot.DateTimeToolTip = false;
          this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
          this.plot.Legend = null;
          this.plot.LegendZOrder = -1;
          this.plot.Location = new System.Drawing.Point(0, 0);
          this.plot.Margin = new System.Windows.Forms.Padding(4);
          this.plot.Name = "plot";
          this.plot.RightMenu = null;
          this.plot.ShowCoordinates = true;
          this.plot.Size = new System.Drawing.Size(1024, 527);
          this.plot.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
          this.plot.TabIndex = 0;
          this.plot.Text = "plot";
          this.plot.Title = "";
          this.plot.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
          this.plot.XAxis1 = null;
          this.plot.XAxis2 = null;
          this.plot.YAxis1 = null;
          this.plot.YAxis2 = null;
          // 
          // ucGraph
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.Controls.Add(this.plot);
          this.Margin = new System.Windows.Forms.Padding(4);
          this.Name = "ucGraph";
          this.Size = new System.Drawing.Size(1024, 527);
          this.ResumeLayout(false);

	  }

	  #endregion

      private NPlot.Windows.PlotSurface2D plot;
   }
}
