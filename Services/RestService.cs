using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiProject.Services
{
    public class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public List<ExerciseItem> ExerciseItems { get; private set; }

        public RestService()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri("https://api.api-ninjas.com/v1/exercises")
            };
            _client.DefaultRequestHeaders.Add("X-Api-Key", "D2fDE/UXOKwqMQorZlbzXQ==FhtlKNrP7XkVLpP1\r\n");


            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
    }
}
