   M S B A M L   `   `   `  ����   KeshCalculator    KeshCalculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � WindowStartupLocation$  CenterScreen=�$	��900��$
��1480�� � 
ResizeMode$ NoResize=� � Icon$ icon.ico�� � Title$ Kesh Kreations Calculator��
���   �.��� $��10 10 10 20q� � ColumnDefinitions �� �� �� ��  � RowDefinitions �� $	��200 ��� �� �� �� �� .+��� -    ��Name$
 btn7��$��5��   btnBlue#��[  $��0��$��6q�.��7�� -   $
 btn8��$��5��$��1��#��[  $��6q�.��8�� -   $
 btn9��$��5��$��2��#��[  $��6q�.��9�� -   $
 btn4��$��4��$��0��#��[  $��6q�.��4�� -   $
 btn5��$��4��$��1��#��[  $��6q�.��5�� -   $
 btn6��$��4��$��2��#��[  $��6q�.��6�� -   $
 btn1��$��3��$��0��#��[  $��6q�.��1�� -   $
 btn2��#��[  $��3��$��1��$��6q�.��2�� -	   $
 btn3��#��[  $��3��$��2��$��6q�.��3�� -
   $
 btn0��#��[  $��2��$��0��$��6q�.��0�� -   $ btnPlus��$��1��$��3��  btnGreen#��[ $��6q�.��PLUS�� -   $ btnMinus��$��2��$��3��#��[ $��6q�.��MINUS�� -   $ btnTimes��$��3��$��3��#��[ $��6q�.��TIMES�� -   $ 	btnDivide��$��4��#��[ $��3��$��6q�.��DIVIDE�� -   $ 	btnEquals��$��5��$��3��#��[ $��6q�.��EQUALS�� -   $ btnClear��$��1��$��0��#��[  $��6q�.��cancel�� -    ��Name$ 
txtDisplay��
���   �
��� ���$��
0 -20 20 0q� �� 
IsReadOnly . 	 �� TextAlignment$	 Right=�$	��140(�$
��Bold"�$��	25 5 20 3q�
��� ���$��0��$��0��$��4��$
��10,0q�$	��180��.��0�� $��1��$��2��$
��Left=�$��151,10,0,10q�$��1��$��2��$	��424��$��1.png��$
��Fill=�
 J� RenderTransformOrigin$
 0.768,0.398&�