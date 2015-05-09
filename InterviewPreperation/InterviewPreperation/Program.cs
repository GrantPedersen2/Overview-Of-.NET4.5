using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreperation
{
    class Program
    {
        //Creation of heap, strong reference
        BaseArchitectureExamples example = new BaseArchitectureExamples();



        //Scope clashing
        static int j = 20;

        static void Main(string[] args)
        {
            int j = 30;
            Console.WriteLine(j);
            Console.WriteLine(Program.j);

        }
    }
}

/* IMPORTANT NOTES AND SIGNIFICANCE OF .NET and C#

    Component Object Model (COM) originated as 
    Object Linking and Embedding (OLE)
    Distributed COM (DCOM)
    .NET API for windows programming
    Help for backwards compatability
    .NET designed with the capability to work with existing software
    Entirely uses COM feature in Windows.
    .NET does have capability to provide wrappers around COM components

ADVANTAGES OF .NET 4.5.1
    OOP both .NET framework and C# are based on OOP
    Good design - base class library, which is degiend from ground up in a highly intuitive way
    compiles to a common intermediate language, langauges are now interoperable
    support for ASP and dynamic web pages
    Effcient data access
    Code Sharing - concept of assembly repaces the traditional DLL formal facilities for versioning
    Improved security
    zero impact installation: shared and private assemblies: shared -> are common libraries available to all software
                                                             private-> assemblies are inteded only for use with particular software, self-contained
    Fully integrated support for developing web services
    Asynchronous programming for UI methods keywords are in .NET Parallel Library
*/