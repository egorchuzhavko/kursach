   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View  5           project.MVVM.View.StafView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:project.MVVM.View     5      
������ .��5
      � 
������   � RowDefinitions  5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5        $��AddToBasket��5   )   $	��130��5      $��45��6!   $(��"Добавить в корзину��6-   ���#00BFFF
���   �$��1q�5      $��70 0 0 0q�5      
�������   
ButControl#��[  5      �� 5      -   5        $��	ComboMode��5   *   $	��190��5      $��27��6#   $��	200 0 0 0q�5      $��Center=�5      $��Center=�5      ���#00BFFF.@�5      �� -   5        $��OdVib��5      $#��Одиночный выбор��6,   ���#00BFFF5       �� 5!      -   5        $��MonVib��5!      $+��%Множественный выбор��6-   ���#00BFFF5#      5$      5%      �� 5'   
   -   5        $��ListViewStuf��5'       $��1��6   
������ $��Disabled=�5(      $��Center=�5)      $��0q�5*       �� SelectionMode$ Multiple=�6'   ��5-      �� 5.      .R�5/      �  � Orientation$ 
Horizontal=�6    $��Center=�50       51      ��54      �� 55      .R�56      � $��20q�6   $	��150��6'     57      �� 58      $��30 �6,   �� 59      $	��170 �6,   �� 5:      $
��auto �6,   .+�5=      �� $	��150��6    $	��150��6-   $��1��69   $��UniformToFill=�6F   $��Center=�5>       $��5q�6=   ��5?      �� 5@   "    �� Path$ Imagesource�6*    �� TargetNullValue 5A   &   ��5B   *   /Images/sobaka.jpg��6J   5D   #   5F      �� 5G      $��Center=�6:    �� TextAlignment$ Center=�5H   $   $	��150��5I   $   $
��Wrap=�60   $��Center=�5J   $   $��12(�6A   $
��Bold"�5K   $   ��5G   $   �� *Name+5K   $   �� 5L      $��2��6[   $��5 5 5 15q�6h   $
��Bold"�5M   $   $��Center=�5N   $   $��12(�6A   ��5L   $   �� *Price+ �� StringFormat$ {0:0} руб/сутки��5N   A   5O      5P      5R      5S      5T      