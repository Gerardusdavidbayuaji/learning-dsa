namespace DSA.Core.DataStructures.Stacks;

/// <summary>
/// Stack (LIFO - Last In, First Out) berbasis array yang bisa membesar otomatis.
/// Diimplementasikan dari nol untuk belajar — di kode produksi pakai System.Collections.Generic.Stack&lt;T&gt;.
/// </summary>
/// <remarks>
/// Kompleksitas:
///   Push  : O(1) amortized (O(n) saat array penuh dan harus di-resize)
///   Pop   : O(1)
///   Peek  : O(1)
///   Space : O(n)
/// </remarks>
public class ArrayStack<T>
{
    private const int DefaultCapacity = 4;

    private T[] _items;
    private int _count; // jumlah elemen sekaligus index slot kosong berikutnya

    public ArrayStack() : this(DefaultCapacity) { }

    public ArrayStack(int capacity)
    {
        if (capacity < 0)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity tidak boleh negatif.");

        _items = new T[capacity];
    }

    public int Count => _count;

    public bool IsEmpty => _count == 0;

    /// <summary>Menambahkan elemen ke puncak stack.</summary>
    public void Push(T item)
    {
        if (_count == _items.Length)
            Resize(_items.Length == 0 ? DefaultCapacity : _items.Length * 2);

        _items[_count] = item;
        _count++;
    }

    /// <summary>Mengambil dan menghapus elemen di puncak stack.</summary>
    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack kosong.");

        _count--;
        T item = _items[_count];
        _items[_count] = default!; // lepas referensi agar bisa di-garbage-collect
        return item;
    }

    /// <summary>Melihat elemen di puncak stack tanpa menghapusnya.</summary>
    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack kosong.");

        return _items[_count - 1];
    }

    public bool TryPop(out T item)
    {
        if (IsEmpty)
        {
            item = default!;
            return false;
        }

        item = Pop();
        return true;
    }

    public void Clear()
    {
        Array.Clear(_items, 0, _count);
        _count = 0;
    }

    private void Resize(int newCapacity)
    {
        var newItems = new T[newCapacity];
        Array.Copy(_items, newItems, _count);
        _items = newItems;
    }
}
