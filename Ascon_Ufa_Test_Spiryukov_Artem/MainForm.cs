using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    public partial class MainForm : Form
    {
        SaveFileDialog saveFileDialog;
        SqlWizard sqlWizard;
        Dictionary<int, Object> Objects;
        public MainForm()
        {
            InitializeComponent();
            sqlWizard = new SqlWizard();
            sqlWizard.Connect += FillForm;
            sqlWizard.Processing += BlockForm;
            sqlWizard.Disconnect += ClearForm;
            toolStripStatusLabel1.Text = "Не подключено";
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Value", "Значение");
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";
            BlockForm();
        }

        private void BlockForm()
        {
            treeView1.Enabled = false;
            dataGridView1.Enabled = false;
            button_DBadd.Enabled = false;
            button_DBdelete.Enabled = false;
            button_AddProperty.Enabled = false;
            button_DeleteProperty.Enabled = false;
            button_Xml.Enabled = false;
        }

        private void UnBlcokForm()
        {
            treeView1.Enabled = true;
            dataGridView1.Enabled = true;
            button_DBadd.Enabled = true;
            button_DBdelete.Enabled = true;
            button_AddProperty.Enabled = true;
            button_DeleteProperty.Enabled = true;
            button_Xml.Enabled = true;
        }

        private void ClearForm()
        {
            treeView1.Nodes.Clear();
            dataGridView1.Rows.Clear();
            BlockForm();
            toolStripStatusLabel1.Text = "Не подключено";

        }

        private async void FillForm()
        {
            Objects = new Dictionary<int, Object>();
            var reader = await sqlWizard.ExecuteOrder("SELECT * FROM Objects");
            if (reader != null && reader.HasRows) // если есть данные
            {
                while (await reader.ReadAsync()) // построчно считываем данные
                {

                    object id = reader.GetValue(0);
                    object type = reader.GetValue(2);
                    object product = reader.GetValue(1);
                    Objects.Add((int)id, new Object((int)id, (string)type, (string)product));

                }
            }
            reader = await sqlWizard.ExecuteOrder("SELECT * FROM Attributes");
            UnBlcokForm();
            if (reader.HasRows) // если есть данные
            {
                while (await reader.ReadAsync()) // построчно считываем данные
                {

                    object Objectid = reader.GetValue(0);
                    object Name = reader.GetValue(1);
                    object Value = reader.GetValue(2);
                    Objects[(int)Objectid].AddAttribute((string)Name, (string)Value);

                }
            }
            reader = await sqlWizard.ExecuteOrder("SELECT * FROM Links");
            if (reader.HasRows) // если есть данные
            {
                while (await reader.ReadAsync()) // построчно считываем данные
                {

                    object ParentId = reader.GetValue(0);
                    object ChildId = reader.GetValue(1);
                    Objects[(int)ChildId].SetParent(Objects[(int)ParentId]);

                }
            }
            List<TreeNode> RootNodes = new List<TreeNode>();
            foreach (Object obj in Objects.Values)
            {
                if (obj.Parent == null)
                {
                    RootNodes.Add(RecursBuildTree(obj));
                }
            }
            treeView1.Nodes.AddRange(RootNodes.ToArray());
            toolStripStatusLabel1.Text = "Подключено";
            UnBlcokForm();

            static TreeNode RecursBuildTree(Object obj)
            {
                TreeNode Node = new TreeNode(obj.Product);
                Node.Name = obj.Id.ToString();
                foreach (Object obj2 in obj.Childs)
                {
                    Node.Nodes.Add(RecursBuildTree(obj2));

                }
                return Node;
            }
        }

        private void button_Property_Click(object sender, EventArgs e)
        {
            splitContainer_Tree_Property.Panel2Collapsed = !splitContainer_Tree_Property.Panel2Collapsed;
            if (panel_TreeAndProperty.Size.Width - splitContainer_Tree_Property.SplitterDistance < 200)
                splitContainer_Tree_Property.SplitterDistance = panel_TreeAndProperty.Size.Width / 2;
        }

        private void splitContainer_Tree_Property_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (panel_TreeAndProperty.Size.Width - splitContainer_Tree_Property.SplitterDistance < 200)
                splitContainer_Tree_Property.Panel2Collapsed = true;
            else
                splitContainer_Tree_Property.Panel2Collapsed = false; ;
        }

        private void button_DBConnect_Click(object sender, EventArgs e)
        {
            DBConnectionForm dBConnectionForm = new DBConnectionForm(sqlWizard);

            dBConnectionForm.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (Attribute property in Objects[Int32.Parse(e.Node.Name)].Attributes)
            {
                dataGridView1.Rows.Add(property.Name, property.Value);
            }


        }

        private void listBox_PropertyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_PropertyValue.SelectedIndex = ((ListBox)sender).SelectedIndex;
        }

        private void listBox_PropertyValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_PropertyName.SelectedIndex = ((ListBox)sender).SelectedIndex;
        }

        private async void button_DBadd_Click(object sender, EventArgs e)
        {
            await sqlWizard.ExecuteOrder($"Insert into Objects (Type,Product) values ( 'Тип', 'Продукт')");
            if (treeView1.SelectedNode != null)
                await sqlWizard.ExecuteOrder($"Insert into Links (parentId,childId) values ({treeView1.SelectedNode.Name}, {Objects.Keys.Max() + 1})");
            ClearForm();
            FillForm();
        }

        private async void button_DBdelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Nodes != null)
                await RecurceDeleteNodes(treeView1.SelectedNode);
            //await sqlWizard.ChangeData($"Delete into Objects (Type,Product) values ( 'Тип', 'Продукт')");
            //if (treeView1.SelectedNode != null)
            //    await sqlWizard.ChangeData($"Insert into Links (parentId,childId) values ({treeView1.SelectedNode.Name}, {Objects.Keys.Max() + 1})");
            ClearForm();
            FillForm();
        }

        private async Task RecurceDeleteNodes(TreeNode Node)
        {
            await sqlWizard.ExecuteOrder($"Delete from Attributes where objectId = {Node.Name}");
            await sqlWizard.ExecuteOrder($"Delete from Links where parentId = {Node.Name}");
            await sqlWizard.ExecuteOrder($"Delete from Links where childId = {Node.Name}");
            await sqlWizard.ExecuteOrder($"Delete from Objects where id = {Node.Name}");
            foreach (TreeNode Child in Node.Nodes)
            {
                await RecurceDeleteNodes(Child);
            }
        }

        private async void button_AddProperty_Click(object sender, EventArgs e)
        {
            int newbee = 0;
            bool exist = false;
            do
            {
                exist = false;
                newbee++;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string name = (string)row.Cells[0].Value;
                    string value = (string)row.Cells[1].Value;
                    if (name == "Новое свойство" + newbee && value == "Новое значение" + newbee)
                        exist = true;
                }
            }
            while (exist);

            await sqlWizard.ExecuteOrder($"Insert into Attributes (objectId, name, value) values ( {treeView1.SelectedNode.Name}, 'Новое свойство{newbee}', 'Новое значение{newbee}')");
            ClearForm();
            FillForm();
        }

        private async void button_DeleteProperty_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                return;
            await sqlWizard.ExecuteOrder($"Delete from Attributes where objectId = {treeView1.SelectedNode.Name} and name = '{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()}' and value = '{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()}'");
            ClearForm();
            FillForm();
        }

        private async void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == "")
            {
                MessageBox.Show("Пустое имя недопустимо");
                ClearForm();
                FillForm();
                return;

            }
            await sqlWizard.ExecuteOrder($"UPDATE Objects SET type = '{e.Label}' WHERE id= {treeView1.SelectedNode.Name}");
            ClearForm();
            FillForm();
        }

        private async void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
                await sqlWizard.ExecuteOrder($"UPDATE Attributes SET name = '{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()}' WHERE objectId= {treeView1.SelectedNode.Name} and value = '{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()}'");
            else
                await sqlWizard.ExecuteOrder($"UPDATE Attributes SET value = '{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()}' WHERE objectId= {treeView1.SelectedNode.Name} and name = '{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()}'");
            ClearForm();
            FillForm();
        }

        private void button_Xml_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Object[]));
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, Objects.Values.ToArray());
                }
                Process.Start("explorer.exe", Path.GetDirectoryName(saveFileDialog.FileName));
            }
        }
    }
}
