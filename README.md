# Learning DSA (C#)

Repo belajar Data Structures & Algorithms menggunakan C# / .NET 9.

## Struktur
| Folder | Isi |
|---|---|
| `docs/` | Catatan teori per topik (markdown), cheatsheet, mistakes log |
| `src/DSA.Core/` | Implementasi struktur data & algoritma dari nol |
| `src/DSA.Problems/` | Solusi soal latihan (LeetCode, dll) per tingkat kesulitan |
| `src/DSA.Playground/` | Console app untuk eksperimen |
| `tests/` | Unit test (xUnit) untuk Core & Problems |

## Perintah
```bash
dotnet build                                  # build semua project
dotnet test                                   # jalankan semua test
dotnet test --filter "FullyQualifiedName~Stack"   # test topik tertentu
dotnet run --project src/DSA.Playground       # jalankan playground
```

## Alur belajar per topik
1. Pelajari teori → tulis di `docs/`
2. Implementasi dari nol di `src/DSA.Core/`
3. Tulis test di `tests/DSA.Core.Tests/` → `dotnet test`
4. Kerjakan 3–5 soal terkait di `src/DSA.Problems/` (+ test)
5. Catat kesalahan di `docs/mistakes_log.md`

## Konvensi
- File soal: `P{nomor 4 digit}_{NamaSoal}.cs` → `P0020_ValidParentheses.cs`
- Header setiap soal: Problem, Link, Pattern, Time, Space, Date (lihat `docs/problem_template.cs.txt`)
- Folder kode pakai PascalCase tanpa angka (namespace C# tidak boleh diawali angka)

## Roadmap & Progress

### 0. Fundamentals
- [ ] Big-O notation
- [ ] Recursion
- [ ] Bit manipulation

### 1. Data Structures
- [ ] Arrays (dynamic array)
- [ ] Strings
- [ ] Linked List
- [x] Stack ← contoh lengkap
- [ ] Queue / Deque
- [ ] Hash Table
- [ ] Tree / BST
- [ ] Heap / Priority Queue
- [ ] Trie
- [ ] Graph
- [ ] Union Find

### 2. Algorithms
- [ ] Sorting
- [ ] Binary Search
- [ ] Two Pointers
- [ ] Sliding Window
- [ ] Prefix Sum
- [ ] Backtracking
- [ ] Greedy
- [ ] Divide and Conquer
- [ ] Graph Algorithms (BFS, DFS, Dijkstra, Topo Sort, MST)
- [ ] Dynamic Programming

## Statistik soal
| Easy | Medium | Hard | Total |
|---|---|---|---|
| 1 | 0 | 0 | 1 |
