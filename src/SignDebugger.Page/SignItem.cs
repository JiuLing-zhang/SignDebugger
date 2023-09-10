namespace SignDebugger.Page;
internal class SignItem
{
    public int Seq { get; set; }
    public string Operation { get; set; }
    public string Result { get; set; }
    public SignItem(int seq, string operation, string result)
    {
        Seq = seq;
        Operation = operation;
        Result = result;
    }
}