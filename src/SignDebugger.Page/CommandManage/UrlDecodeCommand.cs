using System.Web;

namespace SignDebugger.Page.CommandManage;
internal class UrlDecodeCommand : ICommand
{
    public string Title => "Url 解码";
    private string _text;
    private string _result = "";
    public UrlDecodeCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = HttpUtility.UrlDecode(_text);
    }

    public string GetResult()
    {
        return _result;
    }
}