   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View       project.MVVM.View.ItemInfo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:project.MVVM.View     $	��550��$	��550��  � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�.����  �� CornerRadius$ 20�����#E6E6FA$��1q�
���   �._�� -   $��ShowInfo�� � RowDefinitions �� $��35 ��� $
��auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   ���#c80000$��0��$��20��$��20��$��Right=�$	��Top=�$��	0 10 10 0q�   ExitButtonTh#��[   � ToolTip$( "Выход из программы���� $��1��$	��270��$	��270��$��UniformToFill=�����  �� Path$ Imagesource� �� TargetNullValue ��/Images/sobaka.jpg���� 	 �� Orientation$	 
Horizontal=�$��2��$��0 7 0 0q�$��Bottom=�.+��� $��Название: ��$��	20 0 10 0q�$��Center=�
���   �$
��Bold"�$��19(��� $��16(�
���   �$��Center=�$��Center=����� *Name+� 
 � Orientation$
 
Horizontal=�$��3��$��0 10 0 0q�.+��� $��Описание: ��$��	20 0 10 0q�$
��Bold"�$��15(�
���   ��� $	��500�� �� TextAlignment$ Justify=�$��20 0 0 0q�$
��Wrap=�$��15(�$��Center=�
���   ����� *Description+�� $	 
Horizontal=�$��4��$��Center=�$��0 10 0 0q�.+��� $��
Цена: ��$��	20 0 10 0q�$
��Bold"�$��19(�$��Center=�
���   ��� $��15(�$��Center=�
���   ����� *Price+ �� StringFormat$ {0:0} руб/сутки��