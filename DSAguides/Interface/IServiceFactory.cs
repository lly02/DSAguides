namespace DSAguides.Interface
{
    public interface IServiceFactory<T>
    {
        public T GetInstance(string key);
    }
}
