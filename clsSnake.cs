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
        public List<Point> body;
        public int partSize;       
        public enum enDirection { up=1, down=2, left=3, right =4};
        public enDirection direction;

        public clsSnake(int size=20)
        {
            body = new List<Point>();
            partSize = size;
            direction = enDirection.left;
        }

        public void addPart()
        {
            Point p=body[body.Count-1];
            if (direction == enDirection.up || direction == enDirection.down)
                p.Y += partSize;
            else
                p.X += partSize;

            body.Add(p);
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

        public bool isCollision()
        {
            for(int i=0;i<body.Count;i++)
            {
                if(direction==enDirection.up )
                {
                    if (body[0].Y == body[i].Y + partSize)
                        return true;
                }
                else if(direction==enDirection.down)
                {
                    if (body[0].Y + partSize == body[i].Y)
                        return true;
                }
                else if(direction==enDirection.right)
                {
                    if (body[0].X + partSize == body[i].X)
                        return true;
                }
                else
                {
                    if (body[0].X == body[i].X + partSize)
                        return true;
                }
            }
            return false;
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
            if (body[0].X <= x1 || body[0].X >= x2)
                return true;
            if (body[0].Y <= y1 || body[0].Y >= y2)
                return true;

            return false;
        }
    }
}
