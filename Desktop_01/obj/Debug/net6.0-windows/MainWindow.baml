   M S B A M L   `   `   `  ����E  ADesktop_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Desktop_01
Desktop_01  5   	       Desktop_01.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Desktop_01     5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency$
 True��5	   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��500��6   $	��950��6)    � DataContext 5         Desktop_01.MainWindowVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��400 �6   .+�5   
   � $��0��6   .+�5      �� ��5      �� 5       �� 
StartPoint$	 0 0&�6*    �� EndPoint$	 1 1&�5   *   .��5      �  � Color$ Black��6'   	 � Offset$	 0Q�65   � 5      $ DarkBlue��6'   $	 1Q�68   5      ._�5"      �� $'��!____Student Management System____��6   
�������   	Titletext#��[  6X   $��20q�6{   5#      5$      � 5%   
   $��1��6   
 � ColumnDefinitions
 5&      �� 5'      $
��0.7* �6#   �� 5(      $
��1.6* �6#   .+�5+      �� $��1��6   $��0��6"   ��5,      �� 5-      $	 0 0&�6*   $	 1 1&�5.   &   .��5/      � $
 Blue��6'   $	 0Q�64   � 50      $ Purple��6'   $		 0.5Q�66   � 51      $ HotPink��6'   $		 0.3Q�67   � 52      $ DarkGoldenrod��6'   $	 1Q�6=   54      ._�57      � .+�59      �� $��20q�6!    �� Orientation$ Vertical=�6-   .+�5;      �� $��90��6!   $��90��6,    �� Padding$ 3q�68   
���   � �� CornerRadius$	 100��6W   $	��Top=�5<      $��Center=�6.   $��10q�6K   ._�5=      A� $��Right=�6&   $��85��6B   ��5>   "   �� 5?   &    �� ImageSource$P JC:\Users\HP\Desktop\GUIindividual_4066\Desktop_01\Model\Images\lmslogo.png��61   5A      5B      �� 5D      $��Add Student��6!   $��10q�67     
mainbutten#��[ 6i   ��6C   �� *AddStudentCommand+6i   �� 5E      $��Edit Student��6!   $��10q�68   #��[ 6D   ��6h   �� *" ExecuteEditStudentCommandCommand+�� 5F      $��Delete Student��6!   $��10q�6:   #��[ 6F   ��6j   �� *DeleteCommand+�� 5G      -   5        $
��Quit��5G   !   $��10q�60   #��[ 6<   6`   5I      5J      5K      �� 5L      $��1��6   $��1��6"   
�����_�._�5M      �� $	��500��6   
�������$	��Top=�6A   $ Vertical=�6Y   .+�5N      �� $��
 20 20 0 0q�6!   $
��Left=�66   $	��600��6Q   
������ $ 
Horizontal=�6w   .+�5P      �� $��Image��6$   
���   �  ListView#��[ 6E   $��30��6g   �� 5Q      $
��IdNo��6$   
���   �#��[ 6D   $��85��6f   $��20 0 0 0q�6q   �� 5R      $��	FirstName��6$   
���   �#��[ 6I   $��85��6k   $��0q�6v   �� 5S      $��LastName��6$   
���   �#��[ 6I   $��73��6k   �� 5T      $	��Age��6$   
���   �#��[ 6C   $��64��6e   �� 5U      $��DataOfBirth��6$   
���   �#��[ 6L   $��85��6n   �� 5V      $��   GPA��6$   
���   �#��[ 6F   $��58��6h   5X      �� 5Z      -   5         ��Name$ Listview��5Z      $��0 0 0 0q�62   
������ $	��407��6\   ��6i   �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5[      �� *SelectedStudent+$ PropertyChanged=���5\      �� 5]      .R�5^   "   �� 
������ ���#2f1102$��1q�6X   $	 0.1q�5_   !   $ 5��6/   $	��630��6@   $��35��6L   ._�5`   &   �� $	��600��61   
������ $ 
Horizontal=�6W   .+�5b   *   �� $��30��60   $��30��6;   $��1q�6G   ��6R   �� *Image+�� 5c   *   #��[ 6o   $��25 0 0 0q�6�   ��64   �� *IdNo+$ PropertyChanged=�6�   �� 5d   *   #��[ 6t   $��85��6�   $��27 0 0 0q�6�   ��64   �� *	FirstName+$ PropertyChanged=�6�   �� 5e   *   #��[ 6s   $��73��6�   ��64   �� *
LastName+$ PropertyChanged=�6�   �� 5f   *   #��[ 6n   $��64��6�   $��14 0 0 0q�6�   ��64   �� *Age+$ PropertyChanged=�6�   �� 5g   *   #��[ 6v   $��85��6�   ��64   �� *DateofBirth+$ PropertyChanged=�6�   �� 5h   *   #��[ 6n   $��58��6�   $��23 0 0 0q�6�   ��64   �� *GPA+$ PropertyChanged=�6�   5j   '   5l   #   5m      5p      5q      5s      5t      5x      5y      