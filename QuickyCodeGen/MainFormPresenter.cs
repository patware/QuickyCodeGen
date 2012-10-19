using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace QuickyCodeGen
{
    internal class MainFormPresenter
    {
        IMainView _view;
        private DataSet _ds;
        private string _template;

        internal MainFormPresenter(IMainView view)
        {
            _view = view;
            _ds = new DataSet();
            _ds.Tables.Add("foo");
        }

        internal void GenerateSample()
        {
            generateDataInput();
            generateTemplate();
        }


        private void generateDataInput()
        {
            DataTable table = _ds.Tables[0];

            table.BeginInit();
            table.BeginLoadData();

            table.Rows.Clear();
            table.Columns.Clear();

            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");

            table.Rows.Add("Donald", "Duck");
            table.Rows.Add("Lucky", "Luke");
            table.Rows.Add("John", "Doe");

            table.EndLoadData();
            table.EndInit();

            _view.SendData(table);
        }

        private void generateTemplate()
        {
            _template = "Hello <%=FirstName%> <%=LastName%>." + Environment.NewLine;
            
            _view.TemplateChanged(_template);

            compile();
        }

        private void compile()
        {
            StringBuilder builder = new StringBuilder();

            DataTable table = _ds.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                string input = _template;
                foreach (DataColumn column in table.Columns)
                {
                    input = input.Replace("<%=" + column.ColumnName + "%>", row[column.Ordinal].ToString());
                }

                builder.Append(input);
                builder.AppendLine();
            }

            _view.ShowCompilationResult(builder.ToString());

        }
    }
}
