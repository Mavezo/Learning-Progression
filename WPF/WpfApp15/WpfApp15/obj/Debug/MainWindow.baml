   M S B A M L   `   `   `  ����C  ?WpfApp15, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp15WpfApp15  5   	       WpfApp15.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp15     5   	   -   5          �Name$  window��5	   
    � Title$ 
MainWindow��5   	   $	��450��6   $	��300��6)   .��5
      � .+�5   
   �� ��5      �� 5      $��Внешний GroupBox��6   $��15(�64   6D   .��5      �  � RowDefinitions 5      �� 5      6&   �� 5      6&   .+�5      �� $��0��6   ��5      �� 5      $$��Внутренний GroupBox1��6$   $��13(�6@   6P   .��5      ��  �� Orientation$ Vertical=�6!   .+�5      �� -   5         ��Name$
 text��5   $   $ ��Ширина текста:��62   6J   �� 5      
��� �����66   ��  �� RelativeSource ��  �� Mode$
 Self=� �� Path$ ActualWidth� �� Mode$ OneWay=�6�   �� 5      $��Ширина окна:��6$   6:   �� 5      -   5        	 ��Name$
	 okno��5   "   
��� �����6D   ��  �� $ FindAncestor=�
 �� AncestorType"
 �$ Width�6�   5      5       5!      5%      5&      5'      