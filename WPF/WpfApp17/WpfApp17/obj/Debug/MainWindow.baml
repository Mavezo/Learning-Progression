   M S B A M L   `   `   `  ����C  ?WpfApp17, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp17WpfApp17  5   	       WpfApp17.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp17     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       '�� H     �� 5
   
   " ��6   .�5      ��  � ��$ 14(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      6!    � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ 	MainImage��5       � DataContext 6%   �� *SelectedImage+��6K   �� *
Filepath+	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5   
   $��1��6    6%   �� *SelectedImage+.+�5      �� 	FilePath:6#   �� 5      ��6   �� *
Filepath+64   �� 5      	FileName:6#   �� 5       ��6   �� *
Filename+64   �� 5!      Size:6   �� 5"      ��6   �� *Size+60   5#      �� 5%   
   $��1��6   ��6   �� 
 �� Path$
 Images� �� SelectedItem 6C   �� *SelectedImage+��5&      �� 5'      .R�5(      �  5)      �� 5*      61   �� 5+      61   .+�5-      �� $��50��6B   $��50��6M   ��6    �� $
 Filepath�6[   �� 5.      ��6$   �� $
 Filename�6E   50      52      55      �� 57   
   $��1��6   $��1��6"   .+�58      �� ��6   �� *
AddImage+.��64   Add69   �� 59      .��6   Delete6   5:      5>      5?      