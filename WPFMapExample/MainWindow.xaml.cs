using GMap.NET;
using GMap.NET.MapProviders;
using System.Windows;
using System.Windows.Input;

namespace WPFMapExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Map_OnLoaded(object sender, RoutedEventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            // Выбор провайдера
            Map.MapProvider = OpenStreetMapProvider.Instance;
            // Регулировка значения минимального и максимального зума
            Map.MinZoom = 2;
            Map.MaxZoom = 20;
            // Стартовый зум
            Map.Zoom = 2;
            // Позволить использовать колесо мыши для изменения зума 
            Map.MouseWheelZoomType = MouseWheelZoomType.ViewCenter;
            // Определяет возможность перетаскивания карты
            Map.CanDragMap = true;
            // Какой кнопкой можно перетаскивать карту
            Map.DragButton = MouseButton.Left;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Map.SetPositionByKeywords(StreetTextBox.Text);
        }
    }
}
