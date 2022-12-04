# DATING PREDICTIONS
A dating prediction cli script to see if you have a chance with the person that catches your eye.

## Why did i make this?

Because i was bored and wanted to do something in my free time. Its not useful in anykind, 
but feel free to try it out i guess. It is not accurate by any chance, so if you value your 
integrity and don't want to embarrass your self, please step away. 
But, if you like being embarrased or just playing around, then go straight to the [how-to section](https://github.com/amiruldevkun/Dating-Prediction#how-to) section. 
You could also contribute to this mess, if you want to that is.

## TABLE OF CONTENTS
[IMPORTANT](https://github.com/amiruldevkun/Dating-Prediction#important)
[GOALS](https://github.com/amiruldevkun/Dating-Prediction#goals)
[HOW-TO](https://github.com/amiruldevkun/Dating-Prediction#how-to)
[BUILDING](https://github.com/amiruldevkun/Dating-Prediction#building)
[CONTRIBUTING](https://github.com/amiruldevkun/Dating-Prediction#contributing)
[HELP INQUIRIES](https://github.com/amiruldevkun/Dating-Prediction#help-inquires)
[RESOURCES && EXTRA CREDITS](https://github.com/amiruldevkun/Dating-Prediction#resources--extra-credits)


## How does this script works?

First, the code will try and determine your gender. Then, once it knows your gender it will assign the other gender to be the crush's gender

Secondly, it will take your age name and personality, the same goes for the crush. 

Lastly, it will try to match you together, by taking personality and age into consideration.

(explanation is from my old [python](https://github.com/amiruldevkun/datingpredictions) repo

## Why use C# when you already have a python repo with the same goal?

The reason why I use C# instead of python is because python doesn't have the features that I needed for this project specifically and because I wanted to learn
new languages too. C# also have a lot in common with java like how the syntax works and how the code kinda written. 

## The obstacles when making this project

One of the obstacles that I have faced when making this project was with my understanding with personalities. But after I have understanded that, the next
problem lies with the code is not giving me the place where the error originated like a small semi-colon mistake make everything underlined with red squiggly lines
and making it hard to identify the mistake.

# IMPORTANT

This program is currently __UNDER DEVELOPMENT__ so expect unfinished-ness and bugs. The feature that is in development is 
the personality feature, the age will be in development straight after im done with the personality feature. Currently messing around with sqlite3 and making a database for
a list of users using and their crushes. They can also see the percentage (if i finish it...) with the crush that they inputted. That would be cool.


## GOALS

- Implement a GUI

- Add a database for recently made predictions

- Add percentages

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

- The [.NET sdk (Version 6)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Visual Studio 2022 (or any IDEs really)
- A text editor (Optional) 

Download the sdk using your prefered way, by an installer or winget. Your choice of the text editor or IDEs is up to you.

You can choose Rider, Visual Studio Code, Visual Studio 2022, Notepad++ or anything. The only important thing is that you have a terminal that can execute and build

the project using 

```
dotnet build
```

**OR**

```
dotnet run
```

After you have buckled up with the prerequisites that i have stated, click on the green button that says `Code`, 

click download zip, unzip the file, open a command prompt in the folder and type `dotnet clean` and then `dotnet build`. 

And after you are done! Enjoy this project!

## CONTRIBUTING
If you want to contribute to this mess, make a pull request(s) anytime but I might see it late as I dont have too much free time going through code changes when i have school. 

Fork this repo if you want, but please credit my project.

## HELP INQUIRES 
If you need help you can tag me on [twitter](https://twitter.com/amirulplays) or dm me, since i dont have anyone with perms to keep the repo going, i might not respond fast so keep that in mind.


### RESOURCES && EXTRA CREDITS
https://github.com/amiruldevkun/datingpredictions <br />
https://dotnet.microsoft.com/en-us/download/dotnet/6.0 <br />
https://twitter.com/amirulplays <br />
[ProgramBar Source Code (Thank you Daniel!)](https://gist.github.com/DanielSWolf/0ab6a96899cc5377bf54)