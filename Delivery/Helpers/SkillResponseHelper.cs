using System.Collections.Generic;
using Delivery.Dtos.Response;

namespace Delivery.Helpers
{
    public static class SkillResponseHelper
    {
        public static SkillResponse SimpleGreetResponse(string appName)
        {
            return new SkillResponse
            {
                Version = "1.0",
                Response = new ResponseBody
                {
                    OutputSpeech = new SsmlOutputSpeech
                    {
                        Ssml =$"<speak>Hello world, welcome to {appName}</speak>"
                    },
                    Reprompt = new Reprompt
                    {
                        OutputSpeech = new SsmlOutputSpeech
                        {
                            Ssml =$"<speak>Hello world, welcome to {appName}</speak>"
                        }
                    },
                    ShouldEndSession = false,
                    ResponseType = "_DEFAULT_RESPONSE"
                },
                SessionAttributes = new Dictionary<string, object>(),
                UserAgent = "tc-netcore-service"
            };
        }
    }
}