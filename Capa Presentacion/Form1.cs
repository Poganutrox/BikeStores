using CapaEntidades;
using CapaNegocio;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms.VisualStyles;

namespace Capa_Presentacion
{

    ///<author> Miguel Ángel Moreno García</author>
    public partial class Form1 : Form
    {
        //Botones CRUD
        int orderID;
        int? costumerID;
        byte orderStatus;
        DateTime orderDate;
        DateTime requiredDate;
        DateTime? shippingDate;
        int storeId;
        int staffId;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ventas.ListarPedidos();
        }
        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            int orderID;

            if (int.TryParse(textBox1.Text, out orderID))
            {
                dataGridView1.DataSource = Ventas.DatosPedido(orderID);
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("Ha introducido un dato en un formato no válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListarEmpleado_Click(object sender, EventArgs e)
        {
            int employeeID;

            if (int.TryParse(textBox2.Text, out employeeID))
            {
                dataGridView1.DataSource = Ventas.ListarPedidosEmpleado(employeeID);
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("Ha introducido un dato en un formato no válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            int customerID;

            if (int.TryParse(textBox3.Text, out customerID))
            {
                dataGridView1.DataSource = Ventas.ListarPedidosCliente(customerID);
                dataGridView1.AllowUserToAddRows = false;
            }
            else
            {
                MessageBox.Show("Ha introducido un dato en un formato no válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            try
            {
                orderID = Convert.ToInt32(tbOderID.Text);
                orderStatus = Convert.ToByte(tbOrderStatus.Text);
                costumerID = tbCostumerID.Text == "" ? null : Convert.ToInt32(tbCostumerID.Text);
                orderDate = Convert.ToDateTime(tbOrderDate.Text);
                requiredDate = Convert.ToDateTime(tbRequieredDate.Text);
                shippingDate = tbShippingDate.Text == "" ? null : Convert.ToDateTime(tbShippingDate.Text);
                storeId = Convert.ToInt32(tbStoreID.Text);
                staffId = Convert.ToInt32(tbStaffID.Text);

                Order newOrder = new Order(orderID, costumerID, orderStatus, orderDate, requiredDate,
                    shippingDate, storeId, staffId, null, null, null, null);

                Ventas.InsertarOrder(newOrder);
                MessageBox.Show("¡Orden añadido con éxito!");
                dataGridView1.DataSource = Ventas.ListarPedidos();

            }
            catch (FormatException f)
            {
                MessageBox.Show("Ha introducido un dato en un formato no válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Valor demasiado grande", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbOderID.Text = "";
                tbCostumerID.Text = "";
                tbOrderStatus.Text = "";
                tbStoreID.Text = "";
                tbStaffID.Text = "";
                tbOrderDate.Text = "";
                tbShippingDate.Text = "";
                tbRequieredDate.Text = "";

            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                orderID = Convert.ToInt32(tbOderID.Text);
                orderStatus = Convert.ToByte(tbOrderStatus.Text);
                costumerID = tbCostumerID.Text == "" ? null : Convert.ToInt32(tbCostumerID.Text);
                orderDate = Convert.ToDateTime(tbOrderDate.Text);
                requiredDate = Convert.ToDateTime(tbRequieredDate.Text);
                shippingDate = tbShippingDate.Text == "" ? null : Convert.ToDateTime(tbShippingDate.Text);
                storeId = Convert.ToInt32(tbStoreID.Text);
                staffId = Convert.ToInt32(tbStaffID.Text);

                Order updatedOrder = new Order(orderID, costumerID, orderStatus, orderDate, requiredDate,
                    shippingDate, storeId, staffId, null, null, null, null);

                Ventas.ActualizarOrder(updatedOrder);
                MessageBox.Show("¡Orden actulizado con éxito!");
                dataGridView1.DataSource = Ventas.ListarPedidos();
            }
            catch (FormatException f)
            {
                MessageBox.Show("Ha introducido un dato en un formato no válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Valor demasiado grande", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbOderID.Text = "";
                tbCostumerID.Text = "";
                tbOrderStatus.Text = "";
                tbStoreID.Text = "";
                tbStaffID.Text = "";
                tbOrderDate.Text = "";
                tbShippingDate.Text = "";
                tbRequieredDate.Text = "";

            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                orderID = Convert.ToInt32(tbOderID.Text);
                orderStatus = Convert.ToByte(tbOrderStatus.Text);
                costumerID = tbCostumerID.Text == "" ? null : Convert.ToInt32(tbCostumerID.Text);
                orderDate = Convert.ToDateTime(tbOrderDate.Text);
                requiredDate = Convert.ToDateTime(tbRequieredDate.Text);
                shippingDate = tbShippingDate.Text == "" ? null : Convert.ToDateTime(tbShippingDate.Text);
                storeId = Convert.ToInt32(tbStoreID.Text);
                staffId = Convert.ToInt32(tbStaffID.Text);

                Order deletedOrder = new Order(orderID, costumerID, orderStatus, orderDate, requiredDate,
                    shippingDate, storeId, staffId, null, null, null, null);

                Ventas.BorrarOrder(deletedOrder);
                MessageBox.Show("¡Orden borrado con éxito!");
                dataGridView1.DataSource = Ventas.ListarPedidos();
            }
            catch (FormatException f)
            {
                MessageBox.Show("Ha introducido un dato en un formato no válido", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Valor demasiado grande", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbOderID.Text = "";
                tbCostumerID.Text = "";
                tbOrderStatus.Text = "";
                tbStoreID.Text = "";
                tbStaffID.Text = "";
                tbOrderDate.Text = "";
                tbShippingDate.Text = "";
                tbRequieredDate.Text = "";

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOderID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            tbCostumerID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value == null
                                    ? "" : dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            tbOrderStatus.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            tbOrderDate.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            tbRequieredDate.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            tbShippingDate.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value == null
                                    ? "" : dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            tbStoreID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            tbStaffID.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
        }
    }
}