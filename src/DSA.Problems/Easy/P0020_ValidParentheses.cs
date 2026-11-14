using DSA.Core.DataStructures.Stacks;

namespace DSA.Problems.Easy;

/// <summary>
/// Problem : 20. Valid Parentheses
/// Link    : https://leetcode.com/problems/valid-parentheses/
/// Pattern : Stack
/// Time    : O(n)  — setiap karakter diproses sekali
/// Space   : O(n)  — worst case semua karakter adalah kurung buka
/// Date    : 2026-11-14
///
/// Ide:
///   Kurung buka di-Push. Saat ketemu kurung tutup, Pop dan cek apakah pasangannya cocok.
///   Kurung yang dibuka terakhir harus ditutup pertama — persis sifat LIFO stack.
///
/// Edge case:
///   - string kosong → valid
///   - kurung tutup muncul saat stack kosong → tidak valid  (contoh: ")")
///   - sisa kurung buka di akhir → tidak valid             (contoh: "((")
/// </summary>
public static class P0020_ValidParentheses
{
    public static bool IsValid(string s)
    {
        var stack = new ArrayStack<char>();

        foreach (char c in s)
        {
            if (c is '(' or '[' or '{')
            {
                stack.Push(c);
                continue;
            }

            if (!stack.TryPop(out char open))
                return false;

            bool matches = (open, c) is ('(', ')') or ('[', ']') or ('{', '}');
            if (!matches)
                return false;
        }

        return stack.IsEmpty;
    }
}
