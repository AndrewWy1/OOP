   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5      $    MVVM.Views.MakeReservationView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MVVM.Views     5      .��5	      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Make Reservation��6   $��0��6,    
  Header#��[  69   � 5   
   $��1��6   $��0 25 0 0q�6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��UserName��6   $��0��6(   �� 5      $��1��6   $�� 0 5 0 0q�6b   ��6#   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6b   5      � 5   
   $��2��6   $��0 10 0 0q�6    5      �� 5       $
��Auto �6    �� 5!      $
��Auto �6     � ColumnDefinitions 5#      �� 5$      $
��Auto �6#    z� SharedSizeGroup$ 
firstGroup��60   �� 5%      $
��Auto �6#   $ secondGroup��60   .+�5(      �� $��	FLoor No.��5)      $��0��5*      $��0��5+      �� 5,      $��1��5-      $��0��5.      $�� 0 5 0 0q�50      ��5/      �� *FloorNumber+$ PropertyChanged=�50      �� 52      $��Room No.��53      $��0��54      $��1��55      $�� 5 0 0 0q�56      �� 57      $��1��58      $��1��59      $�� 5 5 0 0q�5;      ��5:      �� *
RoomNumber+$ PropertyChanged=�5;      5<      � 5>   
   $��3��6   $��0 10 0 0q�6    5?      �� 5@      $
��Auto �6    �� 5A      $
��Auto �6     5C      �� 5D      $
��Auto �6#   $ 
firstGroup��60   �� 5E      $
��Auto �6#   $ secondGroup��60   .+�5H      �� $��
Start Date��5I      $��0��5J      $��0��5K      (  "System.Windows.Controls.DatePicker  5L      $��1��5M      $��0��5N      $�� 0 5 0 0q�5O         SelectedDate 5P      �� *	StartDate+$ PropertyChanged=��� 5R      $��End Date��5S      $��0��5T      $��1��5U      $�� 5 0 0 0q�5V        5W      $��1��5X      $��1��5Y      $�� 5 5 0 0q�5Z       5[      �� *	EndDate+$ PropertyChanged=�5\      �� 5^   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��0 25 0 0q�6;   .+�5_      �� $��Submit��6   ��6&   �� *SubmitCommand+�� 5`      $�� 5 0 0 0q�6   $�� Cancel��6'   ��69   �� *CancelCommand+5a      5b      5c      