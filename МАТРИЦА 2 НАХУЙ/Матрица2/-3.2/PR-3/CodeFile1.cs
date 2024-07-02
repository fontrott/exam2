
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_3
{
    public partial class Form1 : Form
    {
        static public int Find<T1, T2>(T1 matrix,int columns,int lines)
        {
            int count = 0;
            for (int i = 0; i < lines; i++)
            {
                // Проверяем, есть ли в строке 0
                bool hasZero = false;
                dynamic dmatrix = matrix;
                for (int j = 0; j < columns; j++)
                {
                    if (dmatrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }

                // Если в строке есть 0, считаем отрицательные элементы
                if (hasZero)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (dmatrix[i, j] < 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;

        }
    }
}