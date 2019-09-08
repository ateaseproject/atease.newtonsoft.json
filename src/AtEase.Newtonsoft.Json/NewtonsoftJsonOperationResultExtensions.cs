using System.Diagnostics;

namespace AtEase.Newtonsoft.Json
{
    public static class NewtonsoftJsonOperationResultExtensions
    {
        [DebuggerStepThrough]
        public static string SerializeToJson(this OperationResult operationResult)
        {
            return NewtonsoftJsonExtensions.SerializeToJson(operationResult);
        }

        [DebuggerStepThrough]
        public static string SerializeToJson<TData>(this OperationResult<TData> operationResult)
        {
            return NewtonsoftJsonExtensions.SerializeToJson(operationResult);
        }

        [DebuggerStepThrough]
        public static OperationResult DeserializeJsonAsOperationResult(this string operationResult)
        {
            return operationResult.DeserializeJsonAs<OperationResult>(new OperationResultConverter());
        }

        [DebuggerStepThrough]
        public static OperationResult<TData> DeserializeJsonAsOperationResult<TData>(this string operationResult)
        {
            return operationResult.DeserializeJsonAs<OperationResult<TData>>(new OperationResultConverter<TData>());
        }
    }
}