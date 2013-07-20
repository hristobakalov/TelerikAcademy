using System;
using System.Collections.Generic;
using System.Threading;

//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density.
//The dwarf is (O).

// I have updated the game so the speed is constantly growing and if you die the speed is increased with 40. You also have 3 lives!


// I am sorry for the names of the variables! It's a mess, but I hope you will enjoy the game!!!

struct Rock //This object saves our objects, like the dwarf and the obsticles. The structure has position x and y,
              //a character with which it is represented and a color.
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}


class FallingRocksGame
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringOnPosition(int x, int y, string str,
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 25; //defines the height of the console
        Console.BufferWidth = Console.WindowWidth = 70; //defines the width of the console
        int score = 0;
        double speed = 100;
        double acceleration = 0.5;
        int playFieldWidth = 31; //the width of out playing field
        int livesCount = 3;

        Rock dwarf = new Rock(); // this is our dwarf with its values
        dwarf.x = 16;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = '0';
        dwarf.color = ConsoleColor.Cyan;

        Random randomGenerator = new Random(); //this is a random generator that generates random objects on random place
        List<Rock> objects = new List<Rock>(); // this is our list with obsticles in which can be added or removed obsticles
        int chance = randomGenerator.Next(0, 100);
        while (true)
        {
            speed += acceleration;
            if (speed > 320)
            {
                speed = 320;
            }
        bool hitted = false;
        char[] fallingRocks = new char[12] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        int randomRocks = randomGenerator.Next(0, 12);
        char rock = fallingRocks[randomRocks];
           ConsoleColor color = new ConsoleColor();
        switch (randomGenerator.Next(0,5))
        {
            case 1:
                color = ConsoleColor.Gray;
                break;
            case 2:
                color = ConsoleColor.Magenta;
                break;
            case 3:
                color = ConsoleColor.Yellow;
                break;
            case 4:
                color = ConsoleColor.Red;
                break;
            default:
                break;
        }
        Rock rockObject = new Rock();
        rockObject.c = rock;
        rockObject.color = color;
        rockObject.x = randomGenerator.Next(0, playFieldWidth);
        rockObject.y = 0;
        objects.Add(rockObject);


        while (Console.KeyAvailable) //this while circle moves our dwarf to the left or to the right, depending which arrow we pressed
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);
            if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                if (dwarf.x -1 >= 0)
                {
                    dwarf.x--;
                }
            }
            else if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                if (dwarf.x +1 < playFieldWidth)
                {
                    dwarf.x++;
                }

            }
        }
        List<Rock> newList = new List<Rock>();
        for (int i = 0; i < objects.Count; i++) // this cicle moves our obsticles
        {
            Rock oldRocks = objects[i];
            Rock newObject = new Rock();
            newObject.x = oldRocks.x;
            newObject.y = oldRocks.y + 1;
            newObject.c = oldRocks.c;
            newObject.color = oldRocks.color;
            if (newObject.y == dwarf.y && newObject.x == dwarf.x) // this checks if we are hit by something
            {
                livesCount--;
                hitted = true;
                speed += 50;
                if (speed > 320)
                {
                    speed = 320;
                }
                if (livesCount <= 0)
                {
                    PrintStringOnPosition(35, 10, "GAME OVER!", ConsoleColor.Red);
                    PrintStringOnPosition(35, 12, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            if (newObject.y < Console.WindowHeight)
            {
                newList.Add(newObject);
            }
        }
        objects = newList;
        Console.Clear(); //this clears the whole console
        if (hitted) // if you are hit it clears the objects in order to be easier
	    {
		    objects.Clear();
            PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
	    }
        else
	    {
            PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
	    }
        foreach (Rock something in objects)
        {
            PrintOnPosition(something.x, something.y, something.c, something.color);
        }
        foreach (Rock something1 in objects)
        {
            PrintOnPosition(something1.x, something1.y, something1.c, something1.color);
        }
        score++;
        PrintStringOnPosition(35, 4, "Lives: " + livesCount, ConsoleColor.White);
        PrintStringOnPosition(35, 5, "Score: " + score, ConsoleColor.White);
        PrintStringOnPosition(35, 6, "Speed: " + speed, ConsoleColor.White);
        Thread.Sleep((int)(400 - speed)); //makes the game to run by its self without touching anything.
        }
    }
}
