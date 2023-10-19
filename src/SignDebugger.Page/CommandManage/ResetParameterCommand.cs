using JiuLing.CommonLibs.ExtensionMethods;

namespace SignDebugger.Page.CommandManage;
internal class ResetParameterCommand : ICommand
{
    public string Title => $"重置参数";
    private List<KeyValueItem> _parameters;
    private string _result = "";
    public ResetParameterCommand(List<KeyValueItem> parameters)
    {
        _parameters = parameters;
    }
    public void Execute()
    {
        _result = string.Join('&', _parameters.Where(x => x.Key.Trim().IsNotEmpty()).Select(x => $"{x.Key}={x.Value}").ToArray());
    }

    public string GetResult()
    {
        return _result;
    }
}