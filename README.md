# _Word Counter!_

#### _A fun C# program that checks how frequently a word appears in the sentence._

#### By _**Alex Skreen**_

## Description
### Word Counter

When the user runs the application, they should receive a prompt to enter a word as well as a sentence

The program will search the sentence for the user inputted word.

The application will return the total number of times that word occurs in the user inputted sentence. This does not include longer words that happen to include the user inputted word

## Setup/Installation Requirements


### Node install

_Install Git with the following command:_
* ``$ brew install git``

_Next, install Node.js by entering the following command in Terminal:_
* ``$ brew install node``

### .NET and C# install

#### For macOS:
_If .NET and C# are not installed on your computer already, then install using the following steps:_
* download [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)

* Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

* install and use a REPL called dotnet script.
* run ``dotnet tool install -g dotnet-script`` in the command line
* Download the [MySQL Community Server DMG File](https://dev.mysql.com/downloads/file/?id=484914)
* Click the download icon Use the No thanks, just start my download link.
* Follow along with the Installer
* run ``echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`` in the command line.
* Download the [MySQL Workbench DMG File](https://dev.mysql.com/downloads/file/?id=484391)
* Click the download icon Use the No thanks, just start my download link.


### Setup/install this application

_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone https://github.com/alexskreen/WordCounter``
* ``$ cd WordCounter.Solution``

_Confirm that you have navigated to the Bakery directory (e.g., by entering the command_ ``pwd`` in terminal). 

_Next, build the project and all of its dependencies at the project's root directory via the following command:_
* ``$ dotnet build``

_Open this application via live server using the following command:_
* ``$ dotnet run``

_To view/edit the source code of this application, open the contents of the camping directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._



## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------:|:------:|:------:
| The program will take in a word from the user | "Cat" | "Cat" |
| The program will throw an error if the user enters a number within their word | "Cat1" | "Please enter a valid word" |
| The program will take in a sentence from the user | "Cats are awesome. I have two cats. My first cat is named Charlie. My second cat is named Tina" | "Cats are awesome. I have two cats. My first cat is named Charlie. My second cat is named Tina" |
| The program will convert user inputs to all lower case characters | "Cat3!" | "cat" |
| The program will search for any words in the user inputted sentence that are the same length as the user inputted word | "Cat", "Cats are awesome. I have two cats. My first cat is named Charlie. My second cat is named Tina" | "cat" | 4 words with the same length as the user inputted word |
| The program will check those length matched words for any that match the user inputted word exactly | "Cat", "Cats are awesome. I have two cats. My first cat is named Charlie. My second cat is named Tina" | "cat" | 2 words match the user inputted word |
| The program will tell the user how many times their word occured in the sentence they inputted | "Cat", "Cats are awesome. I have two cats. My first cat is named Charlie. My second cat is named Tina" | "The word  car occurs 2 time(s) in this sentence!" |

## Support 

_The software is provided as is. If you experience an issue please reach out to me using the contact information provided._

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Alex Skreen_**