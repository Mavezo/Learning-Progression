   M S B A M L   `   `   `  ����C  ?WpfApp16, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp16WpfApp16  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       WpfApp16.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp16     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��681��6)    � 	Resources 5         WpfApp16.BoolToItem   
BoolToItem��%   &	          5   
   60   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��5* �6   6,   .+�5   
   �� $��10,15q�6   $��15(�6#   
FontWeight6=   �� 5!   
   -   5         ��Name$ 
fontWeight��5!       �� SelectedIndex$ 9��6`   $��1��6r   $��10,10q�6�   $��16(�6�   $��5q�6�   ��6'   ��  �� ElementName$ 
fontWeight�� �� Path$
 Text�.@�5"      �� ��6   ��  �� Self	 �� RelativeSource#	 Z $ Content�.��6n   Black6u   �� 5#      ��6   �� #	 Z $ Content�.��6n   Bold6t   �� 5$      ��6   �� #	 Z $ Content�.��6n   
DemiBold6x   �� 5%      ��6   �� #	 Z $ Content�.��6n   
ExtraBlack6z   �� 5&      ��6   �� #	 Z $ Content�.��6n   	ExtraBold6y   �� 5'      ��6   �� #	 Z $ Content�.��6n   
ExtraLight6z   �� 5(      ��6   �� #	 Z $ Content�.��6n   Light6u   �� 5)      ��6   �� #	 Z $ Content�.��6n   Heavy6u   �� 5*      ��6   �� #	 Z $ Content�.��6n   Medium6v   �� 5+      ��6   �� #	 Z $ Content�.��6n   Normal6v   �� 5,      ��6   �� #	 Z $ Content�.��6n   	Regular6w   �� 5-      ��6   �� #	 Z $ Content�.��6n   
SemiBold6x   �� 5.      ��6   �� #	 Z $ Content�.��6n   Thin6t   �� 5/      ��6   �� #	 Z $ Content�.��6n   
UltraBlack6z   �� 50      ��6   �� #	 Z $ Content�.��6n   	UltraBold6y   �� 51      ��6   �� #	 Z $ Content�.��6n   	Regular6w   54      �� 56   
   $��1��6   $��10,15q�6!   $��15(�60   	FontStyle6I   �� 58   
   -   5        
 ��Name$
 italic��58      $��1��6#   $��1��60   $��14q�6@    � LayoutTransform 59      �� 5:       �� ScaleX$	 1.5Q�6!    �� ScaleY$	 1.5Q�6.   .��5;   (   Italic5=      �� 5?   
   $��2��6   $��10,15q�6!   $��15(�60   
Foreground6J   �� 5A   
   -   5        $ color��5A      $ 0��6"   $��2��6k   $��1��6x   $��10,10q�6�   $��16(�6�   $��5q�6�   ��64   �� $ color��$
 Text�.@�5B      �� 
����  �
����  �.��6@   Blue6F   �� 5C      
��� � �
��� � �.��6B   Green6I   �� 5D      
��� ���
��� ���.��6L   Orange6T   �� 5E      
���  ��
���  ��.��6>   Red6C   �� 5F      
������
���� ��.��6H   Violet6P   �� 5G      
������
����+��.��6H   
BlueViolet6T   �� 5H      
������
������.��6M   MediumVioletRed6^   �� 5I      
������
����p��.��6K   PaleVioletRed6Z   �� 5J      
������
������.��6D   Violet6L   �� 5K      
������
�������.��6C   Ivory6J   5L      �� 5N   
   $��3��6   $��10,15q�6!   $��15(�60   
FontSize6H   �� 5P   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��1��6;   .+�5Q      �� -   5         ��Name$ textbox��5Q      $��10q�6�   $��25��6�   $��30��6�   $��15(�6�    �� TextAlignment$ Center=�6�   ��6'   �� $ slider1��$ Value� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5R      -   5         ��Name$ slider1��5R       � Minimum$ 0Q�6&    � Maximum$	 100Q�62    �� SelectionStart$ 0Q�6@    � Value$ 0Q�6S    �� TickPlacement$ BottomRight=�6]    �� TickFrequency$ 5Q�6y   $	��495��6�   $��14q�6�   6�   5S      �� 5U   
   $��4��6  $��0��6   $��2��60  ��6   �� $ italic��$ 	IsChecked� �� 	Converter# [  ��6r   �� $ textbox��$
 Text���6�   �� $ color��$
 Text���6�   �� $ 
fontWeight��$
 Text�6F  5X      5Y      