   M S B A M L   `   `   `  ����B  >project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:project.MVVM.Viewproject.MVVM.View  5   	        project.MVVM.View.ItemInfo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:project.MVVM.View     5   	   $	��550��5   	   $	��550��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      ��  �� CornerRadius$ 20��6   ���#E6E6FA$��1q�64   
���   �._�5   
   � -   5        $��ShowInfo��5       � RowDefinitions 5      �� 5      $��35 �6    �� 5      $
��auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� -   5        ���#c80000$��0��5   *   $��20��5      $��20��6    $��Right=�5      $	��Top=�5      $��	0 10 10 0q�5         ExitButtonTh#��[  5       � ToolTip$( "Выход из программы��5!   "   5"      �� 5$      $��1��6   $	��270��6!   $	��270��6.   $��UniformToFill=�6:   ��5%      �� 5&       �� Path$ Imagesource�6    �� TargetNullValue 5'      ��5(      /Images/sobaka.jpg��6>   5*      5,      �� 5.      	 �� Orientation$	 
Horizontal=�6   $��2��62   $��0 7 0 0q�6?   $��Bottom=�5/      .+�50      �� $��Название: ��6   $��	20 0 10 0q�6.   $��Center=�51      
���   �$
��Bold"�52      $��19(�6.   �� 53      $��16(�62   
���   �$��Center=�54      $��Center=�65   ��53      �� *Name+54   5   55      � 56      
 � Orientation$
 
Horizontal=�6   $��3��61   $��0 10 0 0q�6>   .+�57      �� $��Описание: ��6   $��	20 0 10 0q�6.   $
��Bold"�58      $��15(�6.   
���   �59      �� 5:      $	��500��69    �� TextAlignment$ Justify=�5;      $��20 0 0 0q�64   $
��Wrap=�5<      $��15(�60   $��Center=�5=      
���   ���5:      �� *Description+5>      5?      �� 5@      $	 
Horizontal=�6   $��4��62   $��Center=�5A      $��0 10 0 0q�64   .+�5B      �� $��
Цена: ��6   $��	20 0 10 0q�6*   $
��Bold"�5C      $��19(�6.   $��Center=�5D      
���   �5E      �� 5F      $��15(�5G      $��Center=�6*   
���   ���5F      �� *Price+ �� StringFormat$ {0:0} руб/сутки��5H      5I      5J      5K      5L      