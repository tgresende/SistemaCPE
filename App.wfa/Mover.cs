using System;
using System.Drawing;
using System.Windows.Forms;


namespace App.wfa
{
    class Mover
    {
        public enum Direction
        {
            Any,
            Horizontal,
            Vertical
        }

        public static void Init(Control control)
        {
            Init(control, Direction.Any);
        }

        public static void Init(Control control, Direction direction)
        {
            Init(control, control, direction);
        }

        public static void Init(Control control, Control container, Direction direction)
        {          
            bool Dragging = false;
            Point DragStart = Point.Empty;
            Point posInicial = Point.Empty;
            control.MouseDown += delegate(object sender, MouseEventArgs e)
            {
                
                Dragging = true;
                DragStart = new Point(e.X, e.Y);
                posInicial = new Point(control.Left, control.Top);
                control.Capture = true;
                
            };
            control.MouseUp += delegate(object sender, MouseEventArgs e)
            {
                Dragging = false;
                if ((control.Left < 425)||(control.Left > 775)||(control.Top < 3)||(control.Top > 336))
                {
                    control.Left = (int)posInicial.X;
                    control.Top  = (int)posInicial.Y;        
                }
                control.Capture = false;
            };
            control.MouseMove += delegate(object sender, MouseEventArgs e)
            {
                if (Dragging)
                {
                    if (direction != Direction.Vertical)
                        container.Left = Math.Max(0, e.X + container.Left - DragStart.X);
                    if (direction != Direction.Horizontal)
                        container.Top = Math.Max(0, e.Y + container.Top - DragStart.Y);
                }
            };
        }
    }
}


