using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrations {
    public class LinkedListDemo : IDemonstration {
        public void Run() {
            var zaChain = new LinkedList<Person>();
            var takeshi = new Person("Takeshi69", 72);

            zaChain.Append(takeshi);
            zaChain.Append(new Person("DonaldJGrump", 2));
            zaChain.Append(new Person("GrubbyMcGee", 12));
            zaChain.Append(new Person("Ronald Macdonald", 25));
            zaChain = new LinkedList<Person>();
            zaChain.Print();

            var node = zaChain.Get(new Person());
            if(node is not null)
                Console.WriteLine(node.Data.Name + " " + node.Data.Age);
        }
    }

    public class Node<T> {
        public T Data {
            get; set;
        }
        public Node<T> Next {
            get; set;
        }

        public Node(T data) {
            Data = data;
            Next = null;
        }
    }
    public class LinkedList<T> {
        public Node<T> Head {
            get; private set;
        }

        public Node<T> Get(T obj) {
            if(Head is null)
                return default;

            Node<T> Current = Head;

            while(Current.Next is not null) {
                if(Current.Data.Equals(obj)) {
                    return Current;
                }

                Current = Current.Next;
            }

            return default;
        }
        // Add a new node to the end of the list
        public void Append(T data) {
            if(Head == null) {
                Head = new Node<T>(data);
                return;
            }

            Node<T> current = Head;
            while(current.Next != null) {
                current = current.Next;
            }
            current.Next = new Node<T>(data);
        }

        // Add a new node to the start of the list
        public void Prepend(T data) {
            Node<T> newNode = new Node<T>(data) {
                Next = Head
            };
            Head = newNode;
        }

        // Remove a node with the given data from the list
        public void Remove(T data) {
            if(Head == null)
                return;

            if(Head.Data.Equals(data)) {
                Head = Head.Next;
                return;
            }

            Node<T> current = Head;
            while(current.Next != null && !current.Next.Data.Equals(data)) {
                current = current.Next;
            }

            if(current.Next != null) {
                current.Next = current.Next.Next;
            }
        }

        // Print the linked list
        public void Print() {
            Node<T> current = Head;
            while(current != null) {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

    // Sample classes for demonstration
    public class Person {
        public Person() {

        }
        public Person(string? name, int age) {
            Name = name;
            Age = age;
        }
        public string? Name {
            get; set;
        }
        public int Age {
            get; set;
        }
    }
}
