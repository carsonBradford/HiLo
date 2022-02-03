namespace HiLo
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        public Deck _deck = new Deck();
        bool isPlaying = true;
        int score = 300;
        public Card _currentCard = new Card(_deck.drawNext());
       public  Card _nextCard = _deck.drawNext();

       public string _guess;
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write($"The card is : " + _currentCard._face);
            Console.Write("Higher or lower? [h/l] ");
            _guess = Console.ReadLine();
            Console.Write($"The card was : " + _nextCard._face);
            
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }

            if ((( _guess == "l") && (_currentCard._value > _nextCard._value)) || (( _guess == "h") && (_currentCard._value < _nextCard._value)))
            {
                score += 100;
            } 
            else
            {
                score -= 75;
            }
            Console.WriteLine("Play again? [y/n] ");
            string ans = Console.ReadLine();
            if (ans == "n"){
                isPlaying = false;
            }
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            _currentCard = _nextCard;
            _nextCard = _deck.drawNext();
        }
    }
}


