using JiuLing.CommonLibs.Security.Signature;

namespace SignDebugger.Page.CommandManage;
internal class FetchParameterNameAndValueCommand : ICommand
{
    public string Title => $"提取参数键值，分隔符：{_separator}";
    private string _text;
    private string _separator;
    private string _result = "";
    public FetchParameterNameAndValueCommand(string text, string separator)
    {
        _text = text;
        _separator = separator;
    }
    public void Execute()
    {
        _result = SignatureBuilder.Create(_text).FetchParameterNameAndValue(_separator).GetResult();
    }

    public string GetResult()
    {
        return _result;
    }
}