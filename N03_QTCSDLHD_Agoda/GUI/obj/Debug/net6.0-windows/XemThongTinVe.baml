   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.XemThongTinVe   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  XemThongTinVe��5   	   $	��500��6   $	��800��6,   .��5	      � .+�5
   
   �� $��VÉ MÁY BAY��6   $
��Left=�6%   $��
329,25,0,0q�6@   $	��Top=�6T   $��38��6l   $	��160��6x   $
��Bold)�6�   $��24(�6�   $
��Bold"�6�   
���  ��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvThongTinVe��5      $��Center=�5      $	��219��5      $	��Top=�5      $	��780��5      $��16(�5         CanUserAddRows$ False��5         SelectionMode$ Single=�5         SelectionUnit$ FullRow=�5         
IsReadOnly$
 True��5         AutoGenerateColumns$ False��5         MaterialDesignBackground#���   5         RowBackground �	#FFE8EDE0$��	0,167,0,0q�6e      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã Đặt Chỗ��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   %   �� *_id+6?     5      $	 Mã Quốc Gia��6%   
 5   %   �� *	maQuocGia+6E     5      $	 Số Điện Thoại��6%   
 5   %   �� *SDT+6?     5       $	 Email��6%   
 5!   %   �� *email+6A     5"      $	 Ngày Đặt Vé��6%   
 5#   %   �� *	ngayDatVe+6E   5&      �� 5'   
   -   5        $��XEM CHI TIẾT��5'      $
��Left=�6(   $��197,406,0,0q�6C   $	��Top=�6X   $��47��6p   $
��Bold"�6|   $	��175��6�   
��� � �6�   �� 5(   
   -   5        $��
QUAY LẠI��5(      $
��Left=�6$   $��409,406,0,0q�6?   $	��Top=�6T   $��46��6l   $
��Bold"�6x   $	��170��6�   
���  ��6�   �� 5)   
   $
��Left=�6   $��33��6/   $��
31,111,0,0q�6;   $
��Wrap=�6O   $��Ngày Đặt Vé��6c   $	��Top=�6v   $	��120��6�   $��15(�6�   (  "System.Windows.Controls.DatePicker  5*   
   -   5          Name$ dataPickerNgayDat��5*      $
��Left=�62   $��32��6M   $��
133,95,0,0q�6Y   $	��Top=�6m   $	��134��6�   �� 5+   
   -   5         ��Name$ btn_TimKiem��5+      $��TÌM KIẾM��6&   $
��Left=�69   $��33��6T   $��303,105,0,0q�6`   $	��Top=�6u   $	��106��6�   $
��Bold"�6�   6�   5,      5-      