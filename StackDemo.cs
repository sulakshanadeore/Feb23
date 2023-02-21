using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            // WorkingWithStackNonGeneric();

            //WorkingWithQueueNonGeneric();

            Hashtable h = new Hashtable();
            h.Add(1, 100);
            h.Add(2, 100);
            h.Add(3, 100); 
            h.Add(4, 100);
            h.Add(5, 500);
            
            IDictionaryEnumerator item = h.GetEnumerator();

            while (item.MoveNext())
            {
                Console.Write(item.Key + "  " );
                Console.WriteLine(item.Value);
            }


            foreach (DictionaryEntry item1 in h)
            {
                Console.WriteLine(item1.Key  + "   " + item1.Value);
            }



            Console.ReadLine();





        }

        private static void WorkingWithQueueNonGeneric()
        {
            //FIFO---Queue

            Stack s1 = new Stack();
            s1.Push(100);
            s1.Push(200);
            s1.Push(300);


            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(111);
            q.Enqueue("Hello");
            q.Enqueue("J");
            q.Enqueue(3.14f);
            q.Enqueue(new DateTime(2023, 02, 21, 11, 31, 10));


            foreach (var item in q)
            {
                Console.WriteLine(item);
            }


            //object t=q.Dequeue();
            //Console.WriteLine(t);
            //q.Peek();
        }

        private static void WorkingWithStackNonGeneric()
        {
            //LIFO
            Stack s = new Stack(3);
            s.Push(10);
            s.Push(20);
            s.Push("Hello");
            s.Push('B');
            s.Push(new DateTime(2023, 02, 21, 11, 31, 10));

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            object p = s.Peek();//datetime
            Console.WriteLine(p);
            p = s.Pop();
            Console.WriteLine(p);
            int cnt = s.Count;//number of elements on the stack
            //s.ToArray();
            //s.CopyTo()
            bool ans = s.Contains(3.14f);
            Console.WriteLine(ans);
        }
    }
}
