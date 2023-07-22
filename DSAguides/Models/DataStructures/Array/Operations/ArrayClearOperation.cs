using DSAguides.Interface.Interface;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayClearOperation : ArrayOperation
    {
        public ArrayClearOperation(INode[] currentState, INode[] endState)
            : base(currentState, endState)
        {
        }

        public override INode[] NextFrame()
        {
            //for (int i = 0; i < CurrentState.Length ; i++)
            //{
            //    if (CurrentState[i].ElementToString == "")
            //    {
            //        if (i == 0)
            //        {
            //            Done = true;
            //            break;
            //        }
            //        else
            //        {
            //            CurrentState[i - 1].Element = null;
            //        }
            //    } 
            //    else if (i == CurrentState.Length - 1)
            //    {
            //        CurrentState[i].Element = null;
            //    }
            //}

            //return CurrentState;
            Done = true;
            return EndState;
        }
    }
}
