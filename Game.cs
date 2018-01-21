using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntWorldCSharp
{
    class Game
    {
        public Point Position { get; set; }

        public Point Velocity { get; set; }

        public Point ObjSize { get; set; }

        public Point PlaygroundSize { get; set; }

        private Ant[] ants = new Ant[2];

        
        public Game()
        {
            ants[0] = new Ant();
            ants[1] = new Ant();

            //for each
            foreach(Ant actual in ants)
            { 
            Position = new Point(actual.Position.X, actual.Position.Y);
            Velocity = new Point(actual.Velocity.X, actual.Velocity.Y);
            ObjSize = new Point(actual.ObjSize.X, actual.ObjSize.Y);
            }

        }

        public void Update(TimeSpan frameTime)
        {
            //for each
            Position = new Point(
                Position.X + (int)(Velocity.X * frameTime.TotalSeconds),
                Position.Y + (int)(Velocity.Y * frameTime.TotalSeconds));

            ObjSize = new Point(
                ObjSize.X,
                ObjSize.Y);

            // Oben abprüfen
            if (Position.Y < 0)
            {
                Velocity = new Point(Velocity.X, -Velocity.Y);
            }
            // Unten abprüfen
            if ((Position.Y + 50) > PlaygroundSize.Y)
            {
                Velocity = new Point(Velocity.X, -Velocity.Y);
            }
            // Links abprüfen
            if (Position.X < 0)
            {
                Velocity = new Point(-Velocity.X, Velocity.Y);
            }
            // Rechts abprüfen
            if ((Position.X + 50) > PlaygroundSize.X)
            {
                Velocity = new Point(-Velocity.X, Velocity.Y);
            }
        }

    }
}


























//if (Position.X < 0)
//{
//    Velocity = new Point(-Velocity.X, Velocity.Y);
//    //Position = new Point(0, Position.Y);
//}
//else if ((Position.X + 50) > PlaygroundSize.X)
//{
//    Velocity = new Point(-Velocity.X, Velocity.Y);
//    //Position = new Point(PlaygroundSize.X, Position.Y-50);
//}

//if (Position.Y< 0) //oben 
//{
//    Velocity = new Point(Velocity.X, -Velocity.Y);
//    //Position = new Point(Position.X, 75);
//}

//if ((Position.Y + 75) > PlaygroundSize.Y) // unten
//{
//    Velocity = new Point(Velocity.X, -Velocity.Y);
//    //Position = new Point(Position.X, PlaygroundSize.Y);
//}