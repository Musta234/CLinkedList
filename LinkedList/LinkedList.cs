using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LinkedList
{
    internal class CLinkedList<T>
    {
        public Node<T> Head {  get; set; }

        public Node<T> Last { get; set; }

        public int Count = 0;

        public CLinkedList()
        {
        }



        public void AddAfter(Node<T> node1, Node<T> node2)
        {
            if (Head == null)
            {
                Console.WriteLine("La lista è vuota");
                return; 
            }

            node2.Next = node1.Next; 

            if (node1 == Last)
            {
                Last = node2; 
            }

            node1.Next = node2;
            Count++;
        }
        public void AddAfter(Node<T> node1, T data)
        {
            Node<T> node2 = new Node<T>(data);
            AddAfter(node1, node2); 
        }

        public void AddBefore(Node<T> node1, Node<T> node2)
        {
            if (Head == null)
            {
                Console.WriteLine("La lista è vuota");
                return; 
            }

            node2.Next = node1;

            if (node1 == Head) 
            {
                Head = node2;
            }
            else
            {
                Node<T> temp = Head;
                while (temp.Next != node1)
                {
                    temp = temp.Next;
                }
                temp.Next = node2; 
            }

            Count++;
        }
        public void AddBefore(Node<T> node1, T data)
        {
            Node<T> node2 = new Node<T>(data);
            AddBefore(node1, node2); 
        }
        public void AddFirst(Node<T> newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            AddFirst(newNode); 
        }

        public void AddLast(Node<T> newNode)
        {
            if (Head == null)
            {
                Head = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            AddLast(newNode); 
        }

        public void Clear()
        {
            Head = null;
            Last = null;
            Count = 0;
        }

        public void Contains(T data)
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                if (object.Equals(temp.Data, data))
                {
                    Console.WriteLine("Esiste");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Non Esiste");
        }

        public void Find(T data)
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                if (object.Equals(temp.Data, data))
                {
                    Console.WriteLine($"Esiste ed è contenuto da: {temp.Data}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Non Esiste");
        }

        public void FindLast(T data)
        {
            Node<T> temp = Head;
            Node<T> lastFound = null;
            while (temp != null)
            {
                if (object.Equals(temp.Data, data))
                {
                    lastFound = temp; 
                }
                temp = temp.Next;
            }
            if (lastFound != null)
            {
                Console.WriteLine($"Esiste ed è contenuto da: {lastFound.Data}");
            }
            else
            {
                Console.WriteLine("Non Esiste");
            }
        }

        public void Remove(Node<T> nodeToRemove)
        {
            if (Head == null)
            {
                Console.WriteLine("La lista è vuota");
                return; 
            }

            Node<T> temp = Head;
            Node<T> previous = null;

            while (temp != null)
            {
                if (temp == nodeToRemove)
                {
                    if (previous == null) 
                    {
                        Head = temp.Next;
                        if (Head == null) Last = null; 
                    }
                    else
                    {
                        previous.Next = temp.Next; 
                        if (temp == Last) Last = previous; 
                    }
                    Count--;
                    Console.WriteLine($"Elemento rimosso: {temp.Data}");
                    return;
                }
                previous = temp;
                temp = temp.Next;
            }
            Console.WriteLine("Non Esiste");
        }

        public void Remove(T data)
        {
            if (Head == null)
            {
                Console.WriteLine("La lista è vuota");
                return; // Aggiunto return qui
            }

            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (object.Equals(current.Data, data))
                {
                    
                    if (previous == null)
                    {
                        Head = current.Next;
                        if (Head == null) Last = null; 
                    }
                    else
                    {
                        previous.Next = current.Next; 
                        if (current == Last) Last = previous; 
                    }
                    Count--;
                    Console.WriteLine($"Elemento rimosso: {current.Data}");
                    return;
                }
                previous = current;
                current = current.Next;
            }
            Console.WriteLine("Non Esiste");
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                Console.WriteLine("La lista è vuota");
                return; 
            }

            Head = Head.Next; 
            if (Head == null) Last = null; 
            Count--;
        }
        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("La lista è vuota");
                return; 
            }

            if (Head == Last) 
            {
                Head = null;
                Last = null;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != Last)
                {
                    current = current.Next;
                }
                current.Next = null; 
                Last = current; 
            }
            Count--;
        }

        public override string ToString()
        {
            if (Head == null) return "La lista è vuota";

            Node<T> current = Head;
            string result = "";
            while (current != null)
            {
                result += current.Data.ToString() + " ; ";
                current = current.Next;
            }
            return result.TrimEnd(' ', ';'); 
        }

    }




    }

