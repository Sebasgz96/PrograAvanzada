using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cldFechaDeEntrada_SelectionChanged(object sender, EventArgs e)
        {
            lblFechaSeleccionada.Text = cldFechaDeEntrada.SelectedDate.ToShortDateString();
        }
    }
}