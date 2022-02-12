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
        int[,] grid;

        public F_RecursivePainting()
        {
            InitializeComponent();
        }

        private void F_RecursivePainting_Load(object sender, EventArgs e)
        {

        }

        private void b_generateGrid_Click(object sender, EventArgs e)
        {
            CreateGrid((int)nud_gridSize.Value, (int)nud_gridSize.Value);
        }

        void CreateGrid(int width, int height)
        {
            //Suspend the layout
            SuspendLayout();

            //Clear the grid first
            flp_grid.Controls.Clear();

            //Init flow layout panel size
            //Width = Cell.Width * width , Height = Cell.height * height
            flp_grid.Width  = 25 * width;
            flp_grid.Height = 25 * height;

            //Resize form
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
                    // tb_cell_x 
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
                    //Apply cell color
                    ApplyColor(cell);

                    //Add Cell OnClick event for painting
                    cell.Click += Cell_Click;
                    
                    //Add cell to visual grid
                    flp_grid.Controls.Add(cell);
                }
            }

            //Suspend the layout
            ResumeLayout();
            //Try force running garbage collection to prevent out of memoery issues
            //Max size of 30x30 is fine tho and fits the screen so may not be required
            GC.Collect();
        }

        void Cell_Click(object sender, EventArgs e)
        {
            TextBox cell = sender as TextBox;
            DumbPaint(cell);
            //SmartPaint(cell);
        }

        //Without recursivity
        void DumbPaint(TextBox cell)
        {
            
        }

        //With recursivity
        void SmartPaint(TextBox cell)
        {

        }

        void ApplyColor(TextBox cell)
        {
            switch (cell.Text)
            {
                //White
                case "0":
                    cell.BackColor = Color.White;
                    break;
                //Light Gray
                case "1":
                    cell.BackColor = Color.LightGray;
                    break;
                //Dark Gray (Paint Color)
                case "2":
                    cell.BackColor = Color.Gray;
                    break;
            }
        }
    }
}
