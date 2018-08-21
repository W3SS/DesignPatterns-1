using System;
using System.Text;
using static System.Console;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("\nDesign Patterns ...\n");

            // SOLID
            #region SOLID


            #region Single Responsibility Principle
            #endregion


            #region Open-Closed Principle
            #endregion


            #region Liskov Substitution Principle
            #endregion


            #region Interface Segregation Principle
            #endregion


            #region Dependency Inversion Principle
            #endregion


            #endregion


            // Design Patterns
            #region Design Patterns


            #region Creational

            WriteLine("Creational Design Patterns ...\n");

            #region Builder

            WriteLine("Builder ...");

            // without builder
            WriteLine("Without builder ...");
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }
            sb.Append("</ul>");
            WriteLine(sb);

            WriteLine("");
            #endregion


            #endregion


            #region Structural
            #endregion


            #region Behavioral
            #endregion


            #endregion

        }
    }
}
