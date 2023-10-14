using System.Text.Json;

namespace SignDebugger.Page.CommandManage;
internal class JsonToFormCommand : ICommand
{
    public string Title => "Json 提取";
    private string _text;
    private string _result = "";
    public JsonToFormCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        var dic = new Dictionary<string, string>();
        try
        {
            using (var doc = JsonDocument.Parse(_text))
            {
                foreach (JsonProperty property in doc.RootElement.EnumerateObject())
                {
                    dic.Add(property.Name, $"{property.Value}");
                }
            }
            var kv = dic.Select(x => $"{x.Key}={x.Value}").ToArray();
            _result = string.Join("&", kv);
        }
        catch (Exception ex)
        {
            _result = _text;
        }
    }

    public string GetResult()
    {
        return _result;
    }
}