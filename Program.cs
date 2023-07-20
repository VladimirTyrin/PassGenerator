using System.Text;

const int passwordLength = 12;
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
