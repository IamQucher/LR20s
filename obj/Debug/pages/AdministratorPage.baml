   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      %    WpfApp1.pages.AdministratorPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  AdministratorPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      $
��280* �6   �� 5      $
��120* �6   �� 5      $
��193* �6   �� 5      $	��28* �6   �� 5      $��5* �6   �� 5      $	��48* �6   �� 5      $
��126* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dg��5   0   $��0��6   $��0��6       AutoGenerateColumns .  $��7��6V   $��Comic Sans MS)�6j   $��Black"�6�   $��	0,84,0,48q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ProductName+  5      $' !Описание Продукта��6%    6@   �� *ProductDescription+  5       $ Категория��6%    68   �� *ProductCategory+  5!      $  Производитель��6%    6<   �� *ProductManufacturer+  5"      $ Цена��6%    63   �� *ProductCost+  5#      $ Скидка %��6%    67   �� *ProductDiscountAmount+  5$      $, &Количество на складе��6%    6C   �� *ProductQuantityInStock+  5%      $ Статус��6%    65   �� *ProductStatus+5'      �� 5*   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   $	��287��6V   $��2��6b   $��
25,10,0,10q�6v   .+�5,      �� -   5        $!��Добавить товар��5,      $	��113��6C   $��33��6O   $��Comic Sans MS)�6[   5-      �� 5.   
   $��5��6   $��	0,0,6,296q�6)   $��2��6<   .+�5/      �� -   5         ��Name$ fullNameLabel��5/      $��Comic Sans MS)�6+   $��16(�6F   $��28��6T   $	��350��6`   50      �� 51   
   $��1��6   $ 
Horizontal=�6"   $
��Left=�6;   $	��400��6V   $��	10,0,0,10q�6b   $��2��6u   $��5��6�   .+�52      �� -   5        $ ��Редактировать��52      $	��198��6D   $��37��6P   $��Comic Sans MS)�6\   �� 53      -   5        $��Обновить БД��53      $	��199��6B   $��34��6N   $��Comic Sans MS)�6Z   54      �� 55   
   $ 
Horizontal=�6   $
��Left=�6.   $��64��6I   $��63,28,0,273q�6T   $��6��6i   .+�56      �� -   5        $��
Выйти��56      	 J� RenderTransformOrigin$	 -1.535,0.514&�6@   $��34��6e   $��56��6q   $��Comic Sans MS)�6|   z�57      V� 58      .~�59      �� �� 5:      
 �� AngleX$
 1.591Q�6(   �� 5;      T� 5<       T� X$ 0.485Q�6-   5=      5?      5@      5C      5D      