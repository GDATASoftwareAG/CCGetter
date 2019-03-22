using CommandLine;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Tiny.RestClient;

namespace CCGetter
{
    class Program
    {
        private const string ccUrl      = "https://pt-candc-exchange.gdata.de:4443/list/fullList";
        private const int ExitFailure   = 1;
        private const int ExitSuccess   = 0;

        static async Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<Options>(args)
                .MapResult(
                (Options opts) => DownloadListToFile(opts), 
                err => Task.FromResult(ExitFailure));
        }

        private static async Task<int> DownloadListToFile(Options opts)
        {
            using(var httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.ServerCertificateCustomValidationCallback = CertValidation.IsExpectedCert;
                using(var httpClient = new HttpClient(httpClientHandler))
                {
                    var client = new TinyRestClient(httpClient, ccUrl);

                    client.Settings.DefaultHeaders.AddBasicAuthentication(opts.User, opts.Password);
                    var list = await client.GetRequest().ExecuteAsStringAsync();

                    File.WriteAllText(opts.Output, list);
                }
            }

            return ExitSuccess;
        }
    }
}
