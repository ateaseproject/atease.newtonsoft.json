using Newtonsoft.Json;
using Xunit;

namespace AtEase.Newtonsoft.Json.Test
{
    public class OperationResultTestsWithObjectData
    {
        [Fact]
        public void DeserializeOperationResultT_SuccessWithObjectData()
        {
            var name = "Ahmad Chehre";
            var data = new Person(name);

          
            var operationResult = OperationResult<Person>.Succeed(data);
            var serializedOperationResult = JsonConvert.SerializeObject(operationResult);
            var deserializedOperationResult =
                JsonConvert.DeserializeObject<OperationResult<Person>>(serializedOperationResult,
                    new OperationResultConverter<Person>(new PersonConverter()));

            Assert.Equal(operationResult.Succeeded, deserializedOperationResult.Succeeded);
            Assert.Equal(operationResult.Data, deserializedOperationResult.Data);
        }

    }
}
