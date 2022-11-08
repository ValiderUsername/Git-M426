using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http.Json;
namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string result = "";
            if (input % 3 == 0)
            {
                result += "FOO";
            }
            if (input % 5 == 0)
            {
                result += "BAR";
            }
            if (input % 7 == 0)
            {
                result += "QIX";
            }
            string Ausgabe = string.valueOf(input);
            for (int j = 0; j < Ausgabe.Length(); j++)
            {
                char element = Ausgabe.charAt(j);
                if (element == '3')
                    result += "Foo";
                if (element == '5')
                    result += "Bar";
                if (element == '7')
                    result += "Qix";
            }
            return result.isEmpty() ? input : result;
        }
    }
}