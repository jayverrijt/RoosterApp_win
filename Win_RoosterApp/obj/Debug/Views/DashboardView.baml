   M S B A M L   `   `   `  ����I  EWin_RoosterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Win_RoosterAppWin_RoosterApp  5   	       Win_RoosterApp.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Win_RoosterApp     5   	     � Title$  Rooster App - Dashboard��5   	   $	��600��6)   $
��1000��66    � 
ResizeMode$ NoResize=�6C   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   6,   �� 5      $��5* �6   6,   �� 5      $	��12* �6   6-    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��9��5      $��0��6   $��	Uitloggen��6.      btnStyleDash#��[  6T   6|   �� 5   
   -   5        $��8��5      $��0��6   $��
Gebruikers��6.   #��[  6T   6|   �� 5   
   -   5        #��[  5      $��
Selecteren��67   $��0��6L   $��0��6Y   6�   �� 5   
   -   5         ��Name$ ioLabelSelUser��5   �   $��0��6   $��1��6   $��Selecteer een gebruiker��6-   $��2��6O   $��10��6c   $
��48px(�6u   $��Center=�6�   $��Center=�6�   6�   �� 5   
   -   5         ��Name$ ioUserListBorder��5   T   $��0��6   $��1��6   $��10��6.   $y�Hidden=�6@   ._�5       �� ��6   �� *Users+��5!      �� 5"      .R�5#      �� $	��2.5q�6%   64   5$      ��5&      �� 5'      .R�5(      ��  �� Orientation$ 
Horizontal=�6%   .+�5)      �� $��150px��6t   $
��22px(�6�   $��Center=�6�   
���   �$
��50px��6�   ��6(   �� *
Username+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5*      #��[  6%   $��	Selecteer��6K   6a   5+      5,      5.      5/      50      51      