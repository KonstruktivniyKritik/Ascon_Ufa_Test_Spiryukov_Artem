namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    public partial class MainForm : Form
    {
        SqlWizard sqlWizard;
        public MainForm()
        {
            InitializeComponent();
            sqlWizard = new SqlWizard();
        }

        private void button_Property_Click(object sender, EventArgs e)
        {
            splitContainer_Tree_Property.Panel2Collapsed = !splitContainer_Tree_Property.Panel2Collapsed;
            if (panel_TreeAndProperty.Size.Width - splitContainer_Tree_Property.SplitterDistance < 200)
                splitContainer_Tree_Property.SplitterDistance = 200;
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
    }
}
