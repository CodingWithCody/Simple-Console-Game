using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string key, out int xOut, out int yOut){
      xOut = 0;
      yOut = 0;
      switch (key){
        case "W":
        case "UpArrow":
          yOut = yOut - 1;
          break;
        
        case "S":
        case "DownArrow":
          yOut++;
          break;
        
        case "A":
        case "LeftArrow":
          xOut--;
          break;
        
        case "D":
        case "RightArrow":
          xOut++;
          break;
      }
    }

    public new static char UpdateCursor(string key){
      switch (key){
        case "W":
        case "UpArrow":
          return '^';
        
        case "S":
        case "DownArrow":
          return 'v';
        
        case "A":
        case "LeftArrow":
          return '<';
        
        case "D":
        case "RightArrow":
          return '>';

        default:
          return '^'; 
      }
    }

    public new static int KeepInBounds(int coord, int max){
      if (coord < 0) return max-1;
      if (coord >= max) return 0;
      return coord;
    }

    public new static bool DidScore(int charX, int charY, int fruitX, int fruitY){
      if (charX == fruitX && charY == fruitY) return true;
      else return false;
    }
  }
}