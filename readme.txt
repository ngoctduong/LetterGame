Requirement: “I am the client: I want a game based on letter and more precisely on a real dictionary. I want optimized access to the dictionary as binary tree search. I want only the
functional part, thus i don’t ask explicitly a GUI (console can be enough).
I want necessarily at least the following games:
- The hungman
- The longest word
- The mystery word
- The boogle”
RULES:
* Hungman
The computer chooses a word (length >= 5) and the human tries to guess it by suggesting letters.
- If the letter occurs all positions are revealed
- Otherwise the computer draws one element of the hanged man.
The game stops when:
- Human finds all letters of the word
- Computer completes the diagram as follow:

 

* The longest word
The computer chooses at least three letters (the beginning of a word) and the human tries to complete these letters with the longest word.
If the computer can find a longer one, the human loses. Otherwise the human wins.
Example:
- Computer gives “long”
- The human answers “longest”
- The computer searches a longer one (ex: longitudinal). Then the human lose


* The mystery word
This feature is not a real game but the complementary of the hangman for crosswords. The player gives a word with hole(s), and the computer must retrieve all compatible words.
Example:
1- The player ask the word cross????
2- The computer searches all possibles words:
crossover
crossword
crosswise
crosswind
crosstalk
crossroad
. . .

* The boogle
The game consists in a grid of letters, in which players attempt to find longest words in sequences of adjacent letters. Traditionally, the grid is a square 4x4 but we want let the player decide this parameter (but we must keep a square).
1-  at beginning the computer creates a new grid
2-  then the player enters a word
3-  computer checks if the word is correct for this grid (specifically the adjacency constraint)
4-  it checks then if the word exists in the dictionary
5-  it updates score
6-  when the user cannot find word anymore, the computer searches
all possibles words that the player misses.


