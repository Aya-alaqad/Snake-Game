using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Game
{
    internal class clsSnake
    {
        private List<Point> _body;
        private int _partSize;       
        public enum enDirection { up=1, down=2, left=3, right =4};
        private enDirection _direction;

        public List<Point> body { get => _body; }
        public int partSize { get => _partSize; }
        public enDirection direction { get => _direction; set => _direction = value; }


        public clsSnake(int size=20)
        {
            _body = new List<Point>();
            _partSize = size;
            _direction = enDirection.left;
        }

        public void addPart()
        {
            Point p=body[body.Count-1];
            if (body.Count < 2)
            {
                if (direction == enDirection.up)
                    p.Y += partSize;
                else if (direction == enDirection.down)
                    p.Y -= partSize;
                else if (direction == enDirection.right)
                    p.X -= partSize;
                else
                    p.X += partSize;
            }

            else
            {
                Point p2 = new Point();
                p2 = body[body.Count - 2];
                if (p.Y == p2.Y)
                {
                    if (p.X > p2.X)
                        p.X += partSize;
                    else
                        p.X -= partSize;
                }
                else if (p.X == p2.X)
                {
                    if (p.Y > p2.Y)
                        p.Y += partSize;
                    else
                        p.Y -= partSize;
                }
            }
            body.Add(p);
        }

        public bool isThereCollission()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0] == body[i])
                    return true;
            }
            return false;
        }
        public void move()
        {
            Point p = body[0];
            if(direction==enDirection.up)
            {
                p.Y -= partSize;
            }
            else if(direction==enDirection.down)
            {
                p.Y += partSize;
            }
            else if(direction==enDirection.right)
            {
                p.X += partSize;
            }
            else
            {
                p.X -= partSize;
            }
            
            body.Insert(0, p);

            body.RemoveAt(body.Count - 1);
          
        }

     
        public bool isFoodHitted(Point food,int foodSize)
        {
            if(direction==enDirection.up || direction==enDirection.down)
            {
                if (body[0].X >= food.X && body[0].X <= food.X + foodSize || body[0].X + partSize >= food.X && body[0].X + partSize <= food.X + partSize)
                {
                    if (direction == enDirection.up)
                        return (body[0].Y >= food.Y && body[0].Y <= food.Y + foodSize);
                    else
                        return (body[0].Y + partSize >= food.Y && body[0].Y + partSize <= food.Y + foodSize);
                }
                else
                    return false;
            }
            else
            {
                if (body[0].Y >= food.Y && body[0].Y <= food.Y + foodSize || body[0].Y + partSize >= food.Y && body[0].Y + partSize <= food.Y + partSize)
                {
                    if(direction==enDirection.right)
                        return (body[0].X+partSize>= food.X && body[0].X<=food.X + foodSize);
                    else 
                        return (body[0].X>=food.X && body[0].X <=food.X + foodSize);
                }
                else
                    return false;
            }
        }

        public bool isSnakeBreakBoundries(int x1, int x2,int y1, int y2)
        {
            if (body[0].X <= x1 || body[0].X+partSize >= x2)
                return true;
            if (body[0].Y <= y1 || body[0].Y+partSize >= y2)
                return true;

            return false;
        }
    }
}
