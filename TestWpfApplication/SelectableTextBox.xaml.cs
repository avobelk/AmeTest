using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWpfApplication
{
  /// <summary>
  /// Interaction logic for SelectableTextBox.xaml
  /// </summary>
  public partial class SelectableTextBox : TextBox
  {
    public SelectableTextBox()
    {
      InitializeComponent();
    }

    public string ReadonlySelectionText
    {
      get
      {
        return (string)GetValue(ReadonlySelectionTextProperty);
      }
      set
      {
        var oldValue = ReadonlySelectionTextProperty;
        SetValue(ReadonlySelectionTextProperty, value);
      }
    }

    public static readonly DependencyProperty ReadonlySelectionTextProperty =
      DependencyProperty.Register(nameof(ReadonlySelectionText),
        typeof(string),
        typeof(SelectableTextBox),
        new FrameworkPropertyMetadata(string.Empty));
    
    protected override void OnSelectionChanged(RoutedEventArgs e)
    {
      ReadonlySelectionText = SelectedText;
      base.OnSelectionChanged(e);
    }
  }
}
