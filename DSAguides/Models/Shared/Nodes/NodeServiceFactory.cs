using DSAguides.Interface;
using DSAguides.Interface.Nodes;
using DSAguides.Models.DataStructures.Array;

namespace DSAguides.Models.Shared.Nodes
{
    public class NodeServiceFactory : IServiceFactory<INodeFactory>
    {
        private readonly IEnumerable<INodeFactory> _nodeFactory;

        public NodeServiceFactory(IEnumerable<INodeFactory> nodeFactory)
        {
            _nodeFactory = nodeFactory;
        }

        public INodeFactory GetInstance(string key)
        {
            return key switch
            {
                "array" => GetService(typeof(ArrayNodeFactory)),
                _ => throw new InvalidOperationException()
            };
        }

        public INodeFactory GetService(Type type) =>
            _nodeFactory.FirstOrDefault(x => x.GetType() == type)!;
    }
}
