   M S B A M L   `   `   `  ����F  BVRSM_simple, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:VRSM_simpleVRSM_simple  5   	       VRSM_simple.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:VRSM_simple     5   	     � Title$  VRSM_Simple��5   	   $	��450��6   $	��400��6*    � 
ResizeMode$ NoResize=�5	   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��5q�6"    �� Orientation$ 
Horizontal=�6-   .+�5      �� $��User Code: ��6   $
��Left=�6*   �� 5      -   5         ��Name$ 	user_code��5      $
��----��6'   $
��Left=�66   �� 5      -   5         ��Name$ sign_in��5      $��Sign In��6&   $
��auto��68   $
��auto��6E   $��Right=�6S   5      �� 5   
   -   5         ��Name$ 
MainLayout��5   "   $��1��6   $��5q�66   $��Center=�6A   $��Center=�6^   5      � 5   
   $��2��6   $��5q�6   .+�5      �� -   5        $ prev_button��5      $y�Hidden=�6*   $
��Prev��6>   $
��Left=�6M   $��80��6h   �� 5      -   5        $ next_button��5      $y�Hidden=�6*   $
��Next��6>   $��Right=�6M   $��80��6i   5      5!      5#      