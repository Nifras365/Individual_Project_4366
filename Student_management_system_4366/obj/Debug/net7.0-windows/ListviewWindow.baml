   M S B A M L   `   `   `  ����Y  UStudent_management_system_4366, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Student_management_system_4366Student_management_system_4366  5   	   3    -Student_management_system_4366.ListviewWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Student_management_system_4366     5   	     � Title$  ListviewWindow��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�5	   	   
������  � AllowsTransparency$
 True��65    � DataContext 5
      5   /Student_management_system_4366.ListviewWindowVM  5   
    � 	Resources 5         WindowBackgroundBrush �� 
StartPoint �� EndPoint � Color	 � Offset��%�   &	        �� 5   
   $	 0,0&�6<   $	 1,1&�6M   .��5      � $ #9C27B0��6   $	 0Q�6+   � 5      $ #3F51B5��6   $	 1Q�6+   5      5      .��5      �� #��[  6   
 �� CornerRadius$
 15��6A   ._�5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $
 	20 20 0 0��6   ._�5      �� $	��340��6   $	��Top=�6&   .+�5      �� $��Student Management System��6   $��Center=�5          	LabelText#��[ 6=   �� 5!      $��40 0 0 0q�6   $
��Left=�6/    �� Orientation$ 
Horizontal=�6J   
������ $	��600��6|   .+�5"      �� $��	Firstname��6      Topview#��[ 61   �� 5#      $��Lastname��6    #��[ 60   �� 5$      $	��Age��6    #��[ 6+   �� 5%      $��Dathofbirth��6    #��[ 63   �� 5&      $	��GPA��6    #��[ 6+   5'      �� 5)      -   5         ��Name$ Listview��5)      
������ ��6-   �� *	Student+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5*      �� *
StudentNew+$ PropertyChanged=���5+      �� 5,      .R�5-      �� 
������ $��1q�6>   
���   �$
 5��6f   $	��600��5.   !   $��40��6-   ._�5/   "   �� 
������ $	��600��6F   $ 
Horizontal=�6R   .+�50   &   �� $��35��6,   $��35��68   $��0 0 0 0q�6C   ��6T   �� *Image+�� 51   &     Listview#��[ 6p   ��60   �� *	FirstName+$ PropertyChanged=�6p   �� 52   &   #��[ 6p   ��60   �� *
LastName+$ PropertyChanged=�6p   �� 53   &   #��[ 6j   ��60   �� *Age+$ PropertyChanged=�6j   �� 54   &   #��[ 6r   ��60   �� *DateOfBirth+$ PropertyChanged=�6r   �� 55   &   #��[ 6j   ��60   �� *GPA+$ PropertyChanged=�6j   56   #   57      58      5:      5;      5<      �� 5=   
   $��1��6   $
 	0 0 10 10��6   ._�5>      �� $	��800��6   $	��100��6%   $��Bottom=�62   $ 
Horizontal=�6N   .+�5?      �� $��Add Student��6     buttondesign#��[ 6R   ��6/   �� *AdduserCommand+6R   �� 5@      $��Edit Student��6   #��[ 6T   ��60   �� *EdituserCommand+6T   �� 5A      $��Delete Student��6   #��[ 6X   ��62   �� *RemoveuserCommand+6X   �� 5B      $
��Quit��6   #��[ 6R   ��6(   �� *QuitmainwindowCommand+6R   5C      5D      5E      5F      5G      