using DSA.Core.DataStructures.Stacks;

namespace DSA.Core.Tests.DataStructures;

public class ArrayStackTests
{
    [Fact]
    public void NewStack_IsEmpty()
    {
        var stack = new ArrayStack<int>();

        Assert.True(stack.IsEmpty);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Push_ThenPop_ReturnsItemsInLifoOrder()
    {
        var stack = new ArrayStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.Equal(3, stack.Pop());
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
        Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void Peek_ReturnsTopWithoutRemoving()
    {
        var stack = new ArrayStack<string>();
        stack.Push("a");
        stack.Push("b");

        Assert.Equal("b", stack.Peek());
        Assert.Equal(2, stack.Count);
    }

    [Fact]
    public void Pop_OnEmptyStack_Throws()
    {
        var stack = new ArrayStack<int>();

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Peek_OnEmptyStack_Throws()
    {
        var stack = new ArrayStack<int>();

        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    [Fact]
    public void TryPop_OnEmptyStack_ReturnsFalse()
    {
        var stack = new ArrayStack<int>();

        Assert.False(stack.TryPop(out _));
    }

    [Fact]
    public void Push_BeyondInitialCapacity_GrowsAutomatically()
    {
        var stack = new ArrayStack<int>(capacity: 2);

        for (int i = 0; i < 100; i++)
            stack.Push(i);

        Assert.Equal(100, stack.Count);
        Assert.Equal(99, stack.Peek());
    }

    [Fact]
    public void ZeroCapacity_StillAcceptsPush()
    {
        var stack = new ArrayStack<int>(capacity: 0);
        stack.Push(42);

        Assert.Equal(42, stack.Pop());
    }

    [Fact]
    public void NegativeCapacity_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ArrayStack<int>(-1));
    }

    [Fact]
    public void Clear_RemovesAllItems()
    {
        var stack = new ArrayStack<int>();
        stack.Push(1);
        stack.Push(2);

        stack.Clear();

        Assert.True(stack.IsEmpty);
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }
}
