using DSAguides.Interface;
using DSAguides.Interface.Operation;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayServiceFactory : IServiceFactory<ArrayOperation>
    {
        private readonly IEnumerable<ArrayOperation> _operation;

        public ArrayServiceFactory(IEnumerable<ArrayOperation> operation)
        {
            _operation = operation;
        }

        public ArrayOperation GetInstance(string key)
        {
            return key switch
            {
                "new" => GetService(typeof(ArrayNewOperation)),
                "add" => GetService(typeof(ArrayAddOperation)),
                "clear" => GetService(typeof(ArrayClearOperation)),
                _ => throw new InvalidOperationException()
            };
        }

        public ArrayOperation GetService(Type type) =>
            _operation.FirstOrDefault(x => x.GetType() == type)!;
    }
}
