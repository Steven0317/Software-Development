   M S B A M L   `   `   `  ����F  BAssignment4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment4Assignment4  5   	       Assignment4.EditItem   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment4     5   	     � Title$  EditItem��5   	   $	��650��6   $	��800��6'    � 	Resources 5	         ProductTemplate �� Orientation � RowDefinitions � ColumnDefinitions��%�  &	        �� 5
   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��5q�65   $��75��6@   $��60��6K   ��6   �� *	ImagePath+6K   �� 5      .+�5      �  5      �� 5      �� 5      �� 5       5      �� 5      �� 5      �� 5      .+�5      �� $��0��6$   $��Name: ��61   $��Center=�6?   �� 5      $��1��6$   $��Center=�64   $
��Left=�6O   $��Arial)�6�   $��14(�6�   $��DemiBold"�6�   ��6j   �� *Name+6�   �� 5      $��1��6$   $��Description: ��61   $��Center=�6F   �� 5      $��1��6$   $��1��61   $
��Left=�6A   $��Center=�6\   $	��200��6�   $
��Wrap=�6�   ��6w   �� *Description+6�   �� 5      $��2��6$   $��Price:��61   $��Center=�6?   �� 5      $��2��6$   $��1��61   $��Center=�6A   $
��Left=�6\   $	��200��6�   $
��Wrap=�6�   ��6w   �� *Price+6�   5      5       5!      5"      5#      .��5$      �� $��Center=�6   .+�5%   
   �� �� 5&   
   �� 5'   
   �� 5(   
   .+�5)      �� #��[  6k   $
��Auto=�5*      $	��400��6B   
���������5)      �� *Parent._PetsCollection+ �� SelectedItem 6E   �� *SelectedPet+5*   R   �� 5+      $ 
Horizontal=�6   .+�5,      �� $��Edit Pet��6   $��25��6,   $	��125��68   ��6D   �� *EditPetCommand+�� 5-      $��
Delete Pet��6   $��25��6.   $	��125��6:   ��6F   �� *DeletePetCommand+�� 5.      $��Add Pet��6   $��25��6+   $	��125��67   ��6C   �� *AddPetCommand+5/      50      51      52      