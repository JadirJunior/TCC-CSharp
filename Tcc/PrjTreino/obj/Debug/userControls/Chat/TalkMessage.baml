   M S B A M L   `   `   `  ����D  @PrjTreino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PrjTreino.userControls.ChatPrjTreino.userControls.Chat  5      -    'PrjTreino.userControls.Chat.TalkMessage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:PrjTreino.userControls.Chat     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $	��900��5	      $	��550��6   
�������.��5
      �   � RowDefinitions  5   
   �� 5      $
��370* �6   �� 5      $	��63* �6   .+�5   
   �� -   5        $��Scroll��5   <   $��Hidden=�6   $��0��6J   .��5      � $	��470��6   .+�5      �� -   5        $��messages��5      $��18(�6+   5      5      5      � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� 
�������$��2q�62    �� CornerRadius$ 10��6F   $��40��6X   $	��800��6d   $��20,0,0,0q�6p   ._�5      �� -   5        $��
txtMessage��5   C   
�������
���   �$��0q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   
IsFloating .     HintOpacity$	 0.4Q�6�      Hint$ Digite Sua Mensagem��6�   $��18(�6#  $��40��61  $	��800��6=  6K  5      �� 5      -   5         ��Name$ btnSendMessage��5         MaterialDesignFlatButton#��[  5      $��Center=�5      $��50��5      $��50��5       $��40,0,0,0q�5!      $��Right=�6'   .��5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Send=�6.   $��Center=�6:   $��Center=�6U   
�������$��30��6�   $��30��6�   5#      5$      5%      5'      5(      5)      