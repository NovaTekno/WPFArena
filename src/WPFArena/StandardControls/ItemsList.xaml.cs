using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFArena.StandardControls;

public partial class ItemsList : Window
{
    public ItemsList()
    {
        InitializeComponent();
    }

    void OnLangChanged(object s, SelectionChangedEventArgs e)
    {
        _keywordList.Items.Clear();
        string[] keywords = null;

        switch (_langCombo.SelectedIndex)
        {
            case 0:
                keywords = new string[] { "for", "auto", "mutable", "explicit", "class", "volatile" };
                break;
            
            case 1:
                keywords = new string[] { "while", "var", "implicit", "return", "where", "enum" };
                break;
            
            case 2:
                keywords = new string[] { "Dim", "Select", "While", "Property", "Function", "If" };
                break;
            
            case 3:
                keywords = new string[] { "let", "rec", "mutable", "module", "yield", "type"};
                break;
        }

        if (keywords != null)
            Array.ForEach(keywords, keyword => _keywordList.Items.Add(keyword));
    }
}