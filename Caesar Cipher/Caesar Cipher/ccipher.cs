using System;
class Ciphercomp
{
    public void Encrypt()
    {
        Console.WriteLine("Enter the string");
        string ptxt = Console.ReadLine(), str = "";
        Console.WriteLine("Enter the offset");
        try
        {
            byte off = byte.Parse(Console.ReadLine());
            if (off <= 25 & off >= 0)
            {
                for (int i = 0; i < ptxt.Length; i++)
                {
                    char ch = ptxt[i];
                    char mx;
                    if (char.IsLetter(ch))
                    {
                        if (char.IsLower(ch))
                        {
                            int lg = ch + off;
                            if (lg <= 122)
                            {
                                mx = (char)lg;
                                str += mx;
                            }
                            else
                            {
                                mx = (char)(lg - 26);
                                str += mx;
                            }
                        }
                        else
                        {
                            int ug = ch + off;
                            if (ug <= 90)
                            {
                                mx = (char)ug;
                                str += mx;
                            }
                            else
                            {
                                mx = (char)(ug - 26);
                                str += mx;
                            }
                        }
                    }
                    else
                    {
                        str += ch;
                    }
                }
                Console.WriteLine("The encrypted statement is " + str);
            }
        }
        catch { Console.WriteLine("Sorry some error ocurred"); }
    }
    public void Decrypt()
    {
        Console.WriteLine("Enter the string");
        string ctxt = Console.ReadLine(), str = "";
        Console.WriteLine("Enter the offset");
        try
        {
            byte off = byte.Parse(Console.ReadLine());
            if (off <=25 & off >= 0)
            {
                for (int i = 0; i < ctxt.Length; i++)
                {
                    char ch = ctxt[i];
                    char mx;
                    if (char.IsLetter(ch))
                    {
                        int lg = ch - off;
                        if (char.IsLower(ch))
                        {
                            if (lg < 97)
                            {
                                mx = (char)(lg + 26);
                                str += mx;
                            }
                            else
                            {
                                int dg = lg;
                                mx = (char)lg;
                                str += mx;
                            }
                        }
                        else
                        {
                            if (lg < 65)
                            {
                                mx = (char)(lg + 26);
                                str += mx;
                            }
                            else
                            {
                                int dg = lg;
                                mx = (char)lg;
                                str += mx;
                            }
                        }
                    }
                    else { str += ch; }
                }
                Console.WriteLine("The decrypted text is " + str);
            }
        }
        catch { Console.WriteLine("Sorry some error ocurred"); }
    }
}
class Mainprog
{
    public static void Main()
    {
        Console.WriteLine("This is a command line Caesar Cipher program");
        Console.WriteLine(@"The commands are:
                            1) e: Encryption
                            2) d: Decryption");
        string enc = "e", dec = "d", br = "";
        Ciphercomp cp = new Ciphercomp();
        for (; ; )
        {
            Console.WriteLine("Enter the command");
            string cmd = Console.ReadLine();
            if (cmd == enc)
            {
                cp.Encrypt();
            }
            else if (cmd == dec)
            {
                cp.Decrypt();
            }
            else if (cmd == br.Trim()) { break; }
        }
    }
}