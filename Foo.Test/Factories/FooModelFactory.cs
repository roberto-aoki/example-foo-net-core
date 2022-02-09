using Foo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo.Test.Factories
{
    public class FooModelFactory
    {
        public static IEnumerable<FooModel> CreateFooModel()
        {
            return new FooModel[]
            {
                new FooModel
                {
                    Name =  "Foo 1"
                }
            };
        }
    }
}
