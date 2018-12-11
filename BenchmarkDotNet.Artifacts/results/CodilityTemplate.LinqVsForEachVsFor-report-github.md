``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.15063.1088 (1703/CreatorsUpdate/Redstone2)
Intel Pentium CPU G3240 3.10GHz, 1 CPU, 2 logical and 2 physical cores
Frequency=3020350 Hz, Resolution=331.0875 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0
  Job-FTOBUC : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0

InvocationCount=1  UnrollFactor=1  

```
|      Method |     Mean |     Error |    StdDev |
|------------ |---------:|----------:|----------:|
|    LinqCase |       NA |        NA |        NA |
| ForEachCase | 84.57 ms | 0.6936 ms | 0.5792 ms |
|     ForCase | 84.58 ms | 0.5476 ms | 0.4855 ms |

Benchmarks with issues:
  LinqVsForEachVsFor.LinqCase: Job-FTOBUC(InvocationCount=1, UnrollFactor=1)
