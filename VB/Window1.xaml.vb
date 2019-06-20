Imports System.Collections.ObjectModel
Imports System.Windows
Namespace FullStackedBar2DChart
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
		Private privateSaleSeries As ObservableCollection(Of SaleSeries)
		Public Property SaleSeries() As ObservableCollection(Of SaleSeries)
			Get
				Return privateSaleSeries
			End Get
			Private Set(ByVal value As ObservableCollection(Of SaleSeries))
				privateSaleSeries = value
			End Set
		End Property
		Public Sub New()
			SaleSeries = New ObservableCollection(Of SaleSeries) _
				From {
					New SaleSeries With {
						.Category = "Video players",
						.Values = New ObservableCollection(Of SaleInfo) From {
							New SaleInfo With {
								.Region = "Asia",
								.Value = 853R
							},
							New SaleInfo With {
								.Region = "Australia",
								.Value = 321R
							},
							New SaleInfo With {
								.Region = "Europe",
								.Value = 655R
							},
							New SaleInfo With {
								.Region = "North America",
								.Value = 1325R
							},
							New SaleInfo With {
								.Region = "South America",
								.Value = 653R
							}
						}
					},
					New SaleSeries With {
						.Category = "Automation",
						.Values = New ObservableCollection(Of SaleInfo) From {
							New SaleInfo With {
								.Region = "Asia",
								.Value = 172R
							},
							New SaleInfo With {
								.Region = "Australia",
								.Value = 255R
							},
							New SaleInfo With {
								.Region = "Europe",
								.Value = 981R
							},
							New SaleInfo With {
								.Region = "North America",
								.Value = 963R
							},
							New SaleInfo With {
								.Region = "South America",
								.Value = 123R
							}
						}
					},
					New SaleSeries With {
						.Category = "Monitors",
						.Values = New ObservableCollection(Of SaleInfo) From {
							New SaleInfo With {
								.Region = "Asia",
								.Value = 1011R
							},
							New SaleInfo With {
								.Region = "Australia",
								.Value = 359R
							},
							New SaleInfo With {
								.Region = "Europe",
								.Value = 721R
							},
							New SaleInfo With {
								.Region = "North America",
								.Value = 565R
							},
							New SaleInfo With {
								.Region = "South America",
								.Value = 532R
							}
						}
					},
					New SaleSeries With {
						.Category = "Projectors",
						.Values = New ObservableCollection(Of SaleInfo) From {
							New SaleInfo With {
								.Region = "Asia",
								.Value = 998R
							},
							New SaleInfo With {
								.Region = "Australia",
								.Value = 222R
							},
							New SaleInfo With {
								.Region = "Europe",
								.Value = 865R
							},
							New SaleInfo With {
								.Region = "North America",
								.Value = 787R
							},
							New SaleInfo With {
								.Region = "South America",
								.Value = 332R
							}
						}
					},
					New SaleSeries With {
						.Category = "Televisions",
						.Values = New ObservableCollection(Of SaleInfo) From {
							New SaleInfo With {
								.Region = "Asia",
								.Value = 1356R
							},
							New SaleInfo With {
								.Region = "Australia",
								.Value = 232R
							},
							New SaleInfo With {
								.Region = "Europe",
								.Value = 1323R
							},
							New SaleInfo With {
								.Region = "North America",
								.Value = 1125R
							},
							New SaleInfo With {
								.Region = "South America",
								.Value = 865R
							}
						}
					}
				}
		End Sub
	End Class
	Public Class SaleSeries
		Public Property Category() As String
		Public Property Values() As ObservableCollection(Of SaleInfo)
	End Class
	Public Class SaleInfo
		Public Property Region() As String
		Public Property Value() As Double
	End Class
End Namespace
