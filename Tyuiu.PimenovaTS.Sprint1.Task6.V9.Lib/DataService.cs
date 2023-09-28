using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PimenovaTS.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] array = new string[] { };
            string s = "жизнь прекрасна";
            string[] st = s.Split(' ');
            for (int i = 0; i < st.Length; ++i)
            {

                st[i] = st[i].Last() + st[i];
                st[i] = st[i].Remove((st[i].Length - 1), 1);
                array[i] = (string) st[i];
            }
            return string.Join("", array);

        }
    }
}
