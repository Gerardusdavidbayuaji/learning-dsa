// Playground: tempat bebas untuk eksperimen & debugging.
// Jalankan: dotnet run --project src/DSA.Playground

using DSA.Core.DataStructures.Stacks;
using DSA.Problems.Easy;

var stack = new ArrayStack<int>();

Console.WriteLine("== Push 1..5 ==");
for (int i = 1; i <= 5; i++)
{
    stack.Push(i);
    Console.WriteLine($"Push({i}) -> Count = {stack.Count}, Peek = {stack.Peek()}");
}

Console.WriteLine();
Console.WriteLine("== Pop sampai kosong (urutan LIFO) ==");
while (!stack.IsEmpty)
    Console.WriteLine($"Pop() = {stack.Pop()}");

Console.WriteLine();
Console.WriteLine("== P0020 Valid Parentheses ==");
foreach (var s in new[] { "()[]{}", "(]", "{[()]}", "((" })
    Console.WriteLine($"\"{s}\" -> {P0020_ValidParentheses.IsValid(s)}");
