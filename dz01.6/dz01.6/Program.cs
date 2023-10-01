string input = "Это:пример!строки";
int length = input.Length;
int halfLength = length / 2;

string firstHalf = input.Substring(0, halfLength);
string secondHalf = input.Substring(halfLength);

firstHalf = firstHalf.Replace(":", "*");
secondHalf = secondHalf.Replace("!", ".");

string result = firstHalf + secondHalf;

Console.WriteLine(result);