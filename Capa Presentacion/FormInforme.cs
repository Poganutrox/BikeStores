using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting.NETCore;

namespace Capa_Presentacion
{
    public partial class FormInforme : Form
    {
        private readonly ReportViewer reportViewer;
        public DataGridViewRow orderSeleccionado;
        public FormInforme(DataGridViewRow orderSeleccionado)
        {
            InitializeComponent();
            Text = "Factura";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            this.orderSeleccionado = orderSeleccionado;
            //ReportItemSchemas();
        }
        protected override void OnLoad(EventArgs e)
        {
            Factura.Load(reportViewer.LocalReport, orderSeleccionado);
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }
        private void ReportItemSchemas()
        {
            var types = new[] {typeof(Factura), typeof(ElementosFactura)};
            var xri = new System.Xml.Serialization.XmlReflectionImporter();
            var xss = new System.Xml.Serialization.XmlSchemas();
            var xse = new System.Xml.Serialization.XmlSchemaExporter(xss);
            foreach(var type in types )
            {
                var xtm = xri.ImportTypeMapping(type);
                xse.ExportTypeMapping(xtm);
            }
            using var sw = new System.IO.StreamWriter("ReportItemSchemas.xsd", false, Encoding.UTF8);
            for(int i = 0; i < xss.Count; i++)
            {
                var xs = xss[i];
                xs.Id = "ResportItemSchemas";
                xs.Write(sw);
            }
        }

       
    }
}
