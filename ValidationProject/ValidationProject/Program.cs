using ValidationProject.Validators;

namespace ValidationProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var validator = new StringValidator(10);

            var validResult = validator.IsValid("xHe!12x");

            var noSpecialSymbolResult = validator.IsValid("xHe12x");
            var withSpaceResult = validator.IsValid("xHe!12 x");

            Console.WriteLine(validResult);
            Console.WriteLine(noSpecialSymbolResult);
            Console.WriteLine(withSpaceResult);
        }
    }
}