﻿namespace MonkeyFinder.ViewModel;

public class BaseViewModel : ObservableObject
{
    bool isBusy;
    string title;

    public bool IsBusy
    {
        get => isBusy;
        set
        {
            if (isBusy == value)
                return;

            isBusy = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsNotBusy));
        }
    }

    public string Title
    {
        get => title;
        set
        {
            if (title == value)
                return;

            title = value;
            OnPropertyChanged();
        }
    }

    public bool IsNotBusy => !isBusy;

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName]string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
