using BusinessLayer;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen01POO
{
    public partial class MainAutomovil : Form
    {
        AutomovilBL autoIns = new AutomovilBL();

        ColorBL ColorIns = new ColorBL();
        MarcaBL MarcaIns = new MarcaBL();
        TipoVehiculoBL TipoVehiculoIns = new TipoVehiculoBL();

        List<tbAutomovil> lista;
        private bool isCreated;
        public MainAutomovil()
        {
            InitializeComponent();
        }

        private void MainAutomovil_Load(object sender, EventArgs e)
        {
            obtenerDatos(); 
        }
        private void obtenerDatos()
        {

            try
            {
                //cuando el forms cargue tengo el metodo de obtener todos los clientes
                lista = autoIns.obtenerTodos();
                cargarLista(lista);
                CargarComboBox();
            }
            catch (Exception)
            {

                MessageBox.Show("Se genero un error al cargar una lista de clientes");
            }
        }
        private void cargarLista(List<tbAutomovil> lista)
        {//muestro los clientes en la lista clientes

            //A la hora  de cargar la  lista debemos de limpiar la lista para
            //caerle encima, asi evitamos que se muestren datos repetidos en la lista
            lstvAutomovil.Items.Clear();

            foreach (var auto in lista)
            {
                ListViewItem item = new ListViewItem();

                item.Text = auto.placa.ToString();
                item.SubItems.Add(auto.vin);
                item.SubItems.Add(auto.marca.ToString());
                item.SubItems.Add(auto.tipo.ToString());
                item.SubItems.Add(auto.color.ToString());

                lstvAutomovil.Items.Add(item);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    tbAutomovil automovil = new tbAutomovil();
                    automovil.placa = Int32.Parse(txtPlaca.Text);
                    if (autoIns.obtenerPorID(automovil) == null)
                    {
                        automovil.placa = Int32.Parse(txtPlaca.Text);
                        automovil.vin = txtVin.Text;

                        tbMarca marca = new tbMarca();
                        marca.id = (int)cbMarca.SelectedValue;
                        marca = MarcaIns.obtenerPorID(marca);
                        automovil.marca = marca.id;

                        tbTipoVehiculo tipoMarca = new tbTipoVehiculo();
                        tipoMarca.id = (int)cbTipo.SelectedValue;
                        tipoMarca = TipoVehiculoIns.obtenerPorID(tipoMarca);
                        automovil.tipo = tipoMarca.id;

                        tbColor color = new tbColor();
                        color.id = (int)cbColor.SelectedValue;
                        color = ColorIns.obtenerPorID(color);
                        automovil.color = color.id;

                        automovil.estado = true;

                        autoIns.guardar(automovil);

                        MessageBox.Show("El Automovil se creo correctamente");
                        obtenerDatos();
                    }
                    else
                    {
                        MessageBox.Show("El Automovil Existe");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el Automovil");

            }
            
        }

        private bool validar()
        {
            if (txtPlaca==null)
            {
                MessageBox.Show("Falta el numero de placa");
                return false;
            }
            else if (txtVin == null)
            {
                MessageBox.Show("Falta el numero de vin");
                return false;
            }
            return true;
        }
        private void CargarComboBox()
        {
            var lista= TipoVehiculoIns.obtenerTodos();
            cbTipo.DataSource = lista;
            cbTipo.DisplayMember = "tipo";
            cbTipo.ValueMember = "id";

            var lista2 = MarcaIns.obtenerTodos();
            cbMarca.DataSource = lista2;
            cbMarca.DisplayMember = "marca";
            cbMarca.ValueMember = "id";

            var lista3 = ColorIns.obtenerTodos();
            cbColor.DataSource = lista3;
            cbColor.DisplayMember = "color";
            cbColor.ValueMember = "id";
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    tbAutomovil automovil = new tbAutomovil();

                    automovil.placa = Int32.Parse(txtPlaca.Text);
                    if (autoIns.obtenerPorID(automovil) == null)
                    {
                        MessageBox.Show("El Automovil no existe");
                    }
                    else
                    {
                        automovil.vin = txtVin.Text;

                        tbMarca marca = new tbMarca();
                        marca.id = (int)cbMarca.SelectedValue;
                        marca = MarcaIns.obtenerPorID(marca);
                        automovil.marca = marca.id;

                        tbTipoVehiculo tipoMarca = new tbTipoVehiculo();
                        tipoMarca.id = (int)cbTipo.SelectedValue;
                        tipoMarca = TipoVehiculoIns.obtenerPorID(tipoMarca);
                        automovil.tipo = tipoMarca.id;

                        tbColor color = new tbColor();
                        color.id = (int)cbColor.SelectedValue;
                        color = ColorIns.obtenerPorID(color);
                        automovil.color = color.id;

                        automovil.estado = true;

                        autoIns.modificar(automovil);

                        MessageBox.Show("El Automovil se modifico correctamente");
                        obtenerDatos();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar el Automovil");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tbAutomovil automovil = new tbAutomovil();

                automovil.placa = Int32.Parse(txtPlaca.Text);
                if (autoIns.obtenerPorID(automovil) == null)
                {
                    MessageBox.Show("El Automovil no existe");
                }
                else
                {
                    automovil = autoIns.obtenerPorID(automovil);
                    automovil.estado = false;

                    autoIns.modificar(automovil);

                    MessageBox.Show("El Automovil se Elimino correctamente");
                    obtenerDatos();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar el Automovil");
            }
            
        }

        private void lstvAutomovil_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var placa = ((ListView)sender).SelectedItems[0].Text;
            var automovil = lista.Where(x => x.placa == Int32.Parse(placa)).SingleOrDefault();

            txtPlaca.Text = automovil.placa.ToString();
            txtVin.Text = automovil.vin.ToString();
            cbColor.SelectedIndex = automovil.color - 1;
            cbMarca.SelectedIndex = automovil.marca - 1;
            cbTipo.SelectedIndex = automovil.tipo - 1;
        }
    }
}
