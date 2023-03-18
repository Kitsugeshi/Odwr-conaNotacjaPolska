using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdwróconaNotacjaPolska
{
    internal sealed class LinkedNode<T>
    {
            internal T Data { get; set; }
            internal LinkedNode<T> Link { get; set; }
            internal LinkedNode(T data = default) => Data = data;
    }
}
