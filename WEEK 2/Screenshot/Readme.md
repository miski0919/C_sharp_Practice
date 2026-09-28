## Declaring Variables Before Using Them

You can declare variables and use them later in the same method. In this example, the `fullname` variable is declared first, given a value, and then used to fill a Label.

When the user clicks the **Show Name** button, the `showNameButton_Click` event runs:

1. Declare a string variable to hold the full name.
2. Combine the first name, a space, and the last name, and assign the result to `fullname`.
3. Display the `fullname` variable in the `fullNameLabel` control.

The second event handler, `exitButton_Click`, closes the form when the user clicks the Exit button.

### Code

```csharp
private void showNameButton_Click(object sender, EventArgs e)
{
    // Declare a string variable to hold the full name
    string fullname;

    // Combine the names with a space between them
    // and assign the result to the fullname variable
    fullname = firstNameTextBox.Text + " " + lastNameTextBox.Text;

    // Display the fullname variable in the fullNameLabel control
    fullNameLabel.Text = fullname;
}

private void exitButton_Click(object sender, EventArgs e)
{
    // Close the form
    this.Close();
}
```

## Integer Division

When you divide one `int` by another `int` in C#, the result is also an `int`. The fractional part is dropped (not rounded).

In this example, `x` is 7 and `y` is 3. Since `7 / 3` is 2.333..., the result is cut down to **2**, and the message box shows `2`.

### Code

```csharp
private void divideButton_Click(object sender, EventArgs e)
{
    // Declare two integer variables
    int x = 7, y = 3;

    // Divide x by y. Both are int, so the result is an int (2)
    // Convert the result to a string and display it in a message box
    MessageBox.Show((x / y).ToString());
}
```

### Getting a Decimal Result

To keep the fractional part, convert at least one of the values to `double` (or `decimal`) before dividing:

```csharp
int x = 7, y = 3;

// Cast x to double so the division is done with decimals
MessageBox.Show(((double)x / y).ToString());   // 2.3333333333333335
```




