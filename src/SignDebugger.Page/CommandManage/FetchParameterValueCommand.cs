using JiuLing.CommonLibs.Security.Signature;

namespace SignDebugger.Page.CommandManage;
internal class FetchParameterValueCommand : ICommand
{
    public string Title => $"提取参数值，分隔符：{_separator}";
    private string _text;
    private string _separator;
    private string _result = "";
    public FetchParameterValueCommand(string text, string separator)
    {
        _text = text;
        _separator = separator;
    }
    public void Execute()
    {
        _result = SignatureBuilder.Create(_text).FetchParameterValue(_separator).GetResult();
    }

    public string GetResult()
    {
        return _result;
    }
}