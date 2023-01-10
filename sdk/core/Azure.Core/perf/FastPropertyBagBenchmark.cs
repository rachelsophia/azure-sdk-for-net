// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Azure.Core.Perf
{
    [MemoryDiagnoser]
    // [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    // [SimpleJob(RuntimeMoniker.Net461)]
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    public class FastPropertyBagBenchmark
    {
        [Benchmark(Baseline = true)]
        // [Arguments(1)]
        // [Arguments(2)]
        // [Arguments(3)]
        // [Arguments(5)]
        [Arguments(10)]
        public void Dictionary(int items)
        {
            object val1;
            object val2;
            object val3;
            object val4;
            object val5;
            object val6;
            object val7;
            object val8;
            object val9;
            object val10;

            HttpMessage message = new HttpMessage(new MockRequest(), new ResponseClassifier());
            switch (items)
            {
                case 1:
                    message.SetProperty(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetProperty(typeof(T1), out val1);
                    break;
                case 2:
                    message.SetProperty(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetProperty(typeof(T1), out val1);
                    message.SetProperty(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetProperty(typeof(T2), out val2);
                    break;
                case 3:
                    message.SetProperty(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetProperty(typeof(T1), out val1);
                    message.SetProperty(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetProperty(typeof(T2), out val2);
                    message.SetProperty(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetProperty(typeof(T3), out val3);
                    break;
                case 5:
                    message.SetProperty(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetProperty(typeof(T1), out val1);
                    message.SetProperty(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetProperty(typeof(T2), out val2);
                    message.SetProperty(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetProperty(typeof(T3), out val3);
                    message.SetProperty(typeof(T4), new T4() { Value = 1234 });
                    message.TryGetProperty(typeof(T4), out val4);
                    message.SetProperty(typeof(T5), new T5() { Value = 1234 });
                    message.TryGetProperty(typeof(T5), out val5);
                    break;

                case 10:
                    message.SetProperty(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetProperty(typeof(T1), out val1);
                    message.SetProperty(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetProperty(typeof(T2), out val2);
                    message.SetProperty(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetProperty(typeof(T3), out val3);
                    message.SetProperty(typeof(T4), new T4() { Value = 1234 });
                    message.TryGetProperty(typeof(T4), out val4);
                    message.SetProperty(typeof(T5), new T5() { Value = 1234 });
                    message.TryGetProperty(typeof(T5), out val5);
                    message.SetProperty(typeof(T6), new T6() { Value = 1234 });
                    message.TryGetProperty(typeof(T6), out val6);
                    message.SetProperty(typeof(T7), new T7() { Value = 1234 });
                    message.TryGetProperty(typeof(T7), out val7);
                    message.SetProperty(typeof(T8), new T8() { Value = 1234 });
                    message.TryGetProperty(typeof(T8), out val8);
                    message.SetProperty(typeof(T9), new T9() { Value = 1234 });
                    message.TryGetProperty(typeof(T9), out val9);
                    message.SetProperty(typeof(T10), new T10() { Value = 1234 });
                    message.TryGetProperty(typeof(T10), out val10);
                    break;
            }
        }

        // [Benchmark]
        // [Arguments(1)]
        // [Arguments(2)]
        // [Arguments(3)]
        // [Arguments(5)]
        // [Arguments(10)]
        public void PunyDictionary(int items)
        {
            object val1;
            object val2;
            object val3;
            object val4;
            object val5;
            object val6;
            object val7;
            object val8;
            object val9;
            object val10;
            HttpMessage message = new HttpMessage(new MockRequest(), new ResponseClassifier());
            switch (items)
            {
                case 1:
                    message.SetPropertyFast(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T1), out val1);
                    break;
                case 2:
                    message.SetPropertyFast(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T1), out val1);
                    message.SetPropertyFast(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T2), out val2);
                    break;
                case 3:
                    message.SetPropertyFast(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T1), out val1);
                    message.SetPropertyFast(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T2), out val2);
                    message.SetPropertyFast(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T3), out val3);
                    break;
                case 5:
                    message.SetPropertyFast(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T1), out val1);
                    message.SetPropertyFast(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T2), out val2);
                    message.SetPropertyFast(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T3), out val3);
                    message.SetPropertyFast(typeof(T4), new T4() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T4), out val4);
                    message.SetPropertyFast(typeof(T5), new T5() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T5), out val5);
                    break;

                case 10:
                    message.SetPropertyFast(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T1), out val1);
                    message.SetPropertyFast(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T2), out val2);
                    message.SetPropertyFast(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T3), out val3);
                    message.SetPropertyFast(typeof(T4), new T4() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T4), out val4);
                    message.SetPropertyFast(typeof(T5), new T5() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T5), out val5);
                    message.SetPropertyFast(typeof(T6), new T6() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T6), out val6);
                    message.SetPropertyFast(typeof(T7), new T7() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T7), out val7);
                    message.SetPropertyFast(typeof(T8), new T8() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T8), out val8);
                    message.SetPropertyFast(typeof(T9), new T9() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T9), out val9);
                    message.SetPropertyFast(typeof(T10), new T10() { Value = 1234 });
                    message.TryGetPropertyFast(typeof(T10), out val10);
                    break;
            }
        }

        [Benchmark]
        // [Arguments(1)]
        // [Arguments(2)]
        // [Arguments(3)]
        // [Arguments(5)]
        [Arguments(10)]
        public void PunyDictArray(int items)
        {
            object val1;
            object val2;
            object val3;
            object val4;
            object val5;
            object val6;
            object val7;
            object val8;
            object val9;
            object val10;
            HttpMessage message = new HttpMessage(new MockRequest(), new ResponseClassifier());
            switch (items)
            {
                case 1:
                    message.SetPropertyFast2(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T1), out val1);
                    break;
                case 2:
                    message.SetPropertyFast2(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T1), out val1);
                    message.SetPropertyFast2(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T2), out val2);
                    break;
                case 3:
                    message.SetPropertyFast2(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T1), out val1);
                    message.SetPropertyFast2(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T2), out val2);
                    message.SetPropertyFast2(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T3), out val3);
                    break;
                case 5:
                    message.SetPropertyFast2(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T1), out val1);
                    message.SetPropertyFast2(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T2), out val2);
                    message.SetPropertyFast2(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T3), out val3);
                    message.SetPropertyFast2(typeof(T4), new T4() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T4), out val4);
                    message.SetPropertyFast2(typeof(T5), new T5() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T5), out val5);
                    break;
                case 10:
                    message.SetPropertyFast2(typeof(T1), new T1() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T1), out val1);
                    message.SetPropertyFast2(typeof(T2), new T2() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T2), out val2);
                    message.SetPropertyFast2(typeof(T3), new T3() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T3), out val3);
                    message.SetPropertyFast2(typeof(T4), new T4() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T4), out val4);
                    message.SetPropertyFast2(typeof(T5), new T5() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T5), out val5);
                    message.SetPropertyFast2(typeof(T6), new T6() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T6), out val6);
                    message.SetPropertyFast2(typeof(T7), new T7() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T7), out val7);
                    message.SetPropertyFast2(typeof(T8), new T8() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T8), out val8);
                    message.SetPropertyFast2(typeof(T9), new T9() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T9), out val9);
                    message.SetPropertyFast2(typeof(T10), new T10() { Value = 1234 });
                    message.TryGetPropertyFast2(typeof(T10), out val10);
                    break;
            }
        }

        private struct T1
        {
            public int Value { get; set; }
        }

        private struct T2
        {
            public int Value { get; set; }
        }

        private struct T3
        {
            public int Value { get; set; }
        }

        private struct T4
        {
            public int Value { get; set; }
        }

        private struct T5
        {
            public int Value { get; set; }
        }

        private struct T6
        {
            public int Value { get; set; }
        }

        private struct T7
        {
            public int Value { get; set; }
        }

        private struct T8
        {
            public int Value { get; set; }
        }

        private struct T9
        {
            public int Value { get; set; }
        }

        private struct T10
        {
            public int Value { get; set; }
        }
    }
}
