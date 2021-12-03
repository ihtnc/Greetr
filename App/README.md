# Greetr App

## Usage
* Run `dotnet run` to view the greeting.

## Requirements
* A message will be randomly selected from the corresponding list depending on where the current local time falls on the time range. Refer to the table below for the specifics.
* This project should not be modified and any changes made elsewhere should not cause this project to break.

|Time Range|Messages|
|:-        |:-      |
|4:00AM to 9:59AM|"Good morning!" or "Rise and shine!" or "It's a brand new day!"|
|10:00AM to 3:59PM|"Hi!" or "How's the day so far?" or "Hello!"|
|4:00PM to 9:59PM|"Good evening!" or "Hello!" or "A pleasant night to you!"|
|10:00PM to 3:59AM|"Isn't it too late for you?" or "You're too early!" or "You should be sleeping!"|

## Examples
Running the application at 7:00AM:
```
...\Greetr\App> dotnet run
Rise and shine!
```

Running the application at 9:15AM:
```
...\Greeter\App> dotnet run
Hello!
```

Running the application at 4:00PM:
```
...\Greeter\App> dotnet run
Hello!
```

Running the application at 3:59AM:
```
...\Greeter\App> dotnet run
Isn't it too late for you?
```
