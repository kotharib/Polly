using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace testApplicationAPI.Models
{
    public class MyGithubClient
    {
        public MyGithubClient(HttpClient client)
        {
            Client = client;
        }

        public HttpClient Client { get; set; }
    }
}
