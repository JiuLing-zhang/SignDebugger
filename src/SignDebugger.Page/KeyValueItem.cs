namespace SignDebugger.Page;
public class KeyValueItem
{
    public string Key { get; set; }
    public string Value { get; set; }
    public KeyValueItem(string key = "", string value = "")
    {
        Key = key;
        Value = value;
    }
}