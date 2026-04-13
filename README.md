# Cyber Security Awareness ChatBot (Part 1)

## Overview

This project is a C# Console Application chatbot developed to educate users about basic cybersecurity practices.
The chatbot interacts with the user by answering questions related to online safety such as passwords, phishing, safe browsing, viruses, and general security tips.

---

## Purpose

The purpose of this chatbot is to:

* Raise awareness about cybersecurity threats
* Help users understand how to protect themselves online
* Provide simple and practical security advice

---

## Features

* Voice greeting using a WAV audio file
* ASCII art logo display in the console
* User name input with validation
* Personalised chat using the user’s name
* Keyword-based chatbot responses using ArrayLists
* Input validation and error handling
* Exit option to close the program

---

## Program Structure

The program is divided into multiple classes:

* Program.cs
* user_intercation.cs
* audio.cs
* logo.cs
* chats.cs

---

## Multimedia Integration

### Sound (Voice Greeting)

The program plays a sound when it starts using a `.wav` file.

```csharp
SoundPlayer player = new SoundPlayer("greeting.wav");
player.Play();
```

This improves user experience by making the chatbot more interactive.

---

### ASCII Image (Logo)

A text-based logo is displayed in the console:

private void Asci()
{
    //path of the logo [ where the logo is ]
    string path = string.Empty;

    //auto get full path

    string fullpath = AppDomain.CurrentDomain.BaseDirectory;
    //now combine the paths
    path = fullpath.Replace(@"bin\Debug\", "logoo.png");
    
    Bitmap image = new Bitmap(path);

    // Resize for better console fit
    int width = 150;
    int height = 70; //(image.Height * width) / image.Width;
    Bitmap resized = new Bitmap(image, new Size(width, height));

    // Default color , you can set yours before this line
    Console.ForegroundColor = ConsoleColor.Magenta;
    string asciiChars = "@#S%?*+;:,. ";

    //start by the height
    for (int y = 0; y < resized.Height; y++)
    {
        //then width
        for (int x = 0; x < resized.Width; x++)
        {
            //color the pixel on x and y
            Color pixel = resized.GetPixel(x, y);

            // Convert to grayscale
            int gray = (pixel.R + pixel.G + pixel.B) / 3;

            // Map grayscale to ASCII
            int index = (gray * (asciiChars.Length - 1)) / 255;

            Console.Write(asciiChars[index]);
        }
        Console.WriteLine();
```

This improves the visual appearance of the application.

---

## User Input and Validation

The program ensures that the user enters a valid name:

```csharp
do
{
    Console.Write("User: ");
    username = Console.ReadLine();

} while (string.IsNullOrWhiteSpace(username));
```

This prevents empty input and improves usability.

---

## Chatbot Logic

The chatbot uses ArrayLists to store keywords and answers:

```csharp
ArrayList holder = new ArrayList();
ArrayList answers = new ArrayList();

holder.Add("password");
answers.Add("Always use strong passwords with a mix of letters, numbers, and symbols.");
```

When the user enters a question, the program checks for matching keywords:

```csharp
if (question.Contains(holder[i].ToString()))
{
    Console.WriteLine("Bot: " + answers[i]);
}
```

---

## Personalised Interaction

The chatbot uses the user's name during conversation:

```csharp
Console.Write(name + ": ");
```

Example:

Olly: password
Bot: Always use strong passwords with a mix of letters, numbers, and symbols.

---

## How It Works

1. The program starts and displays a welcome message
2. A sound is played and a logo is shown
3. The user enters their name
4. The chatbot processes user input
5. Keywords are matched with responses
6. The chatbot displays the correct answer

---

## CI Workflow

A Continuous Integration workflow was implemented using GitHub Actions:

```yaml
name: .NET Build

on:
  push:
    branches: [ "main" ]

jobs:
  build:
    runs-on: windows-latest

    steps:
    - uses: actions/checkout@v3
    - uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '6.0.x'
    - run: dotnet build
```

This ensures the project builds successfully.

<img width="706" height="194" alt="image" src="https://github.com/user-attachments/assets/d763ffc8-8088-4c9b-8b2a-2616543c7515" />
screenshot under word document submitted 


---

## Technologies Used

* C#
* .NET Console Application
* Visual Studio

---

## Conclusion

This project demonstrates:

* Object-oriented programming using multiple classes
* Use of ArrayLists for data storage
* Input validation and error handling
* Interactive user experience

It also promotes cybersecurity awareness in a simple and effective way.

---

## Author

olwethu 
