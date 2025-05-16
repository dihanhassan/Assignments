using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumLib
{
   public  class TwoSumSolve
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int now = target - nums[i];
                if (dic.ContainsKey(now))
                    return new[] { dic[now], i };
                dic[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }
}
