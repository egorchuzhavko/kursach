   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View  !    project.MVVM.View.MakeOrder   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:project.MVVM.View     $	��550��$	��800��  � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�.����  �� CornerRadius$ 20�����#E6E6FA
���   �$��1q�._��  � RowDefinitions �� $��50 ��� $	��100 ��� $	��380 ��� $��* �.+��� -   ���#c80000$��0��$��20��$��20��$��Right=�$	��Top=�$��	0 10 10 0q�   ExitButtonTh#��[   � ToolTip$ Закрыть окно���� $'��!Оформление заказа��$��Center=�$��0 10 0 0q�$��Calibri)�$��20(�
���   ��� $��1��$��
Цена: ��$��18(�$��Calibri)�
���   �$��	10 15 0 0q��� -   $��Price��$��1��$��18(�$��Calibri)�
���   �$��	10 41 0 0q��� $��1��$��18(�$��Calibri)�
���   �$��
135 15 0 0q�$)��#Дата начала аренды:��(  "System.Windows.Controls.DatePicker  -   $��	DateStart��$��1��$	��200��   SelectedDate$ 
2020/10/10X�$��25��$��-340 10 0 0q��� $��1��$��18(�$��Calibri)�
���   �$��
375 15 0 0q�$'��!Дата Конца аренды:��  -   $��DateEnd��$��1��$	��200��$ 
2020/10/10X�$��25��$��
140 10 0 0q��� -   $��MakeOrderrr��$	��130��$��45��$��Сделать заказ��$��Calibri)�$��15(����#00BFFF
���   �$��1q�
�������$��1��$��Center=�$��Right=�$��0 0 15 0q�  
ButControl#��[ �� -   $��OrderItemsList��$��2��
������ $��Disabled=�$��Center=�$��0q� �� SelectionMode$ Multiple=����� .R�� 	 � Orientation$	 Vertical=�$��Center=����� .R�� $��20q�$��30��
 � ColumnDefinitions
 �� $	��200 ��� $	��200 ��� $	��200 ��� $	��200 �.+��� $)��#Название продукта: ��$��15(�$��0��$��15 0 0 0q�$��Calibri)�
���   �$��Center=��� $
��Name��$��1��$��15(�$��30 0 0 0q�$��Calibri)�
���   �$��Center=����� *Name+�� $!��Цена продукта: ��$��Center=�$��15(�$��2��$��Calibri)�
���   ��� $��Price��$��3��$��15(�$��30 0 0 0q�$��Center=�$��Calibri)�
���   ����� *Price+ �� StringFormat$ {0:0} руб/сутки��