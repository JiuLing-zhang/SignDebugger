using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignDebugger.Page.CommandManage;
internal class ToUpperCommand : ICommand
{
    public string Title => "转大写";
    private string _text;
    private string _result = "";
    public ToUpperCommand(string text)
    {
        _text = text;
    }

    public void Execute()
    {
        _result = _text.ToUpper();
    }

    public string GetResult()
    {
        return _result;
    }
}