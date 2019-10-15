using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

/* 10 10     Building has 100 windows(10x10)
6         Batman has 6 jumps to find the bombs
2 5       Batman starts at position(2,5)*/

class Player
{
  static void Main(string[] args)
  {
    string[] inputs;
    inputs = Console.ReadLine().Split(' ');
    int W = int.Parse(inputs[0]); // width of the building.
    int H = int.Parse(inputs[1]); // height of the building.
    int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
    inputs = Console.ReadLine().Split(' ');
    int X0 = int.Parse(inputs[0]);
    int Y0 = int.Parse(inputs[1]);

    string resX = Convert.ToString(X0);
    string resY = Convert.ToString(Y0);

    List<decimal> x  = new List<decimal>();
    x.Add(0);
    x.Add(X0);
    x.Add(W);
    x.Sort();

    List<decimal> y = new List<decimal>();
    y.Add(0);
    y.Add(Y0);
    y.Add(H);
    y.Sort();

    // game loop
    while (true)
    {
      string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)

      switch(bombDir)
      {
        case "U":
          y[2] = y[1];
          y[1] = (int)Math.Floor((y[1] + y[0])/2);
          resY = Convert.ToString(y[1]);
          break;
        case "UR":
          y[2] = y[1];
          y[1] = (int)Math.Floor((y[1] + y[0]) / 2);
          resY = Convert.ToString(y[1]);
          x[0] = x[1];
          x[1] = (int)Math.Floor((x[1] + x[2]) / 2);
          resX = Convert.ToString(x[1]);
          break;
        case "R":
          x[0] = x[1];
          x[1] = (int)Math.Floor((x[1] + x[2]) / 2);
          resX = Convert.ToString(x[1]);
          break;
        case "DR":
          y[0] = y[1];
          y[1] = (int)Math.Floor((y[1] + y[2]) / 2);
          resY = Convert.ToString(y[1]);
          x[0] = x[1];
          x[1] = (int)Math.Floor((x[1] + x[2]) / 2);
          resX = Convert.ToString(x[1]);
          break;
        case "D":
          y[0] = y[1];
          y[1] = (int)Math.Floor((y[1] + y[2]) / 2);
          resY = Convert.ToString(y[1]);
          break;
        case "DL":
          y[0] = y[1];
          y[1] = (int)Math.Floor((y[1] + y[2]) / 2);
          resY = Convert.ToString(y[1]);
          x[2] = x[1];
          x[1] = (int)Math.Floor((x[1] + x[0]) / 2);
          resX = Convert.ToString(x[1]);
          break;
        case "L":
          x[2] = x[1];
          x[1] = (int)Math.Floor((x[1] + x[0]) / 2);
          resX = Convert.ToString(x[1]);
          break;
        case "UL":
          y[2] = y[1];
          y[1] = (int)Math.Floor((y[1] + y[0]) / 2);
          resY = Convert.ToString(y[1]);
          x[2] = x[1];
          x[1] = (int)Math.Floor((x[1] + x[0]) / 2);
          resX = Convert.ToString(x[1]);
          break;
        default:
          
          break;
      }        
        
      // Write an action using Console.WriteLine()
      // To debug: Console.Error.WriteLine("Debug messages...");


      // the location of the next window Batman should jump to.
      Console.WriteLine(resX + "" + resY);
    }
  }
}