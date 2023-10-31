const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string spanTag = "<span>";
string spanCloseTag = "</span>";

int spanTagIndex = input.IndexOf(spanTag);
int spanTagLength = spanTag.Length;

int spanCloseTagIndex = input.IndexOf(spanCloseTag, spanTagIndex);

int quantityIndex = spanTagIndex + spanTagLength;
int quantityLength = spanCloseTagIndex - quantityIndex;

quantity = input.Substring(quantityIndex, quantityLength);

string divTag = "<div>";
string divCloseTag = "</div>";

int divTagIndex = input.IndexOf(divTag);
int divTagLength = divTag.Length;

output = input.Remove(divTagIndex, divTagLength);

int divCloseTagIndex = output.IndexOf(divCloseTag, divTagIndex);
int divCloseTagLength = divCloseTag.Length;

output = output.Remove(divCloseTagIndex, divCloseTagLength);
output = output.Replace("&trade;", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");