   M S B A M L   `   `   `  ����D  @ZadatakPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ZadatakPP	ZadatakPP  5   	       ZadatakPP.Izmena   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ZadatakPP     5   	   -   5          � Title$  Izmena��5   	   $	��700��6   $��850.666��6%    � WindowStyle$
 None=�6f    � AllowsTransparency . 
������ .��5
      �� $��127,0,-63.333,0q�6   .+�5   
   F� -   5        $��UIPath��5   1   
�������$��2��6   $	��700��6?    �� Stretch$
 Fill=�6L   $	��706��6[    �� Left$ 19��6g   ��5      �� 5       �� Color$ 	PeachPuff��6"   ��5      B� 5      .��5      E�  E� 
StartPoint$
 70,0&�6!   .��5      ��  �� Point$
 0,80&�6&   �� 5      $ 0,350&�6&   �� 5      $ 510,380&�6&   �� 5      $ 570,0&�6&   �� 5      $
 70,0&�6&   5      5      5      �� 5   
   -   5         ��Name$ 
labelSlika��5      $��Slika:��6$   $
��Left=�65   $	��Top=�6P   $��82��6h   	 J� RenderTransformOrigin$	 1.228,0.838&�6s   $	 180��6�   

 �� Top$	
 314��6�   �� 5   
   -   5        $ labelIme��5      $
��Ime:��6"   $	��Top=�61   $	 -0.474,-0.421&�6I   $	 180��6o   $	
 377��6�   $��54��6�   �� 5   
   -   5        $ labelDatumRodjenja��5      $��Datum rodjenja:��6,   $
��Left=�6F   $	��Top=�6a   $	 0.412,2.051&�6y   $	 180��6�   $	
 429��6�   �� 5   
   -   5        $ 	labelBroj��5      $��Broj:��6#   $
��Left=�63   $	��Top=�6N   $��30��6f   $	 
0.439,1.55&�6r   $��95��6�   $	 180��6�   $	
 484��6�   �� 5    
   -   5        $ labelPozicija��5       $��	Pozicija:��6'   $
��Left=�6;   $	��Top=�6V   $	 0.465,-1.199&�6n   $	 182��6�   $	
 548��6�   �� 5!   
   -   5        $��Izmena��5!      $
��Left=�6"   $	��Top=�6=   $	��179��6U   $��Segoe UI Black)�6|   ���	#FFEDF1EA$	 0.507,3.825&�6�   $	 140��6�   $	
 609��6�   ��5"      �� 5#       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5$      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5%      $ 	#FFE9EAE5��6#   $ 1Q�65   5&      5(      �� 5)   
   -	   5        $��Izadji��5)      $
��Left=�6"   $	��Top=�6=   $	��174��6U   $��Segoe UI Black)�6|   ���	#FFEAF2E4$��1��6�   $	 0.429,0.645&�6�   $	 470��6�   $	
 609��6�   ��5*      �� 5+      $ 0.5,1&�6&   $ 0.5,0&�67   .��5,      � $ Black��6#   $ 0Q�61   � 5-      $ White��6#   $ 1Q�61   5.      50      �� 51   
   -
   5         ��Name$ buttonSlika��51      $��Dodaj SLIKU��6&   $
��Left=�6<   $��24��6W   $	��Top=�6c   $	��256��6{   $��2��6�   $	 324��6�   $	
 316��6�   �� 52   
   -   5         ��Name$ 
textBoxIme��52      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��256��6�   $��2��6�   $	 324��6�   $	
 377��6�   (  "System.Windows.Controls.DatePicker  53   
   -   5          Name$ 
dataPicker��53      $
��Left=�6+   $	��Top=�6F   $	��256��6^   $��2��6j   $	 324��6~   $	
 431��6�   �� 54   
   -   5        $ textBoxBroj��54      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��256��6�   $��2��6�   $	 324��6�   $	
 491��6�   �� 55   
   -   5         ��Name$ comboBoxPozicija��55      $
��Left=�6-   $	��Top=�6H   $	��256��6`   $��2��6l   $	 324��6�   $	
 552��6�   �� 56   
   $
��Left=�6   $��233,467,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 57   
   -   5        $ labelSlikaGreska��57      $�� ��6+   $
��Left=�66   $��23��6Q   $	��Top=�6]   $	��256��6u   ���	#FFCE381D$��2��6�   $	 324��6�   $	
 288��6�   �� 58   
   -   5        $ labelImeGreska��58      $�� ��6(   $
��Left=�63   $��28��6N   $	��Top=�6Z   $	��256��6r   ���	#FFE73919$��2��6�   $	 324��6�   $	
 345��6�   �� 59   
   -   5        $ labelGreskaDT��59      $�� ��6'   $
��Left=�62   $	��Top=�6M   $	��256��6e   $��23��6q   ���	#FFED1A1A$��2��6�   $	 324��6�   $	
 405��6�   �� 5:   
   -   5        $ labelBrojGreska��5:      $�� ��6*   $
��Left=�65   $	��Top=�6P   $	��256��6h   ���	#FFF21414$��2��6�   $	 324��6�   $	
 460��6�   �� 5;   
   -   5        $ labelPozicijaGreska��5;      $�� ��6-   $
��Left=�68   $	��Top=�6S   $	��256��6k   ���	#FFED1A1A$��2��6�   $	 324��6�   $	
 521��6�   �� 5<   
   -   5         ��Name$ slikaIgraca��5<      $
��Left=�6%   $��84��6@   $	��Top=�6L   $	��222��6d   $ 82��6p   $	
 225��6�   ]� 5>   
   $	 107��6   $
 36��6&   $	��169��66   $	��502��6C   .+�5?      c� $	��Top=�6   $	 0.523,0.488&�6+   $��0,0,-0.333,0q�6O   .@�5@      �� -   5        $��cmbFontFamily��5@      $	��144��60   $��0q�6e   $��26��6p   $	 0.491,0.472&�6|   �� 5A      �� 5B      -   5        $ textColorButton��5B      $��36��6E   .��5C      �� $��Slike\color.jpg��6   $	�� 18��65   $��20��6B   5D      �� 5E      �� 5F      -   5        $ comboFontSize��5F      $��84��62    �� SelectedIndex$ 2��6o   $��0q�6�   $��28��6�   �� 5G      d� 5I      -   5        $��btnBold��5I   D   $ ��EditingCommands.ToggleBold��6   
���   �$��B��6f   $��29��6r   ��5J      �� 5K       �� 
TargetType" d�6    .�5L      ��  �� Property � �� �� Value$
 Bold"�6;   5M      5O      �� 5P      d� 5Q      -   5        $��	btnItalic��5Q   F   $"��EditingCommands.ToggleItalic��6   $��I��6X   
���   �$��29��6w   ��5R      �� 5S      " d�6    .�5T      ��  � ��$
 Bold"�6;   �� 5U       � ��$ Italic$�6:   5V      5X      �� 5Y      d� 5Z      -   5        $��btnUnderline��5Z   I   $%��EditingCommands.ToggleUnderline��6   
���   �$��54��6q   .��5[      �� $��	Underline{�6    $��U��6<   $��47��6E   $��15��6P   ��5\      �� 5]      " d�6    .�5^      ��  � ��$
 Bold"�6;   5_      5a      5b      �� 5c      -   5        $��Words��5c      $��Bottom=�6%    J� Opacity$
 0.75Q�6=   
�������$	 0.5,0.5&�6^   z�5d      V� 5e      .~�5f      �� �� 5g      �� 5h       �� Angle$ -0.195Q�6*   T� 5i      5j      .@�5l      �� -   5        $��
labelWords��5l      $�� ��6*   $	��473��65   $��Right=�6A   $��32��6]   5m      �� 5n      -   5        $��	rtbEditor��5n      $��0,-0.667q�6|   $	��501��6�   $	��100��6�   $	��Top=�6�   $	 0.5,0.5&�6�   z�5o      V� 5p      .~�5q      �� �� 5r      �� 5s      $ 0.011Q�6*   T� 5t      5u      5w      5x      �� 5y   
   $��Ukratko o fudbaleru��6   $
��Left=�6.   $	��Top=�6I   $	��121��6a   $	 140��6m   $
 5��6   5z      5}      