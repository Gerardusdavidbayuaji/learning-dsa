# Cheatsheet

## Kompleksitas struktur data
| Struktur | Access | Search | Insert | Delete |
|---|---|---|---|---|
| Array | O(1) | O(n) | O(n) | O(n) |
| Dynamic Array (append) | O(1) | O(n) | O(1)* | O(n) |
| Linked List | O(n) | O(n) | O(1)** | O(1)** |
| Stack | O(n) | O(n) | O(1) | O(1) |
| Queue | O(n) | O(n) | O(1) | O(1) |
| Hash Table | – | O(1)* | O(1)* | O(1)* |
| BST (balanced) | O(log n) | O(log n) | O(log n) | O(log n) |
| Heap | O(1) top | O(n) | O(log n) | O(log n) |

\* amortized / average  ·  \** jika node sudah diketahui

## Padanan di .NET
| Konsep | C# |
|---|---|
| Dynamic array | `List<T>` |
| Stack | `Stack<T>` |
| Queue | `Queue<T>` |
| Deque | `LinkedList<T>` |
| Hash map / set | `Dictionary<K,V>` / `HashSet<T>` |
| Sorted map / set | `SortedDictionary<K,V>` / `SortedSet<T>` |
| Priority queue | `PriorityQueue<TElement,TPriority>` (min-heap) |

## Pattern → ciri soal
| Pattern | Ciri |
|---|---|
| Stack | pasangan buka/tutup, "next greater" |
| (isi seiring belajar) | |
