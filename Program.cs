using System.Text;

var passwordLength = args.Length > 1 && int.TryParse(args[1], out var length) && length > 0
    ? length
    : 12;
var random = new Random();

var chars = new List<char>();
for (var i = 'a'; i <= 'z'; ++i)
    chars.Add(i);
for (var i = 'A'; i <= 'Z'; ++i)
    chars.Add(i);
for (var i = '0'; i <= '9'; ++i)
    chars.Add(i);

var passBuilder = new StringBuilder();
for (var i = 0; i < passwordLength; i++)
{
    passBuilder.Append(chars[random.Next(chars.Count)]);
}

Console.WriteLine(passBuilder.ToString());