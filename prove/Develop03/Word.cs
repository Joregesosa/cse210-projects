class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string getDisplayText()
    {
        if (_isHidden)
        {
            return string.Concat(Enumerable.Repeat("-", _text.Length)) + " ";
        }
        else
        {
            return _text + " ";
        }
    }

    public void hide()
    {
        _isHidden = true;
    }

    public void show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

}