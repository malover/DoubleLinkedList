namespace DoubleLinkedList
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

        public T GetFirst()
        {
            T valueToReturn = default(T);
            if (Length == 0)
            {
                return default(T);
            }
            else if (Length == 1)
            {
                valueToReturn = Head.Value;
                Head = null;
                Length--;
                return valueToReturn;
            }
            else
            {
                valueToReturn = Head.Value;
                Head = Head.Next;
                Head.Previous = null;
                Length--;
                return valueToReturn;
            }
        }

        public T GetLast()
        {
            T valueToReturn = default(T);
            if (Length == 0)
            {
                return default(T);
            }
            else if (Length == 1)
            {
                valueToReturn = Head.Value;
                Head = null;
                Length--;
                return valueToReturn;
            }
            else
            {
                Node<T> currentLast = Head;
                while (currentLast.Next != null)
                {
                    currentLast = currentLast.Next;
                }
                valueToReturn = currentLast.Value;
                Node<T> futureLast = currentLast.Previous;
                futureLast.Next = null;
                Length--;
                return valueToReturn;
            }
        }
    }
}
