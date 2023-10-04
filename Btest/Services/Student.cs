using BtestShared.Models;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Reflection.Metadata.Ecma335;

namespace Btest.Services
{
    public class Student : IStudent
    {
        //private readonly HttpClient _client;


        public Task<IEnumerable<Students>> GetStudentsAsync()
        {
            IEnumerable<Students> students = null;



             

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(@"https://localhost:7097/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Get data response
            var response = client.GetAsync(@"api/WeatherForecast").Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body
                var dataObjects = response.Content.ReadFromJsonAsync<IEnumerable<Students>>();
                client.Dispose();
                return dataObjects;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode,
                              response.ReasonPhrase);

                client.Dispose();
                // Since there was no response, let us create an array with one blank student
            }

            return (Task<IEnumerable<Students>>)students;

        }
    }
}
