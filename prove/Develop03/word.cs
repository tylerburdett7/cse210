using System.ComponentModel.DataAnnotations;

public class Word {
    // constructor for none and text 
    //display function
    //ishidden function return true or false 

    private string _word;
    private bool _isHidden;
    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    public void DisplayWord() {
        if(_isHidden) {
            Console.Write(new string('_', _word.Length));
            Console.Write("_");
        }
        else {
            Console.Write(_word);
        }
    }

    public void HideWord() {
        _isHidden = true;
    }
    public bool IsHidden() {
        return _isHidden;
    }

}


