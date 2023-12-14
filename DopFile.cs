using System;
using System.Collections;
using System.Collections.Generic;

namespace Zadacha
{
    public static class Zadacha
    {
        public static void Main()
        {
            int n = 3; 
            Dictionary<string, Dictionary<string, string>> dict = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> authorYears = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                
                authorYears[str.Split(' ')[1]] = str.Split(' ')[2];
                dict.Add(str.Split(' ')[0], authorYears);
            }

            Dictionary<string, Dictionary <string, string>> result = NewDictionary(dict);            

            foreach (var a in dict)
            {
                foreach (var d in a.Value)
                    Console.WriteLine(a.Key + " : " + d.Key + ". " + d.Value);
            }
        }
        public static Dictionary<string, Dictionary<string, string>> NewDictionary(Dictionary<string, Dictionary<string, string>> dict)
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();
            foreach (var title in dict)
            {
                foreach (var author in title.Value)
                {
                    if (result.ContainsKey(author.Key))
                        result[author.Key].Add(title.Key, author.Value);
                    else
                    {
                        Dictionary<string, string> p = new Dictionary<string, string>();
                        p[title.Key] = author.Value;
                        result[author.Key] = p;
                    }    
                }
            }
            return result;
        }
    }
}