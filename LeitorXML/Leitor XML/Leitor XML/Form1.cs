using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Leitor_XML
{
    public partial class frmPrincipal : Form
    {
        private string strTexto;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strTexto = Classes.Funcoes.Ler.LERXML("C:\\LeitorXML\\XML\\RM2721.xml");

            txtResposta.Text = strTexto;
        }
    }
}
