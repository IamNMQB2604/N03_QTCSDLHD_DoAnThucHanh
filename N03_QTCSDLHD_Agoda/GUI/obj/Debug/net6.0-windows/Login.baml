   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       	GUI.Login   5   
   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $	��320��5   	   $	��520��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    J� Clip 5      �� 5   
    �� Rect$ 0,0,520,320�6   	 �� RadiusX$	 10Q�5      
 �� RadiusY$
 10Q�5      .��5      � ��5   
   �� 5       �� ImageSource$ Image/anhMayBay.jpg��6    j� TileMode$
 None=�5       .+�5"   
   �� $��	10,40,0,0q�6   $	��250��5#      $��Center=�5$      $��Center=�5%      .+�5&      �� $��0,0,0,20q�6   $ ��HỆ THỐNG AGODA FLIGHTS��5'      $��19(�5(       �� TextAlignment$ Center=�5)      
���  ��$
��Bold"�5+      ��5,      �� 5-       �� Color$ White��6&    �� Opacity$	 0.5Q�5.   &   50      �� 52      -   5         ��Name$ 
tbUsername��52       ! MaterialDesignOutlinedTextBox#��[ 53      $	��Top=�54      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên đăng nhập (SDT)��55      
�������56      G� 57      -   5         G�Name$ tbPass��57      $��0,15,0,0q�58       % !MaterialDesignOutlinedPasswordBox#��[ 59      $	��Top=�5:      $ Mật khẩu��5;      
�������5<      � 5>       � ColumnDefinitions 5?      �� 5@      �� 5A      .+�5D      �� -   5         ��Name$ 	btnLoggin��5D      $��0��5E      $��0,15,5,0q�5F       " MaterialDesignRaisedDarkButton#��[ 5G      $��35��5H      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5I       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5J      {�5K      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��5M      �� $��Đăng nhập��6    5N      �� 5P      -   5        $ btnClose��5P      $��1��5Q      $��5,15,0,0q�5R      #��[ 5S      $��35��5T      ���	#FFDC4D4D$ 15��5V      $7 1MaterialDesignRaisedDarkButton with Round Corners��5W      {�5X      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5Z      �� $��Thoát��6    5[      5]      �� 5_      -   5         ��Name$ 
txtWarning��5_      $��0,20,0,0q�5`      $��-��5a      
���  ��$
��Wrap=�5c      $��16(�5d      $ Center=�5e      5f      5h      5j      5k      