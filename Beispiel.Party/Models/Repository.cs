using System.Collections.Generic;
using System.ComponentModel;

namespace Beispiel.Party.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static List<GuestResponse> GetResponses()
        {
            return responses;
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
