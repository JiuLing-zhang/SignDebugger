namespace SignDebugger.Page.CommandManage;
internal class CommandExecutor
{
    private ICommand? _currentCommand;
    private Stack<ICommand> _commandHistory;

    public CommandExecutor()
    {
        _commandHistory = new Stack<ICommand>();
    }

    public void Execute(ICommand command)
    {
        command.Execute();
        _currentCommand = command;
        _commandHistory.Push(command);
    }

    public void Undo()
    {
        if (_commandHistory.Count > 0)
        {
            _commandHistory.Pop();
            if (_commandHistory.Count > 0)
            {
                _currentCommand = _commandHistory.Peek();
            }
            else
            {
                _currentCommand = null;
            }
        }
    }

    public List<SignItem> GetHistory()
    {
        var result = new List<SignItem>();
        var commandHistory = _commandHistory.ToList();
        commandHistory.Reverse();
        foreach (var command in commandHistory)
        {
            result.Add(new SignItem(result.Count + 1, command.Title, command.GetResult()));
        }
        return result;
    }

    public string GetResult()
    {
        return _currentCommand?.GetResult() ?? "";
    }
}