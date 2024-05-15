public class Entry
{
    public string _text;
    public string _prompt;
    public string _date;

    public override string ToString()
    {
        return "Date: " + this._date + " - Prompt: " + this._prompt + "\n" + this._text + "\n\n";
    }
}