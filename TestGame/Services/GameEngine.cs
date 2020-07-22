using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class GameEngine
    {
        private int allSticks;
        public int AllSticks 
        {
            get { return allSticks; }
            private set { allSticks = value; }
        }

        private int playerSticks;
        public int PlayerSticks
        {
            get { return playerSticks; }
            private set { playerSticks = value; }
        }

        private int aiSticks;
        public int AISticks
        {
            get { return aiSticks; }
            private set { aiSticks = value; }
        }

        private AI ai;

        public GameEngine(int allSticks, int maxPerTurn)
        {
            this.AllSticks = allSticks;
            PlayerSticks = 0;
            AISticks = 0;
            ai = new AI(maxPerTurn);
        }
        public void Turn(PlayerTypes playerType, int numberOfSticks = 0)
        {
            if (playerType == PlayerTypes.Player)
            {
                AllSticks -= numberOfSticks;
                PlayerSticks += numberOfSticks;
            }
            else
            {
                int aiTurn = ai.AITurn(AllSticks);
                AISticks += aiTurn;
                AllSticks -= aiTurn;  
            }
        }
        public PlayerTypes Winner()
        {
            if (AISticks % 2 == 0 && AllSticks == 0)
            {
                return PlayerTypes.AI;
            }
            else if (PlayerSticks % 2 == 0 && AllSticks == 0)
            {
                return PlayerTypes.Player;
            }

            return PlayerTypes.Undefined;
        }
    }
}
