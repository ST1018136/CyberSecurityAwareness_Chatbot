# Cybersecurity Awareness Chatbot

## Overview
This is a C# console application that serves as a cybersecurity awareness chatbot for South African citizens. The chatbot helps users learn about online safety practices including password safety, phishing detection, and safe browsing habits.

## Features
- Voice greeting playback (WAV file support)
- ASCII art logo display
- Personalized responses using user's name
- Input validation with error handling
- Typing effect for realistic conversation
- Color-coded console output
- Covers cybersecurity topics:
  - Password safety tips
  - Phishing attack awareness
  - Safe browsing practices

## Technologies Used
- C# (.NET Framework)
- System.Media (for audio playback)
- System.Threading (for typing effect)

## How to Run the Program
1. Open the solution in Visual Studio
2. Press `F5` or click "Start" to run the program
3. The chatbot will greet you with a voice message (if greeting.wav is present)
4. Enter your name when prompted
5. Ask questions like:
   - "hello"
   - "password safety"
   - "what is phishing"
   - "safe browsing"
   - "how are you"
   - "goodbye" (to exit)
  
   - Link for the youtubeVideo
   - https://youtu.be/kW72yaX3kOE?si=pvRUKcuPFJwEDOxi
     

## Project Structure
- `Program.cs` - Main entry point
- `CyberSecurityBot.cs` - Main chatbot controller
- `AudioPlayer.cs` - Handles WAV audio playback
- `LogoDisplay.cs` - Manages ASCII art and visual elements
- `ResponseManager.cs` - Processes user input and generates responses

## File Requirements
- Place `greeting.wav` in the same folder as the executable for voice greeting functionality
- The program will continue running even if the audio file is missing

## Author
[Sefako Siphosethu Mongalo]
[ST10181363]

## Diploma in software development
[Programming 2A]
[Rosebank College BraamFontien]
