   M S B A M L   `   `   `  ����C  ?WpfApp18, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp18WpfApp18  5   	       WpfApp18.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp18     5   	   V RXamlAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=20a987d8023d9690<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��400��6)    � 	Resources 5
         x_brush j� TileMode j� Viewport L� Drawing
 � Pen >� Brush >� 	Thickness � Geometry	 �� 
StartPoint
 �� EndPoint  o_brush @� Center @� RadiusX @� RadiusY��%�  &	        &	 }    L� 5   
   $ FlipXY=�6'   $ 0,0,1,1�69    5      I� 5      .��5      �  5      >� 5      
 �   �$ 20Q�6,    5      �� 5      $		 0,0&�6'   $
 100,100&�68   6M   5      � 5       5      >� 5      
 �   �$ 20Q�60    5      �� 5      $	 0,100&�6+   $
 100,0&�6>   6Q   5      5!      5#      L� 5$   
   $ FlipXY=�6'   $ 0,0,1,1�69    5%      I� 5&      .��5'      �  5(      >� 5)      
 �   �$ 20Q�60    5+      @� 5,      $ 50,50&�6.   $ 50Q�6=   $ 50Q�6J   6Y   5.      5/      51      52      .��54      � -   5         �Name$ MainGrid��54        � ShowGridLines .  � ColumnDefinitions 55   
   �� 56      6!   �� 57      6!   �� 58      6!    � RowDefinitions 5:   
   �� 5;      6   �� 5<      6   �� 5=      6   .+�5?   
   �� -   5         ��Name$ two_zero��5?      6T   �� 5@   
   -   5        $ two_one��5@      $��1��6%   6c   �� 5A   
   -   5        $ two_two��5A      $��2��6%   6c   �� 5B   
   -   5        $ one_zero��5B      $��1��6&   $��0��63   6q   �� 5C   
   -   5        $ one_one��5C      $��1��6%   $��1��62   6q   �� 5D   
   -   5        $ one_two��5D      $��1��6%   $��2��62   6p   �� 5E   
   -   5        $ 	zero_zero��5E      $��2��6'   $��0��64   6r   �� 5F   
   -	   5        $ zero_one��5F      $��2��6&   $��1��63   6q   �� 5G   
   -
   5        $ zero_two��5G      $��2��6&   $��2��63   6q   5I      5K      