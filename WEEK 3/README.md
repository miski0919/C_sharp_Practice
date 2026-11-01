# 📘 Visual C# - Chapter 4: Making Decisions

Guide and comprehensive documentation for **Chapter 4: Making Decisions** from *Starting Out with Visual C# (6th Edition)* by Tony Gaddis.

---

## 📑 Table of Contents
1. [4.1 Decision Structures & the `if` Statement](#41-decision-structures--the-if-statement)
2. [4.2 The `if-else` Statement](#42-the-if-else-statement)
3. [4.3 Nested Decision Structures & `if-else-if`](#43-nested-decision-structures--if-else-if)
4. [4.4 Logical Operators](#44-logical-operators)
5. [4.5 `bool` Variables & Flags](#45-bool-variables--flags)
6. [4.6 Comparing Strings](#46-comparing-strings)
7. [4.7 Preventing Data Conversion Exceptions (`TryParse`)](#47-preventing-data-conversion-exceptions-tryparse)
8. [4.8 Input Validation](#48-input-validation)
9. [4.9 Radio Buttons and Check Boxes](#49-radio-buttons-and-check-boxes)
10. [4.10 The `switch` Statement](#410-the-switch-statement)
11. [4.11 Introduction to List Boxes](#411-introduction-to-list-boxes)

---

## 4.1 Decision Structures & the `if` Statement

### 🎯 Key Concepts
* **Control Structure:** A logical design that controls the order in which code statements execute.
* **Sequence Structure:** Statements execute sequentially in the exact order they appear.
* **Decision (Selection) Structure:** Executes specific actions only under certain conditions (*single-alternative decision structure*).

### 🔍 Relational Operators
Used to compare two values, evaluating to either `true` or `false`:

| Operator | Meaning | Example | Meaning of Example |
| :---: | :--- | :---: | :--- |
| `>` | Greater than | `x > y` | Is `x` greater than `y`? |
| `<` | Less than | `x < y` | Is `x` less than `y`? |
| `>=` | Greater than or equal to | `x >= y` | Is `x` greater than or equal to `y`? |
| `<=` | Less than or equal to | `x <= y` | Is `x` less than or equal to `y`? |
| `==` | Equal to | `x == y` | Is `x` equal to `y`? |
| `!=` | Not equal to | `x != y` | Is `x` not equal to `y`? |

### 💻 Code Example
```csharp
double sales = 60000;
double bonus = 0;

if (sales > 50000)
{
    bonus = 500;
}
```

---

## 4.2 The `if-else` Statement

### 🎯 Key Concepts
* A **dual-alternative decision structure**.
* Executes one block of code if the Boolean condition is `true`, and an alternate block if the condition is `false`.

### 💻 Code Example
```csharp
double temp = 45.0;

if (temp > 40)
{
    MessageBox.Show("Weather is hot!");
}
else
{
    MessageBox.Show("Weather is cold!");
}
```

---

## 4.3 Nested Decision Structures & `if-else-if`

### 🎯 Key Concepts
* **Nested Structure:** Placing an `if` statement inside another `if` statement to test multiple layered conditions.
* **`if-else-if` Statement:** Provides a clean way to test multiple mutually exclusive conditions without creating deep indentation.

### 💻 Code Example: Nested `if` (Loan Qualification)
```csharp
double salary = 45000;
int yearsOnJob = 3;

if (salary >= 40000)
{
    if (yearsOnJob >= 2)
    {
        decisionLabel.Text = "You qualify for the loan.";
    }
    else
    {
        decisionLabel.Text = "Minimum years at current job not met.";
    }
}
else
{
    decisionLabel.Text = "Minimum salary requirement not met.";
}
```

### 💻 Code Example: `if-else-if` (Grade Calculator)
```csharp
int score = int.Parse(testScoreTextBox.Text);
string grade;

if (score >= 90)
{
    grade = "A";
}
else if (score >= 80)
{
    grade = "B";
}
else if (score >= 70)
{
    grade = "C";
}
else if (score >= 60)
{
    grade = "D";
}
else
{
    grade = "F";
}
```

---

## 4.4 Logical Operators

### 🎯 Key Concepts
Used to combine multiple Boolean expressions into compound logical expressions.

| Operator | Name | Description |
| :---: | :---: | :--- |
| `&&` | **AND** | Both conditions must be `true` for the compound expression to be `true`. |
| `\|\|` | **OR** | At least one condition must be `true` for the compound expression to be `true`. |
| `!` | **NOT** | Reverses (negates) the truth value of a Boolean expression. |

### 📊 Truth Tables

#### Logical AND (`&&`)
| Expression 1 | Expression 2 | Natiijada (`&&`) |
| :---: | :---: | :---: |
| `true` | `false` | `false` |
| `false` | `true` | `false` |
| `false` | `false` | `false` |
| `true` | `true` | **`true`** |

#### Logical OR (`||`)
| Expression 1 | Expression 2 | Natiijada (`||`) |
| :---: | :---: | :---: |
| `true` | `false` | **`true`** |
| `false` | `true` | **`true`** |
| `false` | `false` | `false` |
| `true` | `true` | **`true`** |

### 💻 Code Example
```csharp
// Using AND (&&)
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("Danger zone!");
}

// Using OR (||)
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("Extreme temperature warning!");
}

// Using NOT (!)
if (!(temperature > 100))
{
    MessageBox.Show("Temperature is within bounds.");
}
```

---

## 4.5 `bool` Variables & Flags

### 🎯 Key Concepts
* A **`bool`** data type variable stores either `true` or `false`.
* A **Flag** is a boolean variable used as a signal to indicate whether a specific condition exists within a program.

### 💻 Code Example
```csharp
double points = double.Parse(txtpoints.Text);
bool grandMaster;

if (points > 5000)
{
    grandMaster = true;
}
else
{
    grandMaster = false;
}

if (grandMaster)
{
    MessageBox.Show("Player unlocked Grand Master status!");
}
```

---

## 4.6 Comparing Strings

### 🎯 Key Concepts
In C#, strings can be compared for equality or alphabetical sorting using relational operators or string methods.

### 💻 Code Examples
```csharp
string name1 = "Alice";
string name2 = "Bob";

// 1. Using == Operator
if (name1 == name2) { }

// 2. Using String.Compare Method (Returns 0 if equal)
if (String.Compare(name1, name2) == 0)
{
    MessageBox.Show("Strings are identical.");
}

// 3. Using CompareTo Instance Method
if (name1.CompareTo(name2) == 0)
{
    MessageBox.Show("Strings are identical.");
}
```

---

## 4.7 Preventing Data Conversion Exceptions (`TryParse`)

### 🎯 Key Concepts
* `Parse` methods throw exceptions when bad data is entered.
* **`TryParse` Methods** convert string inputs into numbers safely without crashing the application.
* Uses the **`out`** keyword to output converted data to a variable.

### 💻 Code Examples
```csharp
// int.TryParse Example
int intResult;
if (int.TryParse(inputTextBox.Text, out intResult))
{
    MessageBox.Show("Valid Integer: " + intResult);
}

// double.TryParse Example
double doubleResult;
if (double.TryParse(inputTextBox.Text, out doubleResult))
{
    MessageBox.Show("Valid Double: " + doubleResult);
}
```

---

## 4.8 Input Validation

### 🎯 Key Concepts
* **Input Validation:** Inspecting input data before processing it to ensure it meets logical business criteria (e.g., test scores must be between 0 and 100).

### 💻 Code Example
```csharp
int hours;

if (int.TryParse(textBox1.Text, out hours))
{
    // Validate range criteria
    if (hours > 0 && hours <= 168)
    {
        MessageBox.Show("Valid work hours entered.");
    }
    else
    {
        MessageBox.Show("Error: Hours worked must be between 1 and 168.");
    }
}
else
{
    MessageBox.Show("Error: Enter a valid whole number.");
}
```

---

## 4.9 Radio Buttons and Check Boxes

### 🎯 Key Concepts
* **RadioButton:** Allows selecting a single option from a group (*Mutually Exclusive*).
* **CheckBox:** Allows selecting multiple options simultaneously.
* **`Checked` Property:** `bool` property reflecting whether the control is selected.
* **`CheckedChanged` Event:** Fires automatically whenever the `Checked` state changes.

### 💻 Code Example: Radio Buttons & CheckBoxes
```csharp
// RadioButton selection
if (footballRadioButton.Checked)
{
    MessageBox.Show("Selected Sport: Football");
}

// CheckBox multiple selection logic
string subjects = "";

if (chkJava.Checked && chkReact.Checked && chkPHP.Checked)
{
    subjects += "Java\nReact\nPHP";
}
else if (chkJava.Checked && chkReact.Checked)
{
    subjects += "Java\nReact";
}
else if (chkJava.Checked)
{
    subjects += "Java";
}
else
{
    MessageBox.Show("Please select at least one subject.");
}
```

---

## 4.10 The `switch` Statement

### 🎯 Key Concepts
* Multi-alternative decision structure.
* Alternative to long `if-else-if` chains testing a single variable against discrete values.
* Uses `case`, `break`, and an optional `default` fallback block.

### 💻 Code Example
```csharp
int month = int.Parse(monthTextBox.Text);

switch (month)
{
    case 1:
        MessageBox.Show("January");
        break;
    case 2:
        MessageBox.Show("February");
        break;
    case 3:
        MessageBox.Show("March");
        break;
    default:
        MessageBox.Show("Error: Invalid month number.");
        break;
}
```

---

## 4.11 Introduction to List Boxes

### 🎯 Key Concepts
Displays a list of items and allows user selection.

* **Key Properties:**
  * `Items`: Collection of items in the ListBox.
  * `Items.Count`: Total number of items in the list.
  * `SelectedItem`: Currently selected item (returns an `object`).
  * `SelectedIndex`: Zero-based index of selected item (`-1` if no item selected).

### 💻 Code Example: ListBox Operations
```csharp
// 1. Adding items
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");

// 2. Checking selection safely using SelectedIndex
if (fruitListBox.SelectedIndex != -1)
{
    string selectedFruit = fruitListBox.SelectedItem.ToString();
    MessageBox.Show("You selected: " + selectedFruit);
    
    // 3. Removing selected item
    fruitListBox.Items.RemoveAt(fruitListBox.SelectedIndex);
}
else
{
    MessageBox.Show("Please select an item first.");
}

// 4. Clearing all items
daysListBox.Items.Clear();
```

---

## 📊 Comparison Summary: `Text` vs `SelectedItem`

| Feature | `Text` Property | `SelectedItem` Property |
| :--- | :--- | :--- |
| **Type** | `string` | `object` |
| **Use Case** | Direct text access | Full data object access |
| **Null Safety** | Returns `""` if nothing selected | Returns `null` if nothing selected |
| **Best For** | Simple text-only items | Complex objects or data-bound controls |

---
*Created for study and reference based on **Tony Gaddis - Starting Out with Visual C# (6th Edition)**.*
