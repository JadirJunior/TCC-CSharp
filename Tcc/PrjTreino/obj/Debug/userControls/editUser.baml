   M S B A M L   `   `   `  ����D  @PrjTreino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PrjTreino	PrjTreino  5      %    PrjTreino.userControls.editUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:PrjTreino     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������  � 	Resources  5       �� DataType'   !PrjTreino.NotificationInformation � ColumnDefinitions'  !MaterialDesignThemes.Wpf.PackIcon   Kind)  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand�� 5   
   %+  (��       5      *, +)�� 6   "  6   .R�5      �� $��20q�6   .+�5      �  5      �� 5      $
��Auto �6/   6>   �� 5      $
��Auto �6/   6>   .+�5        $��48��5   2   $��48��5   2   $��20, 25, 20, 20q�5   2   $��0��5   2    5   2   �� *Icon+5   2   �� 5      $��20q�6%   $��1��5   %   $	��150��5   %   .+�5      �� $��18(�6A   $��0,10,0,0q�5   (   ��5   (   �� *	Message+5   <   5      5      �� 5       $��OK��6   #��Z 5!      6a   5"      5#      5$      .��5'           
Identifier$ dialogUpdate��6       DialogContent 5(   
   � 5)      $	��300��6   $	��150��6   $��Center=�6,   .+�5*      ��  �� Orientation$ 
Horizontal=�6   $��15q�66   .+�5+        $ Exclamation=�6.      PrimaryHueMidBrush#��[  6A   $��50��6r   $��50��6}   �� 5,      
�������$	��200��62   $
��15 5q�6>   $
��Wrap=�6L   $5��/Por favor, não deixe nenhum espaço em branco!��6`   5-      5.      �� 5/      $ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R   $��15q�6m   .+�50      �� #��Z 6     MaterialDesignFlatButton#���  6_   $��4q�6�   $��Center=�6�   .��6�   Ok52      53      54      .��56   
   � $��2,0,-2,0q�6   .+�57   
   �� $	��Top=�6   .+�58      �� $��Editar Usuário��6   $��30(�6.   6>   59      �� 5:   
   $	��Top=�6   $��
10,131,0,0q�6-   $	��400��6A   $
��Left=�6M   .+�5;      �� .+�5<      �� 
�������$��2q�5>       �� CornerRadius$ 25��5?      $��50��5@      $	��400��5A      ._�5B      �� $ 
Horizontal=�6%   .+�5C      �� -   5        $��
txtUsuario��5F   %   $��Center=�5D   %   $��0q�5E   %   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Usuário��5G   %   
 �� 
CaretBrush

 �   �
������  �� SelectionBrush
 �   �
������ $��18(�5L   %   $��Center=�5M   %   $	��350��5N   %   $��10,0,0,0q�5O   %      
IsFloating .  5P   %     5R      $ Account=�66   $��30��6E   ���#9a9a9a$��30��6e   $��Center=�6q   5S      5T      �� 5U      
�������$��2q�5W      $ 25��5X      $��50��5Y      $	��400��5Z      $��0,20,0,0q�5[      ._�5\      �� $ 
Horizontal=�6%   .+�5]      �� $ 
Horizontal=�6)   .+�5^   "   G� -   5        $��txtSenha��5b   %   
������ $��Center=�5`   %   $��0q�5a   %   $	 Senha��5c   %    G� 
CaretBrush
 �   � G� SelectionBrush
 �   �
������ $��18(�5g   %   $��Center=�5h   %   $	��350��5i   %   $��10,0,0,0q�5j   %    .  5k   %     5m   "   $
 Lock=�6:   ���#9a9a9a$��30��6[   $��30��6f   $��Center=�6r   5n      5o      5p      5r      5t      �� 5u   
   $��Right=�6   $��Center=�61   $	��234��6L   $	��234��6X   $��
0,72,0,194q�6e   .+�5v      �� 
���   �$ 15��6)   ._�5w      �� -   5        $��	foto_func��5w      $	��200��6F   $	��200��6R   ��6)   �� *	ImagePath+6a   5x      �� 5y      $��Bottom=�5z      ���	#FF9C27B0���	#FF9C27B0$��1q�5}      $ 20��5~      ._�5      �� -   5        $��
openDialog��5   9   $��Center=�6   
������ $��0q�6d     MaterialDesignRaisedButton#��[ 6x   
�������$��Escolher imagem��6�   $��16(�6�   $��Medium"�6�   6  5�      5�      �� 5�      $��Bottom=�5�      $��	0,0,0,100q�5�      ���	#FF9C27B0���	#FF9C27B0$��1q�5�      $ 20��5�      $	��300��5�      $��40��5�      ._�5�      �� -   5        $��btnAtualizar��5�   B   $��Center=�6   $��28��65   
������ $��0q�6o   #��[ 6�   
�������$��Atualizar Usuário��6�   $��16(�6�   $��Medium"�6�   6'  5�      5�      5�      5�      