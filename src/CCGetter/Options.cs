using CommandLine;
using CommandLine.Text;
using System.Collections;
using System.Collections.Generic;

namespace CCGetter
{
    public class Options
        {
            [Option('u', "user", Required = true, HelpText = "User needed for authentication.")]
            public string User { get; set; }

            [Option('p', "password", Required = true, HelpText = "Password needed for authentication.")]
            public string Password { get; set; }

            [Option('o', "output", Required = false, Default = "cc.json", HelpText = "Output file to save the C&C list to.")]
            public string Output { get; set; }

            [Usage(ApplicationAlias = "CCGetter")]
            public static IEnumerable Examples
            {
                get
                {
                    return new List<Example>
                    {
                        new Example("Download list to current folder", new Options { User = "MyUser", Password = "MyPassword" })
                    };
                }
            }
        }
}
