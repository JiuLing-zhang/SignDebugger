using JiuLing.CommonLibs.Security.Signature;

namespace SignDebugger.Page.CommandManage;
internal class UrlEncodeUpperCommand : ICommand
{
    public string Title => "Url 大写编码";
    private string _text;
    private string _result = "";
    public UrlEncodeUpperCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = SignatureBuilder.Create(_text).UrlEncodeUpper().GetResult();
    }

    public string GetResult()
    {
        return _result;
    }
}