using System;

public class Node {
    public int data;
    public Node next;
    
    public Node(int data) {
        this.data = data;
        this.next = null;
    }
}

public class CircularLinkedList {
    public Node head;
    public Node tail;
    
    public CircularLinkedList() {
        this.head = null;
        this.tail = null;
    }

    public void CreateCircularList(int[] values) {
        foreach (int value in values) {
            Node newNode = new Node(value);

            if (head == null) {
                head = newNode;
                tail = newNode;
            }
            else {
                tail.next = newNode;
                tail = newNode;
            }
        }
        
        if (head != null) {
            tail.next = head;
        }
    }

    public void SwapPairs() {
        if (head == null || head == tail) // Перевірка на порожній список або список з одним елементом
            return;

        Node current = head;
        do {
            int temp = current.data;
            current.data = current.next.data;
            current.next.data = temp;
            current = current.next.next;
        } while (current != head && current.next != head); // Повторювати, поки не повернемося до початку або до передпочаткового елемента
    }

    public void DisplayCircularList() {
        if (head == null) // Перевірка на пустий список
            return;

        Node current = head;
        do {
            Console.Write(current.data + " ");
            current = current.next;
        } while (current != head); // Повторювати, поки не повернемося до початку
        Console.WriteLine();
    }
}

class Program {
    static void Main(string[] args) {
        CircularLinkedList circularList = new CircularLinkedList();
        int[] values = { 1, 2, 3, 4, 5 };
        
        circularList.CreateCircularList(values);
        
        Console.Write("Original List: ");
        circularList.DisplayCircularList();
        
        circularList.SwapPairs();
        
        Console.Write("List after swapping pairs: ");
        circularList.DisplayCircularList();
    }
}
