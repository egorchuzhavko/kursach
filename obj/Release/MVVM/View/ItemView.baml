   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View       project.MVVM.View.ItemView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:project.MVVM.View     .���   � RowDefinitions  �� $��80 ��� $��30 ��� .+��� $��Center=� �� Orientation$ 
Horizontal=�$��0��$��Center=�.+��� -   $��AddStaf��$	��130��$��55��$!��Добавить товар�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��   
ButControl#��[  �� -   $��
DeleteStaf��$	��130��$��55��$��Удалить товар�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��#��[  �� $��Center=�$��1��$ 
Horizontal=�.+��� $��Id товара��$��16(�$��Calibri)�$��60 0 0 0q��� $#��Название товара��$��16(�$��Calibri)�$��65 0 0 0q��� $��Цена товара��$��16(�$��Calibri)�$��80 0 0 0q��� $��Статус товара��$��16(�$��Calibri)�$��80 0 0 0q��� -   $��	ItemsList��$��2��
������ $��Disabled=�$��Center=�$��0q� �� SelectionMode$ Single=�$	��700������ .R��  � Orientation$ 
Horizontal=�$��Center=����� .R��  � ColumnDefinitions �� $	��150 ��� $	��220 ��� $	��190 ��� $	��200 �  �� $��70 �.+��� $��Center=�$��Center=� �� TextAlignment$
 Left=�$��Calibri)�$��15(�$
��Bold"�$��0������ *Id+�� $��Center=�$ Center=�$��1��$	��150��$
��Wrap=�$
��Left=�$��15(�$��Calibri)�$
��Bold"����� *Name+�� $
��Bold"�$��2��$��Calibri)�$
��Left=�$��15(�$��Center=����� *Price+ �� StringFormat$ {0:0} руб/сутки���� $
��Left=�$ Center=�$��Calibri)�$��15(�$
��Bold"�$��3��$��Center=����� *Status+