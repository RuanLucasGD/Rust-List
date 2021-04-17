using System;
using System.Collections.Generic;

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
            public Node Last { get => last; set => last = value; }
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
                head.Last = head;
            }
            else
            {
                var current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                newNode.Last = current;
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
        /// remove determinado elemento da lista
        /// </summary>
        /// <param name="v">
        /// elemento a ser removido
        /// </param>
        public void Remove(T v)
        {
            if (head == null)
            {
                TreateError("List is empty");
            }

            Node node = head;

            // checando primeiro elemento da lista
            if (Equal(head.Value, v))
            {
                head = head.Next;
                head.Last = head;
            }

            // checando elementos do meio da lista
            while (node.Next != null)
            {
                if (Equal(v, node.Value))
                {
                    node.Last.Next = node.Next;
                    node.Next.Last = node.Last;
                    node = null;
                    return;
                }

                node = node.Next;
            }

            // checando ultimo elemento da lista
            if (Equal(v, node.Value))
            {
                node.Next = null;
                node.Last.Next = null;
                node = null;
            }

            size++;

            bool Equal(T a, T b)
            {
                return EqualityComparer<T>.Default.Equals(a, b);
            }
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