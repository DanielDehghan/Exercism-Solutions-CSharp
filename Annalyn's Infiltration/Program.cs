using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annalyn_s_Infiltration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool knightIsAwake = true;
            var res = QuestLogic.CanFastAttack(knightIsAwake);
        }


      
    }

    public class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake)
            {
                //Cannot execute fast attack if knight is awake
                return false;
            }
            else
            {
                //Can execute fast attack if knight is sleeping
                return true;
            }
        }

        public static bool CanSpy (bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == false)
            {
                return false;
            }     
           else if(knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == false)
            {
                return true;
            }
            else if (knightIsAwake == false && archerIsAwake == true && prisonerIsAwake == false)
            {
                return true;
            }
            else if (knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else if (knightIsAwake == false && archerIsAwake == true && prisonerIsAwake == true)
            {
                return true;
            }
            else if (knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }
            else if (knightIsAwake == true && archerIsAwake == true && prisonerIsAwake == false)
            {
                return true;
            }
            else if (knightIsAwake == true && archerIsAwake == true && prisonerIsAwake == true)
            {
                return true;
            }
            return true;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if(!archerIsAwake && prisonerIsAwake)
            {
                return true;
            }
            else if (archerIsAwake && !prisonerIsAwake)
            {
                return false;
            }
            else if (!archerIsAwake && !prisonerIsAwake)
            {
                return false;
            }else if(archerIsAwake && prisonerIsAwake)
            {
                return false;
            }

            return false;
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if(knightIsAwake && archerIsAwake && prisonerIsAwake && petDogIsPresent)
            {
                return false;
            }
            else if (knightIsAwake && archerIsAwake && prisonerIsAwake && !petDogIsPresent)
            {
                return false;
            }
            else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
            {
                return true;
            }

             if(!knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
            {
                return true;
            }

             if(knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent)
            {
                return false;
            }

            if (knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
            {
                return true;
            }


             if(!archerIsAwake && !knightIsAwake && prisonerIsAwake && !petDogIsPresent)
            {
                return true;
            }

             if(!archerIsAwake && !prisonerIsAwake && knightIsAwake && petDogIsPresent)
            {
                return true;
            }

             if(prisonerIsAwake && knightIsAwake && !archerIsAwake && petDogIsPresent)
            {
                return true;
            }

            return false;
        }
    }
}
