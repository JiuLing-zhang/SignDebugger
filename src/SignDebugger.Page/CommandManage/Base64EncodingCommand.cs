using JiuLing.CommonLibs.Security;

namespace SignDebugger.Page.CommandManage;
internal class Base64Command : ICommand
{
    public string Title => "Base64";
    private string _text;
    private string _result = "";
    public Base64Command(string text)
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