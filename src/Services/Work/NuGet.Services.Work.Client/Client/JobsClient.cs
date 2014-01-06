﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NuGet.Services.Client;
using NuGet.Services.Work.Models;

namespace NuGet.Services.Work.Client
{
    public class JobsClient
    {
        private HttpClient _client;

        public JobsClient(HttpClient client)
        {
            _client = client;
        }

        public Task<ServiceResponse<IEnumerable<JobStatistics>>> GetStatistics()
        {
            return _client.GetAsync("jobs/stats").AsServiceResponse<IEnumerable<JobStatistics>>();
        }
    }
}
