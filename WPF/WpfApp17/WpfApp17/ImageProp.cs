using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp17
{
    public class ImageProp : ObservableObject
    {
        private string filepath;
        private string filename;
        private string size;

        public string Filepath { get => filepath;
            set
            {
                if(filepath != value)
                {
                    filepath = value;
                    OnPropertyChanged(filepath);
                }

            }
        }
        public string Filename { get => filename;
            set
            {
                if (filename != value)
                {
                    filename = value;
                    OnPropertyChanged(filename);
                }

            }
        }
        public string Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    OnPropertyChanged(size);
                }

            }
        }
    }
}
