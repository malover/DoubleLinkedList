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

            DoubleLinkedList<TestClassStudent> list = new DoubleLinkedList<TestClassStudent>();
            list.AddFirst(student1);
            list.AddLast(student2);
            list.AddFirst(student3);
            list.AddLast(student4);
            list.AddFirst(student5);

            Console.WriteLine($"The first value is: {list.GetFirst().FirstName}, the last value is: {list.GetLast().FirstName}");

            list.DeleteFirst();
            list.DeleteLast();
            list.DeleteFirst();
            list.DeleteLast();
            list.DeleteFirst();
            Console.ReadLine();
        }
    }
}