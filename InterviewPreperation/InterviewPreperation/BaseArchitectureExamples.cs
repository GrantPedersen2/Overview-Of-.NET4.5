using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*NOTES
2 important consequences for C#
    1.) architecture and methodologies of C# refect the underlying methodologies of .NET
    2.) specific language features of C# actually depend on features of .NET or of .NET base classes

2 respects for .NET and C#
    1.) C# designed and targeeted for use with Microsofts .NET Framework(feature-rich platform for development, deployment and execution
    2.) It is a language based on modern OOP design methodology

Example of C# language not supported by .NET or MSIL, operator overloading

CLR - > common language runtime / compulation steps
    1.) Compliation of source code to Microsoft Intermediate Language(IL)
    2.) Compilation of IL to platform-specifc code by the CLR
    IL shares Java byte code the idea of low-level language with simple synatx

Platform Independence
    Same FLE containing byte code instructions can be placed on any platform
    by compiling to IL you obtain platform independence for .NET
    Libraries such as Xamarin (www.xamarin.com) can compiler C# on iPhone and Android

Performance Improvement
    IL always Just-in-Time (JIT comp) whereas Java byte code is often interpreted.
    disadvantages of Java was, on execution, process Java byte to native executable
    JIT compiler simply compiles each portion of code as it is called (JIT)
    Resultant native executable is stored until the app exits (example with MemoryStream, where we need to CACHE IT)

COM and COM+
    Not targeted at .NET - components based on them cannot be compiled into IL
    COM+ features not duplicated in .NET framework
    COM still works with .NET

Intermediate Language
    important features of IL:
        OOP and use of Interfaces
        Strong distinction between value and reference types
        Strong Data typing
        Error handling using exceptions
        Use of attributes

     A class written in one language can inherit from a class written in another language.
     The class can contain an instance of another class, no matter what the languages of the two classes are.
     An object can directly call methods against another object written in another language.
     Objects (or references to objects) can be passed around between methods.
     When calling methods between languages, you can step between the method calls in the debugger, even when this means stepping between source code written in different languages.

     IL also lays down specifications about data storage: Instances of reference types are always stored in an area of memory known as the managed heap, 
     whereas value types are normally stored on the stack

     One important aspect of IL is that it is based on exceptionally strong data typing. That means that all variables are clearly marked as being of a particular, specific data type. 
     (There is no room in IL, for example, for the Variant data type recognized by Visual Basic and scripting languages.) 
     In particular, IL does not normally permit any operations that result in ambiguous data types. 
        -E.G. dynamic can be anytype of value data to put in for typing
    
    Although enforcing type safety might initially appear to hurt performance, in many cases the benefits gained from the services provided by .NET that rely on type safety far outweigh this performance loss. 
    Such services include the following:

         Language interoperability
         Garbage collection 
         Security 
         Application domains

    Common Type System (CTS)
    defines the predefined data types available in IL so all langauges that target .NET
    can produce code ultimately based on these types.
        
        E.G. -> Integer is a 32 bit int to Int32
             -> Refers to Int32 with int
    
    Common Language Specification
        1.) Individual compilers do not need to be powerful enough to support the full features of .NET — this should encourage the development of compilers for other programming languages that target .NET. 
        2.) If you restrict your classes to exposing only CLS-compliant features, then it guarantees that code written in any other compliant language can use your classes. 
        
        This only restricts to public and protected members of classes and public classes
        private implementations of your classes, you can write whatever non-CLS code you want because
        code in other assemblies can't access this part of your code.

    Garbage Collection
        memory management and particular to question of what to do about 
        reclaiming memory that running apps ask for.

        Techniques 
            1.) Make app code do it all manually
            2.) Make objects maintain reference counts
        
        App code responsible for de-allocation memory is technique used by
        Lower-level, high-performance languages such as C++
        Code that requests memory also should explicitly inform the system when it no longer
        requires that memory; resulting of memory leaks.
        
        In .NET, the CLR maintains its own managed heap for .NET
        
        CLR WILL DECIDE WHEN GC IS CALLED
            Calling GC is good for testing purposes, but 
            you should not use it in a normal program.

Use of Attributes
    COM Interface Definition Language [IDL] supported in .NET
    Define your own attributes in your source code, where they are placed as 
    metadata for corresponding data types or methods.
    NOTE: ildasm, Windows based utility, used to inspect contents of an assembly 
    including the manifest and metadata...
*/

/* SYNTAX
    #define
    #undefine
    #warning
    #error
    #region and #endregion
    #line
    #pragma - either suppress or restore specific compiler warnings
*/

namespace InterviewPreperation
{
    struct ExampleStruct
    {
        public double number;
        public string name;

        public ExampleStruct(double num, string word)
        {
            number = num;
            name = word;
        }

        public double ExamplePropertyStructNumber
        {
            get
            {
                return number;
            }
        }

        public string ExamplePropertyStructName
        {
            get
            {
                return name;
            }
        }

        //Can supply a Close or Dispose() methods
    }

    public class BaseArchitectureExamples
    {
        //Fields
        public readonly DateTime dateCreation;
        public dynamic dynamicType;
        private ExampleStruct exampleStruct;


        //Default constructor
        public BaseArchitectureExamples()
        {
            dateCreation = DateTime.Now;
            exampleStruct = new ExampleStruct();
        }

        //Hides method from inheritance of classes
        private new void Test()
        {

        }

        public void ExampleMethod(ref int testc)
        {

        }

        public void ExampleMethod(out string word)
        {
            word = "example";
        }

        //extension method public void ExampleMethodThree(this int number) ONLY USED WITH STATIC CLASSES
        //http://weblogs.asp.net/scottgu/new-orcas-language-feature-extension-methods

        //Properties example AAA https://msdn.microsoft.com/en-us/library/75e8y5dd(v=vs.80).aspx
        public int PropExample { get; internal set; }

        public string PropExampleName { get; private set; }
    }
}
