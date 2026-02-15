# C# IEnumerator Countdown Program

## Overview

This project is a simple C# console application that demonstrates how to use an custom implementation of the **IEnumerator interface**. The program creates a Countdown class that counts down from 10 to 0 using interface methods.

The purpose of this project is to show how interfaces define a contract that classes must follow and how they can be used to control program behavior.

## Features

* Custom implementation of the IEnumerator interface
* Countdown class that iterates through numbers
* Console output using a while loop
* Demonstrates interface-based programming in C#

## How the Program Works

The Countdown class implements the IEnumerator interface by defining:

* **MoveNext()** – Moves to the next number in the countdown
* **Current** – Returns the current number
* **Reset()** – Included but not supported in this example

The main program creates an instance of Countdown and uses a loop to print each value until the countdown is complete.

## How to Run

1. Open the project in Visual Studio or another C# IDE.
2. Build and run the program.
3. The console will display a countdown from 10 to 0.

## Author

Created for a Module 3 C# interfaces assignment.
