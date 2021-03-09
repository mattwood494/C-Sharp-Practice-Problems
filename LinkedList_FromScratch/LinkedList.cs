using System;

namespace LinkedList_FromScratch
{
    public class LinkedList
    {
        public class Node
        {

            private int value1;
            public int value { get => value1; set => value1 = value; }

            private Node next1;
            public Node next { get => next1; set => next1 = value; }

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;
        private Node last { get; set; }
        private int size;


        //Check if empty
        private bool isEmpty()
        {
            return first == null;
        }

        // addFirst
        public void addFirst(int item)
        {
            Node node = new Node(item);

            if(isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }

            size++;

            
        }


        // addLast
        public void addLast(int item)
        {
            Node node = new Node(item);

            if (isEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }

            size++;
        }

        // deleteFirst
        public void deleteFirst()
        {
            if(isEmpty())
            {
                throw new InvalidOperationException();
            }

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var second = first.next;
                first = null;
                first = second;
            }
            

            size--;
        }


        // deleteLast
        public void deleteLast()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException();
            }

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var previous = getPrevious(last);
                last = previous;
                last.next = null;
            }

            size--;
        }

        private Node getPrevious(Node node)
        {
            var current = first;

            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }

        //O(1)
        public int listSize()
        {
            return size;
        }

        

        // contains
        public bool contains(int item)
        {
            return indexOf(item) != -1;
        }

        // indexOf
        public int indexOf(int item)
        {
            int index = 0;
            var current = first;

            while (current != null)
            {
                if (current.value == item)
                {
                    return index;
                }
                else
                {
                    current = current.next;
                    index++;
                }
            }
            return -1;
        }
    }
}
