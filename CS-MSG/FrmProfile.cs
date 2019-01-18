using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CS_MSG {
    public partial class FrmProfile : Form {
        private string response_xml;

        public string Response_xml {
            get { return response_xml; }
            set { response_xml = value; }
        }

        public FrmProfile() {
            InitializeComponent();
        }

        private void gridProfile_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        /**
         * 加载response xml作为数据原显示
         */
        private void FrmProfile_Load(object sender, EventArgs e) {
            CS_MSG.Entity.Message msg = CS_MSG.util.XMLUtil.readDoc("../../Resources/Message.xml");
            fillGrid(msg);
        }

        //填充表格
        private void fillGrid(CS_MSG.Entity.Message response_data) {

            tlpResult.Controls.Add(new Label { Text = "Version:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            tlpResult.Controls.Add(new Label { Text = "Mode:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 1);
            tlpResult.Controls.Add(new Label { Text = "Success:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 2);

            tlpResult.Controls.Add(new Label { Text = response_data.Version, Anchor = AnchorStyles.Left, AutoSize = true }, 1, 0);
            tlpResult.Controls.Add(new Label { Text = response_data.Auth_mode, Anchor = AnchorStyles.Left, AutoSize = true }, 1, 1);
            tlpResult.Controls.Add(new Label { Text = response_data.Result.ToString(), Anchor = AnchorStyles.Left, AutoSize = true }, 1, 2);

            // Create an unbound DataGridView by declaring a column count.
            gridProfile.ReadOnly = true;
            gridProfile.ColumnCount = 4;
            gridProfile.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            gridProfile.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            gridProfile.Columns[0].Name = "NO";
            gridProfile.Columns[1].Name = "Name";
            gridProfile.Columns[2].Name = "Namespace";
            gridProfile.Columns[3].Name = "Value";

            gridProfile.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridProfile.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridProfile.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridProfile.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            int i = 0;
            foreach (CS_MSG.Entity.Attribute atr in response_data.Attrs) {
                string[] row = new string[] { Convert.ToString(++i), atr.Name, atr.Name_space, atr.Value };
                this.gridProfile.Rows.Add(row);
            }

        }

        private void btnClose_Click(object sender, EventArgs e) {
            System.Environment.Exit(0);
        }

        private void FrmProfile_Shown(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void FrmProfile_FormClosed(object sender, FormClosedEventArgs e) {
             System.Environment.Exit(0);
        }
    }
}
