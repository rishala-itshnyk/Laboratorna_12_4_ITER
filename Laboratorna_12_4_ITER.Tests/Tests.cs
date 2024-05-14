namespace Laboratorna_12_4_ITER.Tests;

public class Tests
{
    [Test]
    public void TestSwapPairs()
    {
        CircularLinkedList circularList = new CircularLinkedList();
        int[] values = { 1, 2, 3, 4, 5 };
        int[] expectedAfterSwap = { 2, 1, 4, 3, 5 };

        circularList.CreateCircularList(values);
        circularList.SwapPairs();

        Assert.AreEqual(expectedAfterSwap, GetListValues(circularList));
    }

    private int[] GetListValues(CircularLinkedList list)
    {
        Node current = list.head;
        int[] values = new int[5];
        int index = 0;

        do
        {
            values[index] = current.data;
            current = current.next;
            index++;
        } while (current != list.head);

        return values;
    }
}