// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Core
{
    /// <summary>
    ///
    /// </summary>
    public class PunyDictionaryArray
    {
        private int _arrCount;
        private KeyValuePair<long, object>[]? _array;

        private Type? key1;
        private object? value1;

        private Type? key2;
        private object? value2;

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public int Count { get; private set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(Type key, object value)
        {
            switch (Count++)
            {
                case 0:
                    key1 = key;
                    value1 = value;
                    break;

                case 1:
                    key2 = key;
                    value2 = value;
                    break;

                default:
                    _array ??= new KeyValuePair<long, object>[8];
                    _array[_arrCount] = new((long)key.TypeHandle.Value, value);
                    _arrCount++;
                    break;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(Type key, out object? value)
        {
            switch (Count)
            {
                case 0:
                    value = default;

                    return false;

                case 1:
                    if (key1 == key)
                    {
                        value = value1;

                        return true;
                    }

                    value = default;
                    return false;

                default:
                    if (key1 == key)
                    {
                        value = value1;

                        return true;
                    }

                    if (key2 == key)
                    {
                        value = value2;

                        return true;
                    }

                    if (_array == null)
                    {
                        value = default;

                        return false;
                    }
                    else
                    {
                        long valueToFind = (long)key.TypeHandle.Value;
                        for (int i = 0; i < _arrCount; i++)
                        {
                            if (EqualityComparer<long>.Default.Equals(valueToFind, _array[i].Key))
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
}
