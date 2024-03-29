
namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_buttons = new Panel();
            button_Xml = new Button();
            button_DBConnect = new Button();
            button_DBdelete = new Button();
            button_DBadd = new Button();
            button_Property = new Button();
            panel_TreeAndProperty = new Panel();
            splitContainer_Tree_Property = new SplitContainer();
            treeView1 = new TreeView();
            panel1 = new Panel();
            panel_PropertySplit = new Panel();
            dataGridView1 = new DataGridView();
            panel_PropertyHeader = new Panel();
            label1 = new Label();
            button_AddProperty = new Button();
            button_DeleteProperty = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            panel_buttons.SuspendLayout();
            panel_TreeAndProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Tree_Property).BeginInit();
            splitContainer_Tree_Property.Panel1.SuspendLayout();
            splitContainer_Tree_Property.Panel2.SuspendLayout();
            splitContainer_Tree_Property.SuspendLayout();
            panel1.SuspendLayout();
            panel_PropertySplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_PropertyHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_buttons
            // 
            panel_buttons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_buttons.Controls.Add(button_Xml);
            panel_buttons.Controls.Add(button_DBConnect);
            panel_buttons.Controls.Add(button_DBdelete);
            panel_buttons.Controls.Add(button_DBadd);
            panel_buttons.Controls.Add(button_Property);
            panel_buttons.Location = new Point(12, 12);
            panel_buttons.Name = "panel_buttons";
            panel_buttons.Size = new Size(528, 43);
            panel_buttons.TabIndex = 0;
            // 
            // button_Xml
            // 
            button_Xml.Location = new Point(345, 3);
            button_Xml.Name = "button_Xml";
            button_Xml.Size = new Size(94, 37);
            button_Xml.TabIndex = 3;
            button_Xml.Text = "Xml";
            button_Xml.UseVisualStyleBackColor = true;
            button_Xml.Click += button_Xml_Click;
            // 
            // button_DBConnect
            // 
            button_DBConnect.Location = new Point(203, 3);
            button_DBConnect.Name = "button_DBConnect";
            button_DBConnect.Size = new Size(136, 37);
            button_DBConnect.TabIndex = 2;
            button_DBConnect.Text = "Подключение";
            button_DBConnect.UseVisualStyleBackColor = true;
            button_DBConnect.Click += button_DBConnect_Click;
            // 
            // button_DBdelete
            // 
            button_DBdelete.Location = new Point(103, 3);
            button_DBdelete.Name = "button_DBdelete";
            button_DBdelete.Size = new Size(94, 37);
            button_DBdelete.TabIndex = 1;
            button_DBdelete.Text = "Удалить";
            button_DBdelete.UseVisualStyleBackColor = true;
            button_DBdelete.Click += button_DBdelete_Click;
            // 
            // button_DBadd
            // 
            button_DBadd.Location = new Point(3, 3);
            button_DBadd.Name = "button_DBadd";
            button_DBadd.Size = new Size(94, 37);
            button_DBadd.TabIndex = 1;
            button_DBadd.Text = "Добавить ";
            button_DBadd.UseVisualStyleBackColor = true;
            button_DBadd.Click += button_DBadd_Click;
            // 
            // button_Property
            // 
            button_Property.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Property.Location = new Point(443, 2);
            button_Property.Name = "button_Property";
            button_Property.Size = new Size(82, 38);
            button_Property.TabIndex = 0;
            button_Property.Text = "Свойства";
            button_Property.UseVisualStyleBackColor = true;
            button_Property.Click += button_Property_Click;
            // 
            // panel_TreeAndProperty
            // 
            panel_TreeAndProperty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_TreeAndProperty.Controls.Add(splitContainer_Tree_Property);
            panel_TreeAndProperty.Location = new Point(15, 61);
            panel_TreeAndProperty.Name = "panel_TreeAndProperty";
            panel_TreeAndProperty.Size = new Size(525, 364);
            panel_TreeAndProperty.TabIndex = 1;
            // 
            // splitContainer_Tree_Property
            // 
            splitContainer_Tree_Property.Dock = DockStyle.Fill;
            splitContainer_Tree_Property.Location = new Point(0, 0);
            splitContainer_Tree_Property.Name = "splitContainer_Tree_Property";
            // 
            // splitContainer_Tree_Property.Panel1
            // 
            splitContainer_Tree_Property.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer_Tree_Property.Panel2
            // 
            splitContainer_Tree_Property.Panel2.Controls.Add(panel1);
            splitContainer_Tree_Property.Size = new Size(525, 364);
            splitContainer_Tree_Property.SplitterDistance = 171;
            splitContainer_Tree_Property.TabIndex = 0;
            splitContainer_Tree_Property.SplitterMoved += splitContainer_Tree_Property_SplitterMoved;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.LabelEdit = true;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(171, 364);
            treeView1.TabIndex = 0;
            treeView1.AfterLabelEdit += treeView1_AfterLabelEdit;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel_PropertySplit);
            panel1.Controls.Add(panel_PropertyHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 364);
            panel1.TabIndex = 0;
            // 
            // panel_PropertySplit
            // 
            panel_PropertySplit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_PropertySplit.Controls.Add(dataGridView1);
            panel_PropertySplit.Location = new Point(6, 45);
            panel_PropertySplit.Name = "panel_PropertySplit";
            panel_PropertySplit.Size = new Size(338, 315);
            panel_PropertySplit.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(338, 315);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // panel_PropertyHeader
            // 
            panel_PropertyHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_PropertyHeader.Controls.Add(label1);
            panel_PropertyHeader.Controls.Add(button_AddProperty);
            panel_PropertyHeader.Controls.Add(button_DeleteProperty);
            panel_PropertyHeader.Location = new Point(3, 3);
            panel_PropertyHeader.Name = "panel_PropertyHeader";
            panel_PropertyHeader.Size = new Size(344, 36);
            panel_PropertyHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Свойства";
            // 
            // button_AddProperty
            // 
            button_AddProperty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_AddProperty.Location = new Point(275, 3);
            button_AddProperty.Name = "button_AddProperty";
            button_AddProperty.Size = new Size(30, 29);
            button_AddProperty.TabIndex = 0;
            button_AddProperty.Text = "+";
            button_AddProperty.UseVisualStyleBackColor = true;
            button_AddProperty.Click += button_AddProperty_Click;
            // 
            // button_DeleteProperty
            // 
            button_DeleteProperty.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_DeleteProperty.Location = new Point(311, 3);
            button_DeleteProperty.Name = "button_DeleteProperty";
            button_DeleteProperty.Size = new Size(30, 29);
            button_DeleteProperty.TabIndex = 0;
            button_DeleteProperty.Text = "-";
            button_DeleteProperty.UseVisualStyleBackColor = true;
            button_DeleteProperty.Click += button_DeleteProperty_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(552, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(statusStrip1);
            Controls.Add(panel_TreeAndProperty);
            Controls.Add(panel_buttons);
            MinimumSize = new Size(570, 497);
            Name = "MainForm";
            Text = "Ascon";
            panel_buttons.ResumeLayout(false);
            panel_TreeAndProperty.ResumeLayout(false);
            splitContainer_Tree_Property.Panel1.ResumeLayout(false);
            splitContainer_Tree_Property.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Tree_Property).EndInit();
            splitContainer_Tree_Property.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel_PropertySplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_PropertyHeader.ResumeLayout(false);
            panel_PropertyHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_buttons;
        private Button button_DBadd;
        private Button button_Property;
        private Button button_DBdelete;
        private Panel panel_TreeAndProperty;
        private SplitContainer splitContainer_Tree_Property;
        private TreeView treeView1;
        private Button button_DBConnect;
        private Panel panel1;
        private Button button_DeleteProperty;
        private Button button_AddProperty;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Panel panel_PropertySplit;
        private Panel panel_PropertyHeader;
        private SplitContainer splitContainer_Properties;
        private ListBox listBox_PropertyName;
        private ListBox listBox_PropertyValue;
        private DataGridView dataGridView1;
        private Button button_Xml;
    }
}
