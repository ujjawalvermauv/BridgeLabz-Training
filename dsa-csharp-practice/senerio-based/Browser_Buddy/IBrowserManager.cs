using System;
public interface IBrowserManager
{
    void Visit(string url);
    void Back();
    void Forward();
    void DisplayHistory();
    void CloseTab();
    void RestoreTab();
}
