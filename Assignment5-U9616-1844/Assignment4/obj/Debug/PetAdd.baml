   M S B A M L   `   `   `  ����F  BAssignment4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment4Assignment4  5   	       Assignment4.PetAdd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment4     5   	     � Title$  PetAdd��5   	   $	��450��6   $	��800��6%   .��5	      �� $��Center=�6   .+�5
   
   �� �� 5   
   �� 5   
   �� 5   
   $/��)Fill in the Fields Below to Add a New Pet��6   $��Center=�6E   �� 5   
   � 5   
    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6   $��Name: ��6%   $
��Left=�63   �� 5      $��1��6   $��Center=�6&   $
��Left=�6A   $	��215��6r    �� TextWrapping$
 Wrap=�6~   ��6\   �� *Name+6~   �� 5      $��1��6   $��Stock: ��6%   $
��Left=�64   �� 5      $��1��6   $��1��6#   $
��Left=�63   $��Center=�6N   $	��215��6�   $
 Wrap=�6�   ��6i   �� *Stock+6�   �� 5      $��2��6   $��Price:��6%   $
��Left=�63   �� 5       $��2��6   $��1��6#   $��Center=�63   $
��Left=�6N   $	��215��6�   $
 Wrap=�6�   ��6i   �� *Price+6�   �� 5!      $��Image: ��6   $��3��6'   $
��Left=�64   �� 5"       �� Orientation$ 
Horizontal=�6   $��3��62   $��1��6?   .+�5#      �� $	��200��6B   $��25��6N    �� 
IsReadOnly . ��6   �� *	ImagePath+ �� Mode$ OneWay=�6]   �� 5$      $	��...��6   $��15��6'   $��25��62   ��6>   �� *SelectImageCommand+5%      �� 5&      $��
Pet Type: ��6   $��4��6*   $
��Left=�67   �� 5'       �� SelectedValuePath$ Content��6   $��4��6�   $��1��6�   $	��215��6�   $
��Left=�6�    �� SelectedValue 63   �� *	PetType+$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�.@�5(      �� .��6   Aquatic pet6,   �� 5)      .��6   
Land Pet6)   5*      5+      �� 5,   
   �� 5-   
   $��75��6   $��20��6   $��Add Pet��6)   ��6;   �� *AddPetCommand+5.      5/      