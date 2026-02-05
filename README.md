# DATING PREDICTIONS
A dating prediction cli script (GUI SOON!) to see if you have a chance with the person that catches your eye.

## Why did i make this?

Because i was bored and wanted to do something in my free time. Its not useful in anykind, 
but feel free to try it out i guess. It is not perfectly accurate by any chance, but its fine to play around with 
To run it yourself, please head to the [how-to section](https://github.com/amiruldevkun/Dating-Prediction#how-to)

## TABLE OF CONTENTS
- [IMPORTANT](https://github.com/amiruldevkun/Dating-Prediction#important)
- [GOALS](https://github.com/amiruldevkun/Dating-Prediction#goals)
- [HOW-TO](https://github.com/amiruldevkun/Dating-Prediction#how-to)
- [BUILDING](https://github.com/amiruldevkun/Dating-Prediction#building)
- [HELP INQUIRIES](https://github.com/amiruldevkun/Dating-Prediction#help-inquires)
- [RESOURCES && EXTRA CREDITS](https://github.com/amiruldevkun/Dating-Prediction#resources--extra-credits)


## How does this script works?

First, the code will try and determine your gender. Then, once it knows your gender it will assign the other gender to be the crush's gender

Secondly, it will take your age name and personality, the same goes for the crush. 

Lastly, it will try to match you together, by taking personality and age into consideration.

(explanation is from my old [python](https://github.com/amiruldevkun/datingpredictions) repo

## Why use C# when you already have a python repo with the same goal?

The reason why I use C# instead of python is because python doesn't have the features that I needed for this project specifically and because I wanted to learn
new languages too. C# also have a lot in common with java like how the syntax works and how the code gets written. 

## The obstacles when making this project

One of the obstacles that I have faced when making this project was with my understanding with personalities. But after I have understanded that, the next
problem lies with the code is not giving me the place where the error originated like a small semi-colon mistake make everything underlined with red squiggly lines
and making it hard to identify the mistake.

# IMPORTANT
This program is ***UNDER DEVELOPMENT*** so there will be bugs. This is not to be used seriously also and is not a relationship gauge to see if your partner is your soulmate.

## GOALS (sorted by importance)

- Add tests (on the way)

- Add percentages (Done)

- Implement a GUI (On the way)

- Add a database for recently made predictions

## HOW-TO
Go to the [releases]("https://github.com/amiruldevkun/Dating-Prediction/releases") tab and grab the latest one (as you should on any other thing).

If you are on linux:
1. Grab the linux_publish.zip and unzip it to anywhere you want.
2. Open up the folder and run a terminal inside the folder.
3. Do `./datingpredic_updated` to run the program.

If you are on windows:
1. Grab the windows_publish.zip and unzip it to anywhere you want.
2. Open up the folder and run the `datingpredic_updated.exe`

If you want to build it from [source]("https://github.com/amiruldevkun/Dating-Prediction#building"), its under this section.

No need for installing any dependencies as for every single release, I will build it with the `-self_contained` flag so that you do not need to go through the hassle of installing runtimes!

## BUILDING
Ok, so you have decided to not do it the easy way and wanted to build it yourself. So, these are the prerequisites.

- The [.NET sdk (Version 9)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- An IDE (Rider, Visual Studio)

Download the sdk using your prefered way, be it via installer or winget. Your choice of the text editor or IDEs is up to you.

You can choose Rider, Visual Studio Code, Visual Studio 2022, Notepad++ or anything.

After you have buckled up with the prerequisites that i have stated, you can either clone this repository or use the green code button.

Click download zip, unzip the file, open a command prompt in the folder and type `dotnet clean` and then `dotnet build`. 

And after you are done! Enjoy this project!

## HELP INQUIRES 
If you need help you can tag me on [twitter](https://twitter.com/amirulplays) or dm me, since i dont have anyone with perms to keep the repo going, i might not respond fast so keep that in mind.


### RESOURCES && EXTRA CREDITS
https://github.com/amiruldevkun/datingpredictions <br />
https://dotnet.microsoft.com/en-us/download/dotnet/9.0 <br />
https://twitter.com/amirulplays <br />
[ProgramBar Source Code (Thank you Daniel!)](https://gist.github.com/DanielSWolf/0ab6a96899cc5377bf54)