   M S B A M L   `   `   `  ����D  @PrjTreino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PrjTreino	PrjTreino  5   	       PrjTreino.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PrjTreino     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
Montserrat)�5	   	     � Title$  
MainWindow��5
   	   $	��700��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p    � 	Resources 5       �� DataType'   !PrjTreino.NotificationInformation � ColumnDefinitions'  !MaterialDesignThemes.Wpf.PackIcon   Kind)  #MaterialDesignThemes.Wpf.DialogHost   CloseDialogCommand�� 5   
   %+  (��       5      *, +)�� 6   "  6   .R�5      �� $��20q�6   .+�5      �  5      �� 5      $
��Auto �6/   6>   �� 5      $
��Auto �6/   6>   .+�5        $��48��5   2   $��48��5   2   $��20, 25, 20, 20q�5   2   $��0��5   2    5   2   �� *Icon+5   2   �� 5      $��20q�6%   $��1��5   %   $	��150��5   %   .+�5      �� $��18(�6A   $��0,10,0,0q�5   (   ��5   (   �� *	Message+5   <   5      5      �� 5       $��OK��6   #��Z 5!      6a   5"      5#      5$      .��5&      � -   5        $��	container��5&      .+�5'   
     -   5        $
��View��5'   $   	   
Identifier$	 
RootDialog��60   
   DialogContent
 5(      � 5)      $	��300��6   $	��150��6#   $��Center=�60   .+�5*      ��  �� Orientation$ 
Horizontal=�6!   $��15q�6:   .+�5+        $ Exclamation=�62      PrimaryHueMidBrush#��[  6E   $��50��6v   $��50��6�   �� 5,      
�������$	��200��66   $
��15 5q�6B   $
��Wrap=�6P   1/Por favor, não deixe nenhum espaço em branco!5.      5/      �� 50      $ 
Horizontal=�6!   $��Right=�6:   $��Bottom=�6V   $��15q�6q   .+�51      �� #��Z 6!     MaterialDesignFlatButton#���  6c   $��4q�6�   $��Center=�6�   .��6�   Ok53      54      55      .��57      � .+�58      �� $	��Top=�6   $	��200��61   .+�59      �� $+��%/PrjTreino;component/assets/Logo1.png��6   $	��200��6C   $��45q�6O   5:      �� 5;   
   $��Bottom=�6   $	��500��60   .+�5<      �� $��60,20,60,20q�6   .+�5=      �� $��ACESSAR��6   $��20(�6+   6;   5>      �� 5?      $	��500��6!   $��0,10,0,0q�6-   .+�5@      �� 
�������$��2q�5B       �� CornerRadius$ 25��5C      $��50��5D      $	��400��5E      ._�5F      �� $ 
Horizontal=�6)   .+�5G   "   �� -   5        $��
txtUsuario��5J   %   $��Center=�5H   %   $��0q�5I   %   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuário��5K   %    �� 
CaretBrush
 �   �
������  �� SelectionBrush
 �   �
������ $��18(�5P   %   $��Center=�5Q   %   $	��350��5R   %   $��10,0,0,0q�5S   %      
IsFloating .  5T   %     5V   "   $ Account=�6:   $��30��6I   ���#9a9a9a$��30��6i   $��Center=�6u   5W      5X      �� 5Y      
�������$��2q�5[      $ 25��5\      $��50��5]      $	��400��5^      $��0,20,0,0q�5_      ._�5`      �� $ 
Horizontal=�6%   .+�5a   "   �� $ 
Horizontal=�6-   .+�5b   &   G� -   5        $��txtSenha��5f   %   
������ $��Center=�5d   %   $��0q�5e   %   $ Senha��5g   %    G� 
CaretBrush
 �   � G� SelectionBrush
 �   �
������ $��18(�5k   %   $��Center=�5l   %   $	��350��5m   %   $��10,0,0,0q�5n   %    .  5o   %     5q   &   $
 Lock=�6>   ���#9a9a9a$��30��6_   $��30��6j   $��Center=�6v   5r   #   5s      5t      �� 5u      -   5         ��Name$ manter_conectado��5u   �   $��Manter-me conectado��6#   $��18(�6A   $��	70,20,0,0q�6O   $
��Left=�6c    � Cursor$
 Hand��6~   6�   �� 5v      $��0,40,0,0q�5w      ���	#FF9C27B0���	#FF9C27B0$��1q�5z      $ 20��5{      $	��400��5|      $��40��5}      ._�5~      �� -   5        $��
btnAcessar��5~   N   $��Center=�6%   $��28��6A   
������ $��0q�6y     MaterialDesignRaisedButton#��[ 6�   
�������$��ACESSAR��6�   $��16(�6�   $��Medium"�6�   6!  5      �� 5�      $	��400��6$   $��0,40,0,0q�60   
�������$��2��6N   6[   �� 5�      $��0,30,0,0q�6   $ 
Horizontal=�6/   $��Center=�6H   .+�5�      �� $��15(�6    �� 6/   $�Não possui uma conta? ��63   6S   6Y   �� 5�      $
 Hand��6    ���	#FF9C27B0$��15(�6E   $��	underline{�6S   �� 6p   -   5        $�Cadastre-se��5�   t   6�   6�   5�      5�      5�      5�      5�      5�      5�      