   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View       project.MVVM.View.StafView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:project.MVVM.View     
������ .��� 
������   � RowDefinitions  �� $��70 ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�.+��� -   $��AddToBasket��$	��130��$��45��$(��"Добавить в корзину�����#00BFFF
���   �$��1q�$��70 0 0 0q�
�������   
ButControl#��[  �� -   $��	ComboMode��$	��190��$��27��$��	200 0 0 0q�$��Center=�$��Center=����#00BFFF.@��� -   $��OdVib��$#��Одиночный выбор�����#00BFFF�� -   $��MonVib��$+��%Множественный выбор�����#00BFFF�� -   $��ListViewStuf��$��1��
������ $��Disabled=�$��Center=�$��0q� �� SelectionMode$ Multiple=����� .R��  � Orientation$ 
Horizontal=�$��Center=����� .R�� $��20q�$	��150��  �� $��30 ��� $	��170 ��� $
��auto �.+��� $	��150��$	��150��$��1��$��UniformToFill=�$��Center=�$��5q�����  �� Path$ Imagesource� �� TargetNullValue ��/Images/sobaka.jpg���� $��Center=� �� TextAlignment$ Center=�$	��150��$
��Wrap=�$��Center=�$��12(�$
��Bold"����� *Name+�� $��2��$��5 5 5 15q�$
��Bold"�$��Center=�$��12(����� *Price+ �� StringFormat$ {0:0} руб/сутки��