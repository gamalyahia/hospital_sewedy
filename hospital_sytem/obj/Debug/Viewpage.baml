   M S B A M L   `   `   `  ����I  Ehospital_sytem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:hospital_sytemhospital_sytem  5          hospital_sytem.Viewpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:hospital_sytem     5        N� 
Background
  ����� N� Title$ Viewpage��5	      .��5      � ��5   
   �� 5       �� ImageSource$ v870-tang-36.jpg��6    � RowDefinitions 5   
   �� 5      �� 5      $	��300 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   �� 5      �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��patients_table��5      $��1��6)   $��1��66   5         5"   
   -   5        $��doctors_table��5"      $��1��6(   $��3��65   5$      �� 5%   
   $��3��6   $��Center=�6)   $��1��6F   $��0��6V    �� Orientation$ 
Horizontal=�6c   .+�5&      �� $
��Back��6   $��	0,0,200,0q�6$      ButtonStyle#��[  67   �� 5'      $��Modify��6   $��	200,0,0,0q�6&   #��[  69   5(      5*      5+      