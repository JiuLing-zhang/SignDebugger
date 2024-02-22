using JiuLing.CommonLibs.Security;

namespace SignDebugger.Page.CommandManage;
internal class Base64DecodingCommand : ICommand
{
    public string Title => "Base64 解码";
    private string _text;
    private string _result = "";
    public Base64DecodingCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = Base64Utils.Base64ToString(_text);
    }

    public string GetResult()
    {
        return _result;
    }
}