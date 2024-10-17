using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaSePrice.Utilidades
{
    public static class CustomDataGridView
    {
        public static void ImplementarConfiguracion(this DataGridView datagrid, string textoDeBoton = "")
        {
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToResizeColumns = true;
            datagrid.AllowUserToResizeRows = false;
            datagrid.AllowUserToOrderColumns = false;
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.MultiSelect = false;
            datagrid.RowHeadersVisible = false;
            datagrid.ReadOnly = true;
            datagrid.BackgroundColor = Color.White;
            datagrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(33, 32, 43),
                SelectionBackColor = Color.FromArgb(100, 97, 129),
                ForeColor = Color.FromArgb(255, 255, 255)
            };
            datagrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(248, 244, 255),
                SelectionForeColor = Color.FromArgb(0, 0, 0),
            };
            datagrid.ColumnHeadersHeight = 30;
            datagrid.EnableHeadersVisualStyles = false;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;


            if (textoDeBoton != "") {
                var btnAccionColumn = new DataGridViewButtonColumn();
                btnAccionColumn.Text = textoDeBoton;
                btnAccionColumn.Name = "ColumnaAccion";
                btnAccionColumn.HeaderText = "";
                btnAccionColumn.UseColumnTextForButtonValue = true;
                btnAccionColumn.Width = 90;
                btnAccionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


                datagrid.Columns.Add(btnAccionColumn);

            }


        }
    }
}
