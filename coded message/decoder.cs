using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coded_message;

public class decoder
{
    public char[] fdecoder(char[] input, int key)
    {
        char[] answer = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                int value = ((input[i]-('A'+1))-key+52)%52;
                answer[i] = (char)value;
                }
                else
                {
                int value = (input[i] - 'a' + 27) - key - 27 +'a';
                    answer[i] =(char) value;
                }
        }
        return answer;
    }
}
