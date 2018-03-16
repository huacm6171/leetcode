using System;

namespace JudgeCircle
{
    public class Solution 
    {
        public bool JudgeCircle(string moves){
            int iVectical = 0;
            int iHorizontal = 0;
            
            if (moves.Length % 2 != 0)
            {
                return false;
            }
            foreach (var item in moves)
            {
                switch (item)
                {
                    case 'U': 
                    {
                        iVectical += 1;
                        break;
                    }
                    case 'D': 
                    {
                        iVectical -= 1;
                        break;
                    }
                    case 'R': 
                    {
                        iHorizontal += 1;
                        break;
                    }
                    case 'L': 
                    {
                        iHorizontal -= 1;
                        break;
                    }
                    default:break;
                }
            }
            if (iVectical == 0 && iHorizontal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution MySL = new Solution();
            bool bRes = MySL.JudgeCircle("LLRRUUDD");
            if (bRes)
            {
                Console.WriteLine("{0}", "true");
            }
            
        }
    }
}
