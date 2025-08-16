using System.Collections;

namespace DataStructures.Collections;

public class Collection : CollectionBase
{
    // método de adicionar no ArrayList
    public void Add(Object item)
    {
        InnerList.Add(item);
    }

    // metodo de remover no ArrayList
    public void Remove(Object item)
    {
        InnerList.Remove(item);
    }

    public void Insert(int index, Object item)
    {
        InnerList.Insert(index, item);
    }

    public bool Contains(Object item)
    {
        var contains = InnerList.Contains(item);
        return contains;
    }

    public int IndexOf(Object item)
    {
        var index = InnerList.IndexOf(item);
        return index;
    }
    
    public new void RemoveAt(int index)
    {
        InnerList.RemoveAt(index);
    }
    
    // método de contagem no ArrayList, muitas vezes pode ser também apenas uma propriedade na classe
    // mas nesse caso é um método, além disse, ele é implementado na classe CollectionBase, então utilizamos
    // a palavra "new" para ocultar a definição de Count em CollectionBase.
    public new int Count()
    {
        return InnerList.Count;
    }

    // método de limpar a ArrayList, também é encontrada na CollectionBase, por isso a palavra chave "new".
    public new void Clear()
    {
        InnerList.Clear();
    }

    // função canônica para exemplificar programação genérica / generics
    public static void Swap<T>(ref T val1, ref T val2)
    {
        T temp;
        temp = val1;
        val1 = val2;
        val2 = temp;
    }

    public class Node<T>
    {
        T dados;
        Node<T> link;

        public Node(T dados, Node<T> link)
        {
            this.dados = dados;
            this.link = link;
        }
    }
}