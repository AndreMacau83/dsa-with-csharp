using System.Globalization;
using System.Text;

namespace LiteralsAndExpressionsInCSharp
{
    public class Strings
    {
        string Name = "Alice";
        int Age = 31;
        double Points = 8.347;

        public Strings()
        {
        }

        public Strings(string name, int age, double points)
        {
            Name = name;
            Age = age;
            Points = points;
        }

        public override string ToString()
        {
            // Simple literal
            string str1 = "Olá, mundo!";

            // Concatenation
            string str2 = "Cliente " + Name + " tem idade " + Age + " anos e fez " + Points + " pontos.";

            //Escape characters
            string str3 = "Cliente: " + Name + "\nIdade: " + Age; // \n quadra de linha
            string str4 = "c:\\Program Files\\Windows"; // Quando é nescessário exibir a \
            string str5 = "Senha = \"carro123\"";
            string str6 = "<html>\n"
                + "\t<body>\n"
                + "\t\t<p>Hello, World!</p>\n"
                + "\t</body>\n"
                + "</html>\n";


            //Interpolation
            string str7 = $"Cliente {Name} tem idade {Age} anos e fez {Points} pontos.";

            // Verbatm strings
            string str8 = @"c:\Program Files\Windows";
            string str9 = @"Senha = ""carro123""";
            string str10 =
            @"<html>
                <body>
                    <p>Hello, World! </p>
                </body>            
            </html>
            ";
            string str11 =
            $@"<html>
                <body>
                    <p>Hello, World {Name}</p>
                </body>            
            </html>
            ";

            // String literals multilines

            string str12 = """
                <html>
                    <body>
                        <p>Hello, World!</p>
                    </body>
                </html>
            """;

            string str13 = $"""
                <html>
                    <body>
                        <p>Hello, {Name}</p>
                    </body>
                </html>
            """;

            StringBuilder sb = new StringBuilder();
            sb.Append("<html>\n");
            sb.Append("\t<body>\n");
            sb.Append("\t\t<p>Hello, World!</p>\n");
            sb.Append("\t</body>\n");
            sb.Append("</html>\n");
            string str16 = sb.ToString();

            string str14 = $"Cliente {Name} fez {Points:F2} pontos.";
            string str15 = $"Cliente {Name} fez {Points.ToString("F2", CultureInfo.InvariantCulture)} pontos.";
            return string.Join("\n", new[] {
                str1,
                str2,
                str3,
                str4,
                str5,
                str6,
                str7,
                str8,
                str9,
                str10,
                str11,
                str12,
                str13,
                str14,
                str15,
                str16
            });
        }
    }
}