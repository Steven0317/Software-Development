   M S B A M L   `   `   `  ����F  BAssignment4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment4Assignment4  5   	       Assignment4.ShoppingCart   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment4     5   	     � Title$  ShoppingCart��5   	   $	��500��6   $	��500��6+    � 	Resources 5	         ProductTemplate �� Orientation �� TextWrapping��%  &	        �� 5
   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��5q�65   $��75��6@   $��60��6K   ��6   �� *	ImagePath+6K   �� 5      .+�5      �� $��Arial)�66   $��14(�6I   $
��Bold"�6W   ��6    �� *Name+6W   �� 5      $	��200��6=   $
��Wrap=�6I   ��6    �� *Description+6I   �� 5      $	��200��67   $
��Wrap=�6C   ��6    �� *Price+6C   �� 5      $��40��6?   $
 Wrap=�6J   {�. ��6   �� *PurchasedAmount+6^   5      5      5      5      .��5      �� .+�5   
   �� #��[  6?   $
��Auto=�5      $	��400��6B   ��5      �� *Parent.CartContents+5   B   �� 5   
   $ 
Horizontal=�6   $��Center=�6.   .+�5      �� $��Total��6   $��25��6$   $��75��60   �� 5      $��25��6@   $	��100��6L   ��6   �� *Parent.TotalCostDisplay+6L   5      �� 5   
   $��Center=�6   $ 
Horizontal=�62   .+�5      �� $��Update Order��6   $��25��6,   $	��125��68   ��6D   �� *UpdateOrderCommand+�� 5       $��Place Order��6   $��25��6+   $	��125��67   ��6C   �� *PlaceOrderCommand+5!      5#      5$      