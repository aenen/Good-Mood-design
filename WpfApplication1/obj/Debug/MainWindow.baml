   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35=ed4http://schemas.microsoft.com/expression/2010/drawing  5   	   -   5          � Title$  	Good Mood��5	   	   $	��400��6   $	��650��6(   $	��400��64   $	��650��6D   .��5
      �  � ShowGridLines .   � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��0* �6   $	��100��6(    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   �� 5      $��2* �6   .+�5   
   �� $��3��6   $��3��6%   ��5      �� 5       �� ImageSource$ 	back4.png��6    j� TileMode$
 Tile=�65    j� Viewport$ 0,0,400,200�6E    j� ViewportUnits$ Absolute=�6\   5      �� 5   
   $��1��6   $��0��6!   $��3��6.   
�������6?   �� 5   
   $��3��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FF3A00FF��6#    � Offset$ 0Q�65   � 5      $
 	#BFA200FF��6#   $ 1Q�65   5       5"      �� 5#   
   $��3��6   $��2��6%   ���	#E5E1A04162   �� 5%   
   -   5         ��Name$ 
text_Title��5%      $��1��6(   $
��Wrap=�68   $��
Логин��6L   
������� �� TextAlignment$ Center=�6l   $��Center=�6�   $��20(�6�   $��Microsoft YaHei Light)�6�   A� 5&   
   -   5        $��
pic_Avatar��5&      $��2��6$   ���	#BFFFFFFF$��2��6G    J� Opacity$ 0Q�6[   $y�Hidden=�6g    � Cursor$
 Hand��6{   $��25��6�   $��25��6�   ��5'      �� 5(      $ 
avatar.png��6   5*      A� 5+   
   -   5        $��to_Back��5+      $ 0Q�6!   $��0��6-   ���	#BFFFFFFF$��2��6P   $y�Hidden=�6d   $
 Hand��6�   $��25��6�   $��25��6�   ��5,      �� 5-      $ to_Back.png��6   5/         WpfApplication1.UC_Login  51   
   -   5          Name$ uc_Login��51      $��1��6+   $y�Visible=�6;   $��1��6P   6_   ]� 52   
   -   5         ]�Name$ panel_Registration��52      $y�Hidden=�60   $ 0Q�6D   $��1��6P   $��1��6`   .+�53      *   $WpfApplication1.UC_RegistrationSteps  -   5          Name$ uc_RegistrationSteps��53   )   $��1��6G   $��1��6W   $	��Top=�6d   $��	10,15,0,0q�6y   6�   � 54      .+�55      %   WpfApplication1.UC_Registration  -   5          Name$ uc_Registration��55   $   $y�Visible=�6=   6T   ,   &WpfApplication1.UC_RegistrationConfirm  56      -	   5          Name$ uc_RegistrationConfirm��56   +   $��1��6K   $y�Hidden=�6[   $ 0Q�6o   $��1��6{   6�   57      58      !   WpfApplication1.UC_MainMenu  59   
   $��1��6   $��1��6,   $y�Hidden=�69   5:      5;      