using System;

namespace CSharp_Custom_List
{

    public class List<T>
    {
        private class Node
        {
            private Node next;
            private Node last;

            private T value;

            public Node(T v)
            {
                this.value = v;
            }

            public Node Next { get => next; set => next = value; }
            public Node Last { get => Last; set => Last = value; }
            public T Value { get => value; set => this.value = value; }
        }

        private int size;

        private Node head;

        /// <summary>
        /// Adiciona um novo valor no final da lista
        /// </summary>
        /// <param name="v">
        /// novo valor
        /// </param>
        public void Add(T v)
        {
            var newNode = new Node(v);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }

            size++;
        }

        /// <summary>
        /// Imprime todos os dados da lista
        /// </summary>
        public void ShowData()
        {
            if (head == null)
            {
                return;
            }

            var current = head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public T Get(int index)
        {
            if (head == null)
            {
                TreateError("List is empty");
            }

            int currentIndex = 0;

            Node node = head;

            while (node.Next != null)
            {
                if (currentIndex == index)
                {
                    return node.Value;
                }

                node = node.Next;
                currentIndex++;
            }

            // evita que o ultimo elemento da lista seja ignorado
            // caso o index seja igual ao ultimo elemento
            if (currentIndex == index)
            {
                return node.Value;
            }

            TreateError("Index not exist on this list");

            return default(T);
        }

        /// <summary>
        /// </summary>
        /// <value>
        /// Tamanho da lista
        /// </value>
        public int Size { get => size; }

        private void TreateError(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
            Environment.Exit(-1);
        }
    }
}