# Object Pile Demo - Big Memory
piledemo

## TL;DR
Pile is 100% .NET tative solution that turns pretty much any business.NET object reference into a `struct{int:int}`.
Pile uses very fast serializer and allocator that uses `byte[]`.
This way the GC stops seeing the "objects" and does not stall you process when you need to keep 100s of millions of objects.
On a typical "Person" object Pile yields 1.5M writes/sec and 2+M read/sec speed on a 3Ghz i7 machine.

## Overview
The purpose of this project is to demonstrate and test the speed and applicability of [NFX Object Pile](https://github.com/aumcode/nfx/blob/master/Source/NFX/ApplicationModel/Pile/IPile.cs#L102) objects.
technology using some real-world business cases.

## Object Pile
Pile is a large/big memory heap of objects native to the executing process, so if your 
process's code is written in .NET then the objects gotta be CLR / .NET. 
The trick is to "hide" business objects form CLR's GC which starts causing significant delay when there are tens of millions of
objects allocated and promoted into GC Gen 2. NFX Pile uses intricate serialization with custom memory allocator
 that uses large `byte[]` buffers to hold data. NFX Pile is different from other similar solutions in approach to serialization
 which allows developers to store a wide variarty of CLR objects without a need to create special-purpose data structures for particular business domain.

NFX Pile is 100% managed code, which makes it stable and easy to maintain. There is no special "unmanaged" treatmnet required
for objects that get stored in a Pile.

The performance of the Pile beats the out-of-process storages because the required serialization is for the out-of-process storage
(i.e. Redis/memcache) is still there but Pile saves on 3-rd party network and library calls (which in turn, create extra tranistive instances and copies in drivers/connectors)

As this demo clearly shows, it makes lots of sense to use large memory (i.e. tens/hudreds of gigabytes)
using fast serialization which yields throughput not attainable with out-of-process caching/storage solutions. 

## Results

..TBD ..

## Requirements

* Build using VS2015+
* 64bit OS and process only - otherwise the test runs but makes little sense
* Gotta have at least 16 Gb Physical RAM, better 64Gb or more
* .NET 4.5+

## Recommendations

* Build in `RELEASE` mode
* Running processes from Visual Studio (F5) slows things down by a good 
10%-25% (because of the debugger). Hit `CTRL+F5` or launch as a separate executable.
* Try to disable Intel's 'SpeedStep' or similar tech if you have AMD - they dynamically throttle you CPU clock.
Switch to Windows/ControlPanel/Power/High Performance
