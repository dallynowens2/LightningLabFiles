using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LightningLabFiles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            localPath = Path.Combine(FileSystem.CacheDirectory, localFile);
        }

        string fileName = "";

        string localFile = "";

        string localPath;

        public async void Button_clicked(Object sender, EventArgs e)
        {
            
                Stream stream = null;
                using(var reader = new StreamReader(stream))
                {
                    LabelOutput.Text = await reader.ReadToEndAsync(); 
                }
           
        }

        public void SaveData(object sender, EventArgs e)
        {
            
        }
        public void LoadData(object sender, EventArgs e)
        {
            
        }

    }
}
