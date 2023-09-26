using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MarketPlace.ViewModel;

public class ItemViewModel : INotifyPropertyChanged
{
    public bool IsBusy { get; set; }
    public string Title { get; set; }
    
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}