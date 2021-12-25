using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TheDonut.IntegrationTest
{
    public class DonutTest
    {
        private const string _graphQLendpoint = "graphql/";

        [Fact]
        public async Task FindDonut_ById_ReturnsItem()
        {
            using var donutApp = new TheDonutApplication();
            var client = donutApp.CreateClient();
            var query = "{\"query\":" +
                         "\"query { \\r\\n  findDonut(id: 1) " +
                                    "{" +
                                        "\\r\\n  id," +
                                        "\\r\\n  name," +
                                        "\\r\\n  price" +
                                        "\\r\\n  " +
                                     "} \\r\\n " +
                                 "}\", \"variables\":{}" +
                          "}";

            var content = new StringContent(query, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(_graphQLendpoint, content);
            var result = response.Content.ReadAsStringAsync().Result;

            Assert.Contains("{\"data\":{\"findDonut\":{\"id\":1,\"name\":\"Chocolate Belga\",\"price\":8.5}}}", result);
        }
    }
}