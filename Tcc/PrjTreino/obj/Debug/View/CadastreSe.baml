   M S B A M L   `   `   `  ����D  @PrjTreino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PrjTreino	PrjTreino  5   	       PrjTreino.CadastreSe   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PrjTreino     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
CadastreSe��5	   	   $	��700��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p    � 	Resources 5
       �� DataType'   !PrjTreino.NotificationInformation � ColumnDefinitions'  !MaterialDesignThemes.Wpf.PackIcon   Kind)  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand�� 5   
   %  (��       5      *, +)�� 6   "  6   .R�5      �� $��20q�6   .+�5      �  5      �� 5      $
��Auto �6/   6>   �� 5      $
��Auto �6/   6>   .+�5        $ Exclamation=�62   $��48��5   2   $��48��5   2   $��20, 25, 20, 20q�5   2   $��0��5   2   �� 5      $��20q�6%   $��1��5   %   $	��150��5   %   .+�5      �� $��18(�6A   $��0,10,0,0q�5   (   ��5   (   �� *	Message+5   <   5      5      �� 5      $��OK��6   #��Z 5       6a   5!      5"      5#      .��5%      � -   5        $��	container��5%      .+�5&   
     -   5        $
��View��5&   $   	   
Identifier$	 DialogNormal��60   
   DialogContent
 5'      � 5(      $	��300��6   $	��150��6#   $��Center=�60   .+�5)      ��  �� Orientation$ 
Horizontal=�6!   $��15q�6:   .+�5*        $ Exclamation=�62      PrimaryHueMidBrush#��[  6E   $��50��6v   $��50��6�   �� 5+      
�������$	��200��66   $
��15 5q�6B   $
��Wrap=�6P   $5��/Por favor, não deixe nenhum espaço em branco!��6d   5,      5-      �� 5.      $ 
Horizontal=�6!   $��Right=�6:   $��Bottom=�6V   $��15q�6q   .+�5/      �� #��Z 6!     MaterialDesignFlatButton#���  6c   $��4q�6�   $��Center=�6�   .��6�   Ok51      52      53      .��56      � .+�57      �� $	��Top=�6   $	��170��65   .+�58      �� $+��%/PrjTreino;component/assets/Logo1.png��6   $	��200��6K   $��45q�6W   59      �� 5:      $��Bottom=�6   $	��480��68   .+�5;      �� $��50, 0, 0, 10q�6!   $	��200��67   $
��Left=�6C   .+�5<      �� $��	CADASTRAR��6$   $��20(�65   5=      �� 5>      $	��500��6!   $��0,0,0,0q�6-   .+�5?      �� $��0,20,0,0q�5@      
�������$��2q�5B       �� CornerRadius$ 25��5C      $��50��5D      $	��400��5E      ._�5F      �� $ 
Horizontal=�6)   .+�5G   "   �� -   5        $��
txtUsuario��5J   %   $��Center=�5H   %   $��0q�5I   %   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuário��5K   %    �� 
CaretBrush
 �   �
������  �� SelectionBrush
 �   �
������ $��18(�5P   %   $��Center=�5Q   %   $	��350��5R   %   $��10,0,0,0q�5S   %      
IsFloating .  5T   %     5V   "   $ Account=�6:   $��30��6I   ���#9a9a9a$��30��6i   $��Center=�6u   5W      5X      �� 5Z      
�������$��2q�5\      $ 25��5]      $��50��5^      $	��400��5_      $��0,20,0,0q�5`      ._�5a      �� $ 
Horizontal=�6)   .+�5b   "   �� $ 
Horizontal=�6-   .+�5c   &   G� -   5        $��txtSenha��5g   %   
������ $��Center=�5e   %   $��0q�5f   %   $ Senha��5h   %    G� 
CaretBrush
 �   � G� SelectionBrush
 �   �
������ $��18(�5l   %   $��Center=�5m   %   $	��350��5n   %   $��10,0,0,0q�5o   %    .  5p   %     5r   &   $
 Lock=�6>   ���#9a9a9a$��30��6_   $��30��6j   $��Center=�6v   5s   #   5t      5u      �� 5w      
�������$��2q�5y      $ 25��5z      $��50��5{      $	��400��5|      $��0,20,0,0q�5}      ._�5~      �� $ 
Horizontal=�6)   .+�5   "   �� $ 
Horizontal=�6-   .+�5�   &   G� -   5        $��txtConfSenha��5�   %   
������ $��Center=�5�   %   $��0q�5�   %   $ Confirmar senha��5�   %   
 �   �
 �   �
������ $��18(�5�   %   $��Center=�5�   %   $	��350��5�   %   $��10,0,0,0q�5�   %    .  5�   %     5�   &   $
 Lock=�6>   ���#9a9a9a$��30��6_   $��30��6j   $��Center=�6v   5�   #   5�      5�      �� 5�      $��	0,70,0,30q�5�      ���	#FF9C27B0���	#FF9C27B0$��1q�5�      $ 20��5�      $	��400��5�      $��40��5�      ._�5�      �� -   5        $��btnCadastrar��5�   %     MaterialDesignRaisedButton#��[ 69   
�������$��	CADASTRAR��6�   $	��400��6�   $��0q�6�   
������ 6�   5�      �� 5�      -   5        $��Center=�5�   $   ���	#FF9C27B0$��15(�6X    � Cursor$
 Hand��6f     6�   $ 	ExitToApp=�6�   6�   �� 6�   $�Voltar��6�   6�   6�   5�      5�      5�      5�      5�      5�      