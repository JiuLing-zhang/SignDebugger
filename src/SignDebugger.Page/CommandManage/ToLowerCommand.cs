namespace SignDebugger.Page.CommandManage;
internal class ToLowerCommand : ICommand
{
    public string Title => "转小写";
    private string _text;
    private string _result = "";
    public ToLowerCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = _text.ToLower();
    }

    public string GetResult()
    {
        return _result;
    }
}