using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Titles;

public partial class Test : Window
{
    public Test()
    {
        InitializeComponent();
        DataContext = this;
    }

    public int Current { get; set; } = 1;
    public int Total { get; set; } = 3;
}