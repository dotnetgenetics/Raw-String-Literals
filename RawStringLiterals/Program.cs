namespace RawStringLiterals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rawStringOne = """Hello - "Greg Esguerra".""";
            Console.WriteLine(rawStringOne);

            Console.WriteLine();
            var rawStringTwo = """This\is\a "Raw String Literal" example!""";
            Console.WriteLine(rawStringTwo);

            Console.WriteLine();
            var rawStringThree = """
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
                    sed do eiusmod tempor incididunt
                    ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
                    laboris nisi ut aliquip ex ea commodo consequat.
                """;
            Console.WriteLine(rawStringThree);

            Console.WriteLine();
            var rawStringXML = """
                    <?xml version="1.0" encoding="UTF-8"?>
                    <note>
                      <to>Tove</to>
                      <from>Jani</from>
                      <heading>Reminder</heading>
                      <body>Don't forget me this weekend!</body>
                    </note>
                """;
            Console.WriteLine(rawStringXML);

            Console.WriteLine();
            string firstName = "Greg";
            string lastName = "Esguerra";
            var rawStringJson = $$"""
                    {
                      "Name": {{firstName}},
                      "Surname": {{lastName}}
                    }
                """;
            Console.WriteLine(rawStringJson);

            Console.ReadLine();
        }
    }
}
