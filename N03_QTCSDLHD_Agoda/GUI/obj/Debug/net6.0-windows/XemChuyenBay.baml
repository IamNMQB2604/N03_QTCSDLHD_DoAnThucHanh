   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.XemChuyenBay   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:GUI  5   	     � Title$  XemChuyenBay��5	   	   $	��500��6   $
��1050��6+    � 
ResizeMode$ NoResize=�5
   	   .��5      � .+�5   
   ]� $��	0,0,924,0q�6   ���	#FF627DD2 � 
InputScope$ RegularExpression��6>   .+�5      �� $	��500��6   .+�5      d� -   5         d�Name$ MenuToggleButton��5   '    '  #MaterialDesignHamburgerToggleButton#���   5       d� 	IsChecked$ FalseY�5   '   
�������$	��120��5   '   $��44��64   5      �� 5      -   5         ��Name$ btn_TraCuVe��5      $��Tra Cứu Vé��6.   $	��Top=�6C   $	��NaN��6X   $��50��6d   
�������
���   �$��12(�6�   $
��Left=�6�   6�   �� 5      -   5        $ btn_XemGioHang��5      $��Xem Giỏ Hàng��61   $	��NaN��6H   $	��Top=�6T   $��50��6i   
�������
���   �$��12(�6�   $
��Left=�6�   6�   �� 5      -   5        $��Đăng Xuất��5      $	��NaN��6-   $��50��69   
�������
���   �$��12(�6k   $
��Left=�6y   6�   5      5      �� 5   
   $��TÌM KIẾM CHUYẾN BAY��6   $
��Left=�6.   $��
597,24,0,0q�6I   $	��Top=�6]   $��38��6u   $	��300��6�   $
��Bold)�6�   $��24(�6�   $
��Bold"�6�   
���  ��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvChuyenBay��5      $	��310��5      $��454,74,10,0q�6    $	��Top=�5      $��16(�5         CanUserAddRows$ False��5          SelectionUnit$ FullRow=�5!      	   
IsReadOnly$
	 True��5"      
   AutoGenerateColumns$
 False��5#        MaterialDesignBackground#���  6`      RowBackground �	#FFE8EDE0   Columns 5$      4  .System.Windows.Controls.DataGridCheckBoxColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Chọn��6)      
IsReadOnly$ False��67   0  *System.Windows.Controls.DataGridTextColumn  5&      $ Hãng Hàng Không��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5'   %   �� *hangHangKhong+6I     5(      $ 	Ngày Bay��6%    5)   %   �� *thoiDiemDi.ngayDi+6M     5*      $ 	Giờ Bay��6%    5+   %   �� *thoiDiemDi.gioDi+6L     5,      $ Ngày Đến��6%    5-   %   �� *thoiDiemDen.ngayDen+6O     5.      $ Giờ Đến��6%    5/   %   �� *thoiDiemDen.gioDen+6N     50      $ Thời Gian Bay��6%    51   %   �� *thoiGianBay+6G     52      $ Giá Vé��6%    53   %   �� *giaVe+6A     54      $ Điểm Xuất Phát��6%    55   %   �� *diemXuatPhat+6H     56      $ Điểm Đến��6%    57   %   �� *	diemDen+6C     58      $ Điểm Dừng��6%    59   %   �� *
diemDung+6D     5:      $ 
Hạng Vé��6%    5;   %   �� *hangVe+6B   5?      (  "System.Windows.Controls.DatePicker  5A   
   -   5          Name$ dataPicker_ngayDi��5A      $
��Left=�60   $��278,148,0,0q�6K   $	��Top=�6`   $	��127��6x    J� RenderTransformOrigin$ 	0.5,2.718&�6�     5B   
   -   5        $ dataPicker_ngayVe��5B      $
��Left=�60   $��278,204,0,0q�6K   $	��127��6`   $	��Top=�6l   �� 5C   
   $
��Left=�6   $��148,150,0,0q�6/   $
��Wrap=�6D   $��	Ngày Đi��6X   $	��Top=�6g   $��23��6   $��86��6�   $��14(�6�   $ 0.586,-0.242&�6�   �� 5D   
   $
��Left=�6   $��
148,96,0,0q�6/   $
��Wrap=�6C   $��Hãng Hàng Không��6W   $	��Top=�6n   $��23��6�   $	��125��6�   $��14(�6�   $ 0.586,-0.242&�6�   �� 5E   
   -   5         ��Name$ 	txtNgayVe��5E      $��148,206,765,0q�6(   $
��Wrap=�6?   $��
Ngày Về��6S   $	��Top=�6b   $��23��6z   $��14(�6�   �� 5F   
   $��149,259,578,0q�6   $
��Wrap=�6+   $��Hạng Ghế��6?   $	��Top=�6O   $��21��6g   $��14(�6s   �� 5G   
   $��148,309,527,0q�6   $
��Wrap=�6+   $��Điểm Xuất Phát��6?   $	��Top=�6U   $��23��6m   $��14(�6y   �� 5H   
   $��148,361,552,0q�6   $
��Wrap=�6+   $��Điểm Đến��6?   $	��Top=�6O   $��28��6g   $��14(�6s   �� 5I   
   -	   5         ��Name$ 
cb_HangGhe��5I      $
��Left=�6'   $��278,253,0,0q�6B   $	��Top=�6W   $	��127��6o   $ 
0.372,0.12&�6{   .@�5J      �� $��Phổ Thông��6   �� 5K      $��Phổ Thông Cao Cấp��6   �� 5L      $��Thương Gia��6   �� 5M      $��Hạng Nhất��6   �� 5N      $�� ��6   5O      �� 5Q   
   -
   5        $ cb_diemXuatPhat��5Q      $
��Left=�6,   $��286,299,0,0q�6G   $	��Top=�6\   $	��119��6t   $ 
0.372,0.12&�6�   5R      �� 5T   
   -   5        $ 
cb_diemDen��5T      $
��Left=�6'   $��278,349,0,0q�6B   $	��Top=�6W   $	��127��6o   $ 
0.372,0.12&�6{   5U      	� 5W   
   -   5        $��
rbMotChieu��5W      $��Một Chiều��6(   $��146,45,798,0q�6<   $	��Top=�6R   $��14(�6j   $ 0.488,0.212&�6�   	� 5X   
   -   5        $��rbKhuHoi��5X      $��Khứ Hồi��6&   $
��Left=�68   $��
286,45,0,0q�6S   $	��Top=�6g   $��14(�6   6�   �� 5Y   
   -   5        $ btnChonChuyenBay��5Y      $��CHỌN CHUYẾN BAY��6+   $
��Left=�6E   $��470,414,0,0q�6`   $	��Top=�6u   $	��172��6�   $��37��6�   $
��Bold"�6�   $ 0.683,0.422&�6�   6�   �� 5Z   
   -   5        $ btnThemXeDayHang��5Z      $ ��THÊM VÀO XE ĐẨY HÀNG��6+   $
��Left=�6J   $��725,414,0,0q�6e   $	��Top=�6z   $	��209��6�   $��37��6�   $
��Bold"�6�   6�   �� 5[   
   -   5        $ 
btnTimKiem��5[      $��TÌM KIẾM��6%   $
��Left=�68   $��286,413,0,0q�6S   $	��Top=�6h   $	��100��6�   $��38��6�   $
��Bold"�6�   6�   �� 5\   
   -   5         ��Name$ tbHangHangKhong��5\      $
��Left=�6,   $��22��6G   $��
278,96,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��127��6�   6�   5]      5^      