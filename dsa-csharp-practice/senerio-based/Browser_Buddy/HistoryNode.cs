using System;

public class HistoryNode
{
    private string _url;
    private HistoryNode _previous;
    private HistoryNode _next;

    public string Url
    {
        get
        {
            return _url;
        }
        set
        {
            _url = value;
        }
    }

    public HistoryNode Prev   
    {
        get
        {
            return _previous;
        }
        set
        {
            _previous = value;
        }
    }

    public HistoryNode Next
    {
        get
        {
            return _next;
        }
        set
        {
            _next = value;
        }
    }

    public HistoryNode(string pageUrl)
    {
        _url = pageUrl;
        _previous = null;
        _next = null;
    }

    public override string ToString()
    {
        return _url;
    }
}
