using ModeloParcialApp.Entidades;
using ModeloParcialApp.Servicios.Implementacion;
using ModeloParcialApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ModeloParcialApp.Presentacion
{
    public partial class FrmOrdenRegistro : Form
    {
        IServicio servicio = null;
        OrdenRetiro nuevaOrden=null;

      
        public FrmOrdenRegistro()
        {
            InitializeComponent();
            servicio=new Servicio(); 
            nuevaOrden=new OrdenRetiro();
        }

        private void FrmOrdenRegistro_Load(object sender, EventArgs e)
        {
            DtpFecha.Enabled = false;
            CargarCombo();
        }

        private void CargarCombo()
        {
            
            CboMateriales.ValueMember = "codigo";
            CboMateriales.DisplayMember = "nombre";
            CboMateriales.DataSource = servicio.TraerMateriales();
            CboMateriales.SelectedIndex = -1;
            CboMateriales.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                foreach (DataGridViewRow r in DgvOrdenDetalle.Rows)
                {
                    if (r.Cells["ColNombre"].Value.ToString().Equals(CboMateriales.Text))
                    {
                        MessageBox.Show("Este Material ya está presupuestado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                Material m = (Material)CboMateriales.SelectedItem;
                string responsable = TxtResponsable.Text;
                int cantidad = Convert.ToInt32(NudCantidad.Value);

                DetalleOrden detalle = new DetalleOrden(cantidad,m);

                nuevaOrden.AgregarDetalle(detalle);

                DgvOrdenDetalle.Rows.Add(new object[] { m.Nombre, m.Stock, cantidad, "Quitar" });
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(TxtResponsable.Text))
            {
                MessageBox.Show("Debe ingresar un responsable...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (CboMateriales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (NudCantidad.Value <= 0)
            {
                MessageBox.Show("Ingrese una Cantidad...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           
            return true;
        }

        private void DgvOrdenDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvOrdenDetalle.CurrentCell.ColumnIndex == 3) 
            {
                nuevaOrden.QuitarDetalle(DgvOrdenDetalle.CurrentRow.Index);
                DgvOrdenDetalle.Rows.RemoveAt(DgvOrdenDetalle.CurrentRow.Index);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {    
                this.Dispose();  
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() && DgvOrdenDetalle.Rows.Count >=0)
            {
                Grabar();
            }
        }

        private void Grabar()
        {
            nuevaOrden.Fecha = DtpFecha.Value;
            nuevaOrden.Responsable = TxtResponsable.Text;
            int nroOrden= servicio.CrearOrdenRetiro(nuevaOrden);
            if (nroOrden != 0)
            {
                MessageBox.Show("Se registró con éxito la Orden \nNro: " + nroOrden.ToString(), "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                nuevaOrden = new OrdenRetiro();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la Orden..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpiar()
        {
            TxtResponsable.Text = string.Empty;
            CboMateriales.SelectedIndex = -1;
            NudCantidad.Value = 0;
            DgvOrdenDetalle.Rows.Clear();
        }
    }
    
}
