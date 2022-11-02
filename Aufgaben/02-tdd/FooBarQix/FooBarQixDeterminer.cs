namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Foo => "foo";

        public string Determine(int input)
        {
            if(input == 3)
            {
                return this.Foo;
            }
            return input.ToString();
        }
    }
}