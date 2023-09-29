namespace SignDebugger.Page.CommandManage;
internal class PostfixCommand : ICommand
{
    public string Title => $"加后缀：{_postfix}";
    private string _text;
    private string _postfix;
    private string _result = "";
    public PostfixCommand(string text, string postfix)
    {
        _text = text;
        _postfix = postfix;
    }
    public void Execute()
    {
        _result = _text + _postfix;
    }

    public string GetResult()
    {
        return _result;
    }
}