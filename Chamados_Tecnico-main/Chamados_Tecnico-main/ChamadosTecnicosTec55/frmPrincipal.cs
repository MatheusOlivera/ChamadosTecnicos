using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ChamadosTecnicosTec55
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void soluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Deseja sair", "Sistema de chamados", MessageBoxButtons.YesNo);
        
        if (msgBox == DialogResult.Yes) { 
            
            Application.Exit();
            
        }
        
        
        
        
        
        
        
        
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { 
            
                FileName =@"https://sp.senac.br",
                UseShellExecute = true,
             });
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");  
            
             
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
