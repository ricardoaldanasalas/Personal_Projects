using System;
using System.Collections.Generic;


namespace TaxForecast.Models
{
    public static class NewRepository
    {
        private static List<NewUserInput> responses = new List<NewUserInput>();

        public static IEnumerable<NewUserInput> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(NewUserInput response)
        {
            responses.Add(response);
        }
    }
}
