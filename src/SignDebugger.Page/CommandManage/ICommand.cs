namespace SignDebugger.Page.CommandManage;
interface ICommand
{
    string Title { get; }
    void Execute();
    string GetResult();
}