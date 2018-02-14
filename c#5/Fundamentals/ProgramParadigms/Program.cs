using System;
using System.Collections.Generic;
using Extensions;
using System.Linq;

namespace ProgramParadigms
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> cities = new[] { "Caxias do Sul", "Bento Gonçalves", "Farroupilha", "Cotiporã "};


            Console.WriteLine("Cidades: ");
            foreach (var city in cities)
            {
                Console.WriteLine($"Cidade de: {city}");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione Enter Para Continuar");
            Console.ReadLine();

            var letter = "C";

            Console.WriteLine($"Cidades com a Letra {letter} buscando com ExtensionMethod");

            IEnumerable<string> _query = cities.StringsThatStartWith(letter);
            foreach (var city in _query)
            {
                Console.WriteLine($"Cidades com a Letra: {letter} = {city}");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione Enter Para Continuar");
            Console.ReadLine();

            Console.WriteLine($"Cidades com a Letra {letter} buscando com Lambda e Ordenando");

            IEnumerable<string> _queryLinq = 
                cities.Where(item => item.StartsWith(letter))
                     .OrderByDescending(item => item.Length);

            foreach (var city in _queryLinq)
            {
                Console.WriteLine($"Cidades com a Letra: {letter} = {city}");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione Enter Para Continuar");
            Console.ReadLine();

        }
    }
}

namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<string> StringsThatStartWith(this IEnumerable<string> input, string start)
        {
            foreach (var _input in input )
            {
                if (_input.StartsWith(start))
                    yield return _input;
            }
        }

        //public static IEnumerable<T> Filter<T>(this IEnumerable<T> input, FilterDelegate<T> predicate)
        //{
        //    foreach (var item in input)
        //    {
        //        if (predicate(item))
        //            yield return item;
        //    }
        //}
    }

    public delegate bool FilterDelegate<T>(T item);
}
