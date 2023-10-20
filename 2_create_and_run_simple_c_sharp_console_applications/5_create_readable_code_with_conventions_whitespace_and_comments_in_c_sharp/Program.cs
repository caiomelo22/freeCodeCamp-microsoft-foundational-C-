string message = "The quick brown fox jumps over the lazy dog.";

char[] charArrayMessage = message.ToCharArray();
Array.Reverse(charArrayMessage);

int numOs = 0;

// count the o's
foreach (char i in charArrayMessage) 
{ 
    if (i == 'o') 
    { 
        numOs++; 
    } 
}

string reversedMessage = new String(charArrayMessage);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {numOs} times.");