   M S B A M L   `   `   `  ����E  AStudentApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:StudentApp
StudentApp  5          StudentApp.SchoolInfo   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:StudentApp     5        N� Title$  School Information��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5"   
   �� $��Center=�6   $��Enrollment Year��6.   $��Bottom=�6I   $��2��6d   $��2��6t   $��1��6�   $y�Visible=�6�   �� 5#   
   -   5         ��Name$ 
Enrollment��5#       �� TextAlignment$ Center=�6&   $��2��6=   $��Stretch=�6R   $��0,0,0,1q�6p   $��Center=�6�   $
��auto��6�   $��2��6�   $��2��6�   
������� J� Opacity$
 0.75Q�6�   6L  �� 5%   
   $��Center=�6   $��Graduation Year��6.   $��Bottom=�6I   $��5��6d   $��2��6t   $��1��6�   $y�Visible=�6�   �� 5&   
   -   5        $ 
Graduation��5&      $ Center=�6&   $��2��6=   $��Stretch=�6R   $��0,0,0,1q�6p   $��Center=�6�   $
��auto��6�   $��5��6�   $��2��6�   
�������$
 0.75Q�6�   6K  �� 5(   
   $��Center=�6   $��
Department��6.   $	��Top=�6D   $��2��6\   $��2��6l   $��3��6�   $y�Visible=�6�   �� 5)   
   -   5         ��Name$ 
Department��5)      $��2��6'   $��2��6;   $��3��6K   $��Stretch=�6X   $��Bottom=�6v   $
��auto��6�   .@�5*      �� .��6   Civil Engineering6.   �� 5+      .��6   Chemical Engineering61   �� 5,      .��6   Computer Science6-   �� 5-      .��6   Computer Engineering61   �� 5.      .��6   Mechanical Engineering63   5/      �� 51   
   $��Center=�6   $��G.P.A.��6.   $	��Top=�6@   $��5��6X   $��2��6h   $��3��6|   $y�Visible=�6�   �� 52   
   -   5        $	 GPA��52      $ Center=�6   $��0,0,0,1q�68   $��Stretch=�6R   $��Bottom=�6p   $
��auto��6�   $��5��6�   $��2��6�   $��3��6�   
�������$
 0.75Q�6�   6E  �� 54   
   -   5         ��Name$ Submit_Button��54      $��Submit��6*   $��Center=�6;   $��Center=�6X   $	��100��6s   $��3��6   $��5��6�   $��3��6�   $��26��6�   ���	#FF0078D7$
 0.75Q�6�   ���	#FF0078D7
������� �� 	IsDefault . 6   �� 56   
   -   5        	 ��Name$	 error��56      $��Center=�6   $"��Please fix the errors in red��6<   $��Center=�6d   $��2��6   $��5��6�   $y�Hidden=�6�   58      59      