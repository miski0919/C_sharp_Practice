# Comprehensive Chapter 4 Project: Loops, Files, and Random Numbers

## 📚 Overview
This repository contains a complete C# Windows Forms application demonstrating the advanced programming concepts covered in **Chapter 4** of *Starting Out with Visual C#*[span_0](start_span)[span_0](end_span)[span_1](start_span)[span_1](end_span). The project integrates repetition control structures, persistent file data storage using text files, standard dialog handling, and pseudo-random number generation[span_2](start_span)[span_2](end_span)[span_3](start_span)[span_3](end_span)[span_4](start_span)[span_4](end_span)[span_5](start_span)[span_5](end_span).

---

## 🔍 Detailed Features & Screenshot Guide

This project is divided into four main functional sections, each corresponding to a specific screenshot required for your submission:

### 1. Compound Interest Calculator (`while` Loop)
* **Description:** The application utilizes a pretest `while` loop to calculate the compound balance over a dynamic number of months entered by the user[span_6](start_span)[span_6](end_span)[span_7](start_span)[span_7](end_span)[span_8](start_span)[span_8](end_span)[span_9](start_span)[span_9](end_span). 
* **Code Logic:** It tests the iteration condition before executing the code block, ensuring calculations run accurately month-by-month[span_10](start_span)[span_10](end_span).
* **📸 Required Screenshot:** `Ending_Balance_Loop.png` – This screenshot must capture the user interface displaying the filled input fields (*Starting Balance* and *Number of Months*) alongside the `ListBox` showing the month-by-month calculated ending balances[span_11](start_span)[span_11](end_span)[span_12](start_span)[span_12](end_span).

### 2. File Writing Operations (`StreamWriter`)
* **Description:** To ensure data persistence beyond runtime, the program connects to the hard drive to save text files[span_13](start_span)[span_13](end_span)[span_14](start_span)[span_14](end_span). 
* **Code Logic:** It instantiates a `StreamWriter` object using `File.CreateText()`, looping through the items inside the application's list box to write them line-by-line into a text file named `results.txt`[span_15](start_span)[span_15](end_span)[span_16](start_span)[span_16](end_span).
* **📸 Required Screenshot:** `Save_File_Output.png` – This screenshot should capture the moment the data is successfully saved, showing the prompt or confirmation message indicating that the text file has been created and written to disk[span_17](start_span)[span_17](end_span).

### 3. File Reading Operations (`StreamReader` & `EndOfStream`)
* **Description:** The application features a robust text-reading mechanism to retrieve previously saved records[span_18](start_span)[span_18](end_span)[span_19](start_span)[span_19](end_span).
* **Code Logic:** Using a `StreamReader` combined with a `while (!inputFile.EndOfStream)` loop, the program dynamically reads every single line of text from `results.txt` and re-populates the user interface's list box[span_20](start_span)[span_20](end_span)[span_21](start_span)[span_21](end_span).
* **📸 Required Screenshot:** `Read_File_Output.png` – This screenshot must show the application interface after clicking the read button, verifying that the text file contents have been successfully loaded back into the `ListBox`[span_22](start_span)[span_22](end_span).

### 4. Pseudo-Random Number Generation (`Random` Class & `for` Loop)
* **Description:** The system incorporates the .NET `Random` class to generate unpredictable integer values within a defined mathematical boundary[span_23](start_span)[span_23](end_span)[span_24](start_span)[span_24](end_span).
* **Code Logic:** A `for` loop controls the exact number of iterations, calling `rand.Next(1, 101)` to populate the list box with random numbers[span_25](start_span)[span_25](end_span)[span_26](start_span)[span_26](end_span).
* **📸 Required Screenshot:** `Random_Numbers_Output.png` – This screenshot should display the generated sequence of random numbers rendered dynamically inside the application's output container[span_27](start_span)[span_27](end_span)[span_28](start_span)[span_28](end_span).

---

## 💻 Core Code Implementations Reference

### A. While Loop Compound Interest
```csharp
int count = 1;
while (count <= months)
{
    balance = balance + (INTEREST_RATE * balance);
    lstOutput.Items.Add("Month " + count + " balance: " + balance.ToString("c"));
    count++;
}