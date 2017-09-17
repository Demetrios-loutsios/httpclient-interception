// Copyright (c) Just Eat, 2017. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using BenchmarkDotNet.Running;

namespace JustEat.HttpClientInterception
{
    internal static class Program
    {
        internal static void Main()
        {
            BenchmarkRunner.Run<InterceptionBenchmarks>();
        }
    }
}
