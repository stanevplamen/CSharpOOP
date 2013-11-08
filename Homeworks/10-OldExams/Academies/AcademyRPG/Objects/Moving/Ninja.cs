using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackpoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
        }

        //public bool IsDestroyed
        //{
        //    get
        //    {
        //        return false;
        //    }
        //}

        public int AttackPoints
        {
            get
            {
                return this.attackpoints;
            }
            set
            {
                this.attackpoints = value;
            }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int currentMaxHitPoints = 0;
            int index = -1;

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 && availableTargets[i].HitPoints > currentMaxHitPoints)
                {
                    currentMaxHitPoints = availableTargets[i].HitPoints;
                    index = i;
                }
            }

            return index;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += (resource.Quantity * 2);
                return true;
            }
            else if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += (resource.Quantity * 1);
                return true;
            }

            return false;
        }
    }
}
