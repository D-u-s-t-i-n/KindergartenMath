using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ascension
{
    internal class Profile
    {
    
    }

    internal class Battle
    {
        internal void RewardAnswer(bool bHintUsed, int iLevel, ref int iExp)
        {
            try
            {
                if (bHintUsed)
                    iExp = 1;
                else
                {
                    iExp = 3;
                    iExp *= iLevel;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
