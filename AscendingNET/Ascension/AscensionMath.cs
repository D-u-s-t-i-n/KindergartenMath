using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ascension
{
    internal class AscensionMath
    {
        public AscensionMath()
        {
            
        }

        internal void GenerateProblem(Global.MathOperators mathOperators, int Level, ref int Number1, ref int Number2, ref int Answer)
        {
            Random random = new Random();
            int iMax1, iMin1, iMax2, iMin2;

            try
            {
                switch (Level)
                {
                    case 1:
                        iMax1 = 10; iMax2 = 10;
                        iMin1 = 1; iMin2 = 1;
                        break; 
                    case 2:
                        iMax1 = 20; iMax2 = 10;
                        iMin1 = 1; iMin2 = 1;
                        break;
                    case 3:
                        iMax1 = 20; iMax2 = 20;
                        iMin1 = 1; iMin2 = 1;
                        break;
                    default:
                        iMax1 = Level * 10; iMax2 = Level * 10;
                        iMin1 = 1; iMin2 = 1;
                        break;
                }

                switch (mathOperators)
                {
                    case Global.MathOperators.Add:
                        Number1 = random.Next(iMin1, iMax1); Number2 = random.Next(iMin2, iMax2); 
                        Answer = Number1 + Number2; break;
                    case Global.MathOperators.Sub:
                        do
                        {
                            Number1 = random.Next(iMin1, iMax1); Number2 = random.Next(iMin2, iMax2);
                            Answer = Number1 - Number2; 
                        } while (Number1 >= Number2) ;
                        break;
                    case Global.MathOperators.Mul:
                        if (Level < 10)
                            iMax2 = 10;
                        Number1 = random.Next(iMin1, Level + 1); Number2 = random.Next(iMin2, iMax2);
                        Answer = Number1 * Number2;
                        break;
                    case Global.MathOperators.Div:
                        Answer = random.Next(iMin1, Level + 1); Number2 = random.Next(iMin2, iMax2);
                        Number1 = Answer * Number2;
                        break;
                    default:
                        throw new Exception("Invalid operator passed");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
