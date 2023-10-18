using System.Collections.Specialized;

namespace SignDebugger.Page.CommandManage;
internal class RemoveParameterCommand : ICommand
{
    public string Title => $"删除参数：{_key}";
    private string _text;
    private string _key;
    private string _result = "";
    public RemoveParameterCommand(string text, string key)
    {
        _text = text;
        _key = key;
    }
    public void Execute()
    {
        NameValueCollection queryParams = System.Web.HttpUtility.ParseQueryString(_text);
        if (queryParams[_key] != null)
        {
            queryParams.Remove(_key);
        }

        string updatedParameterString = "";
        for (int i = 0; i < queryParams.Count; i++)
        {
            if (i > 0)
            {
                updatedParameterString += "&";
            }
            updatedParameterString += queryParams.GetKey(i) + "=" + queryParams[i];
        }
        _result = updatedParameterString;
    }

    public string GetResult()
    {
        return _result;
    }
}