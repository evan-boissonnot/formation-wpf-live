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

namespace TravailWpfAvecEntities
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Initialize();
        }

        private void Initialize()
        {
            using (HarryPotter.Core.Data.HarryPotterEntities context = new HarryPotter.Core.Data.HarryPotterEntities())
            {
                var query = from wiwi in context.Witch
                            select wiwi;

                var maList = query.ToList();

                this.lstWitches.ItemsSource = maList;
            }
        }
    }
}
