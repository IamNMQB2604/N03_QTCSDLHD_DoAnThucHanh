   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.XemGioHang   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  
XemGioHang��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   �� $��GIỎ HÀNG��6   $
��Left=�6#   $��
329,25,0,0q�6>   $	��Top=�6R   $��38��6j   $	��300��6v   $
��Bold)�6�   $��24(�6�   $
��Bold"�6�   
���  ��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgvGioHang��5      $	��228��5      $��	0,74,10,0q�6    $	��Top=�5      $��16(�5         CanUserAddRows$ False��5         SelectionUnit$ FullRow=�5         
IsReadOnly$
 True��5         AutoGenerateColumns$ False��5         MaterialDesignBackground#���   6/      RowBackground �	#FFE8EDE0   SelectionMode$ Single=�6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã Chuyến Bay��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *id+6>     5      $
 Thông Tin Chuyến Bay��6%    5   %   �� *thongTinChuyenBay+6M   5      �� 5   
   -   5         ��Name$ 	btn_DatVe��5      $��Đặt Vé Máy Bay��6%   $
��Left=�6>   $��44��6Y   $��156,335,0,0q�6e   $	��Top=�6z   $	��145��6�   $
��Bold"�6�   �� 5   
   -   5        $ btn_QuayLai��5      $��
Quay Lại��6&   $
��Left=�69   $��44��6T   $	��132��6`   $��515,335,0,0q�6l   $	��Top=�6�   $
��Bold"�6�   $��14(�6�    J� RenderTransformOrigin$ 
0.576,0.61&�6�   �� 5   
   -   5        $ btn_XoaChuyenBay��5      $��Xóa Chuyến Bay��6+   $
��Left=�6D   $��44��6_   $��334,335,0,0q�6k   $	��Top=�6�   $	��145��6�   
���  ��$
��Bold"�6�   6�   5      5       