namespace Counter;

internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private int _count = 0;

    [ObservableProperty]
    private int _step = 1;

    [RelayCommand]
    private void Increment()
        => Count += Step;

    [RelayCommand]
    private async Task NavigateToDetails()
    {
        await _navigator.NavigateViewModelAsync<DetailViewModel>(this, data: Count);
    }
}