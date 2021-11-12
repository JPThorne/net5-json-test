using net5_json_test;
using BenchmarkDotNet.Running;
using System;

Console.WriteLine(BenchmarkRunner.Run<PersonSerializer>());