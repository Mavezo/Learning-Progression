   M S B A M L   `   `   `  ����C  ?WpfApp14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp14WpfApp14  5   	       WpfApp14.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp14     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   �� -   5         ��Name$ textbox1��5      $
��24px(�6$   ��64   ��  �� ElementName$ textbox2�� �� Path$
 Text� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ textbox2��5      $
��24px(�6$   66   �� 5   
   -   5         ��Name$ slider1��5       � Minimum$ 0Q�6"   	 � Maximum$		 100Q�6.   
 � Value
 6<   �� $ slider2��$ TwoWay=�$ Value�$ PropertyChanged=�6�   �� 5   
   -   5        $ slider2��5      $ 0Q�6"   $		 100Q�6.   6>   5      5      