public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructors
    public Word()
    {
        _text = "";
        _isHidden = false;
    }

    public Word(string text)
    { 
        _text = text;
        _isHidden= false;
    }

    //Getters and Setters
    public string GetText()
    {
        return _text;
    }
    public void SetText (string text)
    {
        _text = text;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void SetIsHidden (bool isHidden)
    {
        _isHidden = isHidden;
    }

    public void Hide()
    {
        _isHidden= true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden)
            return true;
        else
            return false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
           string hideWord = new string('_', _text.Length);
            return hideWord;
        }
        else
            return _text;

    }

}
