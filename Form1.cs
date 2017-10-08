using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQueens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "0";
            lblTime.Visible = false;
            lblTitleTime.Visible = false;
            timer1.Enabled = false;
            noQueen.ResetText();
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "" + (int.Parse(lblTime.Text) + 1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            lblTitleTime.Visible = true;
            timer1.Enabled = true;
            pictureBoxStarting.Visible = false;

            int noQueens = Decimal.ToInt16(noQueen.Value); //number of queens

            drawChessBoard(noQueens);
        }


        //custom function
        //draw chess board
        private void drawChessBoard(int n)
        {
            flowLayoutPanel1.Controls.Clear();
            int sizeOfSquare = 400 / n;
            for (int i = 0; i < n; i++) //row
            {
                for (int j = 0; j < n; j++) //col
                {
                    Button square = new Button();
                    square.Size = new System.Drawing.Size(sizeOfSquare, sizeOfSquare);
                    square.FlatStyle = FlatStyle.Flat;
                    square.FlatAppearance.BorderSize = 4;
                    if (0 == (i+j)%2)
                    {
                        square.BackColor = System.Drawing.Color.White;
                        square.FlatAppearance.BorderColor = System.Drawing.Color.White;
                        
                    }
                    else
                    {
                        square.BackColor = System.Drawing.Color.Silver;
                        square.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                    }
                    square.Margin = new Padding(0);
                    square.Tag = string.Format("{0},{1},0", i, j); //the index of queen in the board and checkQueen (0 -> no, 1->queens)
                    square.Click += new EventHandler(SquareClicked);
                    flowLayoutPanel1.Controls.Add(square);
                }
            }            
        }

        private void SquareClicked(object sender, EventArgs e)
        {
            string[] tagOfSquare = ("" + ((Button)sender).Tag).Split(',');
            try
            {
                if (tagOfSquare[2] == "0")
                {
                    ((Button)sender).BackgroundImage = Image.FromFile("..\\..\\..\\queen.png");
                    ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                    tagOfSquare[2] = "1";
                }
                else
                {
                    ((Button)sender).BackgroundImage = base.BackgroundImage;
                    tagOfSquare[2] = "0";
                }
                ((Button)sender).Tag = String.Join(",", tagOfSquare); //update value of Button.Tag
            }
            catch (Exception )
            {
                ((Button)sender).Text = "Queen";
            }
            //MessageBox.Show(String.Join(",", tagOfSquare));

            //check safe, return queen's index not safe
            
            List<int[]> queensIndexIsNotSafed = checkSafe(tagOfSquare);

            if (queensIndexIsNotSafed.Count > 0) //not safe, warning!!
            {
                drawWarning(queensIndexIsNotSafed, tagOfSquare);
            }
        }

        //check safe whenever square is clicked
        private List<int[]> checkSafe(string[] tagOfSquare) //empty is safe
        {
            List<int[]> result = new List<int[]>(); //result storage all queen "be eated" indexs
            int noQueens = Decimal.ToInt16(noQueen.Value); //number of queens
            int queenRowIndex = int.Parse(tagOfSquare[0]);
            int queenColIndex = int.Parse(tagOfSquare[1]);
            Button[,] chessBoard = parseArrayButtonChessBoard();

            //check col
            for (int i = 0; i < noQueens; i++)
            {
                if (i != queenRowIndex)
                {
                    string getTag = "" + chessBoard[queenRowIndex, i].Tag; //"row,col,checkQueen"
                    if (getTag[4] == '1') //not safe
                    {
                        result.Add(new int[] { queenRowIndex, i });
                        break;
                    }
                }
            }
            //check row
            for (int i = 0; i < noQueens; i++)
            {
                if (i != queenColIndex)
                {
                    string getTag = "" + chessBoard[queenColIndex, i].Tag; //"row,col,checkQueen"
                    if (getTag[4] == '1') //not safe
                    {
                        result.Add(new int[] { queenColIndex, i });
                        break;
                    }
                }
            }

            //check 2 diagonals
            for (int i = 0; i < noQueens; i++)
            {
                for (int j = 0; j < noQueens; j++)
                {
                    if (i != queenRowIndex && j != queenColIndex)
                    {
                        string getTag = "" + chessBoard[i, j].Tag; //"row,col,checkQueen"
                        if (getTag[4] == '1') //not safe
                        {
                            result.Add(new int[] { i, j });
                            break;
                        }
                    }
                }
            }

            for (int i = noQueens - 1; i >=0 ; i--)
            {
                for (int j = 0; j < noQueens; j++)
                {
                    if (i != queenRowIndex && j != queenColIndex)
                    {
                        string getTag = "" + chessBoard[i, j].Tag; //"row,col,checkQueen"
                        if (getTag[4] == '1') //not safe
                        {
                            result.Add(new int[] { i, j });
                            break;
                        }
                    }
                }
            }

            return result; 
        }

        private Button[,] parseArrayButtonChessBoard()
        {
            int noQueens = Decimal.ToInt16(noQueen.Value);
            Button[,] chessBoard = new Button[noQueens, noQueens];
            //get button array in flowLayoutPanel1
            for (int i = 0; i < noQueens; i++)
            {
                for (int j = 0; j < noQueens; j++)
                {
                    chessBoard[i, j] = (Button) flowLayoutPanel1.GetChildAtPoint(new Point(
                                        (200/noQueens)*(2*i + 1), 
                                        (200 / noQueens) * (2 * j + 1))
                                        );
                }
            }
            return chessBoard;
        }

        private void drawWarning(List<int[]> checkSafeResult, string[] tagOfSquare)
        {
            Button[,] chessBoard = parseArrayButtonChessBoard(); //get Point
            int noQueens = Decimal.ToInt16(noQueen.Value);

            foreach (int[] squareCoordinate in checkSafeResult) //0 -> row ; 1 -> col
            {
                if ((squareCoordinate[0] + "") == tagOfSquare[0]) //same row
                {
                    for (int i = 0; i < noQueens; i++)
                    {
                        ((Button)flowLayoutPanel1.GetChildAtPoint(new Point(
                                        chessBoard[squareCoordinate[0], i].Location.X,
                                        chessBoard[squareCoordinate[0], i].Location.Y
                                        ))).FlatAppearance.BorderColor = Color.Red;
                     
                    }
                }

                if ((squareCoordinate[1] + "") == tagOfSquare[1]) //same col
                {
                    for (int i = 0; i < noQueens; i++)
                    {
                        ((Button)flowLayoutPanel1.GetChildAtPoint(new Point(
                                        chessBoard[i, squareCoordinate[1]].Location.X,
                                        chessBoard[i, squareCoordinate[1]].Location.Y
                                     ))).FlatAppearance.BorderColor = Color.Red;

                    }
                }

                if ((squareCoordinate[0] - squareCoordinate[1]) == (int.Parse(tagOfSquare[0]) - int.Parse(tagOfSquare[1]))) //same diagonals
                {
                    for (int i = 0; i < noQueens; i++)
                    {
                        for (int j = 0; j < noQueens; j++)
                        {
                            ((Button)flowLayoutPanel1.GetChildAtPoint(new Point(
                                            chessBoard[i, j].Location.X,
                                            chessBoard[i, j].Location.Y
                                         ))).FlatAppearance.BorderColor = Color.Red;

                        }
                    }

                }

                if ((squareCoordinate[0] + squareCoordinate[1]) == (int.Parse(tagOfSquare[0]) + int.Parse(tagOfSquare[1]))) //same diagonals
                {
                    for (int i = noQueens - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < noQueens; j++)
                        {
                            ((Button)flowLayoutPanel1.GetChildAtPoint(new Point(
                                            chessBoard[i, j].Location.X,
                                            chessBoard[i, j].Location.Y
                                         ))).FlatAppearance.BorderColor = Color.Red;

                        }
                    }
                }
            }
            //get button array in flowLayoutPanel1
            for (int i = 0; i < noQueens; i++)
            {
                for (int j = 0; j < noQueens; j++)
                {
                    (flowLayoutPanel1.GetChildAtPoint(new Point(
                                        (200 / noQueens) * (2 * i + 1),
                                        (200 / noQueens) * (2 * j + 1))
                                        )).BackColor = Color.Red;
                }
            }
        }
    }
}
