using JiuLing.CommonLibs.Security;

namespace SignDebugger.Page.CommandManage;
internal class Base64EncodingCommand : ICommand
{
    public string Title => "Base64 编码";
    private string _text;
    private string _result = "";
    public Base64EncodingCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = Base64Utils.StringToBase64(_text);
    }

    public string GetResult()
    {
        return _result;
    }
}