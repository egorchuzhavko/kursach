   M S B A M L   `   `   `  ���� B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:projectproject      project.StartWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:project     $	��420��$	��450��  � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � 	Resources  �� 
TargetType �� Triggers P� Property P� Value	 N� EnterActions
 �� From	 �� To �� TargetProperty g� Duration N� ExitActions �� Property �� Value �� 
TargetType �� CornerRadius ��Name J� SnapsToDevicePixels ��Name��%;  '��       '�� w    �� " �� P�  �@J�IsMouseOver . 	 �� .���� .���� $
 #00BFFFX�$ #00dcffX�$1 +(Button.Background).(SolidColorBrush.Color)�$ 0:0:0.2D� �� .���� .���� $
 #00dcffX�$ #00BFFFX�$1 +(Button.Background).(SolidColorBrush.Color)�$ 0:0:0.2D�.���  � �� �� " ��.R��� $ 25��
���   �$��1q�#��z��._��� #��z��#��z���� " �� P�  �@J�IsMouseOver . 	 �� .���� .���� $
 #0096ffX�$ #00b4ffX�$1 +(Button.Background).(SolidColorBrush.Color)�$ 0:0:0.2D� �� .���� .���� $
 #00b4ffX�$ #0096ffX�$1 +(Button.Background).(SolidColorBrush.Color)�$ 0:0:0.2D�.���  � �� �� " ��.R��� $ border��$ 20��#��z��#��z��#��z�� . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�.���� -   ���#E6E6FA$��1q�
���   �$ 20��._��� .+��� -   ���#c80000$��2��$��20��$��20�� �� Right$ 0��$��	0 10 10 0q�   ExitButtonTh#��[   � ToolTip$( "Выход из программы���� -   $��Authorization��
�������$y�Visible=����#00BFFF$	��250��$��50�� �� Left$	 100��
 �� Top$	 100��$��Calibri)�$
��Left=�$��Center=�$��14(�.��Авторизация�� -   $��Registration��
�������$y�Visible=����#00BFFF$	��250��$��50��$	 100��$	 175��$��Calibri)�$��Center=�$	��Top=�$��14(�.��Регистрация�� -   $��Admin��
�������$y�Visible=����#00BFFF$	��250��$��50��$	 100��$	 250��$��Calibri)�$��Center=�$	��Top=�$��14(�.��Администратор�� -   $��AvtorizeLogin��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��180��$	 135��$	 110��$��Введите логин��$
��Left=�$��Center=��� -   $��AvtorizePassword��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��180��$	 135��$	 170��$!��Введите пароль��$
��Left=�$	��Top=��� -   $��	Authorize��$y�Hidden=�
����������#00BFFF$	��250��$��50��$	 100��$	 230��$��Calibri)�$��Center=�$	��Top=�$��14(�$��Вход���� -	   $��BackFromAuthorize��$y�Hidden=�
����������#00BFFF$	��250��$��50��$	 100��$	 290��$��Calibri)�$��Center=�$	��Top=�$��14(�$��
Назад���� -
   $	��FIO��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��300��$ 75��$ 20��$��Ваше ФИО��$
��Left=�$��Center=�(  "System.Windows.Controls.DatePicker  -   $��BirthD��$	��200��$ 10��$	 160��   Text$( "Ваша дата рождения��$y�Hidden=��� -   $��Adress��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��300��$ 75��$ 90��$,��&Ваш адрес проживания��$��Center=�$	��Top=��� -   $��PhoneNumber��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��200��$ 10��$	 220��$!��Номер телефона��$��Center=�$	��Top=��� -   $��PassportNumber��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��200��$ 10��$	 280��$!��Номер паспорта��$
��Left=�$��Center=��� -   $��OrganVidachi��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��200��$ 10��$	 340��$.��(Орган выдачи паспорта��$
��Left=�$��Center=��� -   $��Login��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��200��$ 20��$	 160��$��
Логин��$��Center=�$	��Top=��� -   $��Password��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��200��$ 20��$	 220��$��Пароль��$��Center=�$	��Top=��� -   $��SignUp��$y�Hidden=�
����������#00BFFF$	��200��$��50��$ 20�� �� Bottom$ 50��$��Calibri)�$��Center=�$	��Top=�$��14(�$*��$Зарегистрироваться��$	 275���� -   $��BackFromReg��$y�Hidden=�
����������#00BFFF$	��200��$��50��$ 20��$ 50��$��Calibri)�$��Center=�$	��Top=�$��14(�$��
Назад��$	 335���� -   $��
AdminLogin��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��250��$	 100��$	 100��$��Введите логин��$��Center=�$	��Top=��� -   $��AdminPassword��$y�Hidden=�
�������
���   �$��Center=����#0096ff$��Center=�$��40��$	��250��$	 100��$	 175��$!��Введите пароль��$��Center=�$	��Top=��� -   $��AdminAvtorize��$y�Hidden=�
����������#00BFFF$	��250��$��50��$	 100��$ 50��$��Calibri)�$��Center=�$	��Top=�$��14(�$*��$Зарегистрироваться��$	 250���� -   $��BackFromAdmin��$y�Hidden=�
����������#00BFFF$	��150��$��50��$	 150��$ 50��$��Calibri)�$��Center=�$	��Top=�$��14(�$��
Назад��$	 320��