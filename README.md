# **Tic Tac Toe - C# Windows Forms Project**

**A comprehensive, interactive Tic Tac Toe game developed using C# and Windows Forms.** This project serves as a practical implementation of fundamental programming concepts within a graphical environment, offering a seamless user experience for two players.

---

## **📋 Table of Contents**

1.  [**Project Overview**](#-project-overview)
2.  [**Features**](#-features)
3.  [**Technical Details**](#-technical-details)
4.  [**How to Run the Project**](#-how-to-run-the-project)
5.  [**Code Breakdown**](#-code-breakdown)
6.  [**Contributing**](#-contributing)
7.  [**License**](#-license)

---

## **📖 Project Overview**

**This project is a desktop application designed to mimic the classic pencil-and-paper game of Tic Tac Toe.** Developed in C# using the Windows Forms framework, it provides a functional GUI where users can enjoy the game without needing any additional tools. The project focuses on structured programming, event handling, and basic GDI+ graphics for rendering the game board.

---

## **✨ Features**

* **⚡ Interactive GUI:** The game board is built using a 3x3 grid of `PictureBox` controls, providing a responsive interface.
* **👥 Two-Player Mode:** Play against a friend locally on the same machine, with alternating turns for Player 1 (X) and Player 2 (O).
* **🏆 Intelligent Win Detection:** The application automatically checks for horizontal, vertical, and diagonal winning conditions after every move.
* **🎨 Dynamic Visual Feedback:** When a player wins, the winning line of `PictureBoxes` instantly changes color to **DarkGreen** to highlight the victory.
* **🤝 Draw Condition Management:** The game detects when all cells are filled without a winner, displaying a "Draw" message.
* **🔄 Instant Game Reset:** A dedicated "Restart" button clears the board, resets the scores, and re-initializes the game state immediately.

---

## **🛠️ Technical Details**

* **Language:** C#
* **Framework:** .NET Framework / Windows Forms
* **IDE:** Visual Studio
* **Key Concepts:** Object-Oriented Programming (OOP), GDI+ (for drawing lines), Event Handling (Mouse Clicks).

---

## **🚀 How to Run the Project**

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/your-username/Tic-Tac-Toe.git](https://github.com/your-username/Tic-Tac-Toe.git)
    ```
2.  **Open in Visual Studio:** Locate the `.sln` file and open it.
3.  **Restore NuGet Packages:** If prompted, restore the necessary packages.
4.  **Build and Run:** Press `F5` to compile and launch the application.

---

## **💻 Code Breakdown**

**The core logic resides within the `Form1.cs` file.** Here is a breakdown of the key methods and structures:

### **`Form1_Paint(object sender, PaintEventArgs e)`**
**This method handles the drawing of the game board grid.** Using the `Graphics` object, it draws four thick white lines to create the 3x3 structure.

### **`UpdateStatusOfTheGame(PictureBox PBox)`**
**This is the main click handler.** It checks if the clicked `PictureBox` is empty (`?`), assigns the current player's mark ('X' or 'O'), switches the turn, and calls `UpdateWinnerStatus()`.

### **`WhoWon()`**
**This method orchestrates the win detection.** It calls `IsThereVerticalWinner()`, `IsThereHorizontalWinner()`, and `IsThereDiagonalWinner()` sequentially to check the board state.

### **`Reset()`**
**Ensures a clean slate for a new game.** It resets the `Tag` properties of all `PictureBoxes`, clears the images, resets colors, and updates the UI labels.

---

## **🤝 Contributing**

**Contributions are what make the open-source community such an amazing place to learn, inspire, and create.** Any contributions you make are **greatly appreciated**.

1.  **Fork** the Project
2.  **Create** your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  **Commit** your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  **Push** to the Branch (`git push origin feature/AmazingFeature`)
5.  **Open** a Pull Request

---

## **📜 License**

**Distributed under the MIT License.** See `LICENSE` for more information.
