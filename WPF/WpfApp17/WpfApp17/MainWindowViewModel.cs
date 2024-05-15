using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WpfApp17;

namespace WpfApp17
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            Images = new ObservableCollection<ImageProp>();
        }

        private ImageProp selectedImage;



     
        private RelayCommand addImage;

        

        public ObservableCollection<ImageProp> Images { get; set; }
        public ImageProp SelectedImage
        {
            get => selectedImage;
            set
            {
                if (selectedImage != value)
                {
                    selectedImage = value;
                    OnPropertyChanged(nameof(SelectedImage));

                }
            }


        }
        public RelayCommand AddImage
        {
            get
            {
                return addImage ?? (addImage = new RelayCommand(
                    (obj) =>
                    {
                        OpenFileDialog ofd = new OpenFileDialog();
                        if (ofd.ShowDialog() == true)
                        {
                            ImageProp imageProp = new ImageProp();
                            FileInfo fileinfo = new FileInfo(ofd.FileName);
                            imageProp.Filepath = fileinfo.FullName;
                            imageProp.Filename = fileinfo.Name;
                            imageProp.Size = (fileinfo.Length / 1024).ToString() + "KB";
                            SelectedImage = imageProp;
                            Images.Add(imageProp);
                        }
                    }
                    ));
            }
        }

    }
}
