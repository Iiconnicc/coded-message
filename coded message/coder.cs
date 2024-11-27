using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coded_message;
public class valuer
{
    public int[] fvaluer(char[] c ) 
    {
        int[] rez = new int[c.Length];
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] >= 'A' && c[i] <= 'Z')
            {
                rez[i]= (c[i] - 'A' + 1)%52;
            }
            else if (c[i]>= 'a' && c[i]<= 'z')
            {
                rez[i] = (c[i] - 'a' + 27)%52;
            }
            
        }
        return rez;
    }
}

public class coder
{
    public char[] fcoder(int[] input, int key)
    {
        char[] answer = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            int value = (input[i] + key) % 52; 
            if (value <= 26)
            {
                answer[i] = (char)(value + 'A'); 
            }
            else
            {
                answer[i] = (char)(value - 27 + 'a'); 
            }
        }

        return answer;
    }
}
