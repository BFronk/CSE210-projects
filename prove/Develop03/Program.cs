using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Scripture script1 = new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        scriptures.Add(script1);
        Scripture script2 = new Scripture(new Reference("Matthew", 5, 14, 16), "Ye are the light of the world. A city that is set on an hill cannot be hid.; Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house.; Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        scriptures.Add(script2);
        Scripture script3 = new Scripture(new Reference("James", 1, 5, 6), "5 If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not- and it shall be given him.; But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        scriptures.Add(script3);
        Scripture script4 = new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.");
        scriptures.Add(script4);
        Scripture script5 = new Scripture(new Reference("D&C", 88, 123, 124), "See that ye love one another; cease to be covetous; learn to impart one to another as the gospel requires.; Cease to be idle; cease to be unclean; cease to find fault one with another; cease to sleep longer than is needful- retire to thy bed early, that ye may not be weary; arise early, that your bodies and your minds may be invigorated.");
        scriptures.Add(script5);

        //Randomly chooses a scripture from list of scriptures
        Random scriptChooser = new Random();
        int scriptint = scriptChooser.Next(scriptures.Count());
        Scripture chosenScript = scriptures[scriptint]; 
        while (true)
        {
            Console.Clear();
            if (chosenScript.IsCompletelyHidden())
            {
                Console.WriteLine("you're done!");
                break;
            }
            else
            {
                chosenScript.HideRandomWords(3);
                Console.WriteLine(chosenScript.GetDisplayText());                
                Console.WriteLine("Press enter to coninue and quit to end the program");
                string userInput = Console.ReadLine();
                if  (userInput == "quit")
                {
                    break;
                }
            }
        }
    }   
}