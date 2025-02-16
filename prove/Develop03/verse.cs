public class Verse {
    
    private List<Word> _words;

    public Verse(string verse){
        _words = [];
        var wordsString = verse.Split(' ');

        foreach(var word in wordsString) {
            _words.Add(new Word(word));
        }
    }


    public void DisplayVerse() {
        foreach(var word in _words) {
            word.DisplayWord();
            Console.Write(" ");
        }
    }

    public void HideWords() {
        for(int i = 0; i < 3; i++) {
            Random random = new Random();
            int index = random.Next(0, _words.Count);
            var word = _words.ElementAt(index);
            if (word.IsHidden()) {
                i--;
            }
            else {
                word.HideWord();
            }
       }

    }




}