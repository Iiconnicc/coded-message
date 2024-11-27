using coded_message;

Console.WriteLine("please enter your ID(just letters)");
string s = Console.ReadLine();
char[] sender = s.ToArray();

Console.WriteLine("please enter your contact(just letters)");
string r = Console.ReadLine();
char[] reciever = r.ToArray();

sum a1 = new sum();
sum a2 = new sum();

keycal a3 = new keycal();

int finalkey = a3.key(a1.sumf(sender), a2.sumf(reciever));
Console.WriteLine(finalkey);
//for now we just have the key. it could be over 54

string filepath = "C:\\Users\\Iconnic\\Desktop\\message.txt";
string message = File.ReadAllText(filepath);
Console.WriteLine(message);
char[] m2 = message.ToArray();

valuer c1 = new valuer();
int[] numbernonecode =c1.fvaluer(m2);
// Its the text turn into numbers


coder code = new coder();
char [] codedtext = code.fcoder(numbernonecode, finalkey);
Console.WriteLine(codedtext);
string savedtext = new string(codedtext);
Console.WriteLine(savedtext);

string savingpath = "C:\\Users\\Iconnic\\Desktop\\coded.txt";

File.WriteAllText(savingpath, savedtext);
//CODING PROSSESS IS FINISHED!


Console.WriteLine("DECODING TIME!");

string a4=File.ReadAllText(savingpath);
char[] undecoded = a4.ToArray();


decoder adecoder = new decoder();
char [] a5 = adecoder.fdecoder(undecoded, finalkey);
string decoded = new string(a5); //chera .tostring() nmishe estefade kard?
string decodepath = "C:\\Users\\Iconnic\\Desktop\\decoded.txt";
File.WriteAllText(decodepath, decoded);










