   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View  $    project.MVVM.View.ContractView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:project.MVVM.View     .���   � RowDefinitions  �� $��80 ��� $��30 ��� .+�� $��0�� � ColumnDefinitions �� �� .+���  �� Orientation$ Vertical=�.+��� $/��)Сортировка по статусу:��$��Calibri)�$��20(�$��	20 10 0 0q��� -   $��combobox��$��	20 10 0 0q�$	��200��$
��Left=�$��Center=�.@��� -   $��SelectedAll��$��Все���� -   $��SelectedWaiting��$��Ожидание���� -   $��SelectedInArend��$��В аренде���� -   $��SelecyedInReturn��$*��$Ожидание на возврат���� -   $��SelectedReturned��$��Возвращено���� $��Center=�$ 
Horizontal=�$��1��$��Center=�.+��� -   $��AddContract��$	��150��$��55��$%��Добавить договор�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��   
ButControl#��[  �� -   $��DeleteContract��$	��150��$��55��$#��Удалить договор�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��#��[  � $��1�� �� $	��140 ��� $	��110 ��� $	��110 ��� $	��130 ��� $	��150 �.+��� $��0��$!��Номер договора��$��Center=�$��Center=�$��Calibri)�$��14(��� $��1��$��Дата начала��$��Center=�$��Center=�$��Calibri)�$��14(��� $��2��$��Дата конца��$��Center=�$��Center=�$��Calibri)�$��14(��� $��3��$��Цена аренды��$��Center=�$��Center=�$��Calibri)�$��14(��� $��4��$��Статус��$��Center=�$��Center=�$��Calibri)�$��14(��� -	   $��ContractsList��$��2��
������ $��Disabled=�$��Center=�$��0q� �� SelectionMode$ Single=�$	��700������ .R��  � Orientation$ 
Horizontal=�$��Center=����� .R��  �� $	��100 ��� $	��110 ��� $	��110 ��� $	��170 ��� $	��280 �  �� $��70 �.+��� $��Center=�$��Center=� �� TextAlignment$
 Left=�$��Calibri)�$��15(�$
��Bold"�$��0������ *
IdContract+�� $��Center=�$ Center=�$��1��$	��150��$
��Wrap=�$
��Left=�$��15(�$��Calibri)�$
��Bold"����� *DateOfCustody+�� $��Center=�$ Center=�$��2��$	��150��$
��Wrap=�$
��Left=�$��15(�$��Calibri)�$
��Bold"����� *	DateOfEnd+�� $
��Bold"�$��3��$��Calibri)�$��Center=�$��15(�$��Center=����� *Price+ �� StringFormat$ {0:0} руб���� $
��Left=�$ Center=�$��Calibri)�$��20 0 0 0q�$��15(�$
��Bold"�$��4��$��Center=�$
��Wrap=����� *Status+