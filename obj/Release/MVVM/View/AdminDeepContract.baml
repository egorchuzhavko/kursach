   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View  )    #project.MVVM.View.AdminDeepContract   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:project.MVVM.View     $	��320��$	��700��  � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�.���� -    �� CornerRadius$ 20�����#E6E6FA
���   �$��1q�._��  � RowDefinitions �� $��40 ��� $��50 ��� $��50 ��� $	��100 ��� .+��� -   ���#c80000$��0��$��20��$��20��$��Right=�$	��Top=�$��	0 10 10 0q�   ExitButtonTh#��[   � ToolTip$ Закрыть окно����  �� Orientation$ 
Horizontal=�.+��� $��0��$ 
Horizontal=�$��20 0 0 0q�$��Center=�.+��� $"��Id пользователя:��$��15(�$��Calibri)��� -   $��IdofUser��$��20 0 0 0q�$��80��$��15(�$��Calibri)��� -   $��IdPanel��$��0��$ 
Horizontal=�$��20 0 0 0q�$��Center=�.+��� $��Id договора:��$��15(�$��Calibri)��� -   $��IdofContract��$��Id��$��20 0 0 0q�$��15(�$��Calibri)��� $��1��$ 
Horizontal=�$��20 0 0 0q�$��Center=�.+��� $$��Дата заключения:��$��15(�$��Calibri)�(  "System.Windows.Controls.DatePicker  -   $��	DateStart��$��20 0 0 0q�$	��150��   SelectedDate$ 
2020/10/10X��� $"��Дата Окончания:��$��15(�$��70 0 0 0q�$��Calibri)�  -   $��DateEnd��$��20 0 0 0q�$	��150��$ 
2020/10/10X��� $��2��$ 
Horizontal=�$��20 0 0 0q�$��Center=�.+��� $��Сумма:��$��15(�$��Calibri)��� -   $��Price��$	��150��$��20 0 0 0q�$��15(�$��Calibri)��� $��Руб��$��10 0 0 0q�$��15(�$��Calibri)��� $$��Статус договора:��$��15(�$��75 0 0 0q�$��Calibri)��� -	   $��Status��$	��178��$��20 0 0 0q�$��15(�$��Calibri)��� $��3��$ 
Horizontal=�$��Center=�$��20 0 0 0q�.+��� $(��"Id товаров в заказе:��$��15(�$��Center=�$��Calibri)��� -
   $��IdofStuf��$	��200��$��80��$��20 0 0 0q�	 �� TextWrapping$
	 Wrap=�$��Calibri)�$��15(�.���� -   $��SaveChanges��$	��130��$��45��$��Сохранить�����#00BFFF
���   �$��1q�
�������$��Center=�$��Right=�$��0 0 25 0q�$��5��  
ButControl#��[ 