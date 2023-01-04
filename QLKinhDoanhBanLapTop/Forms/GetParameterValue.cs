namespace QLKinhDoanhBanLapTop.Forms
{
    public partial class GetParameterValue : Form
    {
        public string ParameterValue { get; set; }
        public GetParameterValue(string title)
        {
            InitializeComponent();
            label1.Text = title;
            ParameterValue = string.Empty;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            ParameterValue = textBox1.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
