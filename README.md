# Study Sprout : 10
# 5
Project Manager: Megan Steinhauser (@megansteinhauser)
Communications Lead: Lexi Reed (@lexree17)
Git Master: Ashtyn Roberts (@ashtyn-roberts)
Design Lead: Jeffrey Min (@jeffreymin)
Quality Assurance Tester: Lillian Andino (@lillianandino04)

# About Our Software
Make studying easier for yourself! Study Sprout is a tool that takes advantage of spaced repetition while incorporating flashcards, tests, and quizzes for more efficient studying. Customize your own schedule, get notifications, start streaks, and grow your plants! Whether you're preparing for an exam, mastering a new subject, or reinforcing key concepts, Study Sprout adapts to your needs with a range of tools that enhance your study sessions.

## Platforms Tested on
- MacOS
- Windows

# Important Links
Kanban Board: https://github.com/orgs/CSC-3380-Spring-2025/projects/23/views/1
Designs: all pictures for the site are contained inside of the wwwroot folder. the link to the figma is https://www.figma.com/design/jBMUURKbz1Aa214jjdsGmN/Study-Sprout-fresh-start?node-id=0-1&p=f&t=HTkgcbFsyIYBuS2v-0 the invite has been sent.
Styles Guide(s): StudySprout/Git Master - Code Standards.pdf inside of VSCode or found on moodle. 

# How to Run Dev and Test Environment


## Dependencies
- We used several free VSCode extensions including:
	- C#
	- .NET Install Tool
	- C# Dev Kit
	- GitHub Pull Requests
	- GitLens
	- vscode-pdf
- We used Blazor as a frontend which requires .NET to be installed on the computer. 
- We used FireBase which requires a SDK Key to work the front end of the database that has been emailed to you. Download the JSON file from the email and place it in a empty folder inside of StudySprout named Credentials to work when running the site. The JSON file name should match what is in the Program.cs credentialpath function.

### Downloading Dependencies
- https://dotnet.microsoft.com/en-us/download/dotnet/9.0 follow this link and download both the SDK 9.0.203 and ASP.NET Core Runtime 9.0.4 that works for your computer (windows vs MacOS vs Linux) and install them. 
	- this is the only download that should be necessary aside from VSCode 

## Commands
- Open a new terminal once open in VSCode
- When cloning the repository you will see the origin path from your local machine (PS C:\Users\username\VSCode\localfileforrepo on Windows)
	- cd into Team-10 (this ensures that the command runs)
	- cd into StudySprout (you cannot run the dotnet commands outside of this folder)
- To clean the project (ensures that you have a safe build) run:
	- dotnet clean 
- To build the project (ensures that you have a complete build before runtime and makes execution shorter) run:
	- dotnet build 
- To run the project run: 
	- dotnet watch run
	- this will automatically open the site (to avoid having to manually type the host port) as well as show some hot commands in the case of restarting the page. 
- To shut down the project 
	- inside the dotnet terminal press control + C for windows or command + C for MacOS
- If you receive an error on the My Study Sets or Create New Sets pages about the database not being found go into the Program.cs page an on line 5 replace the 
"name_of_json_file.json" with the name_of_the_json_file.json sometimes the program does not like when the json is added and the file is not changed. 
- When on the Quiz page when clicking take quiz button refresh the page to get to the quiz blazor still has some quirky issues that we have spent hours trying to debug and this is one 

