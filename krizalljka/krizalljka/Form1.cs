using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace krizalljka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicijalizacija();
            
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    slika(r, c);
                }
            }

            for (int r = 7; r < 10; r++)
            {
                for (int c = 5; c < 10; c++)
                {
                    slika(r, c);
                }
            }

            PostaviPitanje(1,4,"Pravomoćna sudska odluka");
            PostaviPitanje(2, 4, "Telekomu- nikacijski uređaj");
            PostaviPitanje(3, 4, "Pohvalne pjesme");
            PostaviPitanje(4, 4, "Majka odmila");
            PostaviPitanje(5, 4, "Stanovnica Irana --------  Ocrt");
            PostaviPitanje(5, 3, "Dronjci, krpe");
            PostaviPitanje(5, 2, "Sin Ivice Osima");
            PostaviPitanje(5, 1, "Nogometaš Fabregas");
            PostaviPitanje(6, 0, "X (panamska misica)");
            PostaviPitanje(7, 0, "Redatelj Kusturica");
            PostaviPitanje(8, 0, "Šezdeset minuta (mn.)");
            PostaviPitanje(9, 0, "Naš otok bjeloglavih supova");
            PostaviPitanje(0, 5, "Mjera alkohol- iziranosti vozača");
            PostaviPitanje(0, 6, "Čuvari reda");
            PostaviPitanje(0, 7, "Pra- stanovnik Njemačke");
            PostaviPitanje(0, 8, "Venecija");
            PostaviPitanje(0,9,  "Redateljica Kodar");
            PostaviPitanje(0, 10, "Repriza");
            PostaviPitanje(0, 11, "Jedanako, identično");
            PostaviPitanje(0, 12, "Jennifer Aniston");
            PostaviPitanje(0, 13, "Austrijski pisac Canneti");
            PostaviPitanje(0, 14, "Činiti kadrove filma");
            PostaviPitanje(3, 8, "Uredski spis -----  Tenisačica Konjuh");
            PostaviPitanje(4, 9, "Vodonoša -------- Kelly Brook");
            PostaviPitanje(2, 10, "Dvorana ----- Mehanički defekt");
            PostaviPitanje(3, 12, "Ivan Dodig ------ Doticaji");
            PostaviPitanje(5, 11, "Apscise i ordinate ----- Pronalazak");
            PostaviPitanje(6, 13, "Radijus ------ Mamljenje, vabljenje");
            PostaviPitanje(7, 10, "Najhladnije godišnje doba");
            PostaviPitanje(8, 10, "Sol mokraćne kiseline");
            PostaviPitanje(9, 10, "Glumica Rogers");


            Odgovori(1, 5, "P");
            Odgovori(1, 6, "R");
            Odgovori(1, 7, "A");
            Odgovori(1, 8, "V");
            Odgovori(1, 9, "O");
            Odgovori(1, 10, "R");
            Odgovori(1, 11, "I");
            Odgovori(1, 12, "J");
            Odgovori(1, 13, "E");
            Odgovori(1, 14, "K");
            Odgovori(2, 5, "R");
            Odgovori(2, 6, "E");
            Odgovori(2, 7, "L");
            Odgovori(2, 8, "E");
            Odgovori(2, 9, "J");
            Odgovori(2, 11, "S");
            Odgovori(2, 12, "A");
            Odgovori(2, 13, "L");
            Odgovori(2, 14, "A");
            Odgovori(3, 5, "O");
            Odgovori(3, 6, "D");
            Odgovori(3, 7, "E");
            Odgovori(3, 9, "A");
            Odgovori(3, 10, "K");
            Odgovori(3, 11, "T");
            Odgovori(3, 13, "I");
            Odgovori(3, 14, "D");
            Odgovori(4, 5, "M");
            Odgovori(4, 6, "A");
            Odgovori(4, 7, "M");
            Odgovori(4, 8, "A");
            Odgovori(4, 10, "V");
            Odgovori(4, 11, "O");
            Odgovori(4, 12, "D");
            Odgovori(4, 13, "A");
            Odgovori(4, 14, "R");
            Odgovori(5, 5, "I");
            Odgovori(5, 6, "R");
            Odgovori(5, 7, "A");
            Odgovori(5, 8, "N");
            Odgovori(5, 9, "K");
            Odgovori(5, 10, "A");
            Odgovori(5, 12, "O");
            Odgovori(5, 13, "S");
            Odgovori(5, 14, "I");
            Odgovori(6, 1, "C");
            Odgovori(6, 2, "A");
            Odgovori(6, 3, "R");
            Odgovori(6, 4, "O");
            Odgovori(6, 5, "L");
            Odgovori(6, 6, "I");
            Odgovori(6, 7, "N");
            Odgovori(6, 8, "E");
            Odgovori(6, 9, "B");
            Odgovori(6, 10, "R");
            Odgovori(6, 11, "I");
            Odgovori(6, 12, "D");
            Odgovori(6, 14, "R");
            Odgovori(7, 1, "E");
            Odgovori(7, 2, "M");
            Odgovori(7, 3, "I");
            Odgovori(7, 4, "R");
            Odgovori(7, 11, "Z");
            Odgovori(7, 12, "I");
            Odgovori(7, 13, "M");
            Odgovori(7, 14, "A");
            Odgovori(8, 1, "S");
            Odgovori(8, 2, "A");
            Odgovori(8, 3, "T");
            Odgovori(8, 4, "I");
            Odgovori(8, 11, "U");
            Odgovori(8, 12, "R");
            Odgovori(8, 13, "A");
            Odgovori(8, 14, "T");
            Odgovori(9, 1, "C");
            Odgovori(9, 2, "R");
            Odgovori(9, 3, "E");
            Odgovori(9, 4, "S");
            Odgovori(9, 11, "M");
            Odgovori(9, 12, "I");
            Odgovori(9, 13, "M");
            Odgovori(9, 14, "I");

        }
        private void PostaviPitanje(int red, int kolona, string pitanje)
        {

            DataGridViewCell c = board[kolona, red];
            c.Style.BackColor = Color.Gray;
            c.Style.ForeColor = Color.Black;
            c.ReadOnly = true;
            c.Style.SelectionBackColor = Color.Black;
            c.Style.SelectionForeColor = Color.White;
            c.Style.WrapMode = DataGridViewTriState.True;
            c.Value = pitanje;
            c.Style.Font = new Font("Arial", 6);
            
        }
        private void Odgovori(int red, int kolona, string slovo)
        {
            DataGridViewCell c = board[kolona, red];
            
            c.ReadOnly = false;
            c.Tag = slovo;
            c.Style.Font = new Font("Arial", 16);
            c.Style.SelectionBackColor = Color.LightYellow;
            c.Style.SelectionForeColor = Color.Black;
            
            
        }
        private void inicijalizacija()
        {
            
                board.Rows.Add(10);
                foreach (DataGridViewColumn a in board.Columns)
                    a.Width = board.Width / board.Columns.Count;
                foreach (DataGridViewRow b in board.Rows)
                    b.Height = board.Height / board.Rows.Count;

                for (int red = 0; red < board.Rows.Count; red++)
                {
                    for (int kolona = 0; kolona < board.Columns.Count; kolona++)
                    {
                        board[kolona, red].ReadOnly = true;
                        
                    }
                }
               
        
        }

        private void formatCell(int red, int kolona, string slovo)
        {
            
            DataGridViewCell c = board[kolona, red];
            
            c.ReadOnly = false;
            c.Tag = slovo;
        }

        private void slika(int red, int kolona)
        { 
            DataGridViewCell c= board[kolona, red];
            c.ReadOnly = true;
            c.Style.BackColor = Color.Black;
        }

        private void provjeriTočnostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.EndEdit();

            for (int r = 0; r < board.Rows.Count -1; r++)
            {
                for (int k = 0; k < board.Columns.Count -1; k++)
                {
                    DataGridViewCell c = board[k, r];

                    if (!c.ReadOnly && c.Value!=null)
                    {
                        if (c.Value.ToString().ToUpper() != c.Tag.ToString().ToUpper())
                        {
                            c.Style.BackColor = Color.Red;
                        }
                        else
                        {
                            c.Style.BackColor = Color.Green;
                        }
                    } 
                }
            }
        }

        private void board_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void board_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewCell c = board[e.ColumnIndex, e.RowIndex];
            if (!c.ReadOnly && c.Value != null)
            {
                if (c.Value.ToString().Trim().Length > 0)
                    c.Value = c.Value.ToString().Substring(0, 1).ToUpper();
            }
        }
    }

}