   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View       project.MVVM.View.UserView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:project.MVVM.View     .���   � RowDefinitions  �� $��80 ��� $��30 ��� .+��� $��Center=� �� Orientation$ 
Horizontal=�$��0��$��Center=�.+��� -   $��AddUser��$	��150��$��55��$/��)Добавить пользователя�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��   
ButControl#��[  �� -   $��
DeleteUser��$	��150��$��55��$-��'Удалить пользователя�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��#��[  �� $��Center=�$ 
Horizontal=�$��1��.+��� $!��Id пользователя��$��16(�$��Calibri)�$��60 0 0 0q��� $��
Логин��$��16(�$��Calibri)�$��	130 0 0 0q��� $%��ФИО пользователя��$��16(�$��Calibri)�$��	130 0 0 0q��� -   $��	UsersList��$��2��
������ $��Disabled=�$
��Left=�$��0q� �� SelectionMode$ Single=�$	��700������ .R��  � Orientation$ 
Horizontal=�$��Center=����� .R��  � ColumnDefinitions �� $	��150 ��� $	��350 ��� $	��300 �  �� $��70 �.+��� $��Center=�$��Center=�$��35 0 0 0q� �� TextAlignment$
 Left=�$��Calibri)�$��15(�$
��Bold"�$��0������ *Iduser+�� $��Center=�$ Center=�$��1��$	��150��$
��Wrap=�$��	-20 0 0 0q�$��Center=�$��15(�$��Calibri)�$
��Bold"����� *Login+�� $��	-40 0 0 0q�$
��Bold"�$��2��$��Calibri)�$
��Left=�$��15(�$��Center=����� *Fio+