   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View  #    project.MVVM.View.KorzinaView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     1localclr-namespace:project.MVVM.View     
������ .���   � RowDefinitions  �� $��70 ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�.+��� -   $��
OformZakaz��$	��130��$��45��$#��Оформить аренду�����#00BFFF
���   �$��1q�
�������$��40 0 0 0q�   
ButControl#��[  �� -   $��ClearBasket��$	��130��$��45��$%��Очистить корзину�����#00BFFF
���   �$��1q�
�������$��25 0 0 0q�#��[  �� -   $��ClearItemsFromBasket��$	��130��$��45��$(��"Удалить из корзины�����#00BFFF
���   �
�������$��1q�$��25 0 0 0q�#��[  �� -   $��	ComboMode��$	��190��$��27��$��25 0 0 0q�$��Center=�$��Center=����#00BFFF.@��� -   $��OdVib��$#��Одиночный выбор�����#00BFFF�� -   $��MonVib��$+��%Множественный выбор�����#00BFFF�� -   $��
BasketList��$��1��
������ $��Disabled=�$��Center=�$��0q� �� SelectionMode$ Multiple=����� .R��  � Orientation$ 
Horizontal=�$��Center=����� .R�� $��20q�$	��150��  �� $��30 ��� $	��170 ��� $
��auto �.+��� $	��150��$	��150��$��1��$��UniformToFill=�$��Center=�$��5q�����  �� Path$ Imagesource� �� TargetNullValue ��/Images/sobaka.jpg���� $��Center=� �� TextAlignment$ Center=�$	��150��$
��Wrap=�$��Center=�$��11(�$
��Bold"����� *Name+�� $��2��$��5 5 5 15q�$
��Bold"�$��Center=�$��11(����� *Price+ �� StringFormat$ {0:0} руб/сутки��