using System;
using System.Collections.Generic;
using System.Text;

namespace QuickyCodeGen
{
    interface IMainView
    {
        void SendData(System.Data.DataTable table);

        void ShowCompilationResult(string result);

        void TemplateChanged(string template);
    }
}
