using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericChallenge
{
    public static class GenericMixer
    {

        public static List<T> Mix<T>(List<T> list1, List<T> list2)
        {
            if (list1.Count < list2.Count)
            {
                return GenericMixer.Mix(list2, list1);
            }
            List<T> combinedList = new List<T>();
            int i = 0;
            int j = 0;
            while (i < list1.Count)
            {
                combinedList.Add(list1[i]);
                i++;

                if (j < list2.Count)
                {
                    combinedList.Add(list2[j]);
                    j ++;
                }
            }

            return combinedList;
        }

        

        public static TitleInterface SelectLongerObject<T, U>(T item1, U item2) where T:TitleInterface where U : TitleInterface
        {
            string title1 = item1.Title;
            string title2 = item2.Title;
            if (title1.Length >= title2.Length)
            {
                return item1;
            }
            return item2;
        }
    }
}
