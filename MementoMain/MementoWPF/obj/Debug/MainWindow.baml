   M S B A M L   `   `   `  ����E  AMementoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MementoWPF
MementoWPF  5   	       MementoWPF.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MementoWPF     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � 
������� � RowDefinitions 5   
   �� 5      $	��21* �6   �� 5      $	��57* �6   �� 5      $	��57* �6   �� 5      $	��57* �6   �� 5      $	��58* �6   �� 5      $	��65* �6   �� 5      $
��108* �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��3* �6   �� 5      $��4* �6   .+�5   
   � $��1��6   $��0��6   .+�5      �� .��6   Rut Usuario6!   �� 5      $��30��6   $
��auto��6"   $��Bottom=�6/   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ XX.XXX.XXX-X��6J   6|   5      � 5   
   $��2��6   $��0��6   .+�5       �� .��6   Nombre6   �� 5!      $��30��6   $
��auto��6"   $��Bottom=�6/   $ Nombre Usuario��6J   6~   5"      � 5$   
   $��3��6   $��0��6   .+�5%      �� .��6   
Apellido6   �� 5&      $��30��6   $
��auto��6"   $��Bottom=�6/   $ Apellido Usuario��6J   6�   5'      � 5)   
   $��4��6   $��0��6   .+�5*      �� .��6   Fecha Nacimiento6&   (  "System.Windows.Controls.DatePicker  5+      $��30��6   $
��auto��6%   $��Bottom=�62   6O   5,      � 5.   
   $��1��6   $��2��6   .+�5/      �� .��6   Correo Electronico6(   �� 50      $��30��6   $
��auto��6"   $��Bottom=�6/   $ Correo Usuario��6J   6~   51      � 53   
   $��2��6   $��2��6   .+�54      �� .��6   Número Telefono6%   �� 55      $��30��6   $
��auto��6"   $��Bottom=�6/   $ Correo Usuario��6J   6~   56      � 58   
   $��3��6   $��2��6   .+�59      �� .��6   Sexo6   �� 5:      $��30��6   $
��auto��6$   $��Bottom=�61   $ Seleccione sexo��6L   6�   5;      � 5=   
   $��5��6   $��0��6   .+�5>      ��    AccentedSquareButtonStyle#��[  6   $��40��6H   .��6T   	Registrar6_   5?      5C      5D      