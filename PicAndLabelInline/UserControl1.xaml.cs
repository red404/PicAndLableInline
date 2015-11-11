using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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

namespace PicAndLabelInline
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private bool status;
        private string name;
        private string address;
        private Size imgS;

        public bool objectStatus
        {
            // Возвращает статус объекта.
            get
            {
                return status;
            }
            // Устанавливает статус объекта
            // и обновляет графический индикатор
            set
            {
                status = value;
                switchStatusImage(status);
            }
        }

        // функция переключения индикатора
        public void switchStatusImage(bool st)
        {
                if (st) 
                {
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("on.jpg", UriKind.Relative);
                    bi3.EndInit();
                    statusImage.Stretch = Stretch.Uniform;
                    statusImage.StretchDirection = StretchDirection.Both;
                    statusImage.Source = bi3;
                }
                else 
                {
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("off.jpg", UriKind.Relative);
                    bi3.EndInit();
                    statusImage.Stretch = Stretch.Uniform;
                    statusImage.StretchDirection = StretchDirection.Both;
                    statusImage.Source = bi3;
                }

        }


        public string objectName
        {
            // Возвращает статус объекта.
            get
            {
                return name;
            }
            // Устанавливает статус объекта
            // и обновляет графический индикатор
            set
            {
                name = value;
                objLabel.Content = name;
            }
        }

        public string objectAddress
        {
            // Возвращает статус объекта.
            get
            {
                return address;
            }
            // Устанавливает статус объекта
            // и обновляет графический индикатор
            set
            {
                address = value;
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(string n = "new", string a = "192.168.0.1")
        {
            InitializeComponent();
            status = false;
            name = n;
            objectName = n;
            address = a;
            objectAddress = a;
            //this.Foreground = Color;
            //this.Background = Colors;
            //this.SetBounds(0, 0, 200, 48);
        }
    }
}
