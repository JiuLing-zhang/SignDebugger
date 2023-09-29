using JiuLing.CommonLibs.Security.Signature;

namespace SignDebugger.Page.CommandManage;
internal class UrlEncodeLowerCommand : ICommand
{
    public string Title => "Url 小写编码";
    private string _text;
    private string _result = "";
    public UrlEncodeLowerCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = SignatureBuilder.Create(_text).UrlEncodeLower().GetResult();
    }

    public string GetResult()
    {
        return _result;
    }
}