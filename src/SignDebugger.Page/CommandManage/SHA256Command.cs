using JiuLing.CommonLibs.Security;

namespace SignDebugger.Page.CommandManage;
internal class SHA256Command : ICommand
{
    public string Title => "SHA256";
    private string _text;
    private string _result = "";
    public SHA256Command(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = SHA256Utils.GetStringValueToLower(_text);
    }

    public string GetResult()
    {
        return _result;
    }
}