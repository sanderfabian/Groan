using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SanderVictorAssgt
{//Sander Fabian C3418982 & Victor Chua Jia Zhi C3418248
    public partial class Results  : Form
    {

        string player1,player2;
        int score, p1, p2, type;

        

        public Results(string player1, string player2, int score, string winner, int p1, int p2, List<ListHolder.TableContent> table,int type)//takes an object list called table and the type of the game

        {
            InitializeComponent();

            //int b = a.Count(s => s == "has won the game!");
            //var mainForm = Application.OpenForms.OfType<Form2>().Single();
            dataGridView1.DataSource = GenerateFullTable(table); // generating the datagrid table
            dataGridView1.RowHeadersVisible = false;

            this.player1 = player1;
            this.player2 = player2;
            this.score = score;
            this.p1 = p1;
            this.p2 = p2;
            this.type = type;

        }

        public DataTable GenerateFullTable(List<ListHolder.TableContent> Table) //  function to generate to table, taking a list as its parameters to return a data table
        {

            DataTable table = new DataTable("table");
            DataColumn column;
            DataRow row;



            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Active Player";

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Die 1";

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Die 2";

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Running score";

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Cumulative score";

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Comments";

            table.Columns.Add(column);


            foreach (var obj in Table) // for each objects in the list named table, it creates a row 
            {
                row = table.NewRow();

                row["Active Player"] = obj.activePlayer;
                row["Die 1"] = obj.die1;
                row["Die 2"] = obj.die2;
                row["Running Score"] = obj.runScore;
                row["Cumulative Score"] = obj.cumScore;
                row["Comments"] = obj.comments;
                table.Rows.Add(row);

            }
            return table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bPlayAgain_Click(object sender, EventArgs e) // button for play again?
        {
            if (type == 1) // it will generate another PVP game
            {
                PVPGame form2 = new PVPGame(player1, player2, score, p1, p2);

                this.Close();
                form2.Show();

            }
            else // it will generate AI game
            {
                PVAIGame form4 = new PVAIGame(player1, player2, score, p1, p2);

                this.Close();
                form4.Show();
            }
        }

        private void Results_Load(object sender, EventArgs e) // giving a fixed postioning to the border
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }
    }
}
