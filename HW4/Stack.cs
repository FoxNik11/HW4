using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    public class Stack
    {
        private List<string> Elemets = new List<string>();
        public Stack(params string[] elString)
        {
            Elemets.AddRange(elString);
            // Реализовать установку параметрв size и top !!!!!!!!
        }
            //public Stack(string n) => Elemets.Add(n);

            //public Stack(string Elemets)
            //{
            //    this.Elemets.Add();
            //}

            public void Add(string[] ElString)
        {
            foreach (var n in ElString)
            {
                Elemets.Add(n);
                Console.WriteLine(n);
            }
        }
        public void Add(string ElString)
        {
            Elemets.Add(ElString);
            size++;
            top = ElString;
            Console.WriteLine($"В стек добавлено значение: {ElString}, элементов в стеке: {size}, последний элемент стека: {top}");
        }
        public void Pop()
        {
            string LastElPop = Elemets.Last();
            Elemets.RemoveAt(size);
            size--;
            top = Elemets.Last();
            Console.WriteLine($"Из стека удалено значение: {LastElPop}, элементов в стеке: {size}, последний элемент стека: {top}");
        }
        private int size=-1;
        public int Size
        {
            get
            {
                return size;
            }
        }
        private string top;
        public string Top
        {
            get
            {
                return top;
            }
        }
    }
}
