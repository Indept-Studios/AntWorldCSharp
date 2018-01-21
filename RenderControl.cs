using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntWorldCSharp
{
    public partial class RenderControl : UserControl
    {
        public Point game1 = new Point();

        int x;
        int y;
        int w;
        int h;

        public RenderControl()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.Clear(Color.CornflowerBlue);

            using (Brush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, new Rectangle(x,y,h,w));
            }
            e.Dispose();
        }

        public void Update_RenderControl(int PositionX, int PositionY, int width, int height) 
        {
            x = PositionX;
            y = PositionY;
            w = width;
            h = height;
        }

        private void RenderControl_Load(object sender, EventArgs e)
        {

        }
    }
}
