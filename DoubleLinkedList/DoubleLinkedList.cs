﻿namespace DoubleLinkedList
{
    public class DoubleLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public int Length { get; set; }

        public DoubleLinkedList()
        {
            Head = null;
            Length = 0;
        }

        public DoubleLinkedList(Node<T> headNode)
        {
            Head = headNode;
        }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Head == null)
            {
                Head = node;
                Length++;
                return;
            }
            else
            {
                Node<T> currentNode = Head;
                node.Next = Head;
                currentNode.Previous = node;
                Head = node;
                Length++;
                return;
            }
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Head == null)
            {
                Head = node;
                Length++;
                return;
            }
            else
            {
                Node<T> currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = node;
                node.Previous = currentNode;
                Length++;
                return;
            }
        }

        public void DeleteFirst()
        {
            if (Length == 0)
            {
                return;
            }
            else if (Length == 1)
            {
                Head = null;
                Length--;
                return;
            }
            Head = Head.Next;
            Head.Previous = null;
            Length--;
        }

        public void DeleteLast()
        {
            if (Length == 0)
            {
                return;
            }
            else if (Length == 1)
            {
                Head = null;
                Length--;
                return;
            }

            Node<T> currentLast = Head;
            while (currentLast.Next != null)
            {
                currentLast = currentLast.Next;
            }
            Node<T> futureLast = currentLast.Previous;
            futureLast.Next = null;
            Length--;
        }

        public T GetFirst()
        {
            if (Length == 0)
            {
                return default(T);
            }
            else
            {
                return Head.Value;
            }
        }

        public T GetLast()
        {
            if (Length == 0)
            {
                return default(T);
            }
            else
            {
                Node<T> currentLast = Head;
                while (currentLast.Next != null)
                {
                    currentLast = currentLast.Next;
                }
                return currentLast.Value;
            }
        }
    }
}
