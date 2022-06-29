﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CustomStack<T>
    {
        //Sack FiLo
        private CustomList<T> list = new CustomList<T>();

        public bool isEmpty()
        {
            return list.isEmpty();
        }

        public void push(T e)
        {
            list.Add(e);
        }
        public T pop()
        {

            if (list.isEmpty())
                return default(T);

            list.Start();
            var value = list.GetValue();

            list.deleteAt(1);

            return value;
        }
    }
}
