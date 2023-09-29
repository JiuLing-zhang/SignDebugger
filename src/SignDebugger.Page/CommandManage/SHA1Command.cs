using JiuLing.CommonLibs.Security;

namespace SignDebugger.Page.CommandManage;
internal class SHA1Command : ICommand
{
    public string Title => "SHA1";
    private string _text;
    private string _result = "";
    public SHA1Command(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = SHA1Utils.GetStringValueToLower(_text);
    }

    public string GetResult()
    {
        return _result;
    }
}