   M S B A M L   `   `   `  ����I  ELibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LibraryProject.ViewsLibraryProject.Views  5   	   '    !LibraryProject.Views.AddItemsView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:LibraryProject.Views     5   	     � Title$  AddItemsView��5   	   $	��450��6   $	��800��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      $��2* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��ComboBoxMonths��5      $��Center=�6)   $	��100��6F   $��30��6R   $��1��6^   $��2��6n      ComboBoxDesign#��[  6{   6�   �� 5   
   -   5        $��ComboBoxItemType��5      $��Center=�6+   $	��100��6H   $��30��6T   $��1��6`   $��1��6p   #��[  6�   .@�5      �� ${�False��6   .��6-   Select Type6:   5      �� 5   
   $��(For Journals) Add Month:��6   $��0��65   $��2��6E   $��Center=�6R   $��Center=�6m   $��WrapWithOverflow=�6�   �� 5   
   -   5        $��AddItem��5      $��2��6    $��3��60     ButtonDesign#��[ 6S   .��6y   
Add Item6�   �� 5   
   -   5        $��tbTitle��5      $��1��6!   $��0��61   $	��100��6>   $��30��6J   6X   �� 5   
   $��Enter item's name here:��6   $��0��63   $��0��6C   $��Center=�6P   $��Center=�6k   $��WrapWithOverflow=�6�   �� 5    
   $ ��Enter type (Book/Journal):��6   $��0��66   $��1��6F   $��Center=�6S   $��Center=�6n   $��WrapWithOverflow=�6�   �� 5!   
   -   5        $��tbPrice��5!      $��3��6!   $��1��6.   $	��100��6>   $��30��6J   �� 5"   
   $��Enter Price:��6   $��0��6(   $��3��68   $��Center=�6E   $��Center=�6b   �� 5#   
   $��3��6   $��Parsons)�6$   $��Center=�69   $��Center=�6V   $��20(�6q   $��WrapWithOverflow=�6   $��2��6�   Current items in library:6�   �� 5$   
   -   5         ��Name$ lvItems��5$      $��1��6$   $��3��61   $��3��6A    �� DisplayMemberPath$ Title��6R   
�������6�   �� 5%   
   -   5        $ lvItemsPrice��5%      $��1��6)   $��4��66   $��3��6F   $ Price��6W   
�������6�   5(      5)      