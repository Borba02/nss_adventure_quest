using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text) {
            _text = text;
        }

        //method to show the prize the adventurer has recieved. Will print the same amount of times as the adventurer's awesomeness.
        public void ShowPrize(Adventurer adventurer) {
            if (adventurer.Awesomeness > 0) {
                Console.WriteLine("You have recieved the hefty reward of: ");
                for (int i = 0; i < adventurer.Awesomeness; i++) {
                    Console.WriteLine(_text);
                }
            } else {
                Console.WriteLine("You recieve nothing. For you are pathetic. Worm.\nThis is a message of pity.");
            }
        }
    }
}