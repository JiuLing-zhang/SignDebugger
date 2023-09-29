using JiuLing.CommonLibs.Security.Signature;

namespace SignDebugger.Page.CommandManage;
internal class OrderByCommand : ICommand
{
    public string Title => "字典序";
    private string _text;
    private string _result = "";
    public OrderByCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = SignatureBuilder.Create(_text).OrderBy().GetResult();
    }

    public string GetResult()
    {
        return _result;
    }
}