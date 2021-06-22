using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseHardwareMonitor
{
    public partial class Toggle : UserControl
    {
        public bool Checked=false;
        public Toggle()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            Padding = new Padding(6);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                var d = Padding.All;
                var r = this.Height - 2 * d;
                path.AddArc(d, d, r, r, 90, 180);
                path.AddArc(this.Width - r - d, d, r, r, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? Brushes.DarkGray : Brushes.LightGray, path);
                r = Height - 1;
                var rect = Checked ? new System.Drawing.Rectangle(Width - r - 1, 0, r, r)
                                    : new System.Drawing.Rectangle(0, 0, r, r);
                e.Graphics.FillEllipse(Checked ? Brushes.Green : Brushes.LightSlateGray, rect);
            }
        }

        private void Toggle_Load(object sender, EventArgs e)
        {

        }

        private void Toggle_Click(object sender, EventArgs e)
        {

        }
    }
}
