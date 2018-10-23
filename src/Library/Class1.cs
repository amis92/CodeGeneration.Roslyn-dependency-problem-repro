using Generator;
using System;

namespace Library
{
    [DuplicateWithSuffix("Abc")]
    public class Class1
    {
    }

    class A
    {
        public Class1Abc Stuff { get; }
    }
}
