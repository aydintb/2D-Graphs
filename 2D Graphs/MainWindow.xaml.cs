using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2D_Graphs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddChart();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {


        }

        private void AddChart()
        {
            Polyline pl;
            // Draw sine curve:
            pl = new Polyline();
            pl.Stroke = Brushes.Black;
            for (int i = 0; i < 360; i++)
            {
                double x = 2.0 * Math.PI * ((double)i / 360.0);
                double y = Math.Sin(x);
                pl.Points.Add(CurvePoint(
                new Point(x, y)));
            }
            chartCanvas.Children.Add(pl);
            // Draw cosine curve:
            pl = new Polyline();
            pl.Stroke = Brushes.Black;
            pl.StrokeDashArray = new DoubleCollection(
            new double[] { 4, 3 });

            for (int i = 0; i < 360; i++)
            {
                double x = 2.0 * Math.PI * ((double)i / 360.0);
                double y = Math.Cos(x);
                pl.Points.Add(CurvePoint(
                new Point(x, y)));
            }
            chartCanvas.Children.Add(pl);
        }

        private Point CurvePoint(Point pt)
        {
            const double xmin = 0;
            const double xmax = 2.0 * Math.PI;
            //
            const double ymin = -1.1;
            const double ymax = 1.1;
            //
            Point result = new Point();
            result.X = pt.X  / xmax * chartCanvas.Width;
            result.Y = chartCanvas.Height - (pt.Y - ymin)  / (ymax - ymin) * chartCanvas.Height;
            return result;
        }

        //  double w = this.ActualWidth / 20;
        //double h = 5.0;

        //canvas1.Children.Clear();

        //for (int i = 1; i < 20; i++)
        //{

        //    Line newLine = new Line();
        //    newLine.Stroke = Brushes.Black;
        //    newLine.Fill = Brushes.Black;
        //    newLine.StrokeLineJoin = PenLineJoin.Bevel;
        //    newLine.X1 = points[i - 1].X * w;
        //    newLine.Y1 = points[i - 1].Y * h;
        //    newLine.X2 = points[i].X * w;
        //    newLine.Y2 = points[i].Y * h;
        //    newLine.StrokeThickness = 1;
        //    canvas1.Children.Add(newLine);

        //}



    }
}
