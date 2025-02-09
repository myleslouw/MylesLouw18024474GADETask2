﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_Task_1
{
    class ResourceBuilding : Building
    {
        private string resourceType;
        private string generatedResource;
        private int remainingPool;
        private int generatedPerRound;

        public ResourceBuilding(int x, int y, int health, int maxHealth, string team, string symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.team = team;
            this.symbol = symbol;
        }

        public override int X
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }
        public override int Y
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }
        public override int Health
        {
            get
            {
                return Health;
            }
            set
            {
                Health = value;
            }
        }
        public override string Team
        {
            get
            {
                return Team;
            }
            set
            {
                Team = value;
            }
        }
        public override String Symbol
        {
            get
            {
                return Symbol;
            }
            set
            {
                Symbol = value;
            }
        }


        public override string ToString()
        {
            return symbol + ": [" + x + "," + y + "] " + health + "hp " + generatedResource;
        }
        public override void Death()
        {
            throw new DeathException(this.ToString() + " IS DESTROYED");
        }

        public void generateResources()
        {
            
        }


    }
}