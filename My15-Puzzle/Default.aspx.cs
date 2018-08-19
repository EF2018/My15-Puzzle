using My15_Puzzle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My15_Puzzle
{
    public partial class Default : System.Web.UI.Page
    {
        Game myGame;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                myGame = new Game();
                myGame.InitGame();
                Session["MyObject"] = myGame;
                Label3.Text = "Your step №:" + myGame.step;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((System.Web.UI.WebControls.Button)sender).Text);

            myGame = Session["MyObject"] as Game;
            myGame.FindCoordCurCell(position);
            myGame.FindEmptyInNeighborCells();
            Label3.Text = "Your step №:" + myGame.step;
            UpdateGameField();


            if (CheckForEndGame() == true)
            {
                SaveRecord.Visible = true;
                TextBox1.Visible = true;
                Label2.Visible = true;
                Label1.Visible = true;
            };
        }

        /// <summary>
        /// Обновление значений кнопок
        /// </summary>
        public void UpdateGameField()
        {
            int numb = 0;
            for (int i = 0; i < myGame.ArrGame.Length; i++)
            {
                for (int j = 0; j < myGame.ArrGame[i].Length; j++)
                {
                    string nam = "Button" + numb;
                    Button foundButton = GameBox.FindControl(nam) as Button;
                    foundButton.Text = (myGame.ArrGame[i][j].Name).ToString();
                    foundButton.BorderStyle = BorderStyle.NotSet;
                    foundButton.BackColor = System.Drawing.Color.SteelBlue;
                    numb++;
                    if (foundButton.Text == "")
                    {
                        foundButton.BorderColor = System.Drawing.Color.White;
                        foundButton.BorderStyle = BorderStyle.None;
                        foundButton.BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Проверка на конец игры
        /// </summary>
        /// <returns></returns>
        public bool CheckForEndGame()
        {
            bool check = true;
            for (int i = 0; i < myGame.size * myGame.size - 1; i++)
            {
                Button foundButton = GameBox.FindControl("Button" + i.ToString()) as Button;
                if (foundButton.Text == (i + 1).ToString())
                {
                    check = true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        protected void SaveRecord_Click(object sender, EventArgs e)
        {
            myGame.UserName = TextBox1.Text;

        }
    }
}
