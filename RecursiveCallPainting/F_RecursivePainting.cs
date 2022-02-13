using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveCallPainting
{
    public partial class F_RecursivePainting : Form
    {
        //2D array representing the grid
        //When painting, values are stored there as we aren't working on the UI directly
        int[,] grid;

        public F_RecursivePainting()
        {
            InitializeComponent();
        }

        private void F_RecursivePainting_Load(object sender, EventArgs e)
        {
        }

        private void B_generateGrid_Click(object sender, EventArgs e)
        {
            CreateGrid((int)nud_gridSize.Value, (int)nud_gridSize.Value);
        }

        void CreateGrid(int width, int height)
        {
            /// 3 forward slashes for UI stuffs
            //  2 forward slashes for logic stuffs
            ///Clear the grid first
            flp_grid.Controls.Clear();

            ///Init flow layout panel size
            ///Width = Cell.Width * width , Height = Cell.height * height
            flp_grid.Width  = 25 * width;
            flp_grid.Height = 25 * height;

            ///Resize form
            this.Width =  20 + flp_grid.Width;
            this.Height = 85 + flp_grid.Height;

            //Init 2d array size
            grid = new int[width, height];

            //Random number generator object
            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < height; x++)
                {
                    //Random value of the current cell
                    int value = rand.Next(0, 2);
                    //Assign to the 2d array (our grid)
                    grid[x, y] = value;
                    /// tb_cell_x 
                    TextBox cell = new TextBox
                    {
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                        MinimumSize = new System.Drawing.Size(25, 25),
                        Multiline = true,
                        Name = "cell_" + x + "_" + y, //cell_x_y
                        Size = new System.Drawing.Size(25, 25),
                        Text = grid[x, y].ToString(),
                        TextAlign = System.Windows.Forms.HorizontalAlignment.Center,
                        Margin = new Padding(0)
                    };
                    ///Apply cell color
                    ApplyColor(cell);

                    //Add Cell OnClick event for painting
                    cell.Click += Cell_Click;
                    
                    ///Add cell to visual grid
                    flp_grid.Controls.Add(cell);
                }
            }
        }

        void Cell_Click(object sender, EventArgs e)
        {
            ///Current clicked cell
            TextBox cell = sender as TextBox;
            //Get x, y values of the cell (stored in its name : case_x_y) 
            int x = Int32.Parse(cell.Name.Split('_')[1]);
            int y = Int32.Parse(cell.Name.Split('_')[2]);
            //Main painting method
            PaintCells(x,y);
        }

        //Get initial cell value 0 (white) or 1 (light gray)
        int initialColor = 0;
        //This method works on the main cell / the cell user clicked on
        //Set initial array index to 2 (will be painted)
        //Set direct neighbors indexes with same color than initial index (initialColor) to 2 (will be painted)
        ///Apply array to the grid in UI
        ///Paint cells considering their new values
        void PaintCells(int x, int y)
        {
            //Initial color : the color we'll searching for in neighbors
            initialColor = grid[x,y];

            //Set initial index[x,y] (the index user clicked on) to 2 (will be painted) 
            grid[x, y] = 2;

            //Search neighbors in a clockwise pattern (up, right, down, left) 
            //Up    -> grid[ x     , y - 1 ]
            //Right -> grid[ x + 1 , y     ]
            //Down  -> grid[ x     , y + 1 ]
            //Left  -> grid[ x - 1 , y     ]
            CheckNeighbor(x    , y - 1);
            CheckNeighbor(x + 1, y    );
            CheckNeighbor(x    , y + 1);
            CheckNeighbor(x - 1, y    );

            ///Regenerate grid
            RegenerateGrid();
        }

        //Method used to check neighbors of the initial/main index/cell user clicked on
        //Method then call itself to check neighbors of neighbors, etc
        //Checks are added so method has limits => wont go out of range, does not process neighbors having a different color than the initalColor(user clicked cell initial color)
        private void CheckNeighbor(int x, int y)
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

        #region UI 
        ///Cycles through the UI grid, takes the matching grid array values and assign them to it (to the UI grid)
        private void RegenerateGrid()
        {
            foreach (Control control in flp_grid.Controls)
            {
                TextBox cell = control as TextBox;
                int cell_x = Int32.Parse(cell.Name.Split('_')[1]);
                int cell_y = Int32.Parse(cell.Name.Split('_')[2]);
                cell.Text = grid[cell_x, cell_y].ToString();
                ApplyColor(cell);
            }
        }

        void ApplyColor(TextBox cell)
        {
            switch (cell.Text)
            {
                ///White
                case "0":
                    cell.BackColor = Color.White;
                    break;
                ///Light Gray
                case "1":
                    cell.BackColor = Color.LightGray;
                    break;
                ///Dark Gray (Paint Color)
                case "2":
                    cell.BackColor = Color.Gray;
                    break;
            }
        }
        #endregion
    }
}
