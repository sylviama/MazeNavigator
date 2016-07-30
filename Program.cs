using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeNavigator.cs
{
   class Program
   {
       static void Main(string[] args)
       { 
           char[][] labyrinth = new char[][] {
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
               new char[10] { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' }
           };

           labyrinth[PlayerRow][PlayerColumn] = '#';
           DrawMaze(labyrinth);


           while (true)
           {
               Console.Write("Enter a direction> ");
               labyrinth[PlayerRow][PlayerColumn] = '.';
               MoveCharacter(Console.ReadLine());
               labyrinth[PlayerRow][PlayerColumn] = '#';
               DrawMaze(labyrinth);
           }

       }

       public static int PlayerRow = 0;
       public static int PlayerColumn = 0;


       public static void MoveCharacter(string direction)
       {
           switch (direction)
           {
               case "up":
                   PlayerRow--;
                   break;
               case "down":
                   PlayerRow++;
                   break;
               case "right":
                   PlayerColumn++;
                   break;
               case "left":
                   PlayerColumn--;
                   break;
               default:
                   break;
           }
       }

       public static void PrintArray(char[] row)
       {
           foreach (char blip in row)
           {
               Console.Write(blip + " ");
           }
           Console.WriteLine();
       }

       public static void DrawMaze(char[][] labyrinth)
       {
           foreach (var row in labyrinth)
           {
               PrintArray(row);
           }
       }
       
   }
}