using System;
using System.Collections.Generic;
using System.Text;

namespace buildtree
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Parent { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node(T value, params Node<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();

            foreach (var item in children)
            {
                item.Parent = this;
                Children.Add(item);
            }
        }

    }

}
