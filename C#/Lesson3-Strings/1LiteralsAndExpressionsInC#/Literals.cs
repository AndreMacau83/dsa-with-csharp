using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LiteralsAndExpressionsInCSharp
{
    public class Literals
    {
        string name = "André";
        int age = 42;
        double points = 8.347;

        //Simple literal
        string str1 = "Olá mundo";

        // "Concatenation"
        public override string ToString()
        {
            return "Cliente " + name + " tem idade " + age + " anos e fez " + points + " pointos.";
        }
    }
}