using System;
using System.Diagnostics;
using System.Windows;

namespace James
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String[] message = new String[10] { "Google it.", "Skill issue!", "Magic 8 ball says try again.", "Try rebooting it.", "Layer 8 issue.", "No", "Yes", "Maybe", "Dude, drink some coffee and think about it.", "Hahahaha" };
            Random random = new Random();
            int num1 = random.Next(0, (message.Length - 1));

            Window1 window1 = new Window1();
            window1.tipBox.Content = message[num1];
            window1.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string target = "https://www.google.com/search?q=" + textBox1.Text;
            Process.Start(new ProcessStartInfo() { FileName = target, UseShellExecute = true });
        }
    }
}
