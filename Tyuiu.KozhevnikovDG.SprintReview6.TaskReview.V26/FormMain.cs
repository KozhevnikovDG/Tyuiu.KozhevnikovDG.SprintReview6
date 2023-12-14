using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KozhevnikovDG.SprintReview6.TaskReview.V26.Lib;

namespace Tyuiu.KozhevnikovDG.SprintReview6.TaskReview.V26
{
    public partial class FormMain_KDG : Form
    {
        public FormMain_KDG()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        Random rnd = new Random();

        int[,] mtrx;
        

        
        private void buttonDone_KDG_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxVarN1_KDG.Text) < Convert.ToInt32(textBoxVarN2_KDG.Text) && Convert.ToInt32(textBoxVarK_KDG.Text) < Convert.ToInt32(textBoxVarL_KDG.Text)
               && Convert.ToInt32(textBoxVarR_KDG.Text) < Convert.ToInt32(textBoxVarN_KDG.Text))
            {
                
                int K = Convert.ToInt32(textBoxVarK_KDG.Text);
                int L = Convert.ToInt32(textBoxVarL_KDG.Text);
                int R = Convert.ToInt32(textBoxVarR_KDG.Text);

                int res = 1;
                
                for (int i = K; i <= L; i++)
                {
                    if (mtrx[R, i] % 2 != 0)
                    {
                        res *= mtrx[R, i];
                    }
                }

                textBoxResult_KDG.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("ТаскРевью выполнил студент группы ИИПБ-23-1 Кожевников Данил Георгиевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonHelp_KDG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТаскРевью 4 выполнил студент группы ИИПБ-23-1 Кожевников Данил Георгиевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonMatrix_KDG_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBoxVarN_KDG.Text);
            int M = Convert.ToInt32(textBoxVarM_KDG.Text);
            int N1 = Convert.ToInt32(textBoxVarN1_KDG.Text);
            int N2 = Convert.ToInt32(textBoxVarN2_KDG.Text);
            mtrx = new int[N, M];  // инициализируем массив mtrx
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mtrx[i, j] = rnd.Next(N1, N2);
                    if ((i + j) % 2 == 1)
                    {
                        mtrx[i, j] *= -1;
                    }
                }
            }
            dataGridViewMatrix_KDG.RowCount = N;
            dataGridViewMatrix_KDG.ColumnCount = M;
            for (int i = 0; i < N; i++)
            {
                dataGridViewMatrix_KDG.Columns[i].Width = 25;
                for (int j = 0; j < M; j++)
                {
                    dataGridViewMatrix_KDG.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }
    }

    

    

}