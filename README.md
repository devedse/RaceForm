# RaceForm

Bet on horses to win money!

# Cheat Sheet

### Assigning class variables

```
public class Game
{
	private ILogger logger;
	public int AmountOfHorses { get; set; }

	//Het is dus altijd per parameter eerst het type (de class, interface of int/string/etc) en dan een naampje
	//Dus ILogger = het type, logger = de naam
	//En int = het type, amountOfHorses = de naam
	public Game(ILogger logger, int amountOfHorses)
	{
		//We moeten hier this.logger doen om te verwijzen naar het veld logger van deze klasse
		//Want het veld logger (van de klasse) heeft dezelfde naam als logger die als parameter binnenkomt in deze constructor)
		this.logger = logger;

		//Bij AmountOfHorses is het veld van de klasse met een hoofdletter, dus hoeven we geen this.
		AmountOfHorses = amountOfHorses;
		//Het zou wel kunnen, dan zou er dus this.AmountOfHorses = amountOfHorses; staan
	}
}
```

### Creating a list in a class variable

```
public class Game
{
	public List<Horse> Horses { get; set; }

	public Game(int amountOfHorses)
	{
		this.logger = logger;

		Horses = new List<Horse>();

		for (int i = 0; i < amountOfHorses; i++)
		{
			Horses.Add(new Horse("Huppelpaard" + i, this));
		}
	}

	public void LogPaardjes()
	{
		//Omdat Horses (de class variable) is gevuld kunnen we er hier door heen lopen
		foreach (var horse in Horses)
		{
			Console.WriteLine($"Paard: {horse.Name}");
		}
	}
}
```

### Adding a new item to a list

```
public class Game
{
	public List<Gambler> Gamblers { get; set; }

	public Game()
	{
		Gamblers = new List<Gambler>();
	}

	public void addGambler(string naam, int cash)
	{
		Gamblers.Add(new Gambler(naam, cash));
	}
}
```