Test Score Average Calculator (C# WinForms)

This project demonstrates a practical implementation of decision structures and exception handling in C# Windows Forms, calculating the average of three test scores and determining if a high-score threshold is reached.

📌 Features & Logic Overview

User Input Parsing: Reads inputs from three text boxes (txtScore1, txtScore2, txtScore3) and converts them into floating-point numbers (double).

Average Calculation: Sums the test scores and divides by $3.0$ to get the precise average score.

Formatted Display: Rounds and displays the average in txtScore4 formatted to one decimal place ("n1").

Decision Making (if statement): Compares the calculated average against a predefined threshold (HIGH_SCORE = 95.0). Displays a congratulatory message if exceeded.

Exception Handling (try-catch): Prevents application crashes if invalid data (e.g., non-numeric text) is entered into the textboxes.

💻 Source Code

try
{
    // Constant for high score value
    const double HIGH_SCORE = 95.0;

    // Variables to store test scores and average
    double test1, test2, test3, average;

    // Get the test scores from the TextBoxes
    test1 = double.Parse(txtScore1.Text);
    test2 = double.Parse(txtScore2.Text);
    test3 = double.Parse(txtScore3.Text);

    // Calculate the average test score
    average = (test1 + test2 + test3) / 3.0;

    // Display the average, rounded to 1 decimal place
    txtScore4.Text = average.ToString("n1");

    // If the average is a high score, congratulate the user with a message box
    if (average > HIGH_SCORE)
    {
        MessageBox.Show("Congratulations! Great job!");
    }
}
catch (Exception ex)
{
    // Display error message if input is invalid
    MessageBox.Show(ex.Message);
}


🔑 Variable & Controls Mapping

Name

Type

Purpose

HIGH_SCORE

const double

Benchmark value ($95.0$) to qualify for congratulations

test1, test2, test3

double

Stores parsed numeric values from user input

average

double

Stores calculated average score

txtScore1, txtScore2, txtScore3

TextBox

Form controls capturing score inputs

txtScore4

TextBox

Form control displaying output average

🛡️ Error Handling Details

If the user enters non-numeric text (e.g., letters or symbols) in any of the score textboxes, double.Parse() will throw a FormatException.

The catch (Exception ex) block catches this error and pops up a MessageBox displaying the system error message instead of letting the application crash unexpectedly.
