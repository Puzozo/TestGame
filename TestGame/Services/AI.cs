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
       
        public AI(int maxPerTurn)
        {
            this.maxPerTurn = maxPerTurn;
        }

        //first limit is (maxPerTurn * 2) + 3
        private int MoreThenFirstLimit()
        {
            return 1;
        }

        //second limit is  maxPerTurn + 1
        private int BetweenFirstAndSecondLimits(int currentSticks)
        {
            if (AISticks % 2 == 0 && currentSticks <= (maxPerTurn * 2) + 3)
            {
                if (currentSticks - maxPerTurn - 3 <= maxPerTurn && currentSticks - maxPerTurn - 3 > 0)
                {
                    AISticks += currentSticks - maxPerTurn - 3;
                    return currentSticks - maxPerTurn - 3;
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
            }
                return 0;
        }

        private int LessThenSecondLimit(int currentSticks)
        {
            if (AISticks % 2 == 1 && currentSticks <= maxPerTurn + 1 && maxPerTurn % 2 == 0)
            {
                int turn = 1;
                while (currentSticks > turn && turn < maxPerTurn - 1)
                {
                    turn += 2;
                }
                if (currentSticks > turn)
                {
                    AISticks += turn;
                    return turn;
                }
                else
                {
                    AISticks += currentSticks;
                    return currentSticks;
                }
            }
            else if (AISticks % 2 == 0 && currentSticks <= maxPerTurn + 1 && maxPerTurn % 2 == 0)
            {
                int turn = 2;
                while (currentSticks > turn && turn < maxPerTurn)
                {
                    turn += 2;
                }
                if (currentSticks > turn)
                {
                    AISticks += turn;
                    return turn;
                }
                else
                {
                    AISticks += currentSticks;
                    return currentSticks;
                }
            }
            else if (AISticks % 2 == 1 && currentSticks <= maxPerTurn + 1 && maxPerTurn % 2 == 1)
            {
                int turn = 1;
                while (currentSticks > turn && turn < maxPerTurn)
                {
                    turn += 2;
                }
                if (currentSticks > turn)
                {
                    AISticks += turn;
                    return turn;
                }
                else
                {
                    AISticks += currentSticks;
                    return currentSticks;
                }
            }
            else if (AISticks % 2 == 0 && currentSticks <= maxPerTurn + 1 && maxPerTurn % 2 == 1)
            {
                int turn = 2;
                while (currentSticks > turn && turn < maxPerTurn - 1)
                {
                    turn += 2;
                }
                if (currentSticks > turn)
                {
                    AISticks += turn;
                    return turn;
                }
                else
                {
                    AISticks += currentSticks;
                    return currentSticks;
                }
            }

            return 0;
        }

        public int AITurn(int currentSticks)
        {
            if (currentSticks > (maxPerTurn * 2) + 3)
            {
                return MoreThenFirstLimit();
            }
            else if (currentSticks <= (maxPerTurn * 2) + 3 && currentSticks > maxPerTurn + 1)
            {
                return BetweenFirstAndSecondLimits(currentSticks);
            }
            else
            {
                return LessThenSecondLimit(currentSticks);
            }                
        }
    }
}
