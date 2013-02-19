using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioQuizShow.Models
{
    public class QuizShowViewModel
    {
        public QuizShowViewModel()
        {
            this.PlayQuizShow = true;

            this.Questions = new List<Question>()
            {
                new Question() {
	                Id = 0,
	                Text = "What was Jason Bourne's real name?",
	                Difficulty=1,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "David Webb",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Ethan Hunt",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Alex Laemus",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "John Clark",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 1,
	                Text = "Ethan Hunt works for which organization?",
	                Difficulty=1,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "IMF",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "MIF",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "MI5",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "NSA",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 2,
	                Text = "Jason Bourne worked for which organization?",
	                Difficulty=1,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "CIA",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "NSA",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "FBI",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "IMF",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 3,
	                Text = "Which person as of 2012 has been Oscar nominated a record 17 times?",
	                Difficulty=1,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Meryl Streep",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Jack Nicholson",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Katherine Hepburn",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Richard Burton",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 4,
	                Text = "What was the most expensive silent film ever made?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Ben Hur",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "The Great Dictator",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "The General",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Gold Rush",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 5,
	                Text = "What was the name of Godzilla's son?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Mozilla",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Fozilla",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Zozilla",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Bozilla",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 6,
	                Text = "Helen Mirren appeared in which film with a year in the title?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 7,
	                Text = "What is the name of the mouse in the film 'The Green Mile'?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Mr. Jingles",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Mr. Wrinkles",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Mr. Bo Jangles",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Mr. Tingles",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 8,
	                Text = "Who was not a member of 'The Brat Pack'?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Tom Hanks",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Tom Cruise",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Patrick Swayze",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Matt Dillon",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 9,
	                Text = "What is the name of the space ship in the first Alien film?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Nostromo",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Endeavour",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Dreadnought",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Poseidon",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 10,
	                Text = "What is John Rambo's middle initial?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "J",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "R",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "T",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "K",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 11,
	                Text = "Which horror film set in Bodega Bay has no music score?",
	                Difficulty=2,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "The Birds",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "The Mist",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Jaws",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Carrie",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 12,
	                Text = "A plot element in film is often called what?",
	                Difficulty=3,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "MacGuffin",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Macbeth",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Macleod",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Macangus",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 13,
	                Text = "Which fruit plays a role in the downfall of Capt. Queeg in 'The Caine Mutiny'?",
	                Difficulty=3,
	                Category="Film",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Strawberries",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Oranges",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Bananas",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Peaches",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 14,
	                Text = "The Ancient Mariner was penalized for shooting which bird?",
	                Difficulty=1,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Albatross",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Swan",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Condor",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Owl",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 15,
	                Text = "What is the scientific name for the constellation known as 'The Archer'?",
	                Difficulty=1,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Sagittarius",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Andromeda",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Capricornus",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Gemini",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 16,
	                Text = "Which nickname has been given to the UN Peacekeeping Force?",
	                Difficulty=1,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Blue Berets",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "White Berets",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Green Berets",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Red Berets",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 17,
	                Text = "The Chinese delicacy Birds Nest Soup is made from what?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Seaweed",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Straw",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Noodles",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Egg whites",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 18,
	                Text = "What are the first four words of the Hippocratic Oath?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "I swear by Apollo",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "I swear by Zeus",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "I swear by Athena",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "I swear by Hades",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 19,
	                Text = "What do farmers in Norway provide their cows with in order to produce more milk?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "A mattress",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Television",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Slippers",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Chocolate ",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 20,
	                Text = "What is a kylie in Australia?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "A boomerang that won't come back",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "A female crocodile",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "A hen night",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "A surf board",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 21,
	                Text = "A boomerang that won't come back is called what in Australia?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Kylie",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Bruce",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Sheila",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Rolf",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 22,
	                Text = "Asclepius was the Greek god of what?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Medicine",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "The harvest",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Sport",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "The Weather",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 23,
	                Text = "Which two semaphoric letters are found on the iconic 1960s peace symbol? ",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "N and D",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "P and H",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "L and P",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "W and D",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 24,
	                Text = "What is the traditional colour worn by mourners in China?",
	                Difficulty=2,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "White",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Red",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Black",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Yellow",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 25,
	                Text = "What is the name of the most expensive perfume in the world?",
	                Difficulty=3,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Clive Christian No 1",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Claude Christian No 1",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Corbin Christian No 1",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Calvin Christian No 1",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 26,
	                Text = "Which letter of the alphabet is the traditional code name for the head of MI6?",
	                Difficulty=3,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "C",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Q",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "M",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "H",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 27,
	                Text = "Which of the following is a long scarf worn by learned men?",
	                Difficulty=3,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Liripoop",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Tittynope",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Bafflegab",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Attercop",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 28,
	                Text = "Which of the following is not a surname in the USA?",
	                Difficulty=3,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Q",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "W",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "J",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "F",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 29,
	                Text = "Who was the first Time Magazine Man of the Year in 1927?",
	                Difficulty=3,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Charles Lindbergh",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Joseph Stalin",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Adolf Hitler",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Albert Einstein",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 30,
	                Text = "Who was the first man to appear on the cover of Playboy magazine?",
	                Difficulty=3,
	                Category="General Knowledge",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Peter Sellers",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Paul Newman",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Marlon Brando",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Johnny Carson",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 31,
	                Text = "The Daiquiri cocktail is named after a village located on which island country?",
	                Difficulty=1,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Cuba",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Barbados",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Martinique",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Madagascar",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 32,
	                Text = "What is the most populated city in the USA named after a general?",
	                Difficulty=1,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Houston",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Washington",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Detroit",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "San Francisco",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 33,
	                Text = "Which famous landmark is found on Mount Lee?",
	                Difficulty=1,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Hollywood Sign",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Angel Falls",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Statue of Liberty",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Niagara Falls",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 34,
	                Text = "Which of the following countries is an acronym?",
	                Difficulty=1,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Pakistan",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Canada",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Belize",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Iraq",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 35,
	                Text = "Which comic book figure shares his name with a city in Turkey?",
	                Difficulty=1,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Batman",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Hulk",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Magneto",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Hellboy",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 36,
	                Text = "What is the name of the river that runs through Amsterdam?",
	                Difficulty=1,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Amstel",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Grolsch",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Heineken",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Bavaria",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 37,
	                Text = "According to folklore Baba Yaga is a witch in which country?",
	                Difficulty=2,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Russia",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Persia",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Spain",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Japan",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 38,
	                Text = "Which country has a record 11 official languages?",
	                Difficulty=2,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "South Africa",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Brazil",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Russia",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "China",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 39,
	                Text = "What is the only landlocked country in South East Asia?",
	                Difficulty=2,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Laos",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Vietnam",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Cambodia",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Myanmar",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 40,
	                Text = "The name of which European capital city translated means 'wisdom'?",
	                Difficulty=2,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Sophia",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Warsaw",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Nicosia",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Vaduz",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 41,
	                Text = "What is the most populated city north of the Arctic Circle?",
	                Difficulty=2,
	                Category="Geography & Places",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Murmansk",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Oslo",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Ottawa",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Anchorage",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 42,
	                Text = "Who coined the expression \"15 minutes of fame\"?",
	                Difficulty=1,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Andy Warhol",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "John Lennon",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Lee Harvey Oswald",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Charlie Chaplin",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 43,
	                Text = "Where did Aristotle claim the mind was located?",
	                Difficulty=1,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Heart",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Brain",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Soul",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Stomach",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 44,
	                Text = "Henry Ford kept the last breath of which man in an enclosed test tube?",
	                Difficulty=1,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Thomas Edison",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Billy the Kid",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Abraham Lincoln",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Sitting Bull",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 45,
	                Text = "Which name was given to Mussolini's Italian fascists?",
	                Difficulty=1,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Black Shirts",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Brown Shirts",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Green Shirts",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Red Shirts",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 46,
	                Text = "In which year did the Royal Navy abolish the rum ration?",
	                Difficulty=1,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 47,
	                Text = "What did William Shakespeare leave his wife in his will?",
	                Difficulty=1,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "His 2nd best bed",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "His 2nd best horse",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "His 2nd best shoes",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "His 2nd best quill",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 48,
	                Text = "In which year did Coca-Cola first become cocaine free?",
	                Difficulty=2,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 49,
	                Text = "Which of the following was a former Soviet intelligence agency?",
	                Difficulty=2,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "MGB",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "XKE",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "TR6",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "VW",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 50,
	                Text = "Which ship held the Blue Riband for the fastest Atlantic crossing between 1907-1929? ",
	                Difficulty=2,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Mauretania",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Lusitania",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Olympic",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Queen Mary",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 51,
	                Text = "Which name did the Portuguese originally give to the Cape of Good Hope?",
	                Difficulty=2,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Cape of Storms",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Cape Fear",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Cape of No Return",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Dark Cape",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 52,
	                Text = "What did the ancient Greeks use to cast their ballots?",
	                Difficulty=2,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Beans",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Olives",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Raisons",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Almonds",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 53,
	                Text = "How many female snipers did the Soviet Union have during World War Two?",
	                Difficulty=3,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 54,
	                Text = "According to an 1851 census, what was the population of the U.K.?",
	                Difficulty=3,
	                Category="History",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "20,959,477",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "10,959,477",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "30,959,477",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "5,959,477",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 55,
	                Text = "The word Avatar stems from which language?",
	                Difficulty=1,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Sanskrit",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Latin",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Arabic",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Zulu",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 56,
	                Text = "Which organizations name translated means 'The Base'?",
	                Difficulty=1,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Al-Qaida",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Hamas",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Al Jazeera",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Hezbollah",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 57,
	                Text = "Which Persian title means 'manifestation of god'?",
	                Difficulty=1,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Ayatollah",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Emir",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Sultan",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Sayyid",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 58,
	                Text = "Which cocktails name translated means 'pearl'?",
	                Difficulty=2,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Margarita",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Julep",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Mai Tai",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Martini",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 59,
	                Text = "Which drink takes its name from the Hindi word for 'five'?",
	                Difficulty=2,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Punch",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Julep",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Fizz",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Gimlet",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 60,
	                Text = "The name of which precious stone means 'not to intoxicate'?",
	                Difficulty=2,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Amethyst",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Lapis Lazuli",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Turquoise",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Obsidian",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 61,
	                Text = "What is the heraldic word for the colour blue?",
	                Difficulty=2,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Azure",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Sable",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Argent",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Sanguine",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 62,
	                Text = "Which month of the year is derived from the Latin word 'to purify'?",
	                Difficulty=2,
	                Category="Language & Words",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "February",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "January",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "April",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "May",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 63,
	                Text = "Which popular children's book first appeared with a swastika on its cover in 1917?",
	                Difficulty=1,
	                Category="Literature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Jungle Book",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Peter Pan",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Wind in the Willows",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Pinocchio",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 64,
	                Text = "In literature, which letter was 'The Scarlet Letter'?",
	                Difficulty=2,
	                Category="Literature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "A",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "F",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "H",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "X",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 65,
	                Text = "Who is the grand master of Soviet espionage in 'Smiley's People'?",
	                Difficulty=3,
	                Category="Literature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Karla",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Boris",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Ivan",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Yuri",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 66,
	                Text = "What was the name of the fire demon that haunted the Mines of Moria?",
	                Difficulty=3,
	                Category="Literature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Balrog",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Warg",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Shelob",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Glaurung",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 67,
	                Text = "Which room was a hit song in the 1960s?",
	                Difficulty=1,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "White Room",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Dark Room",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Bedroom",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Motel Room",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 68,
	                Text = "Who was the first musician to achieve 1 billion YouTube hits?",
	                Difficulty=1,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Lady Gaga",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Elvis Presley",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Madonna",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Robbie Williams",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 69,
	                Text = "Who was the first person to appear on the cover of The Rolling Stone magazine?",
	                Difficulty=1,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "John Lennon",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Dr. Hook",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Bob Dylan",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Richard Nixon",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 70,
	                Text = "Which 1958 album was the first gold album?",
	                Difficulty=2,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Oklahoma",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "California",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Ohio",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Texas",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 71,
	                Text = "Which cities name is used by Rastafarians to designate the ungodly western civilization? ",
	                Difficulty=2,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Babylon",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "London",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Sodam",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Jericho",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 72,
	                Text = "What is the S-shaped sound hole in a violin called?",
	                Difficulty=2,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "F-hole",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "S-hole",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "V-hole",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "X-hole",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 73,
	                Text = "Which band were the first to appear on Top of the Pops in 1964?",
	                Difficulty=2,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Rolling Stones",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Beatles",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Zombies",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "The Shadows",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 74,
	                Text = "In the Beatles song 'Penny Lane', who keeps a portrait of the Queen in their pocket? ",
	                Difficulty=3,
	                Category="Music",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Fireman",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Barber",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Banker",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Nurse",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 75,
	                Text = "The flying fox is what kind of animal?",
	                Difficulty=1,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Bat ",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Squirrel",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Monkey",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Fox",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 76,
	                Text = "Where in the human body is the smallest muscle located?",
	                Difficulty=1,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Ear",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Heart",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Eye",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Nose",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 77,
	                Text = "What is the other name for the Baobab tree?",
	                Difficulty=2,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Monkey tree",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Buffalo tree",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Python tree",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Ape tree",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 78,
	                Text = "Bombast is a product from which animal?",
	                Difficulty=2,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Silkworm",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Pot Whale",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Oyster",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Honey Bee",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 79,
	                Text = "Which of the following is not a type of shark?",
	                Difficulty=2,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Doctor",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Cookie Cutter",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Nurse",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Carpenter",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 80,
	                Text = "Which metal is named after a malicious mine demon?",
	                Difficulty=2,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Cobalt",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Tungsten",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Plutonium",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Bismuth",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 81,
	                Text = "Pluto orbits our sun once every how many years?",
	                Difficulty=2,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 82,
	                Text = "Which animal has the thickest fur in the world?",
	                Difficulty=3,
	                Category="Science & Nature",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Sea Otter",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Camel",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Snow Lion",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Polar Bear",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 83,
	                Text = "Who, as of 2012, is the youngest winner of the Wimbledon Mens Singles title?",
	                Difficulty=1,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Boris Becker",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Pete Sampras",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Rod Laver",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Björn Borg",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 84,
	                Text = "Who was the first person in sport to earn 1 million US dollars?",
	                Difficulty=1,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "John L. Sullivan",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Cassius Clay",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Babe Ruth",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Jack Nicklaus",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 85,
	                Text = "Acol is a common system in which game?",
	                Difficulty=2,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Bridge",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Curling",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Roulette",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Chess",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 86,
	                Text = "Who is the oldest male tennis player to have won a Grand Slam singles title?",
	                Difficulty=2,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Ken Rosewall",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Jimmy Connors",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Rod Laver",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Pete Sampras",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 87,
	                Text = "Which country has a national football team nicknamed 'The Eagles of Carthage'?",
	                Difficulty=2,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Tunisia",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Libya",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Morocco",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Nigeria",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 88,
	                Text = "The longest winning streak in sporting history was held by which club?",
	                Difficulty=3,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "New York Yacht Club",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Montreal Canadiens",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Manchester United",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Dallas Cowboys",
			                Order = 3
			                }
		                }
	                },
                new Question() {
	                Id = 89,
	                Text = "Who, as of 2012, was the oldest Formula 1 World Driver's Champion?",
	                Difficulty=3,
	                Category="Sport & Games",
	                PossibleAnswers = new List<PossibleAnswer>() {
		                new PossibleAnswer() {
			                Text = "Juan Manuel Fangio",
			                Order = 0
			                },
		                new PossibleAnswer() {
			                Text = "Jackie Stewart",
			                Order = 1
			                },
		                new PossibleAnswer() {
			                Text = "Michael Schumacher",
			                Order = 2
			                },
		                new PossibleAnswer() {
			                Text = "Jack Brabham",
			                Order = 3
			                }
		                }
	                }
            };
        }

        public List<Question> Questions { get; set; }

        public bool PlayQuizShow { get; set; }

        //public static Question RandomQuestion()
        //{
        //    Random rand = new Random(Environment.TickCount);

        //    QuizShowViewModel vm = new QuizShowViewModel();
        //    var question = vm.Questions[rand.Next(vm.Questions.Count())];
        //    return question;
        //}
    }
}