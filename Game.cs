/*
 * © Caleb Hyatt 2022
 * 
 */

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class PlayingGrid : Form
    {
        /**
         * 
         */
        const int COL_COUNT = 60;
        const int ROW_COUNT = 50;
        protected Cell[,] cells = new Cell[COL_COUNT, ROW_COUNT];
        protected int Steps = 0;
        protected bool anyAlive = false;

        public PlayingGrid()
        {
            InitializeComponent();

            createCells();
        }

        /**
         * Create the grid cells
         */
        public void createCells()
        {
            int x, y;

            for (int c = 0; c < COL_COUNT; c++)
            {
                for (int r = 0; r < ROW_COUNT; r++)
                {
                    x = c * 11 + 10;
                    y = r * 11 + 10;

                    Cell lbl = new Cell();
                    lbl.Width = 10;
                    lbl.Height = 10;
                    lbl.BackColor = Color.Blue;
                    lbl.Text = " ";
                    lbl.Location = new Point(x, y);

                    cells[c, r] = lbl;
                    this.Controls.Add(lbl);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            anyAlive = false;

            for (int c = 0; c < COL_COUNT - 1; c++)
            {
                for (int r = 0; r < ROW_COUNT - 1; r++)
                {
                    Cell cell = cells[c, r];

                    if (cell.currentStatus == 1)
                    {
                        anyAlive = true;
                    }

                    int nCount = 0;
                    if (c == 0) // cell is left side of the grid
                    {
                        nCount += AddNeighbor(c, r - 1);       // up 1
                        nCount += AddNeighbor(c + 1, r - 1);   // up 1 right 1
                        nCount += AddNeighbor(c + 1, r);       // right 1
                        nCount += AddNeighbor(c, r + 1);       // down 1
                        nCount += AddNeighbor(c + 1, r + 1);   // down 1 right 1
                    }
                    else if (c == COL_COUNT - 1) // cell is right side of the grid
                    {
                        nCount += AddNeighbor(c - 1, r - 1);   // up 1 left 1
                        nCount += AddNeighbor(c, r - 1);       // up 1
                        nCount += AddNeighbor(c - 1, r);       // left 1
                        nCount += AddNeighbor(c - 1, r + 1);   // left 1 down 1
                        nCount += AddNeighbor(c, r + 1);       // down 1
                    }
                    else if (r == 0) // cell is top of the grid
                    {
                        nCount += AddNeighbor(c - 1, r);       // left 1
                        nCount += AddNeighbor(c + 1, r);       // right 1
                        nCount += AddNeighbor(c - 1, r + 1);   // down 1 left 1
                        nCount += AddNeighbor(c, r + 1);       // down 1
                        nCount += AddNeighbor(c + 1, r + 1);   // down 1 right 1
                    }
                    else if (r == ROW_COUNT - 1) // cell is bottom of the grid
                    {
                        nCount += AddNeighbor(c - 1, r - 1);   // up 1 left 1
                        nCount += AddNeighbor(c, r - 1);       // up 1
                        nCount += AddNeighbor(c + 1, r - 1);   // up 1 right 1
                        nCount += AddNeighbor(c - 1, r);       // left 1
                        nCount += AddNeighbor(c + 1, r);       // right 1
                    }
                    else
                    {
                        nCount += AddNeighbor(c - 1, r - 1);   // up 1 left 1
                        nCount += AddNeighbor(c, r - 1);   // up 1
                        nCount += AddNeighbor(c + 1, r - 1);   // up 1 right 1
                        nCount += AddNeighbor(c - 1, r);   // left 1
                        nCount += AddNeighbor(c + 1, r);   // right 1
                        nCount += AddNeighbor(c - 1, r + 1);   // down 1 left 1
                        nCount += AddNeighbor(c, r + 1);   // down 1
                        nCount += AddNeighbor(c + 1, r + 1);   // down 1 right 1
                    }

                    if ((nCount == 2 || nCount == 3) && cell.currentStatus == 1) // cell lives
                    {
                        cell.newStatus = 1;
                    }
                    else if (nCount == 3 && cell.currentStatus == 0) // cell is created
                    {
                        cell.newStatus = 1;
                    }
                    else // cell dies
                    {
                        cell.newStatus = 0;
                    }

                    cells[c, r] = cell;
                }
            }

            if (!anyAlive)
            {
                MessageBox.Show("No cells are alive. Apply a layout to get started.");
            }
            else
            {
                Steps++;
                lblSteps.Text = Steps.ToString();

                for (int c = 0; c < COL_COUNT; c++)
                {
                    for (int r = 0; r < ROW_COUNT; r++)
                    {
                        cells[c, r].currentStatus = cells[c, r].newStatus;
                        cells[c, r].newStatus = 0;

                        if (cells[c, r].currentStatus == 0)
                        {
                            cells[c, r].BackColor = Color.Blue;
                        }
                        else
                        {
                            cells[c, r].BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDefaultLayout_Click(object sender, EventArgs e)
        {
            SetLayout("default.txt");
        }

        private void btnRotorLayout_Click(object sender, EventArgs e)
        {
            SetLayout("rotor.txt");
        }

        private void btnCollideLayout_Click(object sender, EventArgs e)
        {
            SetLayout("collide.txt");
        }

        private void SetLayout(string layout)
        {
            // Open file and read coordinates
            string filePath = @"..\..\Lexicon\" + layout;
            StreamReader reader = null;

            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    int col = Int32.Parse(values[0]);
                    int row = Int32.Parse(values[1]);

                    cells[col, row].BackColor = Color.Yellow;
                    cells[col, row].currentStatus = 1;
                }
            }
            else
            {
                // if the specified layout file doesn't exist
                MessageBox.Show("Layout " + layout.Replace(".txt", "") + " not found. Make sure you have the right file downloaded.");
            }
        }

        private void Reset()
        {
            Steps = 0;
            lblSteps.Text = Steps.ToString();

            foreach (Cell cell in cells)
            {
                cell.BackColor = Color.Blue;
                cell.currentStatus = 0;
                cell.newStatus = 0;
            }
        }

        private int AddNeighbor(int col, int row)
        {
            if (col >= 0 && col < COL_COUNT && row >= 0 && row < ROW_COUNT)
            {
                if (cells[col, row].currentStatus == 1)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}

public class Cell : Label
{
    public int currentStatus = 0;
    public int newStatus = 0;
}