using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{

    public class _501FindModes
    {
        public Dictionary<int, int> resDic = new Dictionary<int, int>();
        public int[] FindMode(TreeNode root)
        {
            List<int> resList = new List<int>();
            if (root == null)
            {
                return resList.ToArray();
            }
            
            if (resDic.ContainsKey(root.val))
            {
                resDic[root.val]++;
            }
            else
                resDic.Add(root.val, 1);
            FindMode(root.left);
            FindMode(root.right);
            //sort by value
            //var resDicSorted = resDic.OrderByDescending(o=>o.Value).ToDictionary(p=>p.Key, o=>o.Value);
            int curCnt = 0;
            foreach (var item in resDic)
            {
                if (curCnt < item.Value)
                {
                    resList.Clear();
                    resList.Add(item.Key);
                    curCnt = item.Value;
                }
                else if (curCnt == item.Value)
                {
                    resList.Add(item.Key);
                }
            }

            return resList.ToArray();
        }
    }
}
