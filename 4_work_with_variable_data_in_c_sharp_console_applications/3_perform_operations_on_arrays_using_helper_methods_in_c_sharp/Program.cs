string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramSplitted = pangram.Split(' ');

for(int i = 0; i < pangramSplitted.Length; i++)
{
    char[] wordCharArray = pangramSplitted[i].ToCharArray();
    Array.Reverse(wordCharArray);
    pangramSplitted[i] = new string(wordCharArray);
}

string result = String.Join(' ', pangramSplitted);
Console.WriteLine(result);

Console.WriteLine();

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds = orderStream.Split(',');

Array.Sort(orderIds);

for(int i = 0; i < orderIds.Length; i++)
{
    if (orderIds[i].Length != 4)
        orderIds[i] += "\t- Error";

    Console.WriteLine(orderIds[i]);
}