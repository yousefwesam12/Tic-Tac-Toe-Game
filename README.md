Tic Tac Toe - C# Windows Forms
A classic Tic Tac Toe game implemented in C# using Windows Forms. This project features a graphical user interface where two players can take turns playing on a 3x3 grid.

🚀 Features
GUI Interface: Interactive board using PictureBox controls.

Two-Player Mode: Players take turns placing 'X' and 'O'.

Win Detection: Automatically detects horizontal, vertical, and diagonal winning combinations.

Visual Feedback: Winning lines are highlighted in green.

Draw Detection: Recognizes when the board is full with no winner.

Game Reset: Ability to restart the game at any time.

🛠️ Built With
C#

.NET Framework / Windows Forms

🎮 How to Play
Run the application.

Player 1 starts as 'X', and Player 2 is 'O'.

Click on any empty square to place your mark.

The game will announce the winner or a draw via a message box.

Click the Restart button to clear the board and start a new game.

💻 Code Overview
The game logic is handled entirely within Form1.cs. Key functional areas include:

Form1_Paint: Draws the grid lines onto the form.

UpdateStatusOfTheGame: Handles player turns, updating images, and switching the current player label.

WhoWon: Checks for vertical, horizontal, and diagonal matches using the Tag property of the PictureBox controls.

Reset: Clears images, tags, colors, and resets the turn counter to start over.


🤝 Contributing
Feel free to submit issues or pull requests if you want to add features like AI opponent or sound effects!
