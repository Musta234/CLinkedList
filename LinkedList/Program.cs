using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLinkedList<int> linkedList = new CLinkedList<int>();
          
            linkedList.AddFirst(10); 
            linkedList.AddLast(20);  
            linkedList.AddLast(30);   
            linkedList.AddFirst(5);   
          
            Console.WriteLine("Lista attuale: " + linkedList.ToString());
           
            Node<int> node10 = linkedList.Head.Next; 
            linkedList.AddAfter(node10, 15);        
            Console.WriteLine("Dopo aver aggiunto 15 dopo 10: " + linkedList.ToString());
           
            Node<int> node20 = node10.Next.Next;    
            linkedList.AddBefore(node20, 18);        
            Console.WriteLine("Dopo aver aggiunto 18 prima di 20: " + linkedList.ToString());
           
            linkedList.Contains(15);  
           
            linkedList.Find(20);      
            
            linkedList.AddLast(30);   
            linkedList.FindLast(30);  
           
            linkedList.RemoveFirst();
            Console.WriteLine("Dopo aver rimosso il primo elemento: " + linkedList.ToString());
          
            linkedList.RemoveLast();
            Console.WriteLine("Dopo aver rimosso l'ultimo elemento: " + linkedList.ToString());
           
            linkedList.Clear();
            Console.WriteLine("Dopo aver svuotato la lista: " + linkedList.ToString());
            Console.ReadKey();
        }
    }
}
    

