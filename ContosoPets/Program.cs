using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");


Console.Clear();

// #1 the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

string[] animalDataLabels = ["ID #", "Species", "Nickname", "Age", "Physical Description", "Personality", "Suggested Donation"];


// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal petDonation = 0.00m;


// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, animalDataLabels.Length];


// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
	switch (i)
	{
		case 0:
			animalSpecies = "dog";
			animalID = "d1";
			animalAge = "2";
			animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
			animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
			animalNickname = "lola";
			suggestedDonation = "85.00";
			break;

		case 1:
			animalSpecies = "dog";
			animalID = "d2";
			animalAge = "9";
			animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
			animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
			animalNickname = "gus";
			suggestedDonation = "49.99";
			break;

		case 2:
			animalSpecies = "cat";
			animalID = "c3";
			animalAge = "1";
			animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
			animalPersonalityDescription = "friendly";
			animalNickname = "snow";
			suggestedDonation = "40.00";
			break;

		case 3:
			animalSpecies = "cat";
			animalID = "c4";
			animalAge = "3";
			animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
			animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
			animalNickname = "Lion";
			suggestedDonation = "";
			break;

		default:
			animalSpecies = "";
			animalID = "";
			animalAge = "";
			animalPhysicalDescription = "";
			animalPersonalityDescription = "";
			animalNickname = "";
			suggestedDonation = "";
			break;

	}
	

	ourAnimals[i, 0] = animalID;
	ourAnimals[i, 1] = animalSpecies;
	ourAnimals[i, 2] = animalNickname;
	ourAnimals[i, 3] = animalAge;
	ourAnimals[i, 4] = animalPhysicalDescription;
	ourAnimals[i, 5] = animalPersonalityDescription;
	
	
	if (!decimal.TryParse(suggestedDonation, out petDonation))
	{
		petDonation = 45.00m;
	}
	
	ourAnimals[i, 6] = $"{petDonation:C2}";

}



// #5 display the top-level menu options
do
{
	// NOTE: the Console.Clear method is throwing an exception in debug sessions
	Console.Clear();

	Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
	Console.WriteLine(" 1. List all of our current pet information");
	Console.WriteLine(" 2. Display all dogs with a specified characteristic");
	Console.WriteLine();
	Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

	readResult = Console.ReadLine();
	if (readResult != null)
	{
		menuSelection = readResult.ToLower();
	}

	// use switch-case to process the selected menu option
	switch (menuSelection)
	{
		case "1":
			// list all pet info
			for (int i = 0; i < maxPets; i++)
			{
				if (ourAnimals[i, 0] != "")
				{
					Console.WriteLine();
					for (int j = 0; j < animalDataLabels.Length; j++)
					{
						Console.WriteLine($"{animalDataLabels[j]}: {ourAnimals[i, j]}");
					}
				}
			}
			Console.WriteLine("\n\rPress the Enter key to continue");
			readResult = Console.ReadLine();

			break;

		case "2":
			// Display all dogs with a specified characteristic
			Console.WriteLine("\nUNDER CONSTRUCTION - please check back next month to see progress.");
			Console.WriteLine("Press the Enter key to continue.");
			readResult = Console.ReadLine();
			break;

		default:
			break;
	}

} while (menuSelection != "exit");
