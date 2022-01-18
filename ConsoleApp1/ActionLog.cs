using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ActionLog
    {
        private Stack<SampleData> UndoStack;
        public ActionLog()
        {
            UndoStack = new();
        }
        public void Log(SampleData Data)
        {
            UndoStack.Push(Data);
            foreach (var item in UndoStack)
                System.Console.WriteLine($"{item.Name}");
        }
    }
}
