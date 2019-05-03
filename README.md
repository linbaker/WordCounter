# _Word Counter _

https://github.com/linbaker/WordCounter

#### _C# Testing Exercise for Epicodus, 05.03.2019_

#### By _**Lindsey Baker**_

## Description

_This application take a word and sentence from a user and count how many times the inputted word has been used in the sentence. Only full word matches are counted._

## Setup/Installation Requirements

* _Clone Repository_
* _Compile in C# .Net Core 2.2_



|Behavior|Input|Output|
|-|-|-|
|Input single word to compare to single word not matching, count remains zero |"hello", "goodbye"| 0 |
|Input single word to compare to single word identical matching, counts increases to 1 |"hello", "hello"| 1 |
|Input single word to compare to single word identical matching regardless of case, counts increases to 1 |"hello", "HeLlO"| 1 |
|Input single word to compare to multiple words, count increases for every match |"hello", "HeLlO world I said hello"| 2 |
|Input single word to compare to multiple words with period at the end of sentence, count increases for every match |"hello", "HeLlO world I said hello hello."| 3 |
|Input single word to compare to multiple words with punctuation, count increases for every match |"cat", "Cat, the cat, thought 'I am the best cat!'""| 3 |
|Input single word to compare to multiple words with punctuation, count increases for every match |"good-bye", "I said 'Good-bye' waving good-bye"| 2 |


## Known Bugs

_Not all edge conditions are accounted, such as special characters and numbers in the inputted word, plurals or possessive words. Accented letters are also not accounted for._

## Support and contact details

_Please contact me with any questions, ideas or concerns at lindseybaker0@gmail.com_

## Technologies Used

_C# .NET Core 2.2_


### License

*This software is licensed under the MIT license.*
Copyright (c) 2019 **Lindsey Baker**
