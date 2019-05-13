using Delivery.Controllers;
using Delivery.Dtos.Request;
using Delivery.Dtos.Response;
using NUnit.Framework;

namespace DeliveryTests
{
    [TestFixture]
    public class AlexaControllerTests
    {
        SkillRequest DefaultSkillRequest => new SkillRequest();

        [Test]
        public void SimpleGreetTest()
        {
            var controller = GivenAnAlexaController();
            var response = WhenAnIntentIsCaptured(controller);
            
            ThenIsASpeechResponse(response);
        }
        
        AlexaController GivenAnAlexaController() => new AlexaController();

        SkillResponse WhenAnIntentIsCaptured(AlexaController controller) => controller.Intent(DefaultSkillRequest);

        void ThenIsASpeechResponse(SkillResponse response)
        {
            Assert.IsNotNull(response);
            
            var speechResponse = response.Response.OutputSpeech as SsmlOutputSpeech;
            Assert.IsNotNull(speechResponse);
        }
    }
}