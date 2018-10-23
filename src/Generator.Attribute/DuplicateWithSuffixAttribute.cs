using CodeGeneration.Roslyn;
using System;
using System.Diagnostics;

namespace Generator
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    [CodeGenerationAttribute("Generator.DuplicateWithSuffixGenerator, Generator")]
    [Conditional("CodeGeneration")]
    public class DuplicateWithSuffixAttribute : Attribute
    {
        public DuplicateWithSuffixAttribute(string suffix)
        {
            this.Suffix = suffix;
        }

        public string Suffix { get; }
    }
}
