namespace DoubleLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestClassStudent student1 = new TestClassStudent("Kyrylo", "Bordiuh");
            TestClassStudent student2 = new TestClassStudent("Zakhar", "Trotsenko");
            TestClassStudent student3 = new TestClassStudent("Oleh", "Trotsenko");
            TestClassStudent student4 = new TestClassStudent("Bogdan", "Zbarazhsyi");
            TestClassStudent student5 = new TestClassStudent("John", "Wane");

            Node<TestClassStudent> node1 = new Node<TestClassStudent>(student1);
            Node<TestClassStudent> node2 = new Node<TestClassStudent>(student2);
            Node<TestClassStudent> node3 = new Node<TestClassStudent>(student3);
            Node<TestClassStudent> node4 = new Node<TestClassStudent>(student4);
            Node<TestClassStudent> node5 = new Node<TestClassStudent>(student5);

            DoubleLinkedList<TestClassStudent> list = new DoubleLinkedList<TestClassStudent>();
            list.AddFirst(node1);
            list.AddLast(node2);
            list.AddFirst(node3);
            list.AddLast(node4);
            list.AddFirst(node5);

            list.DeleteFirst();
            list.DeleteLast();
            list.DeleteFirst();
            list.DeleteLast();
            list.DeleteFirst();
            Console.ReadLine();
        }
    }
}