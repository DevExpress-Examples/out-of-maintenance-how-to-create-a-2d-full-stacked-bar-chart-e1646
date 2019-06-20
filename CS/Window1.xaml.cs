using System.Collections.ObjectModel;
using System.Windows;
namespace FullStackedBar2DChart {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        public ObservableCollection<SaleSeries> SaleSeries { get; private set; }
        public ChartViewModel() {
            SaleSeries = new ObservableCollection<SaleSeries> {
                new SaleSeries {
                    Category = "Video players",
                    Values = new  ObservableCollection<SaleInfo> {
                        new SaleInfo { Region = "Asia",          Value = 853D},
                        new SaleInfo { Region = "Australia",     Value = 321D},
                        new SaleInfo { Region = "Europe",        Value = 655D},
                        new SaleInfo { Region = "North America", Value = 1325D},
                        new SaleInfo { Region = "South America", Value = 653D}
                    }
                },
                new SaleSeries {
                    Category = "Automation",
                    Values = new  ObservableCollection<SaleInfo> {
                        new SaleInfo { Region = "Asia",          Value = 172D},
                        new SaleInfo { Region = "Australia",     Value = 255D},
                        new SaleInfo { Region = "Europe",        Value = 981D},
                        new SaleInfo { Region = "North America", Value = 963D},
                        new SaleInfo { Region = "South America", Value = 123D},
                    }
                },
                new SaleSeries {
                    Category = "Monitors",
                    Values = new  ObservableCollection<SaleInfo> {
                        new SaleInfo { Region = "Asia",          Value = 1011D},
                        new SaleInfo { Region = "Australia",     Value = 359D},
                        new SaleInfo { Region = "Europe",        Value = 721D},
                        new SaleInfo { Region = "North America", Value = 565D},
                        new SaleInfo { Region = "South America", Value = 532D},
                    }
                },
                new SaleSeries {
                    Category = "Projectors",
                    Values = new  ObservableCollection<SaleInfo> {
                        new SaleInfo { Region = "Asia",          Value = 998D},
                        new SaleInfo { Region = "Australia",     Value = 222D},
                        new SaleInfo { Region = "Europe",        Value = 865D},
                        new SaleInfo { Region = "North America", Value = 787D},
                        new SaleInfo { Region = "South America", Value = 332D},
                    }
                },
                new SaleSeries {
                    Category = "Televisions",
                    Values = new  ObservableCollection<SaleInfo> {
                        new SaleInfo { Region = "Asia",          Value = 1356D},
                        new SaleInfo { Region = "Australia",     Value = 232D},
                        new SaleInfo { Region = "Europe",        Value = 1323D},
                        new SaleInfo { Region = "North America", Value = 1125D},
                        new SaleInfo { Region = "South America", Value = 865D}
                    }
                },
            };
        }
    }
    public class SaleSeries {
        public string Category { get; set; }
        public ObservableCollection<SaleInfo> Values { get; set; }
    }
    public class SaleInfo {
        public string Region { get; set; }
        public double Value { get; set; }
    }
}
