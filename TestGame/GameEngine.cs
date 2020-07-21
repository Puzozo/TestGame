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
        
        public GameEngine(int allSticks)
        {
            this.AllSticks = allSticks;
            PlayerSticks = 0;
            AISticks = 0;
        }
        public void Turn(PlayerTypes playerType, int numberOfSticks)
        {
            if (playerType == PlayerTypes.Player)
            {
                AllSticks -= numberOfSticks;
                PlayerSticks += numberOfSticks;
            }
            else
            {
                AllSticks -= numberOfSticks;
                AISticks += numberOfSticks;
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
