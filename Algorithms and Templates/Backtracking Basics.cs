using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    class Permutation1
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {
            generate(nums, new List<int>());
            return res;
        }
        public void generate(int[] nums, List<int> temp)
        {
            if (temp.Count == nums.Length)
            {
                res.Add(temp.ToList());
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (temp.Contains(nums[i]))
                        continue;

                    temp.Add(nums[i]);
                    generate(nums, temp);
                    temp.Remove(temp.Last());
                }
            }
        }
    }
    class Permutation2
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            generate(nums, new List<int>(), new bool[nums.Length]);
            return res;
        }
        public void generate(int[] nums, List<int> temp, bool[] used)
        {
            if (temp.Count == nums.Length)
            {
                res.Add(temp.ToList());
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                if (used[i])
                {
                    continue;
                }
                else if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                {
                    continue;
                }

                temp.Add(nums[i]);
                used[i] = true;
                generate(nums, temp, used);
                used[i] = false;
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }

    class Subset1
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            Array.Sort(nums);
            generate(nums, new List<int>(), 0);
            return res;
        }
        public void generate(int[] nums, List<int> temp, int start)
        {
            res.Add(temp.ToList());
            for (int i = start; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                generate(nums, temp, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
    class Subsets2
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            generate(nums, new List<int>(), 0);
            return res;
        }
        public void generate(int[] nums, List<int> temp, int start)
        {
            res.Add(temp.ToList());
            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                    continue;

                temp.Add(nums[i]);
                generate(nums, temp, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }

    class Combination1
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> CombinationSum(int[] nums, int target)
        {
            Array.Sort(nums);
            generate(nums, new List<int>(), target, 0);
            return res;
        }
        public void generate(int[] nums, List<int> temp, int remain, int start)
        {
            if (remain < 0)
            {
                return;
            }
            else if (remain == 0)
            {
                res.Add(temp.ToList());
            }


            for (int i = start; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                generate(nums, temp, remain - nums[i], i);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
    class Combination2
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] nums, int target)
        {
            Array.Sort(nums);
            generate(nums, new List<int>(), target, 0);
            return res;
        }
        public void generate(int[] nums, List<int> temp, int remain, int start)
        {
            if (remain < 0)
            {
                return;
            }
            else if (remain == 0)
            {
                res.Add(temp.ToList());
            }


            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1])
                    continue;

                temp.Add(nums[i]);
                generate(nums, temp, remain - nums[i], i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
