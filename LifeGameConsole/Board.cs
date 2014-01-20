using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGameConsole
{
    public class Board
    {


        const int ySize = 10;
        const int xSize = 10;

        int[,] currentBoard;
        public Board()
        {

            currentBoard = new int[ySize,xSize]{
                {0,0,0,0,1,1,1,0,1,0},
                {1,1,1,0,1,0,1,1,1,1},
                {0,0,0,0,1,0,1,0,1,1},
                {0,0,0,0,1,1,1,0,1,0},
                {1,0,0,1,1,0,0,1,1,1},
                {0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0},
                {0,1,1,0,0,0,0,1,0,0},
                {0,0,1,0,0,0,1,1,1,0},
                {0,0,0,0,0,0,0,0,0,0}};
        

            
        }

        public void Update()
        {
            int[,] nBoard = new int[ySize,xSize];
            for(int y=0;y<ySize;y++)
                for(int x=0;x<xSize;x++)
                {
                    nBoard[y, x] = NumNeibors(x, y);
                    
                }
            for(int y=0;y<ySize;y++)
                for(int x=0;x<xSize;x++)
                {
                    if(currentBoard[y,x]==0&& nBoard[y,x]==3)
                        currentBoard[y,x] =1;
                    if(currentBoard[y,x]==1 && (nBoard[y,x] ==2 || nBoard[y,x]==3))
                        currentBoard [y,x] =1;
                    if(currentBoard[y,x]==1 && (nBoard[y,x]>=4 || nBoard[y,x]<=1))
                        currentBoard[y,x] =0;
                }

        }

        public void Draw()
        {
            StringBuilder st = new StringBuilder();
            for(int y= 0;y<ySize;y++)
            {
                for(int x =0;x<xSize;x++)
                {
                    if (currentBoard[y, x] == 1)
                        st.Append("B");
                    else if (currentBoard[y, x] == 0)
                        st.Append(".");
                }
                st.Append("\n");
            }
            Console.WriteLine(st.ToString());
        }

        public int NumNeibors(int x,int y)
        {
            int sum = 0;
            for(int dy=-1;dy<=1;dy++)
                for (int dx = -1; dx <= 1; dx++)
                {
                    if (x == 0 && dx == -1)
                        continue;
                    if (x == xSize - 1 && dx == 1)
                        continue;
                    if (y == 0 && dy == -1)
                        continue;
                    if (y == ySize-1 && dy == 1)
                        continue;
                    if (dx == 0 && dy == 0)
                        continue;
                    sum += currentBoard[y + dy, x + dx];
                }

               return sum;
        }

    }
}
