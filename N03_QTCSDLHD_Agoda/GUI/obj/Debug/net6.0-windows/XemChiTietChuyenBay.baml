   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.XemChiTietChuyenBay   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  XemChiTietChuyenBay��5   	   $	��550��6%   $	��800��62    � 
ResizeMode$ NoResize=�6>   .��5	      � .+�5
   
   �� $��THÔNG TIN CHUYẾN BAY��6   $
��Left=�6/   $��	25,10,0,0q�6J   $	��Top=�6]   $��33��6u   $	��264��6�   $
��Bold)�6�   $��15(�6�   $
��Bold"�6�   
���  ��6�   �� 5   
   $��THÔNG TIN CHI TIẾT��6   $
��Left=�6-   $��
25,217,0,0q�6H   $	��Top=�6\   $��33��6t   $	��264��6�   $
��Bold)�6�   $��15(�6�   $
��Bold"�6�   
���  ��6�   �� 5   
   $��ĐIỂM DỪNG��6   $
��Left=�6$   $��574,215,0,0q�6?   $	��Top=�6T   $��33��6l   $	��102��6x   $
��Bold)�6�   $��15(�6�   $
��Bold"�6�   
���  ��6�   �� 5   
   $��MÔ TẢ��6   $
��Left=�6    $��294,216,0,0q�6;   $	��Top=�6P   $��33��6h   $��60��6t   $
��Bold)�6   $��15(�6�   $
��Bold"�6�   
���  ��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvThongTinChuyenBay��5      $��Center=�5      $	��162��5      $��0,48,0,0q�6    $	��Top=�5      $	��790��5      $��16(�5         CanUserAddRows$ False��5         SelectionMode$ Single=�5         SelectionUnit$ FullRow=�5         
IsReadOnly$
 True��5         AutoGenerateColumns$ False��5         MaterialDesignBackground#���   5         RowBackground �	#FFE8EDE0	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Hãng Hàng Không��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *hangHangKhong+6I     5      $
 	Ngày Bay��6%    5   %   �� *thoiDiemDi.ngayDi+6M     5      $
 	Giờ Bay��6%    5    %   �� *thoiDiemDi.gioDi+6L     5!      $
 Ngày Đến��6%    5"   %   �� *thoiDiemDen.ngayDen+6O     5#      $
 Giờ Đến��6%    5$   %   �� *thoiDiemDen.gioDen+6N     5%      $
 Thời Gian Bay��6%    5&   %   �� *thoiGianBay+6G     5'      $
 Giá Vé��6%    5(   %   �� *giaVe+6A     5)      $
 Điểm Xuất Phát��6%    5*   %   �� *diemXuatPhat+6H     5+      $
 Điểm Đến��6%    5,   %   �� *	diemDen+6C     5-      $
 Điểm Dừng��6%    5.   %   �� *
diemDung+6D     5/      $
 
Hạng Vé��6%    50   %   �� *hangVe+6B   52      �� 53   
   -   5         ��Name$ tbChiTietChuyenBay��53      $
��Left=�54       ! MaterialDesignOutlinedTextBox#��[ 55      $	��134��56      $��14(�57      $��
25,255,0,0q�58       �� TextWrapping$
 Wrap=�59      $	��Top=�5:      $	��214��5;      �� 5<   
   -   5        $ tbMoTa��5<      $��Center=�5=      #��[ 5>      $	��134��5?      $��14(�5@      $��	0,255,0,0q�5A      $
 Wrap=�5B      $	��Top=�5C      $��214                  ��5D      �� 5F   
   -   5        $ 
tbDiemDung��5F      $
��Left=�5G      #��[ 5H      $	��134��5I      $��14(�5J      $��569,255,0,0q�5K      $
 Wrap=�5L      $	��Top=�5M      $��214                  ��5N      �� 5P   
   -   5         ��Name$ 
btnQuayLai��5P      $��
QUAY LẠI��6%   $
��Left=�68   $��425,451,0,0q�6S   $	��Top=�6h   $	��100��6�   $��38��6�   $
��Bold"�6�   6�   �� 5Q   
   -   5        $ btn_DatVeMayBay��5Q   ,   $��ĐẶT VÉ MÁY BAY��6   $
��Left=�6F   $��224,451,0,0q�6a   $
��Bold"�6v   $	��Top=�6�   $	��154��6�   $��38��6�   6�   5R      5S      