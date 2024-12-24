namespace infragistics_tooltip_repro;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    public void button1_Click(object sender, EventArgs e)
    {
        using var form = new FormToolTip();
        form.ShowDialog(this);
    }

    public void button2_Click(object sender, EventArgs e)
    {
        using var form = new FormComboEditor();
        form.ShowDialog(this);
    }
}
