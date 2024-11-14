// Program to demonstrate Combining Multiple Access Modifiersin C# using Visual Studio.
// Programmer: Srushti Battise

namespace CombiningMultipleAccessModifiers_01
{
    using System;

    namespace CombiningMultipleAccessModifiers_01
    {
        public class Document
        {
            // protected internal field, accessible within derived classes and same assembly
            protected internal string title;

            public Document(string docTitle)
            {
                title = docTitle;
            }

            // private protected method
            private protected void ShowTitle()
            {
                Console.WriteLine("Document Title: " + title);
            }
        }

        public class Report : Document // inherit Document
        {
            public Report(string title) : base(title) { }

            public void DisplayReportTitle()
            {
                // Accessing private protected method in derived class
                ShowTitle();
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Program to demonstrate Combining Multiple Access Modifiers in C# using Visual Studio.\r\n");

                Report report = new Report("Monthly Report!");
                report.DisplayReportTitle();
            }
        }
    }
}
