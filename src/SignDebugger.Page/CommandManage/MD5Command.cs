using JiuLing.CommonLibs.Security;

namespace SignDebugger.Page.CommandManage;
internal class MD5Command : ICommand
{
    public string Title => "MD5";
    private string _text;
    private string _result = "";
    public MD5Command(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = MD5Utils.GetStringValueToLower(_text);
    }

    public string GetResult()
    {
        return _result;
    }
}