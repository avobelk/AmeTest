using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TestWpfApplication
{
  public class CustomProperty : INotifyPropertyChanged
  {
    private string nameSelected;
    private string valueSelected;

    public string Name { get; set; } = new Random().Next().ToString();

    public string NameSelected
    {
      get => nameSelected;
      set
      {
        nameSelected = value;
      }
    }

    public string Value { get; set; } = new Random().Next().ToString();

    public string ValueSelected
    {
      get => valueSelected;
      set
      {
        valueSelected = value;
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;
  }

  public class CustomControlViewModel
  {
    private ObservableCollection<CustomProperty> customProperties = new ObservableCollection<CustomProperty>(
      new[]{
        new CustomProperty(),
        new CustomProperty(),
        new CustomProperty(),
      });

    public ObservableCollection<CustomProperty> CustomProperties
    {
      get => customProperties;
      set => customProperties = value;
    }

    private Timer timer;

    public CustomControlViewModel()
    {
      timer = new Timer(state =>
      {
        Application.Current.Dispatcher.Invoke(UpdateData);
      }, null, 0, 1000);
    }

    private void UpdateData()
    {
      //  To stop
      int i = 3;

      //CustomProperties.Clear();
      //foreach (var customProperty in Enumerable.Range(0, new Random().Next(10))
      //  .Select(x => new CustomProperty()))
      //{
      //  CustomProperties.Add(customProperty);
      //}
    }
  }
}
