/// <summary>
/// Problem : Big Sorting (HackerRank)
/// Link    : https://www.hackerrank.com/challenges/big-sorting/problem
/// Pattern : Sorting (custom comparer)
/// Time    : O(n log n · L) — L = panjang string
/// Space   : O(log n) — sort in-place
/// Date    : 2026-11-15
///
/// Pseudocode:
///   Angka bisa sampai 10^6 digit, jadi tidak muat di long/BigInteger secara efisien.
///   Bandingkan sebagai string: panjang lebih pendek = angka lebih kecil.
///   Kalau panjangnya sama, bandingkan karakter per karakter (Ordinal).
///
/// Edge case:
///   - angka dengan panjang sama → pakai urutan leksikografis
///   - angka duplikat
/// </summary>

namespace DSA.Problems.Easy.Sorting;

public static class BigSorting
{
    public static List<string> Sort(List<string> unsorted)
    {
     unsorted.Sort((a, b) =>
     {
         if (a.Length != b.Length) 
             return a.Length.CompareTo(b.Length);
         
         return string.Compare(a, b, StringComparison.Ordinal);
     });
     
     return unsorted;
    }
}

