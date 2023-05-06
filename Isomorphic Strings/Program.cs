namespace Isomorphic_Strings
{
    internal class Program
    {
                /*
                1 <= s.length <= 5 * 104
        t.length == s.length*/
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length >= 1 || s.Length <= 10000)
            {
                if (s.Length == t.Length)
                {
                    int[] arr1=new int[s.Length];
                    int[] Counterarr1 = new int[s.Length] ;
                    
                    for (int i = 0; i < s.Length; i++)
                    {
                        Counterarr1[i] = i;
                        for (int j = 0; j < s.Length   ; j++)
                        {
                            if(j > i)
                            {
                                if (s[i] == s[j])
                                {
                                    arr1[i] = i;
                                    arr1[j] = j;
                                    Counterarr1[i]++;
                                }
                            }
                            
                        } 
                    }

                    int[] arr2 = new int[s.Length];
                    int[] Counterarr2 = new int[s.Length];

                    for (int i = 0; i < s.Length; i++)
                    {
                        Counterarr2[i] = i;

                        for (int j = 0; j < s.Length; j++)
                        {
                            if (j > i)
                            {
                                if (t[i] == t[j])
                                {
                                    arr2[i] = i;
                                    arr2[j] = j;
                                    Counterarr2[i]++;
                                }
                            }

                        }
                    }
                    bool areEqual = arr1.SequenceEqual(arr2);
                    bool areEqual2 = Counterarr1.SequenceEqual(Counterarr2);
                    return areEqual && areEqual2;
                }
            }
            return false;
            /*Another Solution found online
                     Dictionary<char,char> isoList=new Dictionary<char,char>();
                    for(int i=0;i<s.Length;i++)
                    {
                        if(isoList.ContainsKey(s[i]))
                        {
                            if(isoList[s[i]]!=t[i])
                                return false;
                        }
                        else
                        {
                            if(isoList.ContainsValue(t[i]))
                                return false;
                            isoList.Add(s[i],t[i]);
                        }
                    }
                    return true;
             */

        }
        static void Main(string[] args)
        {
            bool x = IsIsomorphic("aaeaa", "uuxyy");
            Console.WriteLine(x);
        }
    }
}