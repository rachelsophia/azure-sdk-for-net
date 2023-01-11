// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Core
{
    /// <summary>
    /// A property bag which is optimized for storage of a small number of items.
    /// If the item count is less than 2, there are no allocations. Any additional items are stored in an array.
    /// </summary>
    internal class ArrayBackedPropertyBag<TKey, TValue> where TKey : IEquatable<TKey>
    {
        private int _arrayCount;
        private KeyValuePair<TKey, TValue>[]? _array;

        private TKey? _key1;
        private TValue? _value1;

        private TKey? _key2;
        private TValue? _value2;

        /// <summary>
        /// The current count of items in the property bag.
        /// </summary>
        /// <value></value>
        public int Count { get; private set; }

        /// <summary>
        /// Adds a value to the property bag.
        /// </summary>
        /// <param name="key">The key of the value to add.</param>
        /// <param name="value">The value to add.</param>
        public void Add(TKey key, TValue value)
        {
            Argument.AssertNotNull(key, nameof(key));

            switch (Count++)
            {
                case 0:
                    _key1 = key;
                    _value1 = value;
                    break;

                case 1:
                    _key2 = key;
                    _value2 = value;
                    break;

                default:
                    _array ??= new KeyValuePair<TKey, TValue>[8];
                    if (_arrayCount >= _array.Length)
                    {
                        // The array must be re-sized
                        KeyValuePair<TKey, TValue>[] newItems = new KeyValuePair<TKey, TValue>[_array.Length * 2];
                        Array.Copy(_array, newItems, _array.Length);
                        _array = newItems;
                    }
                    _array[_arrayCount] = new(key, value);
                    _arrayCount++;
                    break;
            }
        }

        /// <summary>
        /// Gets a value from the property bag.
        /// </summary>
        /// <param name="key">The key of the item to get.</param>
        /// <param name="value">The out parameter that will store the value, if found.</param>
        /// <returns><c>true</c> if found, else <c>false</c>.</returns>
        public bool TryGetValue(TKey key, out TValue? value)
        {
            Argument.AssertNotNull(key, nameof(key));

            switch (Count)
            {
                case 0:
                    value = default;
                    return false;

                case 1:
                    if (EqualityComparer<TKey>.Default.Equals(key, _key1!))
                    {
                        value = _value1;
                        return true;
                    }

                    value = default;
                    return false;

                default:
                    if (EqualityComparer<TKey>.Default.Equals(key, _key1!))
                    {
                        value = _value1;
                        return true;
                    }

                    if (EqualityComparer<TKey>.Default.Equals(key, _key2!))
                    {
                        value = _value2;
                        return true;
                    }

                    if (_array == null)
                    {
                        value = default;
                        return false;
                    }

                    TKey valueToFind = key;
                    for (int i = 0; i < _arrayCount; i++)
                    {
                        if (EqualityComparer<TKey>.Default.Equals(valueToFind, _array[i].Key))
                        {
                            value = _array[i].Value;
                            return true;
                        }
                    }
                    value = default;
                    return false;
            }
        }
    }
}
