using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Solutions
{
    public  class IsValidSudoku
    {

        public bool Solution1(char[,] board)
        {
            Dictionary<char, int> dictCnt = new Dictionary<char, int>();
            bool bRet = true;
            for (int i = 0; i < 9; i++)
            {
                dictCnt.Clear();
                if (!bRet)
                {
                    break;
                }

                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] != '.')
                    {
                        if (dictCnt.ContainsKey(board[i, j]))
                        {
                            bRet = false;
                            break;
                        }
                        else
                            dictCnt.Add(board[i, j], 1);
                    }
                }
            }
            //remove all elements of dict
           
            for (int j = 0; j < 9; j++)
            {
                dictCnt.Clear();
                if (!bRet)
                {
                    break;
                }
                for (int i = 0; i < 9; i++)
                {
                    if (board[i, j] != '.')
                    {
                        if(dictCnt.ContainsKey(board[i, j]))
                        {
                            bRet = false;
                            break;
                        }
                        else
                            dictCnt.Add(board[i, j], 1);
                    }           
                 }
            }

            dictCnt.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (!bRet)
                    break;

                for (int j = 0; j < 3; j++)
                {
                    dictCnt.Clear();
                    if (!bRet)
                        break;
                    for (int n = 0; n < 9; n++)
                    {
                        int x = i * 3 + n%3;
                        int y = j * 3 + n / 3;
                        if (board[x, y] != '.')
                        {
                            if (dictCnt.ContainsKey(board[x, y]))
                            {
                                bRet = false;
                                break;
                            }
                            else
                                dictCnt.Add(board[x, y], 1);
                        }
                  
                    }
                }
            }
            return bRet;
        }
    }
}
