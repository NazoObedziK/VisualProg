using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    static class TabFunc
    {
        public static void TabExplicitFunc(DataTable dataTable, double a, double b, int n)
        {
            dataTable.Rows.Clear();
            double step = (b - a) / (n - 1);
            DataRow dataRow;
            for (int i = 0; i < n; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow["x"] = a + i * step;
                dataRow["y"] = Math.Pow(2, Math.Sqrt(a + i * step + 1) - Math.Sqrt(a + i * step - 1));

                dataTable.Rows.Add(dataRow);
            }
        }
        public static void TabExplicitFuncx(DataTable dataTable, double a, double b, int n)
        {
            dataTable.Rows.Clear();
            double step = (b - a) / (n - 1);
            DataRow dataRow;
            for (int i = 0; i < n; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow["x"] = a + i * step;
                dataRow["y"] = Math.Pow(a + i * step, 1 / 3f);

                dataTable.Rows.Add(dataRow);
            }
        }
        public static void TabExplicitFuncy(DataTable dataTable, double a, double b, int n)
        {
            dataTable.Rows.Clear();
            double step = (b - a) / (n - 1);
            DataRow dataRow;
            for (int i = 0; i < n; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow["x"] = a + i * step;
                dataRow["y"] = Math.Pow(1 - (a + i * step), 1 / 3f);

                dataTable.Rows.Add(dataRow);
            }
        }

        public static void TabImplicitFunc(DataTable dataTable, double a, double b, int n)
        {
            dataTable.Rows.Clear();
            double step = (b - a) / (n - 1);
            DataRow dataRow;
            for (int i = 0; i < n; i++)
            {
                dataRow = dataTable.NewRow();
                dataRow["t"] = a + i * step;
                dataRow["x"] = Math.Pow(a + i * step, 1/3f);
                dataRow["y"] = Math.Pow(1 - (a + i * step), 1/3f);

                dataTable.Rows.Add(dataRow);

            }
        }
    }
}
