   M S B A M L   `   `   `  ����B  >Zadanie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ZadanieZadanie  5   	       Zadanie.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Zadanie     5   	   -   5          � Title$  FerstPos��5	   	   $	��450��6   $	��800��6'    � Icon$ service_logo.png��6J    � WindowStartupLocation$ CenterScreen=�6b   .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 Dann��5      $��14(�6!   $��10,89,10,48q�6/      AutoGenerateColumns .  $��	Tw Cen MT)�6`   
���   ����	#FFFF9C1A���	#FFFFFFE1 J� OpacityMask �	#FF7E3A3A   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Q   	   
IsReadOnly	 .  
   CanUserSort
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 Name�6p     5      $ Surname��6F   $	 150 6W   	 .  
 .  6%   �� $ Surname�6v     5      $	 Age��6B   $ 80 6O   	 .   6%   �� $	 Age�6Z     5      $ Phone��6D   $	 150 6S   	 .   6%   �� $ Phone�6_     5      $ Email��6i   $	 120 6x   	 .   6%   �� $ Email� �� UpdateSourceTrigger$ PropertyChanged=�6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Online��6F   $ * 6V   	 .   6)   �� $	 Vac�6`   5      �� 5   
   -   5         ��Name$ Sorting��5      $��	Tw Cen MT)�6#   $
��Left=�6:   $��23��6U   $��	10,61,0,0q�6a    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��153��6�   ���	#FFFF9C1A �� TextDecorations 6�   Z� �� 5   
   $
��Left=�6   $��	Tw Cen MT)�6/   $��	10,39,0,0q�6F   $
��Wrap=�6Y   $��Name:��6m   $	��Top=�6z   $��22��6�   $	��105��6�   �� 5   
   $��1��6   $��	Tw Cen MT)�6   $��Right=�65   $��	0,0,33,10q�6Q   $��18��6d   ���	#FFFF9C1A���	#FFFF9C1A���	#FFFFFFE1$��20��6�   $��Bottom=�6�   �� 5    
   -   5        $��2��5       $��	Tw Cen MT)�6,   $��Right=�6C   $��	0,0,10,10q�6_   $��Bottom=�6r   $��18��6�   
����������	#FFFF9C1A$��20��6�    �� 	ClickMode$ Press=�6�   5"      5#      