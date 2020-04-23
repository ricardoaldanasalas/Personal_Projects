using System;
using System.Collections.Generic;


namespace TaxForecast.Models
{
    public static class ExistingRepository
    {
        private static List<loginPortal> responses = new List<loginPortal>();

        public static IEnumerable<loginPortal> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(loginPortal response)
        {
            responses.Add(response);
        }
    }
}
