// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.Core
{
    /// <summary>
    ///
    /// </summary>
    public class PunyDictionary
    {
        private int count;
        private Dictionary<Type, object>? map;

        private Type? key1;
        private object? value1;

        private Type? key2;
        private object? value2;

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(Type key, object value)
        {
            switch (this.count)
            {
                case 0:
                    this.key1 = key;
                    this.value1 = value;
                    break;

                case 1:
                    this.key2 = key;
                    this.value2 = value;
                    break;

                default:
                    if (this.map == null)
                    {
                        this.map = new Dictionary<Type, object>(3);
                    }

                    this.map.Add(key, value);
                    break;
            }

            this.count++;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(Type key, out object? value)
        {
            switch (this.count)
            {
                case 0:
                    value = default(object);

                    return false;

                case 1:
                    if (key1 == key)
                    {
                        value = this.value1;

                        return true;
                    }

                    value = default(object);
                    return false;

                default:
                    if (key1 == key)
                    {
                        value = this.value1;

                        return true;
                    }

                    if (key2 == key)
                    {
                        value = this.value2;

                        return true;
                    }

                    if (this.map == null)
                    {
                        value = default(object);

                        return false;
                    }
                    else
                    {
                        return this.map.TryGetValue(key, out value);
                    }
            }
        }
    }
}
