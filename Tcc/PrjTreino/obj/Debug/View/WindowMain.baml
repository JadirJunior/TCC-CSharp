   M S B A M L   `   `   `  ����D  @PrjTreino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PrjTreino	PrjTreino  5   	       PrjTreino.WindowMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PrjTreino     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $
��page��5	        � Title$  
CadastreSe��6	   $	��600��6A   $	��800��6N    � WindowStartupLocation$ CenterScreen=�6Z    � 
ResizeMode$ NoResize=�6    � WindowStyle$
 None=�6�    � WindowState$ 	Maximized=�6�   .��5
      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost     MaterialDesignDivider#���   6$   .��5      � -   5        $��	container��5   3   .+�5      �� $	��106��6   $
��Left=�6)   
�������.+�5      � $	��100��6   $��12,0,0,0q�6(   
�������.+�5      �� $��/assets/Logo2.png��6    6=   5      �� 5      $��	10,50,0,0q�6!   $��Center=�64   .+�5      �� -   5          MaterialDesignFlatButton#��[ 5   !   $��0,0,0,40q�6S   .��5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ViewDashboard=�6:   $��25��6O   $��30��6Z   $��Center=�6f   ���#a8a8a86�   5      5      �� 5      -   5        #��[ 5   !   $��0,0,0,40q�6S   .��5      �� $ 
Horizontal=�6)   .+�5   "     $ Calendar=�6:   $��25��6J   $��30��6U   $��Center=�6a   ���#a8a8a86|   5      5      �� 5      -   5        $��btnChat��5   !   #��[ 6F   $��0,0,0,0q�6x   .��5      �� $ 
Horizontal=�6)   .+�5    "     $
 Chat=�6:   $��25��6F   $��30��6Q   $��Center=�6]   ���#a8a8a86x   5!      5"      5#      5%      �� 5&      $��3��6   $
��1000��6&   $	��Top=�65   ���#a8a8a8$
��Left=�6\   $��	110,0,0,0q�6w   6�   �� 5(      -   5        $��containerPrincipal��5(   *   $
��1253��6   $��Right=�6D   .+�5)      �� $	��100��6\   $	��Top=�6i   $ 
Horizontal=�6�   ��6   ��  �� ElementName$ containerPrincipal�� �� Path$ Width�.+�5*      �� $
��Left=�6%   $��	 40,0,0,0q�6@   $��Center=�6T   .+�5+      �� -   5        	 ��Name$	 	btnLogout��5,       + 'MaterialDesignFloatingActionLightButton#��[ 5.      $��Right=�5/      
������ 
������ $��0q�52      $��Center=�53      $��40��54      $��40��55      .��57        $ Logout=�66   
 � ToolTip$
 Logout��6D   ���#a8a8a8$��30��6j   $��30��6u   6�   58      59      �� 5:      $ 
Horizontal=�6!   $��	850,0,0,0q�6:   $��70��6M   $��Right=�6Y   .+�5;      �� -   5        $	 btnUser��5;   !   #��[ 6H   $��Right=�6�   
�������$��Center=�6�   $��60��6�   $��60��6�   .��5<      �� -	   5         ��Name$ imageButton��5<   %   6<   5=      �� 5>      -
   5        $��	nome_func��5>   �   $	��120��6$   $��20,0,0,0q�60   $��15(�6m   $��Center=�6{   ��6B   �� $ Usuario� �� Mode$ TwoWay=�6�   5?      5@      �� 5A      $��3��6   $	��Top=�6d   ���#a8a8a8$��Stretch=�6�   ��6'   �� $ containerPrincipal��$ Width�6�   5B      � 5D      -   5         �Name$ stackPanelPrincipal��5D      $	��500��64   $��Stretch=�6B   
�������$	��800��6s   5E      5F      5G      5H      5I      