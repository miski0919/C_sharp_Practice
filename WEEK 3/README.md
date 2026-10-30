# Chapter 3: Making Decisions - Code Implementation

## Overview
This practice demonstrates decision structures, exception handling, and button event handlers in C# Windows Forms based on Chapter 3 concepts.

---

## 1. Calculate Average (`btnCalculateAverage_Click`)
- **Description:** This event handler reads user inputs from three test score text boxes, converts them to numerical values (`double`), and calculates their average. It uses a single-alternative `if` statement to check if the calculated average exceeds the high score threshold (`HIGH_SCORE = 95.0`) and displays a congratulatory message box if true. Additionally, the entire process is enclosed in a `try-catch` block to handle potential conversion exceptions gracefully if invalid input is entered.
- **Screenshot Reference:** `Screenshots/Calculate_Code.png`

---

## 2. Clear Form (`btnClear_Click`)
- **Description:** This event handler resets the user interface for new data entry. When clicked, it clears all input text boxes (`txtScore1`, `txtScore2`, `txtScore3`) and clears the output display box (`txtScore4`), restoring the form to its initial empty state.
- **Screenshot Reference:** `Screenshots/Clear_Code.png`

---

## 3. Exit Application (`btnExit_Click`)
- **Description:** This event handler closes and terminates the running C# Windows Forms application safely using the standard `this.Close()` method upon button interaction.
- **Screenshot Reference:** `Screenshots/Exit_Code.png`