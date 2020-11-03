using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//meus using
using MinesWeeper.Common.Models;
using Windows.UI.ViewManagement;
//using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.WindowManagement.Preview;//PreferredMinSize


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MinesWeeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private App Program;
        //private int gridSize;
        public MainPage()
        {
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
            //ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1280, 720));
            //ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            Program = App.Current as App;
            this.InitializeComponent();
            Button_facil.Visibility = Visibility.Collapsed;
            Button_medio.Visibility = Visibility.Collapsed;
            TextBox_blocked();
        }

        public int buttonCounter = 1;
        public int columnCount = 1;
        public int rowCount = 1;

        private void Buttonfacil_Click(object sender, RoutedEventArgs e)
        {
            //jogo.Tamanho = 9;
            Button_facil.Visibility = Visibility.Collapsed;
            Button_medio.Visibility = Visibility.Collapsed;
            //gridSize = 9;
            clearGrid(gameGrid);
            gameGrid.Width = 1000;
            gameGrid.Height = 700;
            createGamesGrid(Program.M_Jogo.TamanhoPequeno);
        }

        private void Buttonmedio_Click(object sender, RoutedEventArgs e)
        {
            //jogo.Tamanho = 16;
            Button_facil.Visibility = Visibility.Collapsed;
            Button_medio.Visibility = Visibility.Collapsed;
            //gridSize = 16;
            clearGrid(gameGrid);
            gameGrid.Width = 1450;
            gameGrid.Height = 700;
            createGamesGrid(Program.M_Jogo.TamanhoMedio);
        }

        private void FaceButton_Click(object sender, RoutedEventArgs e)
        {
            clearGrid(gameGrid);
            Button_facil.Visibility = Visibility.Visible;
            Button_medio.Visibility = Visibility.Visible;
        }

        private void clearGrid(Grid gameGrid)
        {
            gameGrid.Children.Clear();
            gameGrid.RowDefinitions.Clear();
            gameGrid.ColumnDefinitions.Clear();
        }

        private void createGamesGrid(int gridSize)
        {
            int cols;
            for (cols = 0; cols < gridSize; cols++)
            {
                gameGrid.RowDefinitions.Add(new RowDefinition());
                gameGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            createButtons(gridSize);
        }

        private void createButtons(int gridSize)
        {
            int rows, cols;
            int cont = 0;
            for (rows = 0; rows < gridSize; rows++)
            {
                for (cols = 0; cols < gridSize; cols++)
                {
                    Button button = new Button();

                    //button.Background = global::MinesWeeper.UWP.

                    button.Name = cont.ToString();
                    button.Content = cont.ToString();
                    button.Width = (gameGrid.Width / gridSize) - 4;              //Width and height of rectangle 1501*842            
                    button.Height = (gameGrid.Height / gridSize) - 4;
                    button.HorizontalAlignment = HorizontalAlignment.Center;  //Centre it in the cell
                    button.VerticalAlignment = VerticalAlignment.Center;
                    button.SetValue(Grid.RowProperty, rows);                  //Set its cell positon
                    button.SetValue(Grid.ColumnProperty, cols);
                    button.Click += Button_Click;
                    button.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(200, 0 , 100, 150));
                    gameGrid.Children.Add(button);
                    cont++;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string name = "Botão clicado";
            btn.Content = name;
        }

        private void Buttonsair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }
        private void TextBox_blocked()
        {
            Temporizador.IsEnabled = false;
            Pontos.IsEnabled = false;
            Minas.IsEnabled = false;
        }
    }
}
