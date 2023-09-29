namespace SignDebugger.Page.CommandManage;
internal class PrefixCommand : ICommand
{
    public string Title => $"加前缀：{_prefix}";
    private string _text;
    private string _prefix;
    private string _result = "";
    public PrefixCommand(string text, string prefix)
    {
        _text = text;
        _prefix = prefix;
    }

    public void Execute()
    {
        _result = _prefix + _text;
    }

    public string GetResult()
    {
        return _result;
    }
}