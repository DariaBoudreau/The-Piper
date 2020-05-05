using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
namespace AdventureGame
{
    public class Game
    {
        public string GameTitle = "The Piper";
        public bool isPickedUp = false;


        //Contains everything that will run when the application opens
        public void Play()
        {
            RunMainMenu();
            StartGame();
            DisplayOutro();
        }

        //displays main menu screen
        private void RunMainMenu()
        {
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.DarkBlue;
            string prompt = @"
_________  __              _______   _                          
|  _   _  |[  |            |_   __ \ (_)                         
|_/ | | \_| | |--.  .---.    | |__) |__  _ .--.   .---.  _ .--.  
    | |     | .-. |/ /__\\   |  ___/[  |[ '/'`\ \/ /__\\[ `/'`\] 
   _| |_    | | | || \__.,  _| |_    | | | \__/ || \__., | |     
  |_____|  [___]|__]'.__.' |_____|  [___]| ;.__/  '.__.'[___]    
                                        [__|

                                   .     _,
                                   |`\__/ /
                                   \  . .(
                                    | __T|
                                   /   |
                      _.---======='    |
=================    //               {}  ====================
                    `|      ,   ,     {}
                     \      /___;    ,'
                      ) ,-;`    `\  //
                     | / (        ;||
                     ||`\\        |||
                     ||  \\       |||
                     )\   )\      )||
                     `''   ''      `''

(Use the arrow keys to cycle through options and press 'enter' to select)";

            ResetColor();
            string[] options = { "Play", "Credits", "Exit", };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    DisplayCredits();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }


        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayCredits()
        {
            WriteLine("Based upon the story of 'The Piper' written by Daria Boudreau");
            WriteLine("Game concept and programming by Daria Boudreau");
            WriteLine("Fonts from http://patorjk.com/software/taag");
            WriteLine("Art from https://www.asciiart.eu/animals/deer");
            WriteLine("Created for Intro to Programming, May 2020");
            WriteLine("Press any key to return to the main menu.");
            ReadKey(true);
            RunMainMenu();
        }


        //Starts up the game
        public void StartGame()
        {
            WriteLine("\n========================================");
            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.Black;
            WriteLine(@"The year is 1997. You are Taylor, a 17 year old just trying to make it through
high school with your girlfriend, Avery, and best friend, Ellis. You all live normal,
boring lives until someone, or something, starts causing people in your town to vanish…");
            ResetColor();

            WriteLine("========================================");

            WriteLine(@"It’s a cool, autumn day, and you’ve just gotten home from school. It was
pretty uneventful, with the only thing out of the ordinary being that Ellis didn’t
show up for school today. You figured he had probably skipped, which was a pretty
common occurrence with him. You were just about to take off your backpack and flop
onto bed when a familiar alert chime comes from your computer. You go to your desk to check the screen.
You have several new messages, some from Avery, and some from Ellis.

(press enter to continue)
");

            ReadLine();

            MessageChoice();

        }


        // TEXT MESSAGES ARRAY

        TextMessage[] MessageSet = new TextMessage[18];
        public Game()
        {
            TextMessage firstMessage = new TextMessage("[3:40pm]", "AVERYxFOSTER", "wonder where the hell ellis was today, he usually tells me if he skips");
            MessageSet[0] = firstMessage;

            TextMessage secondMessage = new TextMessage("[3:40pm]", "AVERYxFOSTER", "he better be getting more weed for the weekend :))))");
            MessageSet[1] = secondMessage;

            TextMessage thirdMessage = new TextMessage("[3:41pm]", "AVERYxFOSTER", "im gonna message him it says hes online");
            MessageSet[2] = thirdMessage;

            TextMessage fourthMessage = new TextMessage("[3:52pm]", "AVERYxFOSTER", "holy shit");
            MessageSet[3] = fourthMessage;

            TextMessage fifthMessage = new TextMessage("[3:52pm]", "AVERYxFOSTER", "taylor youve gotta answer his message RIGHT NOW");
            MessageSet[4] = fifthMessage;

            TextMessage sixthMessage = new TextMessage("[3:53pm]", "AVERYxFOSTER", "if you dont answer im calling your house");
            MessageSet[5] = sixthMessage;

            TextMessage seventhMessage = new TextMessage("[3:53pm]", "Taylor_Patterson", "what happened??is everything okay??");
            MessageSet[6] = seventhMessage;

            TextMessage eighthMessage = new TextMessage("[3:53pm]", "AVERYxFOSTER", "just read his message");
            MessageSet[7] = eighthMessage;

            TextMessage ninthMessage = new TextMessage("[3:27pm]", "ellisthewatson", "dude.");
            MessageSet[8] = ninthMessage;

            TextMessage tenthMessage = new TextMessage("[3:27pm]", "ellisthewatson", "stacey is jsut gone");
            MessageSet[9] = tenthMessage;

            TextMessage eleventhMessage = new TextMessage("[3:30pm]", "ellisthewatson", "please answer me");
            MessageSet[10] = eleventhMessage;

            TextMessage twelthMessage = new TextMessage("[3:53pm]", "Taylor_Patterson", "oh my god im so sorry i just got back from school");
            MessageSet[11] = twelthMessage;

            TextMessage thirteenthMessage = new TextMessage("[3:54pm]", "Taylor_Patterson", "wtf happened????");
            MessageSet[12] = thirteenthMessage;

            TextMessage fourteenthMessage = new TextMessage("[3:54pm]", "ellisthewatson", "we dont know but the cops are already setting up a search party they dont want to waste any time");
            MessageSet[13] = fourteenthMessage;

            TextMessage fifthteenthMessage = new TextMessage("[3:54pm]", "ellisthewatson", "can you please come i need you here");
            MessageSet[14] = fifthteenthMessage;

            TextMessage sixteenthMessage = new TextMessage("[3:54pm]", "ellisthewatson", "and avery too if she can i already told her whats going on");
            MessageSet[15] = sixteenthMessage;

            TextMessage seventeenthMessage = new TextMessage("[3:54pm]", "Taylor_Patterson", "of course im leaving right now");
            MessageSet[16] = seventeenthMessage;

            TextMessage eighteenthMessage = new TextMessage("[3:54pm]", "ellisthewatson", "ok im sending you address");
            MessageSet[17] = eighteenthMessage;

        }



        //ALL CHOICES GO DOWN HERE:

        //Taylor gets home from school and gets messages alerting her Stacey is missing
        public void MessageChoice()
        {
            string prompt = @"Whose messages do you view?";
            string[] options = { "Avery", "Ellis" };
            Menu textMenu = new Menu(prompt, options);
            int selectedIndex = textMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine("Press enter to view messages.");
                    // ADD AIM INTERFACE????
                    MessageSet[0].DisplayText();
                    MessageSet[1].DisplayText();
                    MessageSet[2].DisplayText();
                    MessageSet[3].DisplayText();
                    MessageSet[4].DisplayText();
                    MessageSet[5].DisplayText();
                    WriteLine("\nYou hastily respond back.");
                    MessageSet[6].DisplayText();
                    MessageSet[7].DisplayText();

                    WriteLine("\nPress enter to continue");
                    ReadLine();
                    MessageChoice();
                    break;

                case 1:
                    WriteLine("Press enter to view messages.");
                    // ADD AIM INTERFACE????
                    MessageSet[8].DisplayText();
                    MessageSet[9].DisplayText();
                    MessageSet[10].DisplayText();
                    WriteLine(@"Shock settles in as your heart drops. The whole town had been on alert since three kids went missing over the course of only a few months.
 And now Ellis' little sister was the fourth.");
                    MessageSet[11].DisplayText();
                    MessageSet[12].DisplayText();
                    MessageSet[13].DisplayText();
                    MessageSet[14].DisplayText();
                    MessageSet[15].DisplayText();
                    MessageSet[16].DisplayText();
                    MessageSet[17].DisplayText();
                    WriteLine(@"You shoot a message to Avery, telling her that you're coming to pick her up. You hastily shut down the computer and grab your backpack
once more, nearly flying down the stairs before getting in your car and racing away.");

                    WriteLine("\nPress enter to continue");
                    ReadLine();
                    SuppliesChoice();
                    break;
            }
        }


        // taylor and avery reach the meetup spot for the search party
        public void SuppliesChoice()
        {
            Clear();
            WriteLine(@"The sky is already getting dark. You can’t tell if there’s electricity growing in the air,
indicating an oncoming storm, or if you’re just imagining things.

You pull into a small parking lot with a sign that reads ‘BRUNSWICK PROVINCIAL PARK’.

Dozens of people are milling around the entrance to the trails. 
A few police officers stand nearby, one with arms crossed and another scribbling in a notepad as they talk with a trembling teenage girl who appears to be Stacey’s friend.
You soon spot Ellis, who seems to be in deep conversation with his mother. Mrs. Watson has her arms tightly wrapped around herself. You can tell she’s been crying recently.
Upon noticing you, Ellis slips away and walks over.

‘We’ll be heading out in a few minutes,’ he says. His voice is completely hollow, his face impassive.

'So this is where she was last seen?' you say.

'No, the last place I saw her was my house. But she apparently she snuck out last night to go out with her friend. They were supposed to meet here, but the friend said she
never showed up,' he explains.

'What, to go hiking?'

'No, I doubt it. The park was technically shut down years ago, so there’s no rangers around or anything. I've been here a few times before, it’s a good place to go
if you don’t want to be caught doing something you shouldn’t. And when I checked this morning, part of my stash was taken, so I think I have an idea what Stacey
was coming here to do.'

'God. She's only what, a freshman this year? Seems a little young to be-' Avery pipes up, but Ellis cuts her off.

'Does that even matter right now?' he snaps. 'I can yell at her for stealing my weed after I find her.'

You look around. People have already started getting into small groups and are heading into the woods.
‘We gonna get going, or what?’ Ellis asks, impatience clear in his tone.

(press enter to continue)
");
            ReadLine();


            string prompt = @"You are eager to get going, and Ellis obviously is too, considering every second counts.
But you don't want to head in unprepared, either. What do you do?";
            string[] options = { "Start searching right away", "Stay and look around" };
            Menu suppliesMenu = new Menu(prompt, options);
            int selectedIndex = suppliesMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("========================================");
                    ResetColor();

                    WriteLine(@"‘Alright, let’s get going then,’ you say.
And with that, the search begins.You head out onto one of the many trails, and soon the forest is echoing with desperate cries of Stacey’s name, as well as others
that you don’t recognize.
");

                    ReadLine();
                    PathChoice();
                    break;

                case 1:
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("========================================");
                    ResetColor();

                    WriteLine(@"
You stay and look around.
‘Give me a few minutes,’ You say, ignoring Ellis' sigh of frustration, and leave them to look around the site.There are a lot of people
milling around, so it takes you some time to get a good look at everything going on.

You approach one of the folding tables that seems to be covered in papers.When you get closer, you see that they have stacks of posters
already printed out with Stacey’s picture on them, laying alongside the other missing kids’ faces.It looks like this isn’t just a search
party for Stacey, which explains why there’s so many people here.

An older man with greying hair seems to be watching over the table.

‘Nothing good ever comes out of those woods.Bad things been happenin’ there ever since I was your age.’

It takes you a moment to realize that he’s speaking to you.

‘Yeah. My parents always told me to stay away from here.’

‘Good advice,’ he responds gruffly with an affirming nod. ‘Here.’ He reaches into a crate sitting by the table. ‘Take a map. The place is huge,
don’t want you gettin’ lost too.’

‘Thanks, I appreciate it.’");

                    BackgroundColor = ConsoleColor.DarkCyan;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\n * Park map has been added to your inventory * ");
                    ResetColor();

                    WriteLine(@"

‘Make sure you grab a flashlight too.There’s a lady over with the police handing em out.’

‘Alright, thank you.’

‘Make sure you go in a group!’ he calls out as you make your way over to the place he mentioned.

Sure enough, one of the police officers is carrying a bucket full of small plastic flashlights.You take a few from her, and listen as she repeats
the same advice you’ve been hearing since you got here—don’t go anywhere alone, don’t stray far off the trails.There isn’t much else to see, and you
don’t want to keep Ellis waiting much longer, so you return to them.");

                    BackgroundColor = ConsoleColor.DarkCyan;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\n*Flashlight has been added to your inventory *");
                    ResetColor();

                    WriteLine(@"
‘Took you long enough,’ he grumbles. He shifts his weight on his legs over and over, anxious to get moving.

‘Well, you should be glad I did, because I got stuff for us.’ You give them each a flashlight, saving one for yourself, and put the map in the pocket
of your backpack.The sun hadn’t quite gone down yet, but you definitely didn’t want to get caught out in the dark.

And with that, the search begins. You head out onto one of the many trails, and soon the forest is echoing with desperate cries of Stacey’s name, as
well as others that you don’t recognize.");

                    WriteLine("Press enter to continue");
                    ReadLine();
                    isPickedUp = true;
                    PathChoice();
                    break;
            }
        }


        //choose which path to go down
        public void PathChoice()

        {
            Clear();
            WriteLine(@"You walk down the trail for quite some time, trying to get some distance between yourselves and the other groups so that you all can
cover more ground. You've come across nothing except for a deer or two, watching quietly from the trees before running away. Eventually you reach a fork, with
two new paths going inseparate directions.");
            if (isPickedUp == true)
            {
                WriteLine(@"
You unfold the map and show it to Ellis.

'You've been here, before, right? Which way are you thinking? Right or left?'

'I don't know about going right,' he says. He points to a spot further up that trail on the map where the path meets the water. I've been there before, I know that the bridge
crossing the river. is down. We'd have to go off the path and make a pretty big detour if we went that way.'
'This one on the other hand,' he says, pointing to the left path. 'This one would take us in deeper. There's some abandonned sheds up that way, that we could check out too.");
                WriteLine("Press enter to continue");
            }
            else
            {
                WriteLine(@"
'You've been here, before, right, Ellis? Which way are you thinking?'

'I don't know.' He scans the area around us, looking defeated. 'I've only been here a few times before. I'd need a map to really know where I was going.
Let's try going right, maybe.'

You look to Avery.

'Sorry, I'm just as lost as you guys. I haven't been here since like, sophomore year,' she says. ");
                WriteLine("Press enter to continue");
            }
            ReadLine();

            string prompt = "Avery and Ellis seem to be looking to you to make a decision. What do you do?";
            string[] options = { "Go down the left path", "Go down the right path" };
            Menu pathMenu = new Menu(prompt, options);
            int selectedIndex = pathMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine(@"You head down the left path. It takes you a while, but eventually, you reach the cluster of abandonned shacks that Ellis was talking about.
The sun has finally set, darkening the sky.");
                if (isPickedUp == true)
                    {
                        WriteLine("The three of you pull out your flashlights.");
                    }
                    else
                    {
                        WriteLine("It's getting increasingly harder to see, especially with the thick trees all around you.");
                    }

                    WriteLine(@"
Still, you don't turn up anything. Ellis is getting increasingly frustrated. He storms out of the shack, slamming the wooden door
so hard that you're afraid the flimsy structure might come crashing down.

'Ellis, I know you don’t want to hear this, but I really think we should be heading back,' Avery says cautiously, trying not to upset him even more.

'No.'

'It's been hours, and it's getting dark, I don't want-' she starts.

'Don't care. I'm not leaving until I find something.' Ellis insists.

");
                    ReadLine();
                    DialogueChoice();
                    break;

                case 1:
                    WriteLine(@"
You head down the path to your right.

You keep walking, continuing to periodically shout Stacey's name, but turning up nothing.");
                    if (isPickedUp == true)
                    {
                        WriteLine("Sure enough, just as Ellis said, you eventually find the broken bridge.");
                        ReadLine();
                    }
                    else
                    {
                        WriteLine(@"Eventually, the trail hits water. A large wooden bridge crosses the river, leading to the rest of the trail,
but its' broken.");
                        ReadLine();
                    }
                    WriteLine(@"
Storms and years of neglect have left the middle of it covered by logs and other debris and sunken down into the middle of the rushing waters.

'Shit, we're gonna have to go off the path then,' Ellis says, and leads us around.

Avery doesn't seem too happy at the prospect of leaving the marked trails, but sighs in resignation and follows him.

You continue walking. This detour is becoming significantly longer than you thought it would be.

'Hey Ellis, maybe we should loop back...' you start to say as you scan your surroundings.

Nothing appears out of the ordinary.

That is, until you see someone watching you from afar, between the trees to your left.

The light is dim, and the foliage obscures your view. At first, you think it's someone else from the search party.

'Hey! Have you found anything?' You call out, which momentarily distracts Avery and Ellis, and they cease their arguing, looking in the direction you're facing.

But as the figure steps forward, you very quickly realize that it is not human.

And it is certainly not a deer.
");
                    ReadLine();
                    PiperChoice();
                    break;
            }
        }


        //choose what to say
        public void DialogueChoice()
        {
            WriteLine(@"Avery looks to you.
'Taylor, help me out here?'");
            string prompt = "Do you side with Avery or Ellis?";
            string[] options = { "Avery", "Ellis" };
            Menu pathMenu = new Menu(prompt, options);
            int selectedIndex = pathMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine(@"
'She's right, Ellis. We're completely separated from everyone else, I don't exactly want any of our faces to be on missing posters next,' you say.

'Exactly,' Avery says, seemingly happy that you agree. 'For all we know, we’re dealing with a serial killer or something...'

Ellis' face flashes with anger.

'Oh, so you think she's already dead then, that's it? That we're just gonna find her body in a ditch somewhere? Thanks Avery, that makes me feel loads better!' he hisses.

Avery seems to instantly regret her words. 'No, that's not what I meant-'

Ellis looks more sad than angry, as though a part of him might actually agree with her, but he doesn't back down.

'That's exactly what you meant! You know what, fuck you, I'll find her on my own.' His voice is now raised to a shout, echoing amongst the towering trees.
There are tears streaming down his face.

With that, Avery grabs his arm to prevent him from leaving, and the two of them begin to argue.

Helpless to stop them, you scan your surroundings again.

Nothing appears out of the ordinary.

That is, until you see someone watching between the trees just across from you.

The light is dim, and the foliage obscures your view. At first, you think it's someone else from the search party.

'Hey! Have you found anything?' You call out, which momentarily distracts Avery and Ellis, and they cease their arguing, looking in the direction you're facing.

But as the figure steps forward, you very quickly realize that it is not human.

And it is certainly not a deer.

");
                    ReadLine();
                    PiperChoice();
                    break;

                case 1:
                    WriteLine(@"
You think about how you would feel if you were in Ellis' position. You probably wouldn't want to give up either.

'Alright, let's keep going, then. We still have more shacks to check out.'

Avery looks unconvinced, but finally shrugs in resignation. 'Fine.'

'Thank you,' Ellis says, seeming to have calmed down a bit, but his eyes are still dangerously close to tears.

The three of you walk across the clearing towards another shed. This one is larger than the others. When you approach, you see that it has a strange
set of windchimes hanging off the roof. They appear to be wood, but upon closer inspection, you see that they are made of small animal bones.

'Okay, that's slightly creepy...' Avery says.

Ellis freezes. 'Do you hear that?'

'The chimes? Yeah. Like I said, weird as hell.'

But you hear what he's talking about. Something muffled, coming from inside the shed. 'Something's inside...' you say, backing away from the door.

But Ellis wastes no time in flinging the door open.

It takes you a minute to fully register what you see, and you all stand there, stunned for a few moments.

Stacey's unconscious body is sprawled on the floor.

'Holy shit!'

Ellis rushes towards her, begins shaking her.

A wave of nausea hits you, and you instantly fear the worst.

Until you see her eyes open.

");
                    ReadLine();
                    GameEnding4();
                    break;
            }
        }


        //choose to run or hide
        public void PiperChoice()
        {
            WriteLine(@"
The figure is large, much too large to be a person. It walks on two legs, but has massive antlers protruding from its head.

Avery's eyes widen in horror. 'What the fuck...'

Ellis is too paralyzed to speak.

Your heart starts beating faster and faster. The thing is getting closer. Walking at a slow, but steady pace.");

            string prompt = "What do you do?";
            string[] options = { "Run", "Hide" };
            Menu fourthMenu = new Menu(prompt, options);
            int selectedIndex = fourthMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    WriteLine(@"
You run.

You do your best to stifle a scream, and you all make a break for it, going off the trail and darting into the trees, hoping to evade whatever
it is that's following you.

You run for what feels like forever. The three of you duck beneath branches, jump over huge sprawling roots, doing whatever you can to get as far from
whatever you saw as soon as possible.

Eventually, you realize that you have lost sight of it completely, and slow your pace.");
                    ReadLine();

                    if (isPickedUp == true)
                    {
                        WriteLine(@"
You all catch your breath, and come to an unspoken agreement that you need to get the hell out of this forest. No one wants to stay after what they've seen.

Even Ellis is too frozen with fear to speak up.

You consult the map, and eventually are able to find your way back to the trails.

And you lead Avery and Ellis home, deperately hoping that anyone will believe you when you tell them what you saw.
");
                        ReadLine();
                        GameEnding1();
                    }
                    else
                    {
                        WriteLine(@"Your chest feels heavy. It takes a while to catch your breath.

You desperately search for anything at all that looks familiar.

But none of you have any idea where you are. You've gone far off the trails, and there are no landmarks to guide you.

You all have become hopelessly lost. And you think Avery and Ellis know it, too, but none of you will admit it. But you keep walking.

And walking.

And walking, further and further into the endless wilderness.

");
                        GameEnding2();
                    }

                    break;

                case 1:
                    WriteLine(@"
'Hide! Now!' You whisper, only barely stifling a scream.

But there aren't that many places to hide. You rapidly scan your surroundings. The thing is still getting closer.

The land slopes sharply downward to your left, so you make a break for it, sliding down the incline and hide underneath a large rock outcropping.

You all press your backs to the rock, and crouch down, doing the best you can quiet your breathing.

You all wait, holding each other tightly.

A few excrutiating minutes pass.

The sound of snapping leaves and twigs is getting closer.

And closer.

Until it sounds like it's directly above you.

There is silence.

You watch in horror as two long, clawed hands reach around the edge of the rock formation above you.

And then the face lowers. And it looks down at all of you. Pale skin is stretched over a gaunt face, a terrifying mix of human and animal.

You expect a growl or snarl, or even words to come out of its mouth.

It just smiles.
");
                    ReadLine();
                    GameEnding3();
                    break;
            }
        }

        // In order to get this ending, the player must:
        // Have taken the map and flashlight
        // Have gone down the right trail and chose to run OR went down the left trail, chose to side with Avery, and then chose to run
        public void GameEnding1()
        {
            //Add ASCII font here??
            WriteLine("Ending 1 of 4: 'Going Home.'");
            WriteLine("Press any key to continue.");
            ReadLine();
            DisplayOutro();
        }

        // In order to get this ending, the player must:
        // Have NOT taken the map and flashlight
        // Have gone down the right trail and chose to run OR went down the left trail, chose to side with Avery, and then chose to run
        public void GameEnding2()
        {
            WriteLine("Ending 2 of 4: 'Lost in the Woods.'");
            WriteLine("Press any key to continue.");
            ReadLine();
            DisplayOutro();
        }

        // In order to get this ending, the player must:
        // Have gone down the right trail and chose to hide OR went down the left trail, chose to side with Avery, and then chose to hide
        public void GameEnding3()
        {
            WriteLine("Ending 3 of 4: 'Taken by the Piper.'");
            WriteLine("Press any key to continue.");
            ReadLine();
            DisplayOutro();
        }

        // In order to get this ending, the player must:
        // Have gone down the left trail and chose to side with Ellis
        public void GameEnding4()
        {
            WriteLine("Ending 4 of 4: 'Everyone Survives.'");
            WriteLine("Press any key to continue.");
            ReadLine();
            DisplayOutro();
        }


        public void DisplayOutro()
        {
            string prompt = "Thank you for playing The Piper Demo.";
            string[] options = { "Credits", "Play Again", "Exit" };
            Menu EndMenu = new Menu(prompt, options);
            int selectedIndex = EndMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("Based upon the story of 'The Piper' written by Daria Boudreau");
                    WriteLine("Game concept and programming by Daria Boudreau");
                    WriteLine("Fonts from http://patorjk.com/software/taag");
                    WriteLine("Art from https://www.asciiart.eu/animals/deer");
                    WriteLine("Created for Intro to Programming, May 2020");
                    WriteLine("Press any key to return to the end menu.");
                    ReadKey(true);
                    DisplayOutro();
                    break;

                case 1:
                    StartGame();
                    break;

                case 2:
                    ExitGame();
                    break;

            }

        }


    }
}

