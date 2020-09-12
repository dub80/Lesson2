using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Set_isSubset
{
    class SimpleSet<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        // Создание экземпляра класса List<T>

        private readonly List<T> _items = new List<T>();

        public SimpleSet ()
        {
        }
        public SimpleSet (IEnumerable<T> items)
        {
            AddRange(items);
        }

        #region Добавление элементов в множество

        public void Add (T item)
        {
            // Если такой элемент уже существует в множестве, выдать исключение
            if (Contains(item))
            {
                throw new InvalidOperationException("Такое значение уже содержится в множестве");
            }

            _items.Add(item);
        }

        #endregion

        #region Добавление нового множества элементов

        public void AddRange (IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        #endregion

        #region Проверка наличия элемента в множестве
        public bool Contains (T item)
        {
            return _items.Contains(item);
        }
        #endregion

        #region Количество элементов в множестве
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }
        #endregion

        #region Нумератор

        public IEnumerator<T> GetEnumerator ()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
        {
            return _items.GetEnumerator();
        }
        #endregion

        #region Удаление элементов из множества

        public bool Remove (T item)
        {
            return _items.Remove(item);
        }

        #endregion

        public SimpleSet<T> Union (SimpleSet<T> other)
        {
            var result = new SimpleSet<T>(_items);

            foreach (T item in other._items)
            {
                if (!Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public SimpleSet<T> Intersection (SimpleSet<T> other)
        {
            var result = new SimpleSet<T>();

            foreach (T item in _items)
            {
                if (other._items.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public SimpleSet<T> Difference (SimpleSet<T> other)
        {
            var result = new SimpleSet<T>(_items);
            foreach (T item in other._items)
            {
                result.Remove(item);
            }

            return result;
        }

        public SimpleSet<T> SymmetricDifference (SimpleSet<T> other)
        {
            var union = Union(other);                // 1 2 3 4 5 6
            var intersection = Intersection(other);  // 3 4
            return union.Difference(intersection);      // 1 2 5 6
        }


        public bool IsSubset (SimpleSet<T> other)
        {

            var result = new SimpleSet<T>(_items);

            foreach (T item in other._items)
            {


                result.Remove(item);
            }

            if (result.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

    }
}
