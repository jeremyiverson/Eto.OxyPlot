using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Drawing;
using Eto.GtkSharp.Forms;
using OxyPlot;
using OxyPlot.GtkSharp;

namespace Eto.OxyPlot.Gtk
{
    public class PlotHandler : GtkControl<PlotView, Plot, Plot.ICallback>, Plot.IHandler
    {
        public override Color BackgroundColor
        {
            get 
            { 
                var color = Control.Model.PlotAreaBackground;
                return new Color(color.R, color.G, color.B, color.A);
            }
            set 
            {
                Control.Model.PlotAreaBackground = OxyColor.FromArgb(
                    Control.Model.PlotAreaBackground.A,
                    Control.Model.PlotAreaBackground.R,
                    Control.Model.PlotAreaBackground.G,
                    Control.Model.PlotAreaBackground.B);
            }
        }

        public PlotModel Model
        {
            get { return Control.Model; }
            set { Control.Model = value; }
        }

        public PlotHandler()
        {
            Control = new global::OxyPlot.GtkSharp.PlotView()
            {
            };
        }

        public void InvalidatePlot(bool updateData)
        {
            Control.InvalidatePlot(true);
        }
    }
}
