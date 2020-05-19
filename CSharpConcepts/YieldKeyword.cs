using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class YieldKeyword
    {
        public void start()
        {
            IList<int> lst = new List<int>();
            CreateList(lst);

            foreach (var item in GetNextItem(lst))
            {
                Console.WriteLine(item);
            }

            // Real advantage of Yield is that is allows deferred execution
            // Here, we will create the collection on need basis..

            // lstAbc has full list of 5 items, but lstYieldAbc
            // has deferred execution and will be created on need basis

            var lstAbc = GenerateListWithoutYield();
            var lstYieldAbc = GenerateListWithYield();

            foreach (var item in lstYieldAbc)
                Console.WriteLine(item);
        }

        private IEnumerable<int> GenerateListWithoutYield()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }

        private IEnumerable<int> GenerateListWithYield()
        {
            for (int i=0; i<5; i++)
            {
                yield return i;
            }
        }

        private IEnumerable<int> GetNextItem(IList<int> lst)
        {
            foreach (var item in lst)
            {
                yield return item;
            }
        }

        private void CreateList(IList<int> lst)
        {
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
        }
    }
}
