using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SingleObjectBinding;

public class Person : ObservableObject
{
    public string Name { get; set; }
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            SetProperty(ref _age, value);
            OnPropertyChanged("Age");
        }
    }

    protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propName = null)
    {
        if (!EqualityComparer<T>.Default.Equals(field, value))
        {
            field = value;
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs(propName));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}