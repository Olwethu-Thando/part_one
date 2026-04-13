# part_one
Cyber Security Awareness ChatBot (Part 1)

## Overview
This project is a C# Console Application chatbot designed to educate users about basic cybersecurity practices.  
The chatbot interacts with the user by answering questions related to online safety such as passwords, phishing, safe browsing, and viruses.

---

## Purpose
The main purpose of this chatbot is to:
- Create awareness about cybersecurity risks
- Help users understand how to stay safe online
- Provide simple and clear security tips

---

## Features
- Voice greeting when the program starts
- ASCII art logo display
- User name input with validation
- Personalised chat (uses the user’s name)
- Cybersecurity questions and answers
- Input validation and error handling
- Exit option to close the program

---

## Program Structure
The program is divided into multiple classes for better organisation:

- Program.cs → Main entry point of the application  
- user_intercation.cs → Handles greeting and user input  
- audio.cs → Plays voice greeting  
- logo.cs → Displays ASCII art  
- chats.cs → Handles chatbot logic using keywords and responses  

---

## How It Works
- The chatbot uses ArrayLists to store keywords and answers.
- The `.Add()` method is used to insert data.
- When the user types a question, the program:
  1. Breaks the sentence into words  
  2. Ignores unnecessary words  
  3. Matches keywords  
  4. Displays the correct response  

---

## Example InteractionBot: Enter your name...
User: Olly

Olly: password
Bot: Always use strong passwords with a mix of letters, numbers, and symbols.

Olly: phishing
Bot: Phishing is when scammers trick you into giving personal information.## How to Run
1. Open the project in Visual Studio  
2. Make sure all classes are included  
3. Run the program  
4. Enter your name  
5. Start chatting  

---

## Topics Covered
- Password security  
- Phishing awareness  
- Safe browsing  
- Malware and viruses  
- Online safety tips  

---

## Technologies Used
- C#  
- .NET Console Application  
- Visual Studio  

---

## Conclusion
This project demonstrates basic programming concepts such as:
- Classes and methods  
- Arrays (ArrayList)  
- Loops and conditions  
- User interaction  

It also promotes awareness of cybersecurity in a simple and interactive way.

---

## Author
[Olwethu]
