using DSAguides.Interface.Nodes;

namespace DSAguides.Models.DataStructures.Array.Operations
{
    public class ArrayClearOperation : ArrayOperation
    {
        public ArrayClearOperation() 
            : base () { }

        public ArrayClearOperation(Pages.DataStructures.Array page, INode[] endState)
            : base(page, endState)
        {
        }

        public override void NextFrame()
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
            Page!.Nodes = EndState;
            Page.Information = "Constructing a new array.";
        }
    }
}
