﻿namespace proyectoIntegrador
{
    public partial class Deuda : Form
    {
        private Cliente cliente; // Instancia de Cliente

        public Deuda()
        {
            InitializeComponent();
            cliente = new Cliente();
            btnVerDeuda.Click += new EventHandler(btnVerDeuda_Click);
        }

        private void btnVerDeuda_Click(object sender, EventArgs e)
        { }

        private void gridDeudaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}