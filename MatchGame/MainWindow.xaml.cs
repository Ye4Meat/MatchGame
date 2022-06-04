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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()                                   // Создает список эмодзи
            {
                "🐵", "🐵",
                "🐶", "🐶",
                "🐺", "🐺",
                "🐯", "🐯",
                "🦝", "🦝",
                "🐷", "🐷",
                "🐰", "🐰",
                "🐴", "🐴",
            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())          // Для каждого TextBlock в сетке выполняет:
            {
                int index = random.Next(animalEmoji.Count);                                 // Назначает имя index случайному числу в диапазоне
                string nextEmoji = animalEmoji[index];                                      // Использует index для получения случайного эмодзи
                textBlock.Text = nextEmoji;                                                 // Обновляет TextBlock случайными эмодзи из списка
                animalEmoji.RemoveAt(index);                                                // Удаляет случайный эмодзи из списка
            }
        }
    }
}
