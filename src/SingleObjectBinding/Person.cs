using System;
using System.ComponentModel;

namespace SingleObjectBinding;

public class Person : INotifyPropertyChanged
{
    public string Name { get; set; }
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            _age = value;
            var pc = PropertyChanged;
            if (pc != null)
                pc(this, new PropertyChangedEventArgs("Age"));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}