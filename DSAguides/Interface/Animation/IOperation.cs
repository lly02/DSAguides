using System.ComponentModel;

namespace DSAguides.Interface.Animation
{
    public interface IOperation
    {
        public void Insert(int index, int element);
        public void Remove(int index);
    }
}
