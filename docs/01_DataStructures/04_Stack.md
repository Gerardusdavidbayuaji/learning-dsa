# Stack

## Konsep
Stack adalah struktur data **LIFO (Last In, First Out)**: elemen yang terakhir masuk adalah yang pertama keluar.
Analogi: tumpukan piring — kamu hanya bisa menaruh dan mengambil piring dari atas.

```
Push(1), Push(2), Push(3)

   | 3 |  <- top (Peek / Pop mengambil dari sini)
   | 2 |
   | 1 |
   +---+
```

## Operasi & Kompleksitas
| Operasi | Fungsi | Time |
|---|---|---|
| `Push(x)` | Taruh `x` di puncak | O(1) amortized |
| `Pop()` | Ambil & hapus puncak | O(1) |
| `Peek()` | Lihat puncak tanpa menghapus | O(1) |
| `IsEmpty` | Cek kosong | O(1) |

Space: O(n)

**Kenapa Push "amortized" O(1)?** Saat array penuh, kita buat array baru 2x lebih besar dan menyalin semua elemen (O(n)).
Tapi karena kapasitas digandakan, resize jarang terjadi — rata-rata biaya per Push tetap O(1).

## Implementasi
- Kode: `src/DSA.Core/DataStructures/Stacks/ArrayStack.cs`
- Test: `tests/DSA.Core.Tests/DataStructures/ArrayStackTests.cs`

Dua cara umum:
1. **Array-based** (yang dipakai di sini) — cache-friendly, perlu resize.
2. **Linked-list-based** — tidak perlu resize, tapi ada overhead node per elemen.

Di C# produksi: `System.Collections.Generic.Stack<T>`.

## Kapan pakai Stack? (ciri-ciri soal)
- Ada pasangan buka/tutup → kurung, tag HTML
- "Yang terakhir dibuka harus ditutup duluan"
- Undo/redo, tombol back di browser
- Evaluasi ekspresi (postfix/infix)
- DFS iteratif (pengganti rekursi)
- **Monotonic stack**: "next greater element", "daily temperatures"

## Soal latihan
- [x] 20. Valid Parentheses (Easy) → `src/DSA.Problems/Easy/P0020_ValidParentheses.cs`
- [ ] 155. Min Stack (Medium)
- [ ] 150. Evaluate Reverse Polish Notation (Medium)
- [ ] 739. Daily Temperatures (Medium) — monotonic stack
- [ ] 84. Largest Rectangle in Histogram (Hard)

## Jebakan umum
- Pop/Peek saat stack kosong → selalu cek `IsEmpty` dulu
- Lupa cek stack masih berisi di akhir (contoh: `"(("`)
