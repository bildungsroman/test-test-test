using System;
using Amazon.Lambda.Core;

namespace StackeryFunction
{
    public class Handler
    {
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public dynamic handler(dynamic event)
        {
            Console.WriteLine(event);

            return new {};
        }
    }
}
