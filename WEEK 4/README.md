 C# Chapter 4 (Part 1): Loops & Repetition Structures

Comprehensive documentation for Part 1 of Chapter 5 covering loop control structures (while, for, do-while) and increment/decrement operators.

📑 Table of Contents

5.1 The while Loop

5.2 Increment (++) and Decrement (--) Operators

5.3 The for Loop

5.4 The do-while Loop

📊 Comparison: Pretest vs Posttest Loops

5.1 The while Loop

🎯 Key Concepts

Definition: Repeats a statement or block of statements as long as a Boolean expression evaluates to true.

Pretest Loop: Tests its condition before executing the loop body. If the initial condition is false, the loop body never runs.

Counter Variable: A variable initialized before the loop to control the iteration count.

Infinite Loop: Occurs when the loop condition never becomes false (e.g., forgetting to update the counter).

💻 Code Example

int count = 0;

while (count < 5)
{
    MessageBox.Show("Iteration: " + count.ToString());
    count++; // Increment counter to avoid infinite loop
}


5.2 Increment (++) and Decrement (--) Operators

🎯 Key Concepts

Increment (++): Increases a variable's value by 1 (count++ $\equiv$ count = count + 1).

Decrement (--): Decreases a variable's value by 1 (count-- $\equiv$ count = count - 1).

⚙️ Postfix vs. Prefix Modes

Mode

Syntax

Behavior

Postfix

count++

Uses the current value in the expression first, then increments.

Prefix

++count

Increments the variable first, then uses the new value in the expression.

💻 Code Example

int count = 5;
int x = 0;

// Postfix Example: x gets 5, then count becomes 6
x = count++; 

// Prefix Example: count becomes 7 first, then x gets 7
x = ++count; 


5.3 The for Loop

🎯 Key Concepts

Specifically designed for counter-controlled repetition.

Consists of three core expressions:

Initialization: Executes once before the loop starts.

Test: Boolean expression evaluated before each iteration.

Update: Modifies the counter variable at the end of each iteration.

💻 Code Example

// Standard forward counting loop
for (int i = 0; i < 5; i++)
{
    outputListBox.Items.Add("Count: " + i);
}

// Counting backward
for (int i = 10; i >= 0; i--)
{
    outputListBox.Items.Add("Countdown: " + i);
}

// Step increment (by 10)
for (int i = 0; i <= 100; i += 10)
{
    outputListBox.Items.Add("Step: " + i);
}


5.4 The do-while Loop

🎯 Key Concepts

Posttest Loop: Tests its Boolean condition after executing the loop body.

Guaranteed Execution: Always executes at least once, regardless of whether the initial condition is true or false.

💻 Code Example

int number = 1;

do
{
    MessageBox.Show("Executes at least once! Number: " + number);
    number++;
} while (number < 0); // Condition is false, but body executed once


📊 Comparison: Pretest vs Posttest Loops

Loop Type

Test Timing

Minimum Iterations

Best Used When...

while

Pretest

0

The loop may not need to run at all.

for

Pretest

0

The exact number of iterations is known in advance.

do-while

Posttest

1

The loop body must execute at least once before testing.
}
