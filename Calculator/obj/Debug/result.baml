   M S B A M L   `   `   `  ����E  Acalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:calculator
calculator  5          calculator.result   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:calculator     5        N� Title$  result��5	      .��5      � -   5         �Name$
 main��5      ���	#FFD4E4EE.+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5   c      AutoGenerateColumns .  $��Stretch=�6/   $��19,31,144,21q�6M   $��Stretch=�6u      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����
����������	#FF7490AC   GridLinesVisibility$ 
Horizontal=�6     EnableRowVirtualization .     
IsReadOnly . ��6�   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Expression��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *
expression+6h     5      $
 Preorder��6%   $	 120 67    6D   �� *
preorder+6d     5      $
 	Postorder��6%   $	 120 68    6E   �� *	postorder+6f     5      $
 Decimal��6%   $ 75 66    6B   �� *decimalResult+6g     5      $
 Binary��6%   $	 125 65    6B   �� *binaryResult+6f   5      �� 5   
   -   5         ��Name$ buttonDelete��5      $��DELETE��6'   $��72��68   $��615,31,24,0q�6D   $	��Top=�6Y   ���	#FFEDF4F9$��14(�6�   �� 5   
   -   5        $ buttonPrevious��5      $��PREVIOUS��6)   $��72��6<   $��615,123,24,0q�6H   $	��Top=�6^   ���	#FFEDF4F9$��14(�6�   5      5      