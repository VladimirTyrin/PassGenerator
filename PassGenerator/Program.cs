using System;
using System.Collections.Generic;
using System.Text;

namespace PassGenerator
{
    internal static class Program
    {
        private const int PasswordLength = 12;
        private static readonly Random Random = new Random();

        private static T PickRandom<T>(this IReadOnlyList<T> list) => list[Random.Next(list.Count)];

        private static void Main()
        {
            var chars = new List<char>();
            for (var i = 'a'; i <= 'z'; ++i)
                chars.Add(i);
            for (var i = 'A'; i <= 'Z'; ++i)
                chars.Add(i);
            for (var i = '0'; i <= '9'; ++i)
                chars.Add(i);

            var passBuilder = new StringBuilder();
            for (var i = 0; i < PasswordLength; i++)
            {
                passBuilder.Append(chars.PickRandom());
            }

            var pass = passBuilder.ToString();
            Console.WriteLine(pass);
        }
    }
}
