   M S B A M L   `   `   `  ����D  @ZadatakPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ZadatakPP	ZadatakPP  5   	       ZadatakPP.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ZadatakPP     5   	   -   5          � Title$  
MainWindow��5   	   $��754.666��6   $��1129.333��6.    � WindowStyle$
 None=�6p    � AllowsTransparency . 
������ .��5
      �� $��39,80,10.333,9.667q�6   .+�5   
   F� -   5        $��UIPath��5   1   
�������$��2��6   $��598.667��6?    �� Stretch$
 Fill=�6P   $	��950��6_    �� Left$	 120��6k   ��5      �� 5       �� Color$ 	#FF395781��6"   ��5      B� 5      .��5      E�  E� 
StartPoint$
 70,0&�6!   .��5      ��  �� Point$
 0,50&�6&   �� 5      $ 0,350&�6&   �� 5      $ 530,350&�6&   �� 5      $ 570,0&�6&   �� 5      $
 70,0&�6&   5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      	   
IsReadOnly	 . 
   SelectionMode$
 Single=�6Y      AutoGenerateColumns .  $
��Left=�6�   $	��245��6�   $	��Top=�6�   $	��668��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	 232��6�   
 �� Top$	 265��6
  ��6%   �� *	Fudbaleri+   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Slika��6)      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6J      CellTemplate 5!      �� 5"      .R�5#      �� $	��130��6=   $��50��6I   ��6$   �� *Slika+6I   5$      5&      0  *System.Windows.Controls.DataGridTextColumn  5'      $	 Ime��6%   $ 80 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Ime+6J     5(      $ Datum rodjenja��6%   $	 120 6p    6=   �� *DatumRodjenja+ �� StringFormat$ d��6p     5)      $
 Broj��6%   $ 80 6L    63   �� *Broj+6L     5*      $ Pozicija��6%   $ 80 6T    67   �� *
Pozicija+6T     5,      $ * 6)   $  ��63    5-      �� 5.      .R�5/      ��  �� Orientation$ Vertical=�6)   .+�50   "   �� $��buttonPrikazi��6)   -   5        $��Procitaj��50   >   6Q   �� 51   "   $��buttonIzmeni��6)   -   5        $��Izmeni��51   =   6N   �� 52   "   $��buttonObrisiIgraca��6)   -   5        $��Obrisi��52   C   6T   53      54      56      z�58      V� 59      .~�5:      �� �� 5;       �� AngleY$ -1.092Q�6$   �� 5<       �� Angle$ 1.068Q�6&   T� 5=       T� Y$ -0.754Q�6)    T� X$ -0.023Q�64   5>      5@      �� 5A   
   -   5        $��Dodaj igraca��5A      $
��Left=�6(   $��45��6C   $	��Top=�6O   $	��254��6g   $��Impact)�6�   $��24(�6�   $	 252��6�   $	 517��6�   $ 0.496,0.519&�6�   �� 5B   
   -   5        $
��Izaz��5B      $
��Left=�6    $	��Top=�6;   $	��261��6S   $��45��6_   $��Impact)�6�   $��20(�6�   $	 627��6�   $	 517��6�   $ 
0.49,0.563&�6�   �� 5C   
   $��Slike\zlatna.jpg��6   $
��Fill=�6*   $	 236��69   $	��198��6K   $ 65��6X   $	��665��6h   5E      5F      