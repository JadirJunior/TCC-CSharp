   M S B A M L   `   `   `  ����D  @PrjTreino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PrjTreino	PrjTreino  5          PrjTreino.Mural   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:PrjTreino     5      
�������.��5	      � .+�5
   
   �� $	��500��6   $��Bottom=�6"   $��Right=�6=   
�������$	��800��6l   .+�5      �� $
��Left=�6   $��	30,10,0,0q�65   .+�5      �� $��Mural��6   $��30(�6)   69   5      �� 5        �� Orientation$  Vertical=�6   $
��Left=�61   $��	40,20,0,0q�6L   .+�5      �� $  
Horizontal=�6   .+�5      �� -   5        $��	Postagens��5   !    � Cursor$
 Hand��6f   $��	Postagens��6t   $��0,0,30,0q�6�   $��15(�6�    � Triggers 5      :� 5       :� RoutedEvent$ TextBlock.MouseDown��6+   .[�5   "   �� .��5   &   �� -   5         ��Name$ Animacao��5   1   .��5   *   W�  �� 
TargetName$ MyRectangle��6:    �� TargetProperty$ X�5      	 W� To$ 0X�5       g� Duration$ 0:0:0.2D�5      5   '   5   #   5      5      �� 5      -   5        $��notas��5       $
 Hand��6]   $��Notas��6k   $��15(�6x   $��0,0,30,0q�6�    5       :� 5!      $ TextBlock.MouseDown��6+   .[�5"   "   �� .��5#   &   �� -   5        $ Outra��5#   1   .��5$   *   W� $ MyRectangle��6:   $ X�5%      $ 86X�5&      $ 0:0:0.2D�5'      5)   '   5*   #   5+      5-      �� 5.      -   5        $
 Hand��5.   T   $��	Reuniões��6b   $��15(�6r    5/      :� 50      $ TextBlock.MouseDown��6+   .[�51   "   �� .��52   &   �� -   5        $ Outro��52   1   .��53   *   W� $ MyRectangle��6:   $ X�54      $	 166X�55      $ 0:0:0.2D�56      58   '   59   #   5:      5<      5=      �� 5>      .+�5?      �� 
����p��$��3��64   $��63��6?   $
��Left=�6J   z�5@      T� 5A      -   5        MyRectangle��	 T� X$	 0Q�5B   *   
 T� Y$
 0Q�60   5D      5E      5F      �� 5G      $  
Horizontal=�6   $��Bottom=�62   $	��400��6M   $��0,30,0,0q�6Z   .+�5H      � $��	100,0,0,0q�6   $	��700��6*   $	��400��66   .+�5I      �� $��Hidden=�6#   .��5J      � .+�5K      �� -   5        $��PrincipalContent��5K   )   5M      5N      5O      5Q      5R      5S      5T      5U      