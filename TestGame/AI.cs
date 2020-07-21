using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class AI
    {
        private int  maxPerTurn, AISticks;
       // private bool isAISticksEven;
        public AI(int maxPerTurn)
        {
            this.maxPerTurn = maxPerTurn;
        }
        public int AITurn(int currentSticks)
        {
            //if (currentSticks >= (maxPerTurn + 1) *2 )
            //{
            //    AISticks += maxPerTurn;
            //    return maxPerTurn;
            //}
            //if (currentSticks < maxPerTurn)
            //{
            //    return currentSticks;
            //}
            //else
            //{
            //    return maxPerTurn;
            //}
            if (AISticks % 2 == 0 && currentSticks <= (maxPerTurn * 2) + 3)
            {
                if (currentSticks - maxPerTurn - 3 <= maxPerTurn && currentSticks - maxPerTurn - 3 > 0 )
                {
                    AISticks += currentSticks - maxPerTurn - 3;
                    return currentSticks - maxPerTurn - 3;
                    
                }
                else if(currentSticks>maxPerTurn)
                {
                    AISticks += maxPerTurn;
                    return maxPerTurn;
                    
                }
                else
                {
                    AISticks += currentSticks;
                    return currentSticks;

                }
            }
            else if (AISticks % 2 == 1 && currentSticks <= (maxPerTurn * 2) + 2)
            {
                if (currentSticks - maxPerTurn - 2 <= maxPerTurn && currentSticks - maxPerTurn - 2 > 0)
                {
                    AISticks += currentSticks - maxPerTurn - 3;
                    return currentSticks - maxPerTurn - 2;
                }
                else if (currentSticks > maxPerTurn)
                {
                    AISticks += maxPerTurn;
                    return maxPerTurn;

                }
                else
                {
                    AISticks += currentSticks;
                    return currentSticks;

                }

            }
            else
            {
                AISticks++;
                return 1;
                
            }
            //if (AISticks % 2 == 0 && currentSticks <= (maxPerTurn * 2) + 3)
            //{
            //    return currentSticks - maxPerTurn - 3;
            //}
            //else if (AISticks % 2 == 1 && currentSticks <= (maxPerTurn * 2) + 2)
            //{
            //    return currentSticks - maxPerTurn -2;
            //}
            //else
            //{
            //    return 1;
            //}
        }
    }
}
