   M S B A M L   `   `   `  ����K  GCryptoCurrencies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CryptoCurrencies.ViewsCryptoCurrencies.Views  5      &     CryptoCurrencies.Views.CoinsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:CryptoCurrencies.Views     5        � 	Resources  5	         MenuButtonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6(   .�5      ��  � ��$ 80��6'   �� 5       � ��
 ���� 6+   �� 5       � ��$ 0q�60   5      5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��130 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 30��6   $��95��6#   ���#1D212C$��15,20,15,20q�6C   ._�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��0,30,0,0q�6   #��[  6+   .��5      �� $��/img/diamond.png��6   $��32��66   5      �� 5      $��0,50,0,0q�6   #��[  6+   .��5      �� $��/img/collage.png��6   $��22��66   5      �� 5      #��[  6   .��5      �� $��/img/convert.png��6   $��22��66   5       5!      5"      �� 5$   
   $ Vertical=�6   $��1��6,   $��
27,30,15,0q�6<   .+�5%      �� -   5         ��Name$ 	textBlock��5%      $
��Wrap=�6+   $��Top 10 ��6?   $��26(�6N   $��
Leelawadee)�6\   �� 5&      $��0,15,0,0q�6   �� 5'      $��1��6   $��1��6&   ��63   �� *Coins+��5(      �� 5)      .R�5*      � $
��0,10q�6   $��35��6-    5+      �� 5,   "    � RowDefinitions 5.      �� 5/   "   $��20 �60   �� 50   "   $��* �60   .+�52      �� $ 
textBlock2��6(   $��0��6<   $
��Left=�6L   $��20,0,0,0q�6g   $
��Wrap=�6y   $��Center=�6�   $��18(�6�   $��PT Sans)�6�   ���#1D212C��6�   �� *Symbol+6�   �� 53      $��1��6%   $��10,0,5,0q�65   $��0��6G   $��Деталі��6�   ��6U   �� *ShowDetailsCoinCommand+6�   �� 54      $��0��6(   $��1��68   $
��Left=�6E   $��Center=�6v   $��11(�6�   $��PT Sans)�6�   ���#92969F$��20,0,0,0q�6�   ��6`   �� *Name+6�   �� 55      $��1��6(   $��1��68   $��Right=�6E   $��Center=�6{   $��11(�6�   $��PT Sans)�6�   ���#92969F$
��Bold"�6�   $��20,0,0,0q�6�   ��6a   �� *
PriceUsd+6�   56      57      59      5:      5;      5<      