using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntWorldCSharp
{
    public partial class MainForm : Form
    {
        private Game game1 = new Game();
        private Stopwatch watch = new Stopwatch();


        public MainForm()
        {

            InitializeComponent();
            renderControl.Invalidate();
            game1.PlaygroundSize = new Point(renderControl.Width, renderControl.Height);
            watch.Start();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Eventhandle Window resized
           
            game1.Update(watch.Elapsed);
            renderControl.Update_RenderControl(game1.Position.X, game1.Position.Y,game1.ObjSize.X,game1.ObjSize.Y);
            renderControl.Invalidate();
            watch.Restart();
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DropDownMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void renderControl_Load(object sender, EventArgs e)
        {

        }
    }
}
