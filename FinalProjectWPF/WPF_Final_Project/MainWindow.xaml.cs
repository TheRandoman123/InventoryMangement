using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using WPF_Final_Project.ViewModels;

namespace WPF_Final_Project
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

        public void ChangeAllSelections(string whatWasClicked)
        {
            Brush textBlockUnchangedColor = new SolidColorBrush(Color.FromRgb(22, 191, 131));
            Color textBlockChangedColor = Colors.White;
            Brush spaceUnchanged = new SolidColorBrush(Color.FromRgb(23, 42, 51));
            Brush spaceChanged = new SolidColorBrush(Color.FromRgb(22, 191, 191));

            switch (whatWasClicked)
            {
                case "inventory":
                    UserLabel.Foreground = textBlockUnchangedColor;
                    UserSpace.Fill = spaceUnchanged;

                    ReportLabel.Foreground = textBlockUnchangedColor;
                    ReportSpace.Fill = spaceUnchanged;

                    TagCreatorLabel.Foreground = textBlockUnchangedColor;
                    TagCreatorSpace.Fill = spaceUnchanged;

                    EmergencyRegisterLabel.Foreground = textBlockUnchangedColor;
                    EmergencyRegisterSpace.Fill = spaceUnchanged;

                    AuditLabel.Foreground = textBlockUnchangedColor;
                    AuditSpace.Fill = spaceUnchanged;
                    break;
                case "users":
                    InventoryLabel.Foreground = textBlockUnchangedColor;
                    InventorySpace.Fill = spaceUnchanged;

                    ReportLabel.Foreground = textBlockUnchangedColor;
                    ReportSpace.Fill = spaceUnchanged;

                    TagCreatorLabel.Foreground = textBlockUnchangedColor;
                    TagCreatorSpace.Fill = spaceUnchanged;

                    EmergencyRegisterLabel.Foreground = textBlockUnchangedColor;
                    EmergencyRegisterSpace.Fill = spaceUnchanged;

                    AuditLabel.Foreground = textBlockUnchangedColor;
                    AuditSpace.Fill = spaceUnchanged;
                    break;
                case "reports":
                    UserLabel.Foreground = textBlockUnchangedColor;
                    UserSpace.Fill = spaceUnchanged;

                    InventoryLabel.Foreground = textBlockUnchangedColor;
                    InventorySpace.Fill = spaceUnchanged;

                    TagCreatorLabel.Foreground = textBlockUnchangedColor;
                    TagCreatorSpace.Fill = spaceUnchanged;

                    EmergencyRegisterLabel.Foreground = textBlockUnchangedColor;
                    EmergencyRegisterSpace.Fill = spaceUnchanged;

                    AuditLabel.Foreground = textBlockUnchangedColor;
                    AuditSpace.Fill = spaceUnchanged;
                    break;
                case "tagcreator":
                    UserLabel.Foreground = textBlockUnchangedColor;
                    UserSpace.Fill = spaceUnchanged;

                    ReportLabel.Foreground = textBlockUnchangedColor;
                    ReportSpace.Fill = spaceUnchanged;

                    InventoryLabel.Foreground = textBlockUnchangedColor;
                    InventorySpace.Fill = spaceUnchanged;

                    EmergencyRegisterLabel.Foreground = textBlockUnchangedColor;
                    EmergencyRegisterSpace.Fill = spaceUnchanged;

                    AuditLabel.Foreground = textBlockUnchangedColor;
                    AuditSpace.Fill = spaceUnchanged;

                    break;
                case "emergencyregister":
                    UserLabel.Foreground = textBlockUnchangedColor;
                    UserSpace.Fill = spaceUnchanged;

                    ReportLabel.Foreground = textBlockUnchangedColor;
                    ReportSpace.Fill = spaceUnchanged;

                    TagCreatorLabel.Foreground = textBlockUnchangedColor;
                    TagCreatorSpace.Fill = spaceUnchanged;

                    InventoryLabel.Foreground = textBlockUnchangedColor;
                    InventorySpace.Fill = spaceUnchanged;

                    AuditLabel.Foreground = textBlockUnchangedColor;
                    AuditSpace.Fill = spaceUnchanged;

                    break;
                case "audits":
                    UserLabel.Foreground = textBlockUnchangedColor;
                    UserSpace.Fill = spaceUnchanged;

                    ReportLabel.Foreground = textBlockUnchangedColor;
                    ReportSpace.Fill = spaceUnchanged;

                    TagCreatorLabel.Foreground = textBlockUnchangedColor;
                    TagCreatorSpace.Fill = spaceUnchanged;

                    EmergencyRegisterLabel.Foreground = textBlockUnchangedColor;
                    EmergencyRegisterSpace.Fill = spaceUnchanged;

                    InventoryLabel.Foreground = textBlockUnchangedColor;
                    InventorySpace.Fill = spaceUnchanged;

                    break;
            }
        }

        private void InventorySpace_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            InventorySpace.Fill = new SolidColorBrush(Color.FromRgb(22, 191, 131));
            InventoryLabel.Foreground = new SolidColorBrush(Colors.White);

            DataContext = new InventoryViewModel();

            ChangeAllSelections("inventory");

        }
         
        private void UserSpace_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            UserLabel.Foreground = new SolidColorBrush(Colors.White);
            UserSpace.Fill = new SolidColorBrush(Color.FromRgb(22, 191, 131));

            DataContext = new UsersViewModel();

            ChangeAllSelections("users");

        }

        private void ReportSpace_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ReportLabel.Foreground = new SolidColorBrush(Colors.White);
            ReportSpace.Fill = new SolidColorBrush(Color.FromRgb(22, 191, 131));

            DataContext = new ReportsViewModel();

            ChangeAllSelections("reports");
        }

        private void TagCreatorSpace_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TagCreatorLabel.Foreground = new SolidColorBrush(Colors.White);
            TagCreatorSpace.Fill = new SolidColorBrush(Color.FromRgb(22, 191, 131));

            DataContext = new TagCreatorViewModel();

            ChangeAllSelections("tagcreator");
        }

        private void EmergencyRegisterSpace_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            EmergencyRegisterLabel.Foreground = new SolidColorBrush(Colors.White);
            EmergencyRegisterSpace.Fill = new SolidColorBrush(Color.FromRgb(22, 191, 131));

            DataContext = new EmergencyRegisterViewModel();

            ChangeAllSelections("emergencyregister");
        }

        private void AuditSpace_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            AuditLabel.Foreground = new SolidColorBrush(Colors.White);
            AuditSpace.Fill = new SolidColorBrush(Color.FromRgb(22, 191, 131));

            DataContext = new AuditsViewModel();

            ChangeAllSelections("audits");
        }

        private void InventorySpace_MouseEnter(object sender, MouseEventArgs e)
        {
            InventorySpace.StrokeThickness = 1;
            InventorySpace.Stroke = Brushes.Gray;
        }

        private void InventorySpace_MouseLeave(object sender, MouseEventArgs e)
        {
            InventorySpace.StrokeThickness = 0;
        }

        private void UserSpace_MouseEnter(object sender, MouseEventArgs e)
        {
            UserSpace.StrokeThickness = 1;
            UserSpace.Stroke = Brushes.Gray;
        }

        private void UserSpace_MouseLeave(object sender, MouseEventArgs e)
        {
            UserSpace.StrokeThickness = 0;
        }

        private void ReportSpace_MouseEnter(object sender, MouseEventArgs e)
        {
            ReportSpace.StrokeThickness = 1;
            ReportSpace.Stroke = Brushes.Gray;
        }

        private void ReportSpace_MouseLeave(object sender, MouseEventArgs e)
        {
            ReportSpace.StrokeThickness = 0;
        }

        private void EmergencyRegisterSpace_MouseEnter(object sender, MouseEventArgs e)
        {
            EmergencyRegisterSpace.StrokeThickness = 1;
            EmergencyRegisterSpace.Stroke = Brushes.Gray;
        }

        private void EmergencyRegisterSpace_MouseLeave(object sender, MouseEventArgs e)
        {
            EmergencyRegisterSpace.StrokeThickness = 0;
        }

        private void AuditSpace_MouseEnter(object sender, MouseEventArgs e)
        {
            AuditSpace.StrokeThickness = 1;
            AuditSpace.Stroke = Brushes.Gray;
        }

        private void AuditSpace_MouseLeave(object sender, MouseEventArgs e)
        {
            AuditSpace.StrokeThickness = 0;
        }

        private void TagCreatorSpace_MouseEnter(object sender, MouseEventArgs e)
        {
            TagCreatorSpace.StrokeThickness = 1;
            TagCreatorSpace.Stroke = Brushes.Gray;
        }

        private void TagCreatorSpace_MouseLeave(object sender, MouseEventArgs e)
        {
            TagCreatorSpace.StrokeThickness = 0;
        }


    
    }
}

