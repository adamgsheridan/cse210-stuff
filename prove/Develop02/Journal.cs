class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public override string ToString()
    {
        string journalString = "";
        foreach (Entry entry in this._entries)
        {
            journalString += entry.ToString();
        }
        return journalString;
    }
}