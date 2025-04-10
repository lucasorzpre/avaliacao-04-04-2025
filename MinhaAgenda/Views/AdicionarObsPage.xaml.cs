using CasosDeUso.Interface;

namespace MinhaAgenda.Views;

public partial class AdicionarObsPage : ContentPage
{
    private readonly IAdicionarObservacaoUseCase _adicionarObservacaoUseCase;

    public AdicionarObsPage(IAdicionarObservacaoUseCase adicionarObservacaoUseCase)
	{
		InitializeComponent();
        _adicionarObservacaoUseCase = adicionarObservacaoUseCase;
	}

    private async void contatoCtrl_OnSave(object sender, EventArgs e)
    {
        await _adicionarObservacaoUseCase.AdicionarObs(new CoreBusiness.Entidades.Observacao(contatosCtrl.Observacao));
    }

    private void contatoCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Erro", e, "Ok");
    }
}