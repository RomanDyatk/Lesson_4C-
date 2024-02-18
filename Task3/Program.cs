string GetLetters(string s)
{
    string letters = "";
    foreach(char w in s)
    {
        if(char.IsAsciiLetter(w) == true)
        {
            letters += w;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);
        
        

        
        

