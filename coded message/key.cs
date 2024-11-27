using System.Reflection;
using System.Runtime.InteropServices;

public class keycal
{
    public int key(int reciever , int sender)
    {
        int kkey = reciever * sender / (reciever + sender);
        int fkey = Convert.ToInt32(kkey);
        return fkey;
    }
}



public class sum
{
    int asum = 0;

    int CharToValue(char c)
    {
        if (char.IsLetter(c))
        {
            if (char.IsUpper(c)) return c - 'A' + 1;
            if (char.IsLower(c)) return c - 'a' + 27;
        }
        return 0;
    }
    public int sumf(char[] input)
    {
        foreach (char c in input)
        {
            asum += CharToValue(c);
        }
        return asum;

    }

}
