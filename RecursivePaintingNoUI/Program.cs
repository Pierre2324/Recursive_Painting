using System;

namespace RecursivePaintingNoUI
{
    class Program
    {
        //2D array representing the grid
        //When painting, values are stored there as we aren't working on the UI directly
        //Init 2d array size
        static int[,] grid;
        //Grid size
        static int gridSize = 0;

        static void Main(string[] args)
        {
            //Ask user for grid size
            //While loop just to make sure its a int and not just any random keys
            while (gridSize < 1)
            {
                Console.WriteLine("Enter grid size:");
                Int32.TryParse(Console.ReadLine(), out gridSize);
            }
            Console.WriteLine("Generating grid of size : " + gridSize);

            grid = new int[gridSize, gridSize];

            //Random number generator object
            Random rand = new Random();
            //Create grid
            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    //Random value of the current cell
                    int value = rand.Next(0, 2);
                    //Assign to the 2d array (our grid)
                    grid[x, y] = value;
                }
            }

            ShowGrid();

            //X 
            int X = -1;
            //Ask user for X value
            //While loop just to make sure its a int and not just any random keys
            while (X < 0)
            {
                Console.WriteLine("Enter X value of index to paint:");
                Int32.TryParse(Console.ReadLine(), out X);
            }
            //Y 
            int Y = -1;
            //Ask user for Y value
            //While loop just to make sure its a int and not just any random keys
            while (Y < 0)
            {
                Console.WriteLine("Enter Y value of index to paint:");
                Int32.TryParse(Console.ReadLine(), out Y);
            }

            Console.WriteLine("Painting...");

            //Paint
            PaintCells(X, Y);

            //Wait for key to exit
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void ShowGrid()
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    Console.Write(" | " + grid[x, y]);
                    //Last index of row
                    if (x == gridSize - 1)
                        Console.Write(" |" + "\n");
                }
            }
        }

        //Get initial cell value 0 (white) or 1 (light gray)
        static int initialColor = 0;
        //This method works on the main cell / the cell user clicked on
        //Set initial array index to 2 (will be painted)
        //Set direct neighbors indexes with same color than initial index (initialColor) to 2 (will be painted)
        ///Apply array to the grid in UI
        ///Paint cells considering their new values
        static void PaintCells(int x, int y)
        {
            //Initial color : the color we'll searching for in neighbors
            initialColor = grid[x, y];

            //Set initial index[x,y] (the index user clicked on) to 2 (will be painted) 
            grid[x, y] = 2;

            //Search neighbors in a clockwise pattern (up, right, down, left) 
            //Up    -> grid[ x     , y - 1 ]
            //Right -> grid[ x + 1 , y     ]
            //Down  -> grid[ x     , y + 1 ]
            //Left  -> grid[ x - 1 , y     ]
            CheckNeighbor(x, y - 1);
            CheckNeighbor(x + 1, y);
            CheckNeighbor(x, y + 1);
            CheckNeighbor(x - 1, y);

            ///Regenerate grid
            ShowGrid();
        }

        //Method used to check neighbors of the initial/main index/cell user clicked on
        //Method then call itself to check neighbors of neighbors, etc
        //Checks are added so method has limits => wont go out of range, does not process neighbors having a different color than the initalColor(user clicked cell initial color)
        static void CheckNeighbor(int x, int y)
        {
            //If index is out of range return
            if (x == -1 || y == -1 || x >= grid.GetLength(0) || y >= grid.GetLength(1)) return;

            //If not initial color or already set as "will be painted", skip this index
            if (grid[x, y] != initialColor || grid[x, y] == 2) return;

            //Else set value to 2 (will be painted)
            grid[x, y] = 2;

            //Up
            CheckNeighbor(x, y - 1);
            //Right
            CheckNeighbor(x + 1, y);
            //Down
            CheckNeighbor(x, y + 1);
            //Left
            CheckNeighbor(x - 1, y);
        }
    }
}
