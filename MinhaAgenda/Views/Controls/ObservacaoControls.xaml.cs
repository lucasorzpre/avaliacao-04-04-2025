using CoreBusiness.Entidades;

namespace MinhaAgenda.Views.Controls;

public partial class ObservacaoControls : ContentView
{
    public event EventHandler<string> OnError;
	public event EventHandler<EventArgs> OnSave;

    public String Observacao { get { return entryObservacao.Text;} set { entryObservacao.Text = value; } }
	public ObservacaoControls()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
		if(observacaoValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Uma observação é obrigatória");
			return;
		}
		OnSave?.Invoke(sender, e);
    }


}