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
    class Ant
    {
        static Random random = new Random();

        public Point Position { get; set; }

        public Point Velocity { get; set; }

        public Point ObjSize { get; set; }

        public Ant()
        {
            Position = new Point(200, 200);                                                // Position X & Y
            
            Velocity = new Point((random.Next(50, 250)), (random.Next(50, 250)));        // Velocity = Geschwindigkeit X & Y

            ObjSize = new Point(50, 50);                                                 // Größe des Objekts X & Y
        }

    }
}